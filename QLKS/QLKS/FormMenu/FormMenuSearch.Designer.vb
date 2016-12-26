<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuSearch
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
        Me.btnRoomSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRoomSearch
        '
        Me.btnRoomSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRoomSearch.FlatAppearance.BorderSize = 0
        Me.btnRoomSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoomSearch.ForeColor = System.Drawing.Color.Black
        Me.btnRoomSearch.Location = New System.Drawing.Point(0, -1)
        Me.btnRoomSearch.Name = "btnRoomSearch"
        Me.btnRoomSearch.Size = New System.Drawing.Size(122, 40)
        Me.btnRoomSearch.TabIndex = 5
        Me.btnRoomSearch.Text = "Tra cứu phòng"
        Me.btnRoomSearch.UseVisualStyleBackColor = False
        '
        'FormMenuSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(122, 500)
        Me.Controls.Add(Me.btnRoomSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuSearch"
        Me.Text = "FormMenuSearch"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRoomSearch As Button
End Class
