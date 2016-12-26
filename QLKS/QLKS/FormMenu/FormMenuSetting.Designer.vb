<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuSetting
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
        Me.btnSMEditRule = New System.Windows.Forms.Button()
        Me.btnSMAccount = New System.Windows.Forms.Button()
        Me.btnSMSoftwareInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSMEditRule
        '
        Me.btnSMEditRule.FlatAppearance.BorderSize = 0
        Me.btnSMEditRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSMEditRule.Location = New System.Drawing.Point(0, 39)
        Me.btnSMEditRule.Name = "btnSMEditRule"
        Me.btnSMEditRule.Size = New System.Drawing.Size(122, 40)
        Me.btnSMEditRule.TabIndex = 2
        Me.btnSMEditRule.Text = "Change Policy"
        Me.btnSMEditRule.UseVisualStyleBackColor = True
        '
        'btnSMAccount
        '
        Me.btnSMAccount.FlatAppearance.BorderSize = 0
        Me.btnSMAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSMAccount.Location = New System.Drawing.Point(0, 79)
        Me.btnSMAccount.Name = "btnSMAccount"
        Me.btnSMAccount.Size = New System.Drawing.Size(122, 40)
        Me.btnSMAccount.TabIndex = 3
        Me.btnSMAccount.Text = "Account"
        Me.btnSMAccount.UseVisualStyleBackColor = True
        '
        'btnSMSoftwareInfo
        '
        Me.btnSMSoftwareInfo.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSMSoftwareInfo.FlatAppearance.BorderSize = 0
        Me.btnSMSoftwareInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSMSoftwareInfo.ForeColor = System.Drawing.Color.White
        Me.btnSMSoftwareInfo.Location = New System.Drawing.Point(0, -1)
        Me.btnSMSoftwareInfo.Name = "btnSMSoftwareInfo"
        Me.btnSMSoftwareInfo.Size = New System.Drawing.Size(122, 40)
        Me.btnSMSoftwareInfo.TabIndex = 4
        Me.btnSMSoftwareInfo.Text = "Software Infomation"
        Me.btnSMSoftwareInfo.UseVisualStyleBackColor = False
        '
        'FormMenuSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(122, 500)
        Me.Controls.Add(Me.btnSMSoftwareInfo)
        Me.Controls.Add(Me.btnSMAccount)
        Me.Controls.Add(Me.btnSMEditRule)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuSetting"
        Me.Text = "FormMenuSetting"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSMEditRule As Button
    Friend WithEvents btnSMAccount As Button
    Friend WithEvents btnSMSoftwareInfo As Button
End Class
