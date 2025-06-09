<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class teacherfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(teacherfrm))
        teacherPanel = New Panel()
        Panel2 = New Panel()
        btnSchoolyr = New Button()
        logoutBtn = New Button()
        settingsBtn = New Button()
        gradeEntryBtn = New Button()
        dashboardBtn = New Button()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' teacherPanel
        ' 
        teacherPanel.Location = New Point(273, 0)
        teacherPanel.Name = "teacherPanel"
        teacherPanel.Size = New Size(1567, 687)
        teacherPanel.TabIndex = 12
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        Panel2.Controls.Add(btnSchoolyr)
        Panel2.Controls.Add(logoutBtn)
        Panel2.Controls.Add(settingsBtn)
        Panel2.Controls.Add(gradeEntryBtn)
        Panel2.Controls.Add(dashboardBtn)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(267, 776)
        Panel2.TabIndex = 13
        ' 
        ' btnSchoolyr
        ' 
        btnSchoolyr.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btnSchoolyr.Dock = DockStyle.Top
        btnSchoolyr.FlatAppearance.BorderSize = 0
        btnSchoolyr.FlatStyle = FlatStyle.Flat
        btnSchoolyr.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        btnSchoolyr.Image = CType(resources.GetObject("btnSchoolyr.Image"), Image)
        btnSchoolyr.ImageAlign = ContentAlignment.MiddleLeft
        btnSchoolyr.Location = New Point(0, 292)
        btnSchoolyr.Name = "btnSchoolyr"
        btnSchoolyr.Size = New Size(267, 52)
        btnSchoolyr.TabIndex = 13
        btnSchoolyr.Text = "SCHOOL YEAR"
        btnSchoolyr.UseVisualStyleBackColor = False
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = Color.FromArgb(CByte(25), CByte(42), CByte(86))
        logoutBtn.Dock = DockStyle.Bottom
        logoutBtn.FlatAppearance.BorderSize = 0
        logoutBtn.FlatStyle = FlatStyle.Flat
        logoutBtn.Location = New Point(0, 741)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(267, 35)
        logoutBtn.TabIndex = 12
        logoutBtn.Text = "LOGOUT"
        logoutBtn.UseVisualStyleBackColor = False
        ' 
        ' settingsBtn
        ' 
        settingsBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        settingsBtn.Dock = DockStyle.Top
        settingsBtn.FlatAppearance.BorderSize = 0
        settingsBtn.FlatStyle = FlatStyle.Flat
        settingsBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        settingsBtn.Image = CType(resources.GetObject("settingsBtn.Image"), Image)
        settingsBtn.ImageAlign = ContentAlignment.MiddleLeft
        settingsBtn.Location = New Point(0, 240)
        settingsBtn.Name = "settingsBtn"
        settingsBtn.Size = New Size(267, 52)
        settingsBtn.TabIndex = 8
        settingsBtn.Text = "SETTINGS"
        settingsBtn.UseVisualStyleBackColor = False
        ' 
        ' gradeEntryBtn
        ' 
        gradeEntryBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        gradeEntryBtn.Dock = DockStyle.Top
        gradeEntryBtn.FlatAppearance.BorderSize = 0
        gradeEntryBtn.FlatStyle = FlatStyle.Flat
        gradeEntryBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        gradeEntryBtn.Image = CType(resources.GetObject("gradeEntryBtn.Image"), Image)
        gradeEntryBtn.ImageAlign = ContentAlignment.MiddleLeft
        gradeEntryBtn.Location = New Point(0, 188)
        gradeEntryBtn.Name = "gradeEntryBtn"
        gradeEntryBtn.Size = New Size(267, 52)
        gradeEntryBtn.TabIndex = 5
        gradeEntryBtn.Text = "GRADE ENTRY"
        gradeEntryBtn.UseVisualStyleBackColor = False
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        dashboardBtn.Dock = DockStyle.Top
        dashboardBtn.FlatAppearance.BorderSize = 0
        dashboardBtn.FlatStyle = FlatStyle.Flat
        dashboardBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        dashboardBtn.Image = CType(resources.GetObject("dashboardBtn.Image"), Image)
        dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        dashboardBtn.Location = New Point(0, 136)
        dashboardBtn.Name = "dashboardBtn"
        dashboardBtn.Size = New Size(267, 52)
        dashboardBtn.TabIndex = 3
        dashboardBtn.Text = "DASHBOARD"
        dashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox2)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(267, 136)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Top
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(267, 136)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' teacherfrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HighlightText
        ClientSize = New Size(1514, 776)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(teacherPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "teacherfrm"
        Text = "teacherfrm"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents logoutBtn As Button
    Friend WithEvents settingsBtn As Button
    Friend WithEvents gradeEntryBtn As Button
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents teacherPanel As Panel
    Friend WithEvents btnSchoolyr As Button
End Class
