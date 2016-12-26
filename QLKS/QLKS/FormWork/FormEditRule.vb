Imports System.Data.SqlClient
Public Class FormEditRule
    Private db As New Database()
    Private Sub FormEditRule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim selectQuery As String
            selectQuery = "SELECT GiaTri FROM THAMSO"
            selectQuery &= " WHERE TenThamSo = 'HeSoPhuThuKhachThu3'"
            txtHeSoPhuThuKhachThu3.Text = db.ExecuteScalar(selectQuery, CommandType.Text)
            selectQuery = "SELECT GiaTri FROM THAMSO"
            selectQuery &= " WHERE TenThamSo = 'HeSoPhuThuKhachNuocNgoai'"
            txtHeSoPhuThuKhachNuocNgoai.Text = db.ExecuteScalar(selectQuery, CommandType.Text)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnEditParam_Click(sender As Object, e As EventArgs) Handles btnEditParam.Click
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@giatri", SqlDbType.VarChar, 50)
            param(0).Value = txtHeSoPhuThuKhachThu3.Text
            Dim updateQuery As String
            updateQuery = "UPDATE THAMSO SET GiaTri = @giatri WHERE TenThamSo = 'HeSoPhuThuKhachThu3'"
            db.ExecuteNonQuery(updateQuery, CommandType.Text, param)
            Dim param2(0) As SqlParameter
            param2(0) = New SqlParameter("@giatri", SqlDbType.VarChar, 50)
            param2(0).Value = txtHeSoPhuThuKhachNuocNgoai.Text
            updateQuery = "UPDATE THAMSO SET GiaTri = @giatri WHERE TenThamSo = 'HeSoPhuThuKhachNuocNgoai'"
            db.ExecuteNonQuery(updateQuery, CommandType.Text, param2)
            MsgBox("Sửa quy định thành công", MsgBoxStyle.Information, FormMain.msg.msgTitleWarning)
        Catch ex As Exception
            MsgBox("Sửa quy định thất bại", MsgBoxStyle.Exclamation, FormMain.msg.msgTitleWarning)
        End Try
    End Sub
End Class