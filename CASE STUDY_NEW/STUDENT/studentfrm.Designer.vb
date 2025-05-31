<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentfrm))
        studentPanel = New Panel()
        Panel1 = New Panel()
        settingsBtn = New Button()
        logoutBtn = New Button()
        studentsubjectsBtn = New Button()
        studentdashboardBtn = New Button()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' studentPanel
        ' 
        studentPanel.Dock = DockStyle.Bottom
        studentPanel.Location = New Point(200, 54)
        studentPanel.Name = "studentPanel"
        studentPanel.Size = New Size(885, 611)
        studentPanel.TabIndex = 14
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        Panel1.Controls.Add(settingsBtn)
        Panel1.Controls.Add(logoutBtn)
        Panel1.Controls.Add(studentsubjectsBtn)
        Panel1.Controls.Add(studentdashboardBtn)
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 665)
        Panel1.TabIndex = 13
        ' 
        ' settingsBtn
        ' 
        settingsBtn.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        settingsBtn.Dock = DockStyle.Top
        settingsBtn.FlatAppearance.BorderSize = 0
        settingsBtn.FlatStyle = FlatStyle.Flat
        settingsBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        settingsBtn.Image = CType(resources.GetObject("settingsBtn.Image"), Image)
        settingsBtn.ImageAlign = ContentAlignment.MiddleLeft
        settingsBtn.Location = New Point(0, 206)
        settingsBtn.Name = "settingsBtn"
        settingsBtn.Size = New Size(200, 34)
        settingsBtn.TabIndex = 13
        settingsBtn.Text = "SETTINGS"
        settingsBtn.UseVisualStyleBackColor = False
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        logoutBtn.Dock = DockStyle.Bottom
        logoutBtn.FlatAppearance.BorderSize = 0
        logoutBtn.FlatStyle = FlatStyle.Flat
        logoutBtn.Location = New Point(0, 630)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(200, 35)
        logoutBtn.TabIndex = 12
        logoutBtn.Text = "LOGOUT"
        logoutBtn.UseVisualStyleBackColor = False
        ' 
        ' studentsubjectsBtn
        ' 
        studentsubjectsBtn.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        studentsubjectsBtn.Dock = DockStyle.Top
        studentsubjectsBtn.FlatAppearance.BorderSize = 0
        studentsubjectsBtn.FlatStyle = FlatStyle.Flat
        studentsubjectsBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        studentsubjectsBtn.Image = CType(resources.GetObject("studentsubjectsBtn.Image"), Image)
        studentsubjectsBtn.ImageAlign = ContentAlignment.MiddleLeft
        studentsubjectsBtn.Location = New Point(0, 171)
        studentsubjectsBtn.Name = "studentsubjectsBtn"
        studentsubjectsBtn.Size = New Size(200, 35)
        studentsubjectsBtn.TabIndex = 7
        studentsubjectsBtn.Text = "SUBJECTS"
        studentsubjectsBtn.UseVisualStyleBackColor = False
        ' 
        ' studentdashboardBtn
        ' 
        studentdashboardBtn.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        studentdashboardBtn.Dock = DockStyle.Top
        studentdashboardBtn.FlatAppearance.BorderSize = 0
        studentdashboardBtn.FlatStyle = FlatStyle.Flat
        studentdashboardBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        studentdashboardBtn.Image = CType(resources.GetObject("studentdashboardBtn.Image"), Image)
        studentdashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        studentdashboardBtn.Location = New Point(0, 136)
        studentdashboardBtn.Name = "studentdashboardBtn"
        studentdashboardBtn.Size = New Size(200, 35)
        studentdashboardBtn.TabIndex = 3
        studentdashboardBtn.Text = "DASHBOARD"
        studentdashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(PictureBox1)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 136)
        Panel4.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 134)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' studentfrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(1085, 665)
        ControlBox = False
        Controls.Add(studentPanel)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "studentfrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "studentfrm"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents studentPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents settingsBtn As Button
    Friend WithEvents logoutBtn As Button
    Friend WithEvents studentsubjectsBtn As Button
    Friend WithEvents studentdashboardBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
