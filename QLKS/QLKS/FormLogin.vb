Public Class FormLogin
    Private controller As NController.Controller = FormMain.controller
    Private ClUser As NController.CUser = FormMain.ClUser
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (ClUser.Login(txtUserName.Text, txtPassWord.Text)) Then
            FormMain.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
