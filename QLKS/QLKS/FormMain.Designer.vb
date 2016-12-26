<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.pnWorkArea = New System.Windows.Forms.Panel()
        Me.pnHeader = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnMainMenu = New System.Windows.Forms.Panel()
        Me.btnExitApplication = New System.Windows.Forms.Button()
        Me.btnMenuSearch = New System.Windows.Forms.Button()
        Me.btnMenuReport = New System.Windows.Forms.Button()
        Me.btnMenuStore = New System.Windows.Forms.Button()
        Me.btnMenuSetting = New System.Windows.Forms.Button()
        Me.pnSubMenu = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.pnHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnWorkArea
        '
        Me.pnWorkArea.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnWorkArea.Location = New System.Drawing.Point(221, 63)
        Me.pnWorkArea.Name = "pnWorkArea"
        Me.pnWorkArea.Size = New System.Drawing.Size(787, 476)
        Me.pnWorkArea.TabIndex = 4
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnHeader.Controls.Add(Me.PictureBox1)
        Me.pnHeader.ForeColor = System.Drawing.Color.DodgerBlue
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(1008, 64)
        Me.pnHeader.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 60)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnMainMenu
        '
        Me.pnMainMenu.BackColor = System.Drawing.Color.DimGray
        Me.pnMainMenu.Controls.Add(Me.btnExitApplication)
        Me.pnMainMenu.Controls.Add(Me.btnMenuSearch)
        Me.pnMainMenu.Controls.Add(Me.btnMenuReport)
        Me.pnMainMenu.Controls.Add(Me.btnMenuStore)
        Me.pnMainMenu.Controls.Add(Me.btnMenuSetting)
        Me.pnMainMenu.Location = New System.Drawing.Point(-1, 63)
        Me.pnMainMenu.Name = "pnMainMenu"
        Me.pnMainMenu.Size = New System.Drawing.Size(100, 500)
        Me.pnMainMenu.TabIndex = 2
        '
        'btnExitApplication
        '
        Me.btnExitApplication.BackColor = System.Drawing.Color.Transparent
        Me.btnExitApplication.BackgroundImage = CType(resources.GetObject("btnExitApplication.BackgroundImage"), System.Drawing.Image)
        Me.btnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExitApplication.FlatAppearance.BorderSize = 0
        Me.btnExitApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnExitApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitApplication.Location = New System.Drawing.Point(-2, 415)
        Me.btnExitApplication.Name = "btnExitApplication"
        Me.btnExitApplication.Size = New System.Drawing.Size(100, 81)
        Me.btnExitApplication.TabIndex = 4
        Me.btnExitApplication.UseVisualStyleBackColor = False
        '
        'btnMenuSearch
        '
        Me.btnMenuSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuSearch.BackgroundImage = CType(resources.GetObject("btnMenuSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnMenuSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMenuSearch.FlatAppearance.BorderSize = 0
        Me.btnMenuSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnMenuSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMenuSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuSearch.Location = New System.Drawing.Point(2, 200)
        Me.btnMenuSearch.Name = "btnMenuSearch"
        Me.btnMenuSearch.Size = New System.Drawing.Size(100, 100)
        Me.btnMenuSearch.TabIndex = 3
        Me.btnMenuSearch.UseVisualStyleBackColor = False
        '
        'btnMenuReport
        '
        Me.btnMenuReport.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuReport.BackgroundImage = CType(resources.GetObject("btnMenuReport.BackgroundImage"), System.Drawing.Image)
        Me.btnMenuReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMenuReport.FlatAppearance.BorderSize = 0
        Me.btnMenuReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnMenuReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMenuReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuReport.Location = New System.Drawing.Point(2, 299)
        Me.btnMenuReport.Name = "btnMenuReport"
        Me.btnMenuReport.Size = New System.Drawing.Size(100, 100)
        Me.btnMenuReport.TabIndex = 2
        Me.btnMenuReport.UseVisualStyleBackColor = False
        '
        'btnMenuStore
        '
        Me.btnMenuStore.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuStore.BackgroundImage = CType(resources.GetObject("btnMenuStore.BackgroundImage"), System.Drawing.Image)
        Me.btnMenuStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMenuStore.FlatAppearance.BorderSize = 0
        Me.btnMenuStore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnMenuStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMenuStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuStore.Location = New System.Drawing.Point(2, 100)
        Me.btnMenuStore.Name = "btnMenuStore"
        Me.btnMenuStore.Size = New System.Drawing.Size(100, 100)
        Me.btnMenuStore.TabIndex = 1
        Me.btnMenuStore.UseVisualStyleBackColor = False
        '
        'btnMenuSetting
        '
        Me.btnMenuSetting.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnMenuSetting.BackgroundImage = CType(resources.GetObject("btnMenuSetting.BackgroundImage"), System.Drawing.Image)
        Me.btnMenuSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMenuSetting.FlatAppearance.BorderSize = 0
        Me.btnMenuSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btnMenuSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMenuSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuSetting.Location = New System.Drawing.Point(2, 0)
        Me.btnMenuSetting.Name = "btnMenuSetting"
        Me.btnMenuSetting.Size = New System.Drawing.Size(100, 100)
        Me.btnMenuSetting.TabIndex = 0
        Me.btnMenuSetting.UseVisualStyleBackColor = False
        '
        'pnSubMenu
        '
        Me.pnSubMenu.BackColor = System.Drawing.Color.Gainsboro
        Me.pnSubMenu.Location = New System.Drawing.Point(99, 63)
        Me.pnSubMenu.Name = "pnSubMenu"
        Me.pnSubMenu.Size = New System.Drawing.Size(122, 500)
        Me.pnSubMenu.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.ForeColor = System.Drawing.Color.White
        Me.lblWebsite.Location = New System.Drawing.Point(227, 544)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(365, 13)
        Me.lblWebsite.TabIndex = 5
        Me.lblWebsite.Text = "Nguyễn Cao Cường - MSSV: 14520108 - Võ Quang Huy - MSSV: 14520389"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.lblWebsite)
        Me.Controls.Add(Me.pnWorkArea)
        Me.Controls.Add(Me.pnSubMenu)
        Me.Controls.Add(Me.pnMainMenu)
        Me.Controls.Add(Me.pnHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý khách sạn"
        Me.pnHeader.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnMainMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnWorkArea As Panel
    Friend WithEvents pnHeader As Panel
    Friend WithEvents pnMainMenu As Panel
    Friend WithEvents pnSubMenu As Panel
    Friend WithEvents btnMenuSetting As Button
    Friend WithEvents btnMenuStore As Button
    Friend WithEvents btnMenuReport As Button
    Friend WithEvents btnMenuSearch As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExitApplication As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblWebsite As Label
End Class
