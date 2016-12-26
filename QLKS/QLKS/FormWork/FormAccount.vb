Public Class FormAccount
    Private db As Database = New Database()
    Private Sub FormAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim level As Integer = FormMain.ClUser.level
        If (FormMain.ClUser.isLogin AndAlso (level = 0 OrElse level = 1 OrElse level = 2)) Then
            dgvListUser.Visible = True
            pnAddUser.Enabled = True
            'Lấy danh sách user đưa vào DGV
            Dim sqlquery As String
            sqlquery = "SELECT User_Name,Name,UP.Position AS Position,Email,PhoneNumber FROM [USER] AS U,[USER_POSITION] AS UP WHERE U.Pos_ID = UP.Pos_ID"
            dgvListUser.DataSource = FormMain.db.FillDataset(sqlquery, CommandType.Text).Tables(0)
            dgvListUser.Columns("User_Name").HeaderText = "User Name"
            dgvListUser.Columns("Name").HeaderText = "Staff Name"
            dgvListUser.Columns("Position").HeaderText = "Position"
            dgvListUser.Columns("Email").HeaderText = "Email"
            dgvListUser.Columns("PhoneNumber").HeaderText = "Phone Number"
        Else
            lblAddUserNotify.Visible = True
        End If
        'Hiện thông tin tài khoản
        txtEmail.Text = FormMain.ClUser.email()
        txtFullName.Text = FormMain.ClUser.name()
        txtUserName.Text = FormMain.ClUser.userName()
        txtPosition.Text = FormMain.ClUser.position()
        txtPhoneNumber.Text = FormMain.ClUser.phoneNumber()
        'danh sách loại tài khoản vào combobox
        Dim selectQuery = "SELECT Pos_ID,Position FROM USER_POSITION"
        cbbStaffPosition.DataSource = db.FillDataset(selectQuery, CommandType.Text).Tables(0)
        cbbStaffPosition.DisplayMember = "Position"
        cbbStaffPosition.ValueMember = "Pos_ID"
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FormMain.ClUser.Logout()
        FormMain.Close()
        FormLogin.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnResetInput_Click(sender As Object, e As EventArgs) Handles btnResetInput.Click
        For Each txt As TextBox In pnAddUser.Controls.OfType(Of TextBox)().ToArray()
            txt.Text = ""
        Next
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim username, password, name, position, email, phonenumber As String
        username = txtUN.Text
        password = txtPW.Text
        name = txtStaffName.Text
        position = cbbStaffPosition.SelectedValue
        email = txtStaffEmail.Text
        phonenumber = txtPhoneNumber.Text
        Dim insertQuery As String = "INSERT INTO [USER](User_Name,User_Password,Name,Email,PhoneNumber,Pos_ID)"
        insertQuery &= " VALUES(@un,@pw,@name,@email,@phone,@pos)"
        Dim params(0 To 5) As SqlClient.SqlParameter
        params(0) = New SqlClient.SqlParameter("@un", SqlDbType.VarChar, 50)
        params(0).Value = username
        params(1) = New SqlClient.SqlParameter("@pw", SqlDbType.VarChar, 50)
        params(1).Value = password
        params(2) = New SqlClient.SqlParameter("@name", SqlDbType.NVarChar, 100)
        params(2).Value = name
        params(3) = New SqlClient.SqlParameter("@email", SqlDbType.VarChar, 100)
        params(3).Value = email
        params(4) = New SqlClient.SqlParameter("@phone", SqlDbType.VarChar, 15)
        params(4).Value = phonenumber
        params(5) = New SqlClient.SqlParameter("@pos", SqlDbType.Int, 3)
        params(5).Value = position
        db.ExecuteNonQuery(insertQuery, CommandType.Text, params)
        MsgBox("Add staff successful", MsgBoxStyle.Information, FormMain.controller.msg.msgTitleNotify)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtUserName_Click(sender As Object, e As EventArgs) Handles txtUserName.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtEmail_Click(sender As Object, e As EventArgs) Handles txtEmail.Click

    End Sub
End Class