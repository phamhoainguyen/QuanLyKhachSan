Public Class FormBill
    Private Sub FormBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from PHONG"
        Dim col As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        col.HeaderText = "Chon"
        col.Name = "check"
        dgv1.DataSource = FormMain.db.FillDataset(sql, CommandType.Text).Tables(0)
        dgv1.Columns.Add(col)
        dgv1.Columns("check").DisplayIndex = 0
    End Sub

End Class