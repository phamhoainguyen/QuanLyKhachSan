<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRoomManagement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDeleteRoom = New System.Windows.Forms.Button()
        Me.btnEditRoom = New System.Windows.Forms.Button()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.cbbLoaiPhong = New System.Windows.Forms.ComboBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtTenPhong = New System.Windows.Forms.TextBox()
        Me.dgvListRoom = New System.Windows.Forms.DataGridView()
        Me.txtMaPhong = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(30, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(30, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Room Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(399, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Room Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(30, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Note"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(406, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnDeleteRoom)
        Me.GroupBox1.Controls.Add(Me.btnEditRoom)
        Me.GroupBox1.Controls.Add(Me.btnAddRoom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbbLoaiPhong)
        Me.GroupBox1.Controls.Add(Me.txtDonGia)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtGhiChu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTenPhong)
        Me.GroupBox1.Controls.Add(Me.dgvListRoom)
        Me.GroupBox1.Controls.Add(Me.txtMaPhong)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 449)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btnDeleteRoom
        '
        Me.btnDeleteRoom.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteRoom.Enabled = False
        Me.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteRoom.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnDeleteRoom.ForeColor = System.Drawing.Color.White
        Me.btnDeleteRoom.Location = New System.Drawing.Point(545, 156)
        Me.btnDeleteRoom.Name = "btnDeleteRoom"
        Me.btnDeleteRoom.Size = New System.Drawing.Size(120, 30)
        Me.btnDeleteRoom.TabIndex = 2
        Me.btnDeleteRoom.Text = "Delete"
        Me.btnDeleteRoom.UseVisualStyleBackColor = False
        '
        'btnEditRoom
        '
        Me.btnEditRoom.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnEditRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditRoom.Enabled = False
        Me.btnEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditRoom.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnEditRoom.ForeColor = System.Drawing.Color.White
        Me.btnEditRoom.Location = New System.Drawing.Point(355, 156)
        Me.btnEditRoom.Name = "btnEditRoom"
        Me.btnEditRoom.Size = New System.Drawing.Size(120, 30)
        Me.btnEditRoom.TabIndex = 1
        Me.btnEditRoom.Text = "Edit"
        Me.btnEditRoom.UseVisualStyleBackColor = False
        '
        'btnAddRoom
        '
        Me.btnAddRoom.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRoom.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnAddRoom.ForeColor = System.Drawing.Color.White
        Me.btnAddRoom.Location = New System.Drawing.Point(166, 156)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(120, 30)
        Me.btnAddRoom.TabIndex = 0
        Me.btnAddRoom.Text = "Add"
        Me.btnAddRoom.UseVisualStyleBackColor = False
        '
        'cbbLoaiPhong
        '
        Me.cbbLoaiPhong.FormattingEnabled = True
        Me.cbbLoaiPhong.Location = New System.Drawing.Point(500, 24)
        Me.cbbLoaiPhong.Name = "cbbLoaiPhong"
        Me.cbbLoaiPhong.Size = New System.Drawing.Size(215, 27)
        Me.cbbLoaiPhong.TabIndex = 11
        '
        'txtDonGia
        '
        Me.txtDonGia.Enabled = False
        Me.txtDonGia.Location = New System.Drawing.Point(500, 70)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(215, 27)
        Me.txtDonGia.TabIndex = 10
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(133, 117)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(593, 27)
        Me.txtGhiChu.TabIndex = 8
        '
        'txtTenPhong
        '
        Me.txtTenPhong.Location = New System.Drawing.Point(133, 70)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(209, 27)
        Me.txtTenPhong.TabIndex = 9
        '
        'dgvListRoom
        '
        Me.dgvListRoom.AllowUserToAddRows = False
        Me.dgvListRoom.AllowUserToDeleteRows = False
        Me.dgvListRoom.AllowUserToResizeRows = False
        Me.dgvListRoom.BackgroundColor = System.Drawing.Color.White
        Me.dgvListRoom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListRoom.Location = New System.Drawing.Point(4, 195)
        Me.dgvListRoom.MultiSelect = False
        Me.dgvListRoom.Name = "dgvListRoom"
        Me.dgvListRoom.ReadOnly = True
        Me.dgvListRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvListRoom.RowHeadersWidth = 80
        Me.dgvListRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListRoom.Size = New System.Drawing.Size(759, 251)
        Me.dgvListRoom.TabIndex = 7
        '
        'txtMaPhong
        '
        Me.txtMaPhong.Enabled = False
        Me.txtMaPhong.Location = New System.Drawing.Point(133, 21)
        Me.txtMaPhong.Name = "txtMaPhong"
        Me.txtMaPhong.Size = New System.Drawing.Size(152, 27)
        Me.txtMaPhong.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(18, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "List Rooms"
        '
        'FormRoomManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 476)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRoomManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLapDanhMucPhong"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtTenPhong As TextBox
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents txtMaPhong As TextBox
    Friend WithEvents btnDeleteRoom As Button
    Friend WithEvents btnEditRoom As Button
    Friend WithEvents btnAddRoom As Button
    Friend WithEvents cbbLoaiPhong As ComboBox
    Friend WithEvents dgvListRoom As DataGridView
    Friend WithEvents Label6 As Label
End Class
