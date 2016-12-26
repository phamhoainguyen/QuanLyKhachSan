Public Class FormSearch
    Private roomid, roomtypeid, roomName As String
    Private startdate, enddate As Date
    Private db As Database = New Database()
    Private msg As NController.Message = New NController.Message()
    Private datenow As Date = Date.Now().Date
    Private table As DataTable
    Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub
    Private Sub setVar()
        roomtypeid = cbbRoomType.SelectedValue
        roomid = txtRoomID.Text
        roomName = txtRoomName.Text
        startdate = dtpStartDate.Value
        enddate = dtpEndDate.Value
    End Sub
    Private Sub init()
        'reset
        txtRoomID.Text = ""
        txtRoomName.Text = ""
        'Lấy loại phòng đưa vào combobox
        cbbRoomType.DataSource = db.FillDataset("SELECT MaLoaiPhong,TenLoaiPhong FROM LOAIPHONG", CommandType.Text).Tables(0)
        cbbRoomType.DisplayMember = "TenLoaiPhong"
        cbbRoomType.ValueMember = "MaLoaiPhong"
        'Lấy danh sách Danh Mục phòng đưa vào DGV
        Dim sqlGetListRoom As String
        sqlGetListRoom = "SELECT P.MaPhong, P.TenPhong, LP.TenLoaiPhong, PT.NgayBatDau, PT.NgayKetThuc, LP.DonGia,P.GhiChu"
        sqlGetListRoom &= " FROM [PHONG] AS P,[LOAIPHONG] AS LP,[PHIEUTHUEPHONG] PT"
        sqlGetListRoom &= " WHERE P.[MaLoaiPhong] = LP.[MaLoaiPhong] AND PT.MaPhong = P.MaPhong"
        sqlGetListRoom &= " ORDER BY P.MaPhong DESC"
        table = db.FillDataset(sqlGetListRoom, CommandType.Text).Tables(0)
        Dim col As DataColumn = table.Columns.Add()
        col.SetOrdinal(6)
        col.ColumnName = "TinhTrang"
        col.Caption = "Tình trạng"
        Dim rowCount As Int32 = 0
        For Each row As DataRow In table.Rows
            If (datenow >= Convert.ToDateTime(row("NgayBatDau")) And datenow <= Convert.ToDateTime(row("NgayKetThuc"))) Then
                row("TinhTrang") = "Bận"
            Else
                row("TinhTrang") = "Rảnh"
            End If
            rowCount += 1
        Next
        'Sửa tiêu đề các cột của DGV
        dgvListRoomSearch.DataSource = table
        dgvListRoomSearch.Columns("MaPhong").HeaderText = msg.roomID
        dgvListRoomSearch.Columns("TenPhong").HeaderText = msg.roomName
        dgvListRoomSearch.Columns("TenLoaiPhong").HeaderText = msg.roomTypeName
        dgvListRoomSearch.Columns("NgayBatDau").HeaderText = msg.startDate
        dgvListRoomSearch.Columns("NgayKetThuc").HeaderText = msg.endDate
        dgvListRoomSearch.Columns("DonGia").HeaderText = msg.priceUnit
        dgvListRoomSearch.Columns("GhiChu").HeaderText = msg.note
    End Sub

    Private Sub txtRoomName_TextChanged(sender As Object, e As EventArgs) Handles txtRoomName.TextChanged
        If (txtRoomName.Text <> "") Then
            txtRoomID.Enabled = False
            cbbRoomType.Enabled = False
        Else
            txtRoomID.Enabled = True
            cbbRoomType.Enabled = True
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        init()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        setVar()
        Dim sqlGetListRoom As String
        sqlGetListRoom = "SELECT DISTINCT(P.MaPhong), P.TenPhong, LP.TenLoaiPhong, PT.NgayBatDau, PT.NgayKetThuc, LP.DonGia,P.GhiChu"
        sqlGetListRoom &= " FROM [PHONG] AS P,[LOAIPHONG] AS LP,[PHIEUTHUEPHONG] PT"
        sqlGetListRoom &= " WHERE P.[MaLoaiPhong] = LP.[MaLoaiPhong] AND PT.MaPhong = P.MaPhong"
        sqlGetListRoom &= " AND CONVERT(varchar(10), PT.NgayBatDau, 120) >= @ngaybatdau AND CONVERT(varchar(10), PT.NgayKetThuc, 120) <= @ngayketthuc"
        If (roomid <> "") Then
            sqlGetListRoom &= " AND P.MaPhong = '" + roomid + "'"
        ElseIf (roomName <> "") Then
            sqlGetListRoom &= " AND P.TenPhong LIKE N'%" + roomName + "%'"
        ElseIf (roomtypeid <> "") Then
            sqlGetListRoom &= " AND LP.MaLoaiPhong = '" + roomtypeid + "'"
        End If
        sqlGetListRoom &= " ORDER BY P.MaPhong DESC"

        Dim params(0 To 1) As SqlClient.SqlParameter
        params(0) = New SqlClient.SqlParameter("@ngaybatdau", SqlDbType.Date)
        params(0).Value = startdate
        params(1) = New SqlClient.SqlParameter("@ngayketthuc", SqlDbType.Date)
        params(1).Value = enddate
        'Lấy danh sách Danh Mục phòng đưa vào DGV
        Dim table As DataTable = db.FillDataset(sqlGetListRoom, CommandType.Text, params).Tables(0)
        If (table.Rows.Count < 1) Then
            MsgBox("Không tìm thấy phòng phù hợp", MsgBoxStyle.Information, msg.msgTitleNotify)
        Else
            dgvListRoomSearch.DataSource = table
            'Sửa tiêu đề các cột của DGV
            dgvListRoomSearch.Columns("MaPhong").HeaderText = msg.roomID
            dgvListRoomSearch.Columns("TenPhong").HeaderText = msg.roomName
            dgvListRoomSearch.Columns("TenLoaiPhong").HeaderText = msg.roomTypeName
            dgvListRoomSearch.Columns("NgayBatDau").HeaderText = msg.startDate
            dgvListRoomSearch.Columns("NgayKetThuc").HeaderText = msg.endDate
            dgvListRoomSearch.Columns("DonGia").HeaderText = msg.priceUnit
            dgvListRoomSearch.Columns("GhiChu").HeaderText = msg.note
        End If
    End Sub


    Private Sub txtRoomID_TextChanged(sender As Object, e As EventArgs) Handles txtRoomID.TextChanged
        If (txtRoomID.Text <> "") Then
            'Nếu mã phòng khác rỗng thì lấy dừ liệu từ database
            Dim selectQuery As String = Nothing
            selectQuery = "SELECT MaPhong FROM"
            selectQuery &= " (SELECT *, ROW_NUMBER() OVER (ORDER BY MaPhong) as row FROM PHONG) a"
            selectQuery &= " WHERE a.row > 0 and a.row <= 10 AND MaPhong LIKE '%" + txtRoomID.Text + "%'"
            Dim tableRoom As DataTable
            tableRoom = db.FillDataset(selectQuery, CommandType.Text).Tables(0)
            tableRoom.AcceptChanges()

            'Nếu rows Count = 1 tức là đã nhập đúng mã phòng
            If (tableRoom.Rows.Count = 1) Then
                selectQuery = "SELECT TenPhong FROM Phong WHERE MaPhong = '" + txtRoomID.Text + "'"
                txtRoomName.Text = db.ExecuteScalar(selectQuery, CommandType.Text)
            End If

            'Tạo AutoComple cho text box
            Dim col As AutoCompleteStringCollection = New AutoCompleteStringCollection
            For Each row As DataRow In tableRoom.Rows
                col.Add(row("MaPhong").ToString())
            Next
            txtRoomID.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtRoomID.AutoCompleteCustomSource = col

            cbbRoomType.Enabled = False
            txtRoomName.Enabled = False
            btnReset.Enabled = True
        Else
            cbbRoomType.Enabled = True
            txtRoomName.Enabled = True
            btnReset.Enabled = False
        End If
    End Sub

    Private Sub cbbRoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbRoomType.SelectedIndexChanged

    End Sub
End Class