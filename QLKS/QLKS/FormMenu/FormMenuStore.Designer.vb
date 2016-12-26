<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuStore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnRoomManagement = New System.Windows.Forms.Button()
        Me.btnManageRoomType = New System.Windows.Forms.Button()
        Me.btnRoomRentBill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRoomManagement
        '
        Me.btnRoomManagement.BackColor = System.Drawing.Color.Transparent
        Me.btnRoomManagement.FlatAppearance.BorderSize = 0
        Me.btnRoomManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoomManagement.ForeColor = System.Drawing.Color.Black
        Me.btnRoomManagement.Location = New System.Drawing.Point(0, 38)
        Me.btnRoomManagement.Name = "btnRoomManagement"
        Me.btnRoomManagement.Size = New System.Drawing.Size(122, 40)
        Me.btnRoomManagement.TabIndex = 5
        Me.btnRoomManagement.Text = "Create list rooms"
        Me.btnRoomManagement.UseVisualStyleBackColor = False
        '
        'btnManageRoomType
        '
        Me.btnManageRoomType.FlatAppearance.BorderSize = 0
        Me.btnManageRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageRoomType.Location = New System.Drawing.Point(0, 76)
        Me.btnManageRoomType.Name = "btnManageRoomType"
        Me.btnManageRoomType.Size = New System.Drawing.Size(122, 40)
        Me.btnManageRoomType.TabIndex = 6
        Me.btnManageRoomType.Text = "Manage Room Type"
        Me.btnManageRoomType.UseVisualStyleBackColor = True
        '
        'btnRoomRentBill
        '
        Me.btnRoomRentBill.FlatAppearance.BorderSize = 0
        Me.btnRoomRentBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoomRentBill.Location = New System.Drawing.Point(0, -1)
        Me.btnRoomRentBill.Name = "btnRoomRentBill"
        Me.btnRoomRentBill.Size = New System.Drawing.Size(122, 40)
        Me.btnRoomRentBill.TabIndex = 7
        Me.btnRoomRentBill.Text = "Create rent bill"
        Me.btnRoomRentBill.UseVisualStyleBackColor = True
        '
        'FormMenuStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(122, 500)
        Me.Controls.Add(Me.btnRoomRentBill)
        Me.Controls.Add(Me.btnManageRoomType)
        Me.Controls.Add(Me.btnRoomManagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuStore"
        Me.Text = "FormMenuStored"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRoomManagement As Button
    Friend WithEvents btnManageRoomType As Button
    Friend WithEvents btnRoomRentBill As Button
End Class
