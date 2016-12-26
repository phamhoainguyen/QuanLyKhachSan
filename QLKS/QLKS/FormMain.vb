Public Class FormMain
    Public db As Database = New Database()
    Public controller As NController.Controller = New NController.Controller()
    Public ClUser As NController.CUser = New NController.CUser()
    Public msg As NController.Message = controller.msg
    Public frmRoomManagement As FormRoomManagement = New FormRoomManagement()
    Public frmMenuSetting As FormMenuSetting = New FormMenuSetting()
    Public frmMenuStore As FormMenuStore = New FormMenuStore()
    Public frmMenuSearch As FormMenuSearch = New FormMenuSearch()
    Public frmMenuReport As FormMenuReport = New FormMenuReport()
    Public frmAccount As FormAccount = New FormAccount()
    Public frmSoftwareInfo As FormSoftwareInfo = New FormSoftwareInfo()
    Public frmEditRule As FormEditRule = New FormEditRule()

    Private timercount As Int64
    Private timercheck As Boolean = True
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmSoftwareInfo As FormSoftwareInfo = New FormSoftwareInfo()
        addFormToPanel(frmSoftwareInfo, pnWorkArea)
        addFormToPanel(frmMenuSetting, pnSubMenu)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnWorkArea.Paint

    End Sub
    Public Sub addFormToPanel(ByVal frm As Form, ByVal panel As Panel)
        frm.TopLevel = False
        panel.Controls.Clear()
        panel.Controls.Add(frm)
        frm.Show()
    End Sub
    Public Sub clearBackColorbtnSubMenu(ByVal frm As Form)
        For Each btn As Button In frm.Controls.OfType(Of Button)().ToArray()
            btn.BackColor = Color.Gainsboro
            btn.ForeColor = Color.Black
        Next
    End Sub
    Private Sub clearBackColorbtnMainMenu()
        For Each btn As Button In pnMainMenu.Controls.OfType(Of Button)().ToArray()
            btn.BackColor = Color.DimGray
        Next
    End Sub

    Private Sub btnMenuSetting_Click(sender As Object, e As EventArgs) Handles btnMenuSetting.Click
        clearBackColorbtnMainMenu()
        btnMenuSetting.BackColor = Color.RoyalBlue
        addFormToPanel(frmMenuSetting, pnSubMenu)
    End Sub

    Private Sub btnMenuStore_Click(sender As Object, e As EventArgs) Handles btnMenuStore.Click
        clearBackColorbtnMainMenu()
        btnMenuStore.BackColor = Color.RoyalBlue
        addFormToPanel(frmMenuStore, pnSubMenu)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnMenuSearch.Click
        clearBackColorbtnMainMenu()
        btnMenuSearch.BackColor = Color.RoyalBlue
        addFormToPanel(frmMenuSearch, pnSubMenu)
    End Sub

    Private Sub btnMenuReport_Click(sender As Object, e As EventArgs) Handles btnMenuReport.Click
        clearBackColorbtnMainMenu()
        btnMenuReport.BackColor = Color.RoyalBlue
        addFormToPanel(frmMenuReport, pnSubMenu)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnExitApplication_Click(sender As Object, e As EventArgs) Handles btnExitApplication.Click
        Dim result As DialogResult = MessageBox.Show(msg.exitWarning, msg.msgTitleWarning, MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timercount += 1
        If (timercount = 120) Then
            timercheck = Not (timercheck)
            timercount = 0
        End If
        If (timercheck) Then
            lblWebsite.Location = New Point(lblWebsite.Location.X + 5, lblWebsite.Location.Y)
        Else
            lblWebsite.Location = New Point(lblWebsite.Location.X - 5, lblWebsite.Location.Y)
        End If

    End Sub
End Class