Public Class FormMenuStore
    Private frmRoomManagement As FormRoomManagement = New FormRoomManagement()
    Private Sub FormMenuStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim isLogin As Boolean = FormMain.ClUser.isLogin()
        Dim level As Integer = FormMain.ClUser.level()
        If (isLogin = True And level = 2) Then
            btnRoomManagement.BackColor = Color.RoyalBlue
            btnRoomManagement.ForeColor = Color.White
            FormMain.addFormToPanel(frmRoomManagement, FormMain.pnWorkArea)
        End If

    End Sub
    Private Sub btnRoomManagement_Click(sender As Object, e As EventArgs) Handles btnRoomManagement.Click
        Dim isLogin As Boolean = FormMain.ClUser.isLogin()
        Dim level As Integer = FormMain.ClUser.level()
        If (isLogin = True And level = 2) Then
            FormMain.clearBackColorbtnSubMenu(Me)
            btnRoomManagement.BackColor = Color.RoyalBlue
            btnRoomManagement.ForeColor = Color.White
            FormMain.addFormToPanel(frmRoomManagement, FormMain.pnWorkArea)
        Else
            MsgBox(FormMain.controller.msg.notPermission, MsgBoxStyle.Exclamation, FormMain.controller.msg.msgTitleWarning)
        End If
    End Sub

    Private Sub btnManageRoomType_Click(sender As Object, e As EventArgs) Handles btnManageRoomType.Click
        Dim isLogin As Boolean = FormMain.ClUser.isLogin()
        Dim level As Integer = FormMain.ClUser.level()
        If (isLogin = True And level = 2) Then
            FormMain.clearBackColorbtnSubMenu(Me)
            btnManageRoomType.BackColor = Color.RoyalBlue
            btnManageRoomType.ForeColor = Color.White
            FormMain.addFormToPanel(FormRoomTypeManagement, FormMain.pnWorkArea)
        Else
            MsgBox(FormMain.controller.msg.notPermission, MsgBoxStyle.Exclamation, FormMain.controller.msg.msgTitleWarning)
        End If
    End Sub

    Private Sub btnRoomRentBill_Click(sender As Object, e As EventArgs) Handles btnRoomRentBill.Click
        Dim isLogin As Boolean = FormMain.ClUser.isLogin()
        Dim level As Integer = FormMain.ClUser.level()
        If (isLogin = True And level = 3) Then
            FormMain.clearBackColorbtnSubMenu(Me)
            btnRoomRentBill.BackColor = Color.RoyalBlue
            btnRoomRentBill.ForeColor = Color.White
            FormMain.addFormToPanel(FormRoomRentBill, FormMain.pnWorkArea)
        Else
            MsgBox(FormMain.controller.msg.notPermission, MsgBoxStyle.Exclamation, FormMain.controller.msg.msgTitleWarning)
        End If
    End Sub
End Class