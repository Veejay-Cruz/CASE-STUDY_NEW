<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deanfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deanfrm))
        Panel1 = New Panel()
        settingsBtn = New Button()
        sectionBtn = New Button()
        logoutBtn = New Button()
        subjectmanBtn = New Button()
        coursemanagementBtn = New Button()
        gradeentryBtn = New Button()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        mainPanel = New Panel()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        Panel1.Controls.Add(settingsBtn)
        Panel1.Controls.Add(sectionBtn)
        Panel1.Controls.Add(logoutBtn)
        Panel1.Controls.Add(subjectmanBtn)
        Panel1.Controls.Add(coursemanagementBtn)
        Panel1.Controls.Add(gradeentryBtn)
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(267, 736)
        Panel1.TabIndex = 10
        ' 
        ' settingsBtn
        ' 
        settingsBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        settingsBtn.Dock = DockStyle.Top
        settingsBtn.FlatAppearance.BorderSize = 0
        settingsBtn.FlatStyle = FlatStyle.Flat
        settingsBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        settingsBtn.ForeColor = Color.White
        settingsBtn.Image = CType(resources.GetObject("settingsBtn.Image"), Image)
        settingsBtn.ImageAlign = ContentAlignment.MiddleLeft
        settingsBtn.Location = New Point(0, 344)
        settingsBtn.Name = "settingsBtn"
        settingsBtn.Size = New Size(267, 48)
        settingsBtn.TabIndex = 8
        settingsBtn.Text = "SETTINGS"
        settingsBtn.UseVisualStyleBackColor = False
        ' 
        ' sectionBtn
        ' 
        sectionBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        sectionBtn.Dock = DockStyle.Top
        sectionBtn.FlatAppearance.BorderSize = 0
        sectionBtn.FlatStyle = FlatStyle.Flat
        sectionBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        sectionBtn.ForeColor = Color.White
        sectionBtn.Image = CType(resources.GetObject("sectionBtn.Image"), Image)
        sectionBtn.ImageAlign = ContentAlignment.MiddleLeft
        sectionBtn.Location = New Point(0, 292)
        sectionBtn.Name = "sectionBtn"
        sectionBtn.Size = New Size(267, 52)
        sectionBtn.TabIndex = 13
        sectionBtn.Text = "SECTIONS"
        sectionBtn.UseVisualStyleBackColor = False
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = Color.FromArgb(CByte(25), CByte(42), CByte(86))
        logoutBtn.Dock = DockStyle.Bottom
        logoutBtn.FlatAppearance.BorderSize = 0
        logoutBtn.FlatStyle = FlatStyle.Flat
        logoutBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logoutBtn.ForeColor = Color.White
        logoutBtn.Location = New Point(0, 694)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(267, 42)
        logoutBtn.TabIndex = 12
        logoutBtn.Text = "LOGOUT"
        logoutBtn.UseVisualStyleBackColor = False
        ' 
        ' subjectmanBtn
        ' 
        subjectmanBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        subjectmanBtn.Dock = DockStyle.Top
        subjectmanBtn.FlatAppearance.BorderSize = 0
        subjectmanBtn.FlatStyle = FlatStyle.Flat
        subjectmanBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        subjectmanBtn.ForeColor = Color.White
        subjectmanBtn.Image = CType(resources.GetObject("subjectmanBtn.Image"), Image)
        subjectmanBtn.ImageAlign = ContentAlignment.MiddleLeft
        subjectmanBtn.Location = New Point(0, 240)
        subjectmanBtn.Name = "subjectmanBtn"
        subjectmanBtn.Size = New Size(267, 52)
        subjectmanBtn.TabIndex = 7
        subjectmanBtn.Text = "SUBJECT MANAGEMENT"
        subjectmanBtn.UseVisualStyleBackColor = False
        ' 
        ' coursemanagementBtn
        ' 
        coursemanagementBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        coursemanagementBtn.Dock = DockStyle.Top
        coursemanagementBtn.FlatAppearance.BorderSize = 0
        coursemanagementBtn.FlatStyle = FlatStyle.Flat
        coursemanagementBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        coursemanagementBtn.ForeColor = Color.White
        coursemanagementBtn.Image = CType(resources.GetObject("coursemanagementBtn.Image"), Image)
        coursemanagementBtn.ImageAlign = ContentAlignment.MiddleLeft
        coursemanagementBtn.Location = New Point(0, 188)
        coursemanagementBtn.Name = "coursemanagementBtn"
        coursemanagementBtn.Size = New Size(267, 52)
        coursemanagementBtn.TabIndex = 6
        coursemanagementBtn.Text = "COURSE MANAGEMENT"
        coursemanagementBtn.UseVisualStyleBackColor = False
        ' 
        ' gradeentryBtn
        ' 
        gradeentryBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        gradeentryBtn.Dock = DockStyle.Top
        gradeentryBtn.FlatAppearance.BorderSize = 0
        gradeentryBtn.FlatStyle = FlatStyle.Flat
        gradeentryBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        gradeentryBtn.ForeColor = Color.White
        gradeentryBtn.Image = CType(resources.GetObject("gradeentryBtn.Image"), Image)
        gradeentryBtn.ImageAlign = ContentAlignment.MiddleLeft
        gradeentryBtn.Location = New Point(0, 136)
        gradeentryBtn.Name = "gradeentryBtn"
        gradeentryBtn.Size = New Size(267, 52)
        gradeentryBtn.TabIndex = 5
        gradeentryBtn.Text = "GRADE ENTRY"
        gradeentryBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(PictureBox1)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(267, 136)
        Panel4.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(267, 136)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = SystemColors.Control
        mainPanel.Dock = DockStyle.Fill
        mainPanel.Location = New Point(267, 0)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1052, 736)
        mainPanel.TabIndex = 11
        ' 
        ' deanfrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1319, 736)
        Controls.Add(mainPanel)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "deanfrm"
        Text = "deanfrm"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoutBtn As Button
    Friend WithEvents subjectmanBtn As Button
    Friend WithEvents coursemanagementBtn As Button
    Friend WithEvents gradeentryBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents settingsBtn As Button
    Friend WithEvents mainPanel As Panel
    Friend WithEvents sectionBtn As Button
End Class
