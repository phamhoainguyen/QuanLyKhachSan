<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRoomRentBill
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbCustomerType = New System.Windows.Forms.ComboBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.txtCMND = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cbbRoom = New System.Windows.Forms.ComboBox()
        Me.btnNewRoomRentBill = New System.Windows.Forms.Button()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.dgvListRoomRentBill = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListRoomRentBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(28, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tên khách hàng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(417, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ngày kết thúc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chọn phòng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(28, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày bắt đầu"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbbCustomerType)
        Me.GroupBox1.Controls.Add(Me.txtCustomerAddress)
        Me.GroupBox1.Controls.Add(Me.txtCMND)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpEndDate)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.cbbRoom)
        Me.GroupBox1.Controls.Add(Me.btnNewRoomRentBill)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgvListRoomRentBill)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 438)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'cbbCustomerType
        '
        Me.cbbCustomerType.FormattingEnabled = True
        Me.cbbCustomerType.Location = New System.Drawing.Point(166, 137)
        Me.cbbCustomerType.Name = "cbbCustomerType"
        Me.cbbCustomerType.Size = New System.Drawing.Size(209, 27)
        Me.cbbCustomerType.TabIndex = 23
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(529, 137)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(209, 27)
        Me.txtCustomerAddress.TabIndex = 22
        '
        'txtCMND
        '
        Me.txtCMND.Location = New System.Drawing.Point(529, 101)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(209, 27)
        Me.txtCMND.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(457, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Địa chỉ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label8.Location = New System.Drawing.Point(461, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "CMND"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label7.Location = New System.Drawing.Point(28, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Loại khách hàng"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(529, 65)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(209, 27)
        Me.dtpEndDate.TabIndex = 16
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(166, 65)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(209, 27)
        Me.dtpStartDate.TabIndex = 15
        '
        'cbbRoom
        '
        Me.cbbRoom.FormattingEnabled = True
        Me.cbbRoom.Location = New System.Drawing.Point(166, 32)
        Me.cbbRoom.Name = "cbbRoom"
        Me.cbbRoom.Size = New System.Drawing.Size(209, 27)
        Me.cbbRoom.TabIndex = 14
        '
        'btnNewRoomRentBill
        '
        Me.btnNewRoomRentBill.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnNewRoomRentBill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewRoomRentBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewRoomRentBill.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnNewRoomRentBill.ForeColor = System.Drawing.Color.White
        Me.btnNewRoomRentBill.Location = New System.Drawing.Point(375, 206)
        Me.btnNewRoomRentBill.Name = "btnNewRoomRentBill"
        Me.btnNewRoomRentBill.Size = New System.Drawing.Size(120, 30)
        Me.btnNewRoomRentBill.TabIndex = 0
        Me.btnNewRoomRentBill.Text = "Lập phiếu"
        Me.btnNewRoomRentBill.UseVisualStyleBackColor = False
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(166, 101)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(209, 27)
        Me.txtCustomerName.TabIndex = 8
        '
        'dgvListRoomRentBill
        '
        Me.dgvListRoomRentBill.AllowUserToAddRows = False
        Me.dgvListRoomRentBill.AllowUserToDeleteRows = False
        Me.dgvListRoomRentBill.AllowUserToResizeRows = False
        Me.dgvListRoomRentBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListRoomRentBill.BackgroundColor = System.Drawing.Color.White
        Me.dgvListRoomRentBill.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListRoomRentBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListRoomRentBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListRoomRentBill.Location = New System.Drawing.Point(2, 249)
        Me.dgvListRoomRentBill.MultiSelect = False
        Me.dgvListRoomRentBill.Name = "dgvListRoomRentBill"
        Me.dgvListRoomRentBill.ReadOnly = True
        Me.dgvListRoomRentBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvListRoomRentBill.RowHeadersVisible = False
        Me.dgvListRoomRentBill.RowHeadersWidth = 80
        Me.dgvListRoomRentBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListRoomRentBill.Size = New System.Drawing.Size(759, 182)
        Me.dgvListRoomRentBill.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(6, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Lập phiếu thuê phòng"
        '
        'FormRoomRentBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 476)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRoomRentBill"
        Me.Text = "FormRoomRentBill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListRoomRentBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents dgvListRoomRentBill As DataGridView
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents cbbRoom As ComboBox
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents txtCMND As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnNewRoomRentBill As Button
    Friend WithEvents cbbCustomerType As ComboBox
End Class
