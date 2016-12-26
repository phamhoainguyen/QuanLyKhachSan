Public Class FormReport
    Private db As Database = New Database()
    Private msg As NController.Message = New NController.Message()
    Private tongdoanhthu As Double = 0
    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub
    Private Sub init()
        Try
            'Lấy loại phòng đưa vào combobox
            cbbRoomType.DataSource = db.FillDataset("SELECT MaLoaiPhong,TenLoaiPhong FROM LOAIPHONG", CommandType.Text).Tables(0)
            cbbRoomType.DisplayMember = "TenLoaiPhong"
            cbbRoomType.ValueMember = "MaLoaiPhong"

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        tongdoanhthu = 0
        Try
            'Lấy danh sách Danh Mục phòng đưa vào DGV
            Dim maloaiphong As String = cbbRoomType.SelectedValue
            Dim Thang As Integer = Convert.ToInt32(dtpMothReport.Value.ToString("MM"))
            Dim sqlGetListRoom As String
            Dim thanhtien As Double
            sqlGetListRoom = "SELECT P.TenPhong, C.TenKhachHang, LK.TenLoaiKhach, LP.DonGia, PT.NgayBatDau, PT.NgayKetThuc"
            sqlGetListRoom &= " FROM [PHONG] AS P,[LOAIPHONG] AS LP,[PHIEUTHUEPHONG] PT, [LOAIKHACH] AS LK, [CHITIETPHIEUTHUE] AS C"
            sqlGetListRoom &= " WHERE P.[MaLoaiPhong] = LP.[MaLoaiPhong] AND PT.MaPhong = P.MaPhong AND LK.MaLoaiKhach = C.MaLoaiKhach AND C.MaPhieuThue = PT.MaPhieuThue"
            sqlGetListRoom &= " AND P.[MaLoaiPhong] = '" + maloaiphong + "' AND (MONTH(NgayBatDau)=" + Thang.ToString() + " OR MONTH(NgayKetThuc) = " + Thang.ToString() + ")"
            Dim table As DataTable = New DataTable
            table = db.FillDataset(sqlGetListRoom, CommandType.Text).Tables(0)
            If (table.Rows.Count < 1) Then
                MsgBox("Không có báo cáo phù hợp với yêu cầu", MsgBoxStyle.Information, msg.msgTitleNotify)
            Else
                Dim col As DataColumn = New DataColumn
                col.ColumnName = "ThanhTien"
                table.Columns.Add(col)
                For Each row As DataRow In table.Rows
                    thanhtien = (DateDiff(DateInterval.Day, CDate(row("NgayBatDau")), CDate(row("NgayKetThuc"))) * Convert.ToDouble(row("DonGia")))
                    row("ThanhTien") = FormMain.controller.MoneyToString(thanhtien)
                    row("DonGia") = FormMain.controller.MoneyToString(row("DonGia"))
                    row("NgayBatDau") = row("NgayBatDau").ToString()
                    tongdoanhthu = tongdoanhthu + thanhtien
                Next
                dgvReport.DataSource = table
                'Sửa tiêu đề các cột của DGV
                dgvReport.Columns("TenPhong").HeaderText = msg.roomName
                dgvReport.Columns("TenKhachHang").HeaderText = msg.customerName
                dgvReport.Columns("TenLoaiKhach").HeaderText = msg.customerTypeName
                dgvReport.Columns("DonGia").HeaderText = msg.priceUnit
                dgvReport.Columns("NgayBatDau").HeaderText = msg.startDate
                dgvReport.Columns("NgayKetThuc").HeaderText = msg.endDate
                dgvReport.Columns("ThanhTien").HeaderText = "Thành tiền"
                lblTongDoanhThu.Text = FormMain.controller.MoneyToString(tongdoanhthu)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) Handles btnExcelExport.Click
        Dim saveFileDialog As SaveFileDialog = New SaveFileDialog
        saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx"
        If (saveFileDialog.ShowDialog = DialogResult.OK) Then
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            For i = 0 To dgvReport.RowCount - 2
                For j = 0 To dgvReport.ColumnCount - 1
                    For k As Integer = 1 To dgvReport.Columns.Count
                        xlWorkSheet.Cells(1, k) = dgvReport.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = dgvReport(j, i).Value.ToString()
                    Next
                Next
            Next

            xlWorkSheet.SaveAs(saveFileDialog.FileName)
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MsgBox("Xuất File Excel thành công")
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class