Public Class FormMenuSearch
    Private Sub FormMenuSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormMain.addFormToPanel(FormSearch, FormMain.pnWorkArea)
    End Sub

    Private Sub btnRoomSearch_Click(sender As Object, e As EventArgs) Handles btnRoomSearch.Click
        FormMain.clearBackColorbtnSubMenu(Me)
        btnRoomSearch.BackColor = Color.RoyalBlue
        btnRoomSearch.ForeColor = Color.White
        FormMain.addFormToPanel(FormSearch, FormMain.pnWorkArea)
    End Sub
End Class