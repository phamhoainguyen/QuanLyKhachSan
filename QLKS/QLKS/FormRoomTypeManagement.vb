Imports System.Data.SqlClient
Public Class FormRoomTypeManagement
    Private msg As NController.Message = FormMain.controller.msg
    Private db As Database = FormMain.controller.db
    Private ctrl As NController.Controller = FormMain.controller
    Private Sub FormThemLoaiPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = msg.addRoomType
        init()
        btnAdd.Tag = True
    End Sub
    Private Sub init()
        'Xóa nội dung textbox
        txtRoomTypeName.Text = ""
        txtPriceUnit.Text = ""
        'Tắt 2 nút EDIT VÀ DELETE
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        'Tạo mã loại phòng tự động
        Dim roomTypeIDMAX As String = db.ExecuteScalar("SELECT MAX(MaLoaiPhong) FROM LOAIPHONG", CommandType.Text)
        txtRoomTypeID.Text = ctrl.createAutoID(roomTypeIDMAX, "LP")
        'Lấy danh sách loại phòng từ bảng [LOAIPHONG]
        Dim queryGetListRoom As String
        queryGetListRoom = "SELECT MaLoaiPhong, TenLoaiPhong, DonGia FROM LOAIPHONG"
        dgvListRoomType.DataSource = db.FillDataset(queryGetListRoom, CommandType.Text).Tables(0)
        'Đổi tên hiển thị cho các cột
        dgvListRoomType.Columns("MaLoaiPhong").HeaderText = msg.roomTypeID
        dgvListRoomType.Columns("TenLoaiPhong").HeaderText = msg.roomTypeName
        dgvListRoomType.Columns("DonGia").HeaderText = msg.priceUnit
    End Sub
    Private Sub dgvListRoomType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListRoomType.CellClick
        Dim currentRows As DataGridViewRow = dgvListRoomType.Rows(dgvListRoomType.CurrentRow.Index)
        txtRoomTypeID.Text = currentRows.Cells("MaLoaiPhong").Value.ToString()
        txtRoomTypeName.Text = currentRows.Cells("TenLoaiPhong").Value.ToString()
        txtPriceUnit.Text = currentRows.Cells("DonGia").Value.ToString()
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnAdd.Text = "Nhập lại"
        btnAdd.Tag = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (btnAdd.Tag = True) Then
            Try
                Dim insertQuery As String
                insertQuery = "INSERT INTO LOAIPHONG(MaLoaiPhong,TenLoaiPhong,DonGia) VALUES('L000', @tenloaiphong, @dongia)"
                Dim params(0 To 1) As SqlParameter
                params(0) = New SqlParameter("@tenloaiphong", SqlDbType.NVarChar, 100)
                params(0).Value = txtRoomTypeName.Text
                params(1) = New SqlParameter("@dongia", SqlDbType.Money)
                params(1).Value = txtPriceUnit.Text
                FormMain.db.ExecuteNonQuery(insertQuery, CommandType.Text, params)
                Dim ds As DataSet = CType(dgvListRoomType.DataSource, DataTable).DataSet
                Dim newRow As DataRow
                newRow = ds.Tables(0).NewRow()
                newRow("MaLoaiPhong") = txtRoomTypeID.Text
                newRow("TenLoaiPhong") = txtRoomTypeName.Text
                newRow("DonGia") = txtPriceUnit.Text
                ds.Tables(0).Rows.Add(newRow)
                MsgBox("Thêm loại phòng thành công", MsgBoxStyle.Information, msg.msgTitleNotify)
            Catch ex As Exception
                MsgBox("Có lỗi xảy ra, thêm loại phòng thất bại", MsgBoxStyle.Exclamation, msg.msgTitleNotify)
            End Try

        Else
            init()
            btnAdd.Text = "Thêm"
            btnAdd.Tag = True
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim updateQuery As String
            updateQuery = "UPDATE LOAIPHONG Set TenLoaiPhong = @tenloaiphong, DonGia = @dongia"
            updateQuery &= " WHERE MaLoaiPhong = @maloaiphong"
            Dim params(0 To 2) As SqlParameter
            params(0) = New SqlParameter("@tenloaiphong", SqlDbType.NVarChar, 100)
            params(0).Value = txtRoomTypeName.Text
            params(1) = New SqlParameter("@dongia", SqlDbType.Money)
            params(1).Value = txtPriceUnit.Text
            params(2) = New SqlParameter("@maloaiphong", SqlDbType.VarChar, 10)
            params(2).Value = txtRoomTypeID.Text
            FormMain.db.ExecuteNonQuery(updateQuery, CommandType.Text, params)
            Dim ds As DataSet = CType(dgvListRoomType.DataSource, DataTable).DataSet
            For Each row As DataRow In ds.Tables(0).Rows
                If (row("MaLoaiPhong") = txtRoomTypeID.Text) Then
                    row("TenLoaiPhong") = txtRoomTypeName.Text
                    row("DonGia") = txtPriceUnit.Text
                End If
            Next
            MsgBox("Sửa loại phòng thành công!", MsgBoxStyle.Information, msg.msgTitleNotify)
        Catch ex As Exception
            MsgBox("Bị lỗi, sửa thất bại!", MsgBoxStyle.Exclamation, msg.msgTitleWarning)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show(msg.deleteWarning, msg.msgTitleWarning, MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Try
                Dim deleteQuery As String
                deleteQuery = "DELETE FROM LOAIPHONG WHERE MaLoaiPhong = @maloaiphong"
                Dim params(0) As SqlParameter
                params(0) = New SqlParameter("@maloaiphong", SqlDbType.VarChar, 10)
                params(0).Value = txtRoomTypeID.Text
                FormMain.db.ExecuteNonQuery(deleteQuery, CommandType.Text, params)
                Dim ds As DataSet = CType(dgvListRoomType.DataSource, DataTable).DataSet
                Dim delRows() As DataRow = ds.Tables(0).Select("MaLoaiPhong = '" + txtRoomTypeID.Text + "'")
                For Each row As DataRow In delRows
                    row.Delete()
                Next
                MsgBox("Xóa loại phòng thành công!", MsgBoxStyle.Information, msg.msgTitleNotify)
            Catch ex As Exception
                MsgBox(ex.ToString())
                MsgBox("Có lỗi xảy ra, xóa thất bại!", MsgBoxStyle.Exclamation, msg.msgTitleWarning)
            End Try
        End If
    End Sub
End Class