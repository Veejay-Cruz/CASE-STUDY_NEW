<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        currentTime = New Timer(components)
        Panel1 = New Panel()
        btnDepartment = New Button()
        logoutBtn = New Button()
        syBtn = New Button()
        usersBtn = New Button()
        courseBtn = New Button()
        subjectBtn = New Button()
        studBtn = New Button()
        auditBtn = New Button()
        reportsBtn = New Button()
        dashboardBtn = New Button()
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
        Panel1.Controls.Add(btnDepartment)
        Panel1.Controls.Add(logoutBtn)
        Panel1.Controls.Add(syBtn)
        Panel1.Controls.Add(usersBtn)
        Panel1.Controls.Add(courseBtn)
        Panel1.Controls.Add(subjectBtn)
        Panel1.Controls.Add(studBtn)
        Panel1.Controls.Add(auditBtn)
        Panel1.Controls.Add(reportsBtn)
        Panel1.Controls.Add(dashboardBtn)
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(267, 923)
        Panel1.TabIndex = 9
        ' 
        ' btnDepartment
        ' 
        btnDepartment.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btnDepartment.Dock = DockStyle.Top
        btnDepartment.FlatAppearance.BorderSize = 0
        btnDepartment.FlatStyle = FlatStyle.Flat
        btnDepartment.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        btnDepartment.Image = CType(resources.GetObject("btnDepartment.Image"), Image)
        btnDepartment.ImageAlign = ContentAlignment.MiddleLeft
        btnDepartment.Location = New Point(0, 552)
        btnDepartment.Name = "btnDepartment"
        btnDepartment.Size = New Size(267, 52)
        btnDepartment.TabIndex = 13
        btnDepartment.Text = "DEPARTMENT"
        btnDepartment.UseVisualStyleBackColor = False
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = Color.FromArgb(CByte(25), CByte(42), CByte(86))
        logoutBtn.Dock = DockStyle.Bottom
        logoutBtn.FlatAppearance.BorderSize = 0
        logoutBtn.FlatStyle = FlatStyle.Flat
        logoutBtn.Location = New Point(0, 888)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(267, 35)
        logoutBtn.TabIndex = 12
        logoutBtn.Text = "LOGOUT"
        logoutBtn.UseVisualStyleBackColor = False
        ' 
        ' syBtn
        ' 
        syBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        syBtn.Dock = DockStyle.Top
        syBtn.FlatAppearance.BorderSize = 0
        syBtn.FlatStyle = FlatStyle.Flat
        syBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        syBtn.Image = CType(resources.GetObject("syBtn.Image"), Image)
        syBtn.ImageAlign = ContentAlignment.MiddleLeft
        syBtn.Location = New Point(0, 500)
        syBtn.Name = "syBtn"
        syBtn.Size = New Size(267, 52)
        syBtn.TabIndex = 10
        syBtn.Text = "SCHOOL YEAR"
        syBtn.UseVisualStyleBackColor = False
        ' 
        ' usersBtn
        ' 
        usersBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        usersBtn.Dock = DockStyle.Top
        usersBtn.FlatAppearance.BorderSize = 0
        usersBtn.FlatStyle = FlatStyle.Flat
        usersBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        usersBtn.Image = CType(resources.GetObject("usersBtn.Image"), Image)
        usersBtn.ImageAlign = ContentAlignment.MiddleLeft
        usersBtn.Location = New Point(0, 448)
        usersBtn.Name = "usersBtn"
        usersBtn.Size = New Size(267, 52)
        usersBtn.TabIndex = 9
        usersBtn.Text = "USERS"
        usersBtn.UseVisualStyleBackColor = False
        ' 
        ' courseBtn
        ' 
        courseBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        courseBtn.Dock = DockStyle.Top
        courseBtn.FlatAppearance.BorderSize = 0
        courseBtn.FlatStyle = FlatStyle.Flat
        courseBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        courseBtn.Image = CType(resources.GetObject("courseBtn.Image"), Image)
        courseBtn.ImageAlign = ContentAlignment.MiddleLeft
        courseBtn.Location = New Point(0, 396)
        courseBtn.Name = "courseBtn"
        courseBtn.Size = New Size(267, 52)
        courseBtn.TabIndex = 8
        courseBtn.Text = "COURSES"
        courseBtn.UseVisualStyleBackColor = False
        ' 
        ' subjectBtn
        ' 
        subjectBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        subjectBtn.Dock = DockStyle.Top
        subjectBtn.FlatAppearance.BorderSize = 0
        subjectBtn.FlatStyle = FlatStyle.Flat
        subjectBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        subjectBtn.Image = CType(resources.GetObject("subjectBtn.Image"), Image)
        subjectBtn.ImageAlign = ContentAlignment.MiddleLeft
        subjectBtn.Location = New Point(0, 344)
        subjectBtn.Name = "subjectBtn"
        subjectBtn.Size = New Size(267, 52)
        subjectBtn.TabIndex = 7
        subjectBtn.Text = "SUBJECTS"
        subjectBtn.UseVisualStyleBackColor = False
        ' 
        ' studBtn
        ' 
        studBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        studBtn.Dock = DockStyle.Top
        studBtn.FlatAppearance.BorderSize = 0
        studBtn.FlatStyle = FlatStyle.Flat
        studBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        studBtn.Image = CType(resources.GetObject("studBtn.Image"), Image)
        studBtn.ImageAlign = ContentAlignment.MiddleLeft
        studBtn.Location = New Point(0, 292)
        studBtn.Name = "studBtn"
        studBtn.Size = New Size(267, 52)
        studBtn.TabIndex = 6
        studBtn.Text = "STUDENTS"
        studBtn.UseVisualStyleBackColor = False
        ' 
        ' auditBtn
        ' 
        auditBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        auditBtn.Dock = DockStyle.Top
        auditBtn.FlatAppearance.BorderSize = 0
        auditBtn.FlatStyle = FlatStyle.Flat
        auditBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        auditBtn.Image = CType(resources.GetObject("auditBtn.Image"), Image)
        auditBtn.ImageAlign = ContentAlignment.MiddleLeft
        auditBtn.Location = New Point(0, 240)
        auditBtn.Name = "auditBtn"
        auditBtn.Size = New Size(267, 52)
        auditBtn.TabIndex = 5
        auditBtn.Text = "AUDIT-TRAIL"
        auditBtn.UseVisualStyleBackColor = False
        ' 
        ' reportsBtn
        ' 
        reportsBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        reportsBtn.Dock = DockStyle.Top
        reportsBtn.FlatAppearance.BorderSize = 0
        reportsBtn.FlatStyle = FlatStyle.Flat
        reportsBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        reportsBtn.Image = CType(resources.GetObject("reportsBtn.Image"), Image)
        reportsBtn.ImageAlign = ContentAlignment.MiddleLeft
        reportsBtn.Location = New Point(0, 188)
        reportsBtn.Name = "reportsBtn"
        reportsBtn.Size = New Size(267, 52)
        reportsBtn.TabIndex = 4
        reportsBtn.Text = "REPORTS"
        reportsBtn.UseVisualStyleBackColor = False
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
        mainPanel.BackColor = Color.White
        mainPanel.Location = New Point(273, 3)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1634, 908)
        mainPanel.TabIndex = 11
        ' 
        ' main
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1906, 923)
        Controls.Add(mainPanel)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        TransparencyKey = Color.Fuchsia
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents currentTime As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents syBtn As Button
    Friend WithEvents usersBtn As Button
    Friend WithEvents courseBtn As Button
    Friend WithEvents subjectBtn As Button
    Friend WithEvents studBtn As Button
    Friend WithEvents auditBtn As Button
    Friend WithEvents reportsBtn As Button
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents logoutBtn As Button
    Friend WithEvents mainPanel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDepartment As Button

End Class
