Imports System.Data.SqlClient
Public Class FormRoomRentBill
    Private db As New Database()
    Private msg As NController.Message = New NController.Message
    Private maphong, tenphong, tenkhach, tenloaikhach, cmnd, diachi As String
    Private ngaybatdau, ngaykethuc As Date

    Private maloaikhach As Int32
    Private Sub FormRoomRentBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub
    Private Sub Init()
        Dim selectQuery As String
        selectQuery = "SELECT P.MaPhong, P.TenPhong,C.TenKhachHang, C.MaLoaiKhach, LK.TenLoaiKhach,PT.NgayBatDau, PT.NgayKetThuc , C.CMND, C.DiaChi"
        selectQuery &= " FROM [PHONG] AS P, [CHITIETPHIEUTHUE] AS C, [PHIEUTHUEPHONG] AS PT, [LOAIKHACH] AS LK"
        selectQuery &= " WHERE P.MaPhong = PT.MaPhong AND PT.MaPhieuThue = C.MaPhieuThue AND LK.MaLoaiKhach = C.MaLoaiKhach"
        dgvListRoomRentBill.DataSource = db.FillDataset(selectQuery, CommandType.Text).Tables(0)
        dgvListRoomRentBill.Columns("MaPhong").HeaderText = msg.roomID
        dgvListRoomRentBill.Columns("TenPhong").HeaderText = msg.roomName
        dgvListRoomRentBill.Columns("TenKhachHang").HeaderText = msg.customerName
        dgvListRoomRentBill.Columns("MaLoaiKhach").HeaderText = msg.customerTypeID
        dgvListRoomRentBill.Columns("TenLoaiKhach").HeaderText = msg.customerTypeName
        dgvListRoomRentBill.Columns("NgayBatDau").HeaderText = msg.startDate
        dgvListRoomRentBill.Columns("NgayKetThuc").HeaderText = msg.endDate
        dgvListRoomRentBill.Columns("CMND").HeaderText = msg.cmnd
        dgvListRoomRentBill.Columns("DiaChi").HeaderText = msg.address
        selectQuery = "SELECT MaPhong,TenPhong FROM PHONG"
        cbbRoom.DataSource = db.FillDataset(selectQuery, CommandType.Text).Tables(0)
        cbbRoom.DisplayMember = "TenPhong"
        cbbRoom.ValueMember = "MaPhong"
        selectQuery = "SELECT MaLoaiKhach,TenLoaiKhach FROM LOAIKHACH"
        cbbCustomerType.DataSource = db.FillDataset(selectQuery, CommandType.Text).Tables(0)
        cbbCustomerType.DisplayMember = "TenLoaiKhach"
        cbbCustomerType.ValueMember = "MaLoaiKhach"
    End Sub
    Private Sub setVar()
        maphong = cbbRoom.SelectedValue
        tenphong = cbbRoom.Text
        tenkhach = txtCustomerName.Text
        maloaikhach = Convert.ToInt32(cbbCustomerType.SelectedValue)
        tenloaikhach = cbbCustomerType.Text
        ngaybatdau = dtpStartDate.Value.ToString("yyyy-MM-dd")
        ngaykethuc = dtpEndDate.Value.ToString("yyyy-MM-dd")
        cmnd = txtCMND.Text
        diachi = txtCustomerAddress.Text
    End Sub
    Private Sub btnNewRoomRentBill_Click(sender As Object, e As EventArgs) Handles btnNewRoomRentBill.Click
        Try
            setVar()
            Dim insertQuery As String
            insertQuery = "INSERT INTO PHIEUTHUEPHONG(MaPhong,NgayBatDau,NgayKetThuc)"
            insertQuery &= " VALUES(@maphong,@ngaybatdau,@ngayketthuc)"
            Dim params(0 To 2) As SqlParameter
            params(0) = New SqlParameter("@maphong", SqlDbType.VarChar, 10)
            params(0).Value = maphong
            params(1) = New SqlParameter("@ngaybatdau", SqlDbType.Date)
            params(1).Value = ngaybatdau
            params(2) = New SqlParameter("@ngayketthuc", SqlDbType.Date)
            params(2).Value = ngaykethuc
            db.ExecuteNonQuery(insertQuery, CommandType.Text, params)
            Dim newestRentID As Int32 = db.ExecuteScalar("SELECT MAX(MaPhieuThue) FROM PHIEUTHUEPHONG", CommandType.Text)
            insertQuery = "INSERT INTO CHITIETPHIEUTHUE(MaPhieuThue,TenKhachHang,MaLoaiKhach,CMND,DiaChi)"
            insertQuery &= " VALUES(@maphieuthue,@tenkhachhang,@maloaikhach,@CMND,@DiaChi)"
            Dim params2(0 To 4) As SqlParameter
            params2(0) = New SqlParameter("@maphieuthue", SqlDbType.Int, 10)
            params2(0).Value = newestRentID
            params2(1) = New SqlParameter("@tenkhachhang", SqlDbType.NVarChar, 100)
            params2(1).Value = tenkhach
            params2(2) = New SqlParameter("@maloaikhach", SqlDbType.Int, 10)
            params2(2).Value = maloaikhach
            params2(3) = New SqlParameter("@CMND", SqlDbType.VarChar, 11)
            params2(3).Value = cmnd
            params2(4) = New SqlParameter("@DiaChi", SqlDbType.VarChar, 200)
            params2(4).Value = diachi
            db.ExecuteNonQuery(insertQuery, CommandType.Text, params2)
            Dim ds As DataSet = CType(dgvListRoomRentBill.DataSource, DataTable).DataSet
            Dim newRow As DataRow
            newRow = ds.Tables(0).NewRow()
            newRow("MaPhong") = maphong
            newRow("TenPhong") = tenphong
            newRow("TenKhachHang") = tenkhach
            newRow("MaLoaiKhach") = maloaikhach
            newRow("TenLoaiKhach") = tenloaikhach
            newRow("NgayBatDau") = ngaybatdau
            newRow("NgayKetThuc") = ngaykethuc
            newRow("CMND") = cmnd
            newRow("DiaChi") = diachi
            ds.Tables(0).Rows.Add(newRow)
            MsgBox("Lập phiếu thành công!", MsgBoxStyle.Information, FormMain.controller.msg.msgTitleNotify)
        Catch ex As Exception
            MsgBox("Lập phiếu không thành công!")
        End Try


    End Sub
End Class