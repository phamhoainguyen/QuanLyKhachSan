<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.txtPhoneNumber = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnAddUser = New System.Windows.Forms.Panel()
        Me.cbbStaffPosition = New System.Windows.Forms.ComboBox()
        Me.lblAddUserNotify = New System.Windows.Forms.Label()
        Me.btnResetInput = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStaffNumber = New System.Windows.Forms.TextBox()
        Me.txtStaffEmail = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.txtUN = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvListUser = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnAddUser.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.txtPhoneNumber)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtPosition)
        Me.Panel1.Controls.Add(Me.txtFullName)
        Me.Panel1.Controls.Add(Me.txtUserName)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 111)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.QLKS.My.Resources.Resources.userBlack
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(199, 7)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(91, 26)
        Me.btnLogout.TabIndex = 11
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.AutoSize = True
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtPhoneNumber.ForeColor = System.Drawing.Color.Coral
        Me.txtPhoneNumber.Location = New System.Drawing.Point(432, 57)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(103, 15)
        Me.txtPhoneNumber.TabIndex = 10
        Me.txtPhoneNumber.Text = "Phone Number"
        '
        'txtEmail
        '
        Me.txtEmail.AutoSize = True
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Coral
        Me.txtEmail.Location = New System.Drawing.Point(432, 34)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(44, 15)
        Me.txtEmail.TabIndex = 9
        Me.txtEmail.Text = "Email"
        '
        'txtPosition
        '
        Me.txtPosition.AutoSize = True
        Me.txtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtPosition.ForeColor = System.Drawing.Color.Coral
        Me.txtPosition.Location = New System.Drawing.Point(134, 80)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(59, 15)
        Me.txtPosition.TabIndex = 8
        Me.txtPosition.Text = "Position"
        '
        'txtFullName
        '
        Me.txtFullName.AutoSize = True
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.Coral
        Me.txtFullName.Location = New System.Drawing.Point(133, 57)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(78, 15)
        Me.txtFullName.TabIndex = 7
        Me.txtFullName.Text = "Staff Name"
        '
        'txtUserName
        '
        Me.txtUserName.AutoSize = True
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.Coral
        Me.txtUserName.Location = New System.Drawing.Point(133, 34)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(86, 16)
        Me.txtUserName.TabIndex = 6
        Me.txtUserName.Text = "User Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Coral
        Me.Label6.Location = New System.Drawing.Point(325, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Coral
        Me.Label5.Location = New System.Drawing.Point(325, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Coral
        Me.Label4.Location = New System.Drawing.Point(35, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Coral
        Me.Label3.Location = New System.Drawing.Point(35, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Staff Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(35, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(34, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accout Infomation"
        '
        'pnAddUser
        '
        Me.pnAddUser.Controls.Add(Me.cbbStaffPosition)
        Me.pnAddUser.Controls.Add(Me.lblAddUserNotify)
        Me.pnAddUser.Controls.Add(Me.btnResetInput)
        Me.pnAddUser.Controls.Add(Me.btnAddUser)
        Me.pnAddUser.Controls.Add(Me.Label13)
        Me.pnAddUser.Controls.Add(Me.Label12)
        Me.pnAddUser.Controls.Add(Me.Label11)
        Me.pnAddUser.Controls.Add(Me.Label10)
        Me.pnAddUser.Controls.Add(Me.Label9)
        Me.pnAddUser.Controls.Add(Me.Label8)
        Me.pnAddUser.Controls.Add(Me.txtStaffNumber)
        Me.pnAddUser.Controls.Add(Me.txtStaffEmail)
        Me.pnAddUser.Controls.Add(Me.txtStaffName)
        Me.pnAddUser.Controls.Add(Me.txtPW)
        Me.pnAddUser.Controls.Add(Me.txtUN)
        Me.pnAddUser.Controls.Add(Me.PictureBox1)
        Me.pnAddUser.Controls.Add(Me.Label7)
        Me.pnAddUser.Enabled = False
        Me.pnAddUser.Location = New System.Drawing.Point(12, 129)
        Me.pnAddUser.Name = "pnAddUser"
        Me.pnAddUser.Size = New System.Drawing.Size(763, 185)
        Me.pnAddUser.TabIndex = 1
        '
        'cbbStaffPosition
        '
        Me.cbbStaffPosition.FormattingEnabled = True
        Me.cbbStaffPosition.Location = New System.Drawing.Point(417, 44)
        Me.cbbStaffPosition.Name = "cbbStaffPosition"
        Me.cbbStaffPosition.Size = New System.Drawing.Size(221, 21)
        Me.cbbStaffPosition.TabIndex = 16
        '
        'lblAddUserNotify
        '
        Me.lblAddUserNotify.AutoSize = True
        Me.lblAddUserNotify.Location = New System.Drawing.Point(194, 14)
        Me.lblAddUserNotify.Name = "lblAddUserNotify"
        Me.lblAddUserNotify.Size = New System.Drawing.Size(332, 13)
        Me.lblAddUserNotify.TabIndex = 15
        Me.lblAddUserNotify.Text = "You must be an administrator, director or manager to use this function"
        Me.lblAddUserNotify.Visible = False
        '
        'btnResetInput
        '
        Me.btnResetInput.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnResetInput.FlatAppearance.BorderSize = 0
        Me.btnResetInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetInput.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetInput.ForeColor = System.Drawing.Color.White
        Me.btnResetInput.Location = New System.Drawing.Point(399, 146)
        Me.btnResetInput.Name = "btnResetInput"
        Me.btnResetInput.Size = New System.Drawing.Size(91, 33)
        Me.btnResetInput.TabIndex = 14
        Me.btnResetInput.Text = "Reset"
        Me.btnResetInput.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddUser.FlatAppearance.BorderSize = 0
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(221, 149)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(91, 30)
        Me.btnAddUser.TabIndex = 13
        Me.btnAddUser.Text = "Add Staff"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label13.Location = New System.Drawing.Point(325, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Position"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label12.Location = New System.Drawing.Point(323, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Phone Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label11.Location = New System.Drawing.Point(325, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label10.Location = New System.Drawing.Point(54, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Name Staff"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(57, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label8.Location = New System.Drawing.Point(54, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Account"
        '
        'txtStaffNumber
        '
        Me.txtStaffNumber.Location = New System.Drawing.Point(417, 103)
        Me.txtStaffNumber.Name = "txtStaffNumber"
        Me.txtStaffNumber.Size = New System.Drawing.Size(221, 20)
        Me.txtStaffNumber.TabIndex = 7
        '
        'txtStaffEmail
        '
        Me.txtStaffEmail.Location = New System.Drawing.Point(417, 73)
        Me.txtStaffEmail.Name = "txtStaffEmail"
        Me.txtStaffEmail.Size = New System.Drawing.Size(221, 20)
        Me.txtStaffEmail.TabIndex = 6
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(136, 100)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(176, 20)
        Me.txtStaffName.TabIndex = 4
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(136, 73)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(176, 20)
        Me.txtPW.TabIndex = 3
        Me.txtPW.UseSystemPasswordChar = True
        '
        'txtUN
        '
        Me.txtUN.Location = New System.Drawing.Point(136, 47)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(176, 20)
        Me.txtUN.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.QLKS.My.Resources.Resources.addUserBlack
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(33, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Create Account"
        '
        'dgvListUser
        '
        Me.dgvListUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.dgvListUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListUser.Location = New System.Drawing.Point(101, 320)
        Me.dgvListUser.Name = "dgvListUser"
        Me.dgvListUser.ReadOnly = True
        Me.dgvListUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListUser.Size = New System.Drawing.Size(575, 144)
        Me.dgvListUser.TabIndex = 2
        Me.dgvListUser.Visible = False
        '
        'FormAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 476)
        Me.Controls.Add(Me.dgvListUser)
        Me.Controls.Add(Me.pnAddUser)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAccount"
        Me.Text = "FormAccount"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnAddUser.ResumeLayout(False)
        Me.pnAddUser.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnAddUser As Panel
    Friend WithEvents dgvListUser As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhoneNumber As Label
    Friend WithEvents txtEmail As Label
    Friend WithEvents txtPosition As Label
    Friend WithEvents txtFullName As Label
    Friend WithEvents txtUserName As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStaffNumber As TextBox
    Friend WithEvents txtStaffEmail As TextBox
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents txtUN As TextBox
    Friend WithEvents btnResetInput As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents lblAddUserNotify As Label
    Friend WithEvents cbbStaffPosition As ComboBox
End Class
