<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuReport
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
        Me.btnMonthReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMonthReport
        '
        Me.btnMonthReport.FlatAppearance.BorderSize = 0
        Me.btnMonthReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonthReport.Location = New System.Drawing.Point(0, 0)
        Me.btnMonthReport.Name = "btnMonthReport"
        Me.btnMonthReport.Size = New System.Drawing.Size(122, 40)
        Me.btnMonthReport.TabIndex = 8
        Me.btnMonthReport.Text = "Month Report"
        Me.btnMonthReport.UseVisualStyleBackColor = True
        '
        'FormMenuReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(122, 500)
        Me.Controls.Add(Me.btnMonthReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuReport"
        Me.Text = "FormMenuReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMonthReport As Button
End Class
