<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class teacher_settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(teacher_settings))
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        auditBtn = New Button()
        Label8 = New Label()
        TextBox7 = New TextBox()
        Label9 = New Label()
        TextBox8 = New TextBox()
        Label10 = New Label()
        TextBox9 = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(142, 275)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(165, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(142, 239)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 1
        Label1.Text = "LAST NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(142, 330)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 3
        Label2.Text = "FULL NAME"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(142, 357)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(165, 23)
        TextBox2.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(142, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 7
        Label4.Text = "TEACHER ID"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(142, 190)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(165, 23)
        TextBox4.TabIndex = 6
        ' 
        ' auditBtn
        ' 
        auditBtn.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        auditBtn.FlatAppearance.BorderSize = 0
        auditBtn.FlatStyle = FlatStyle.Flat
        auditBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        auditBtn.Image = CType(resources.GetObject("auditBtn.Image"), Image)
        auditBtn.ImageAlign = ContentAlignment.MiddleLeft
        auditBtn.Location = New Point(142, 416)
        auditBtn.Name = "auditBtn"
        auditBtn.Size = New Size(154, 48)
        auditBtn.TabIndex = 8
        auditBtn.Text = "CHANGE PASSWORD"
        auditBtn.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(577, 437)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 15)
        Label8.TabIndex = 46
        Label8.Text = "CONFIRM PASSWORD"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(577, 464)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(165, 23)
        TextBox7.TabIndex = 45
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(577, 363)
        Label9.Name = "Label9"
        Label9.Size = New Size(97, 15)
        Label9.TabIndex = 44
        Label9.Text = "NEW PASSWORD"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(577, 390)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(165, 23)
        TextBox8.TabIndex = 43
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(577, 272)
        Label10.Name = "Label10"
        Label10.Size = New Size(122, 15)
        Label10.TabIndex = 42
        Label10.Text = "CURRENT PASSWORD"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(577, 308)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(165, 23)
        TextBox9.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(70, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 39)
        Label3.TabIndex = 47
        Label3.Text = "SETTINGS"
        ' 
        ' teacher_settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(885, 611)
        ControlBox = False
        Controls.Add(Label3)
        Controls.Add(Label8)
        Controls.Add(TextBox7)
        Controls.Add(Label9)
        Controls.Add(TextBox8)
        Controls.Add(Label10)
        Controls.Add(TextBox9)
        Controls.Add(auditBtn)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "teacher_settings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "teacher_settings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents auditBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label3 As Label
End Class
