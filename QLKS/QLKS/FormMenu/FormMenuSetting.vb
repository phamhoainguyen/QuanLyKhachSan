Public Class FormMenuSetting
    Private Sub btnSMSoftwareInfo_Click(sender As Object, e As EventArgs) Handles btnSMSoftwareInfo.Click
        FormMain.clearBackColorbtnSubMenu(Me)
        btnSMSoftwareInfo.BackColor = Color.RoyalBlue
        btnSMSoftwareInfo.ForeColor = Color.White
        FormMain.addFormToPanel(FormMain.frmSoftwareInfo, FormMain.pnWorkArea)
    End Sub

    Private Sub btnSMEditRule_Click(sender As Object, e As EventArgs) Handles btnSMEditRule.Click
        Dim isLoin As Boolean = FormMain.ClUser.isLogin()
        Dim level As Integer = FormMain.ClUser.level
        If (isLoin AndAlso (level = 0 Or level = 1)) Then
            FormMain.clearBackColorbtnSubMenu(Me)
            btnSMEditRule.BackColor = Color.RoyalBlue
            btnSMEditRule.ForeColor = Color.White
            FormMain.addFormToPanel(FormMain.frmEditRule, FormMain.pnWorkArea)
        Else
            MsgBox(FormMain.msg.notPermission, MsgBoxStyle.Exclamation, FormMain.msg.msgTitleWarning)
        End If

    End Sub

    Private Sub btnSMAccount_Click(sender As Object, e As EventArgs) Handles btnSMAccount.Click
        FormMain.clearBackColorbtnSubMenu(Me)
        btnSMAccount.BackColor = Color.RoyalBlue
        btnSMAccount.ForeColor = Color.White
        FormMain.addFormToPanel(FormMain.frmAccount, FormMain.pnWorkArea)
    End Sub
End Class