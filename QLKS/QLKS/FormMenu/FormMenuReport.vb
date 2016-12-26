Public Class FormMenuReport
    Private Sub btnMonthReport_Click(sender As Object, e As EventArgs) Handles btnMonthReport.Click
        Dim isLogin As Boolean = FormMain.ClUser.isLogin
        Dim level As Integer = FormMain.ClUser.level
        If (isLogin = True And level = 2) Then
            FormMain.clearBackColorbtnSubMenu(Me)
            btnMonthReport.BackColor = Color.RoyalBlue
            btnMonthReport.ForeColor = Color.White
            FormMain.addFormToPanel(FormReport, FormMain.pnWorkArea)
        Else
            MsgBox(FormMain.controller.msg.notPermission, MsgBoxStyle.Exclamation, FormMain.controller.msg.msgTitleWarning)
        End If
    End Sub
End Class