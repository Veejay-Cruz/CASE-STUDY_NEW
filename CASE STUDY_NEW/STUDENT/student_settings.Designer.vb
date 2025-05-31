<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(student_settings))
        auditBtn = New Button()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label8 = New Label()
        TextBox7 = New TextBox()
        Label9 = New Label()
        TextBox8 = New TextBox()
        Label10 = New Label()
        TextBox9 = New TextBox()
        SuspendLayout()
        ' 
        ' auditBtn
        ' 
        auditBtn.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        auditBtn.FlatAppearance.BorderSize = 0
        auditBtn.FlatStyle = FlatStyle.Flat
        auditBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        auditBtn.Image = CType(resources.GetObject("auditBtn.Image"), Image)
        auditBtn.ImageAlign = ContentAlignment.MiddleLeft
        auditBtn.Location = New Point(124, 428)
        auditBtn.Name = "auditBtn"
        auditBtn.Size = New Size(154, 48)
        auditBtn.TabIndex = 15
        auditBtn.Text = "CHANGE PASSWORD"
        auditBtn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(124, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 14
        Label4.Text = "STUDENT ID"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(124, 202)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(165, 23)
        TextBox4.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(124, 342)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 12
        Label2.Text = "FIRST NAME"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(124, 369)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(165, 23)
        TextBox2.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(124, 251)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 10
        Label1.Text = "LAST NAME"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(124, 287)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(165, 23)
        TextBox1.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(63, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 39)
        Label3.TabIndex = 42
        Label3.Text = "SETTINGS"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(562, 428)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 15)
        Label8.TabIndex = 48
        Label8.Text = "CONFIRM PASSWORD"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(562, 455)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(165, 23)
        TextBox7.TabIndex = 47
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(562, 354)
        Label9.Name = "Label9"
        Label9.Size = New Size(97, 15)
        Label9.TabIndex = 46
        Label9.Text = "NEW PASSWORD"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(562, 381)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(165, 23)
        TextBox8.TabIndex = 45
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(562, 263)
        Label10.Name = "Label10"
        Label10.Size = New Size(122, 15)
        Label10.TabIndex = 44
        Label10.Text = "CURRENT PASSWORD"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(562, 299)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(165, 23)
        TextBox9.TabIndex = 43
        ' 
        ' student_settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(885, 611)
        Controls.Add(Label8)
        Controls.Add(TextBox7)
        Controls.Add(Label9)
        Controls.Add(TextBox8)
        Controls.Add(Label10)
        Controls.Add(TextBox9)
        Controls.Add(Label3)
        Controls.Add(auditBtn)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "student_settings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "student_settings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents auditBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox9 As TextBox
End Class
