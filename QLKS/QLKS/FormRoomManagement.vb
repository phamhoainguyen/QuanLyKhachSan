Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class FormRoomManagement
    Public db As Database = New Database()
    Private dtListRoom As DataTable = New DataTable()
    Private MaPhong, TenPhong, MaLoaiPhong, GhiChu, TenLoaiPhong, DonGia As String
    Private msg As New NController.Message()
    Private ctrl As New NController.Controller
    Private countcbb As Int32 = 0
    Private Sub FormRoomManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = msg.addRoom
        init()
    End Sub
    'Lấy dữ liệu nhập vào từ bạn phím
    Private Sub setVar()
        MaPhong = txtMaPhong.Text
        TenPhong = txtTenPhong.Text
        GhiChu = txtGhiChu.Text
        DonGia = txtDonGia.Text
        MaLoaiPhong = cbbLoaiPhong.SelectedValue
        TenLoaiPhong = cbbLoaiPhong.Text
    End Sub
    Private Sub init()
        'Reset
        txtTenPhong.Text = ""
        txtGhiChu.Text = ""
        btnEditRoom.Enabled = False
        btnDeleteRoom.Enabled = False
        'Tạo ra mã phòng mặc định
        Dim MaPhongMax As String = db.ExecuteScalar("SELECT MAX(MaPhong) FROM PHONG", CommandType.Text)
        txtMaPhong.Text = ctrl.createAutoID(MaPhongMax, "P")
        'Lấy loại phòng đưa vào combobox
        cbbLoaiPhong.DataSource = db.FillDataset("SELECT MaLoaiPhong,TenLoaiPhong FROM LOAIPHONG", CommandType.Text).Tables(0)
        cbbLoaiPhong.DisplayMember = "TenLoaiPhong"
        cbbLoaiPhong.ValueMember = "MaLoaiPhong"
        'Lấy đơn giá
        Dim MaLoaiPhong As String = cbbLoaiPhong.SelectedValue.ToString()
        Dim sqlGetPrice As String
        Dim param(0) As SqlParameter
        param(0) = New SqlParameter("@MaLoaiPhong", SqlDbType.VarChar, 10)
        param(0).Value = MaLoaiPhong
        sqlGetPrice = "SELECT DonGia FROM LOAIPHONG"
        sqlGetPrice &= " WHERE MaLoaiPhong = @MaLoaiPhong"
        txtDonGia.Text = db.ExecuteScalar(sqlGetPrice, CommandType.Text, param)
        'Lấy danh sách Danh Mục phòng đưa vào DGV
        Dim sqlGetListRoom As String
        sqlGetListRoom = "SELECT [PHONG].MaPhong, [PHONG].TenPhong, LOAIPHONG.MaLoaiPhong, LOAIPHONG.TenLoaiPhong,LOAIPHONG.DonGia,PHONG.GhiChu "
        sqlGetListRoom &= "FROM [PHONG],[LOAIPHONG] "
        sqlGetListRoom &= "WHERE [PHONG].[MaLoaiPhong] = [LOAIPHONG].[MaLoaiPhong]"
        sqlGetListRoom &= " ORDER BY [PHONG].MaPhong DESC"
        dgvListRoom.DataSource = db.FillDataset(sqlGetListRoom, CommandType.Text).Tables(0)

        'Sửa tiêu đề các cột của DGV
        dgvListRoom.Columns("MaPhong").HeaderText = msg.roomID
        dgvListRoom.Columns("TenPhong").HeaderText = msg.roomName
        dgvListRoom.Columns("MaLoaiPhong").HeaderText = msg.roomTypeID
        dgvListRoom.Columns("TenLoaiPhong").HeaderText = msg.roomTypeName
        dgvListRoom.Columns("DonGia").HeaderText = msg.priceUnit
        dgvListRoom.Columns("GhiChu").HeaderText = msg.note
        'Sửa kích thước các cột cho phù hợp với giao diện
        dgvListRoom.Columns("GhiChu").Width = 150
    End Sub

    Private Sub btnDeleteRoom_Click(sender As Object, e As EventArgs) Handles btnDeleteRoom.Click
        Dim result As DialogResult = MessageBox.Show(msg.deleteWarning, msg.msgTitleWarning, MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Try
                Dim MaPhong As String = txtMaPhong.Text
                Dim deleteQuery As String
                deleteQuery = "DELETE FROM PHONG WHERE MaPhong = @MaPhong"
                Dim params(0) As SqlParameter
                params(0) = New SqlParameter("@MaPhong", MaPhong)
                db.ExecuteNonQuery(deleteQuery, CommandType.Text, params)
                Dim ds As DataSet = CType(dgvListRoom.DataSource, DataTable).DataSet
                Dim delRows() As DataRow = ds.Tables(0).Select("MaPhong = '" + MaPhong + "'")
                For Each row As DataRow In delRows
                    row.Delete()
                Next
                MsgBox(msg.deleteRoomSuccess, MsgBoxStyle.Information, msg.msgTitleNotify)
            Catch ex As Exception
                MsgBox(msg.deleteRoomFail, MsgBoxStyle.Exclamation, msg.msgTitleNotify)
            End Try
        End If
    End Sub


    Private Sub dgvListRoom_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListRoom.CellClick
        btnEditRoom.Enabled = True
        btnDeleteRoom.Enabled = True
        btnAddRoom.Text = "Nhập lại"
        btnAddRoom.Tag = True
        Dim currentRows As DataGridViewRow = dgvListRoom.Rows(dgvListRoom.CurrentRow.Index)
        txtMaPhong.Text = currentRows.Cells("MaPhong").Value.ToString()
        txtTenPhong.Text = currentRows.Cells("TenPhong").Value.ToString()
        txtDonGia.Text = currentRows.Cells("DonGia").Value.ToString()
        txtGhiChu.Text = currentRows.Cells("GhiChu").Value.ToString()
        cbbLoaiPhong.SelectedText = currentRows.Cells("TenLoaiPhong").Value.ToString()
        cbbLoaiPhong.SelectedValue = currentRows.Cells("MaLoaiPhong").Value.ToString()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        If (btnAddRoom.Tag) Then
            init()
            btnAddRoom.Text = "Thêm"
        Else
            setVar()
            Try
                Dim ds As DataSet = CType(dgvListRoom.DataSource, DataTable).DataSet
                Dim insertQuery As String
                insertQuery = "INSERT INTO PHONG(MaPhong,TenPhong,MaLoaiPhong,GhiChu)"
                insertQuery &= " VALUES(@MaPhong,@TenPhong,@MaLoaiPhong,@GhiChu)"
                Dim params(0 To 3) As SqlParameter
                params(0) = New SqlParameter("@MaPhong", "P000")
                params(1) = New SqlParameter("@TenPhong", TenPhong)
                params(2) = New SqlParameter("@MaLoaiPhong", MaLoaiPhong)
                params(3) = New SqlParameter("@GhiChu", GhiChu)
                db.ExecuteNonQuery(insertQuery, CommandType.Text, params)
                Dim newRow As DataRow
                newRow = ds.Tables(0).NewRow()
                newRow("MaPhong") = MaPhong
                newRow("TenPhong") = TenPhong
                newRow("MaLoaiPhong") = MaLoaiPhong
                newRow("TenLoaiPhong") = TenLoaiPhong
                newRow("DonGia") = DonGia
                newRow("GhiChu") = GhiChu
                ds.Tables(0).Rows.Add(newRow)
                MsgBox(msg.addRoomSuccess, MsgBoxStyle.Information, msg.msgTitleNotify)
            Catch ex As Exception
                MsgBox(msg.deleteRoomFail, MsgBoxStyle.Exclamation, msg.msgTitleNotify)
            End Try
        End If
    End Sub

    Private Sub cbbRoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbLoaiPhong.SelectedIndexChanged
        Try
            setVar()
            If (cbbLoaiPhong.SelectedIndex > -1) Then
                Dim MaLoaiPhong As String = cbbLoaiPhong.SelectedValue.ToString()
                Dim sqlGetPrice As String
                Dim param(0) As SqlParameter
                param(0) = New SqlParameter("@MaLoaiPhong", SqlDbType.VarChar, 10)
                param(0).Value = MaLoaiPhong
                sqlGetPrice = "SELECT DonGia FROM LOAIPHONG"
                sqlGetPrice &= " WHERE MaLoaiPhong = @MaLoaiPhong"
                txtDonGia.Text = db.ExecuteScalar(sqlGetPrice, CommandType.Text, param)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEditRoom_Click(sender As Object, e As EventArgs) Handles btnEditRoom.Click
        setVar()
        Dim currentRows As DataGridViewRow = dgvListRoom.Rows(dgvListRoom.CurrentRow.Index)
        Try
            Dim ds As DataSet = CType(dgvListRoom.DataSource, DataTable).DataSet
            Dim updateQuery As String
            updateQuery = "UPDATE [PHONG] SET TenPhong = @TenPhong,MaLoaiPhong = @MaLoaiPhong,GhiChu = @GhiChu WHERE MaPhong = @MaPhong"
            Dim params(0 To 3) As SqlParameter
            params(0) = New SqlParameter("@TenPhong", TenPhong)
            params(1) = New SqlParameter("@MaLoaiPhong", MaLoaiPhong)
            params(2) = New SqlParameter("@GhiChu", GhiChu)
            params(3) = New SqlParameter("@MaPhong", MaPhong)
            db.ExecuteNonQuery(updateQuery, CommandType.Text, params)
            For Each row As DataRow In ds.Tables(0).Rows
                If (row("MaPhong") = MaPhong) Then
                    row("TenPhong") = TenPhong
                    row("MaLoaiPhong") = MaLoaiPhong
                    row("TenLoaiPhong") = TenLoaiPhong
                    row("DonGia") = DonGia
                    row("GhiChu") = GhiChu
                End If
            Next
            MsgBox(msg.editRoomSuccess, MsgBoxStyle.Information, msg.msgTitleNotify)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class