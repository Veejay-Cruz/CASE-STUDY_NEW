<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        SkyLabel1 = New ReaLTaiizor.Controls.SkyLabel()
        SkyLabel2 = New ReaLTaiizor.Controls.SkyLabel()
        MetroLabel1 = New ReaLTaiizor.Controls.MetroLabel()
        loginBtn = New ReaLTaiizor.Controls.Button()
        Button2 = New ReaLTaiizor.Controls.Button()
        PictureBox1 = New PictureBox()
        usernameTxt = New ReaLTaiizor.Controls.BigTextBox()
        passwordTxt = New ReaLTaiizor.Controls.BigTextBox()
        Timer1 = New Timer(components)
        usernameLbl = New ReaLTaiizor.Controls.MetroLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SkyLabel1
        ' 
        SkyLabel1.AutoSize = True
        SkyLabel1.Font = New Font("Verdana", 6.75F, FontStyle.Bold)
        SkyLabel1.ForeColor = Color.FromArgb(CByte(27), CByte(94), CByte(137))
        SkyLabel1.Location = New Point(324, 282)
        SkyLabel1.Name = "SkyLabel1"
        SkyLabel1.Size = New Size(17, 12)
        SkyLabel1.TabIndex = 6
        SkyLabel1.Text = "ID"
        ' 
        ' SkyLabel2
        ' 
        SkyLabel2.AutoSize = True
        SkyLabel2.Font = New Font("Verdana", 6.75F, FontStyle.Bold)
        SkyLabel2.ForeColor = Color.FromArgb(CByte(27), CByte(94), CByte(137))
        SkyLabel2.Location = New Point(324, 365)
        SkyLabel2.Name = "SkyLabel2"
        SkyLabel2.Size = New Size(65, 12)
        SkyLabel2.TabIndex = 7
        SkyLabel2.Text = "PASSWORD"
        ' 
        ' MetroLabel1
        ' 
        MetroLabel1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MetroLabel1.IsDerivedStyle = True
        MetroLabel1.Location = New Point(229, 20)
        MetroLabel1.Name = "MetroLabel1"
        MetroLabel1.Size = New Size(596, 35)
        MetroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light
        MetroLabel1.StyleManager = Nothing
        MetroLabel1.TabIndex = 9
        MetroLabel1.Text = "LYCEUM OF ALABANG GRADING SYSTEM"
        MetroLabel1.ThemeAuthor = "Taiizor"
        MetroLabel1.ThemeName = "MetroLight"
        ' 
        ' loginBtn
        ' 
        loginBtn.BackColor = Color.Transparent
        loginBtn.BorderColor = Color.Empty
        loginBtn.EnteredBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        loginBtn.EnteredColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        loginBtn.Font = New Font("Microsoft Sans Serif", 12F)
        loginBtn.Image = Nothing
        loginBtn.ImageAlign = ContentAlignment.MiddleLeft
        loginBtn.InactiveColor = Color.FromArgb(CByte(0), CByte(100), CByte(255))
        loginBtn.Location = New Point(314, 460)
        loginBtn.Name = "loginBtn"
        loginBtn.PressedBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        loginBtn.PressedColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        loginBtn.Size = New Size(192, 40)
        loginBtn.TabIndex = 10
        loginBtn.Text = "LOGIN"
        loginBtn.TextAlignment = StringAlignment.Center
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BorderColor = Color.Empty
        Button2.EnteredBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        Button2.EnteredColor = Color.FromArgb(CByte(32), CByte(34), CByte(37))
        Button2.Font = New Font("Microsoft Sans Serif", 12F)
        Button2.Image = Nothing
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.InactiveColor = Color.FromArgb(CByte(245), CByte(124), CByte(115))
        Button2.Location = New Point(512, 460)
        Button2.Name = "Button2"
        Button2.PressedBorderColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        Button2.PressedColor = Color.FromArgb(CByte(165), CByte(37), CByte(37))
        Button2.Size = New Size(174, 40)
        Button2.TabIndex = 11
        Button2.Text = "CANCEL"
        Button2.TextAlignment = StringAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-10, 67)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1030, 560)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' usernameTxt
        ' 
        usernameTxt.BackColor = Color.Transparent
        usernameTxt.Font = New Font("Arial", 11.25F, FontStyle.Italic)
        usernameTxt.ForeColor = Color.DimGray
        usernameTxt.Image = Nothing
        usernameTxt.Location = New Point(314, 297)
        usernameTxt.MaxLength = 32767
        usernameTxt.Multiline = False
        usernameTxt.Name = "usernameTxt"
        usernameTxt.ReadOnly = False
        usernameTxt.Size = New Size(372, 41)
        usernameTxt.TabIndex = 13
        usernameTxt.TextAlignment = HorizontalAlignment.Left
        usernameTxt.UseSystemPasswordChar = False
        ' 
        ' passwordTxt
        ' 
        passwordTxt.BackColor = Color.Transparent
        passwordTxt.Font = New Font("Arial", 11.25F, FontStyle.Italic)
        passwordTxt.ForeColor = Color.DimGray
        passwordTxt.Image = Nothing
        passwordTxt.Location = New Point(314, 380)
        passwordTxt.MaxLength = 32767
        passwordTxt.Multiline = False
        passwordTxt.Name = "passwordTxt"
        passwordTxt.ReadOnly = False
        passwordTxt.Size = New Size(372, 41)
        passwordTxt.TabIndex = 14
        passwordTxt.TextAlignment = HorizontalAlignment.Left
        passwordTxt.UseSystemPasswordChar = True
        ' 
        ' usernameLbl
        ' 
        usernameLbl.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        usernameLbl.IsDerivedStyle = True
        usernameLbl.Location = New Point(863, 109)
        usernameLbl.Name = "usernameLbl"
        usernameLbl.Size = New Size(99, 23)
        usernameLbl.Style = ReaLTaiizor.Enum.Metro.Style.Light
        usernameLbl.StyleManager = Nothing
        usernameLbl.TabIndex = 15
        usernameLbl.ThemeAuthor = "Taiizor"
        usernameLbl.ThemeName = "MetroLight"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1014, 617)
        Controls.Add(usernameLbl)
        Controls.Add(passwordTxt)
        Controls.Add(usernameTxt)
        Controls.Add(Button2)
        Controls.Add(loginBtn)
        Controls.Add(MetroLabel1)
        Controls.Add(SkyLabel2)
        Controls.Add(SkyLabel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents SkyLabel1 As ReaLTaiizor.Controls.SkyLabel
    Friend WithEvents SkyLabel2 As ReaLTaiizor.Controls.SkyLabel
    Friend WithEvents MetroLabel1 As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents loginBtn As ReaLTaiizor.Controls.Button
    Friend WithEvents Button2 As ReaLTaiizor.Controls.Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usernameTxt As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents passwordTxt As ReaLTaiizor.Controls.BigTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents usernameLbl As ReaLTaiizor.Controls.MetroLabel
End Class
