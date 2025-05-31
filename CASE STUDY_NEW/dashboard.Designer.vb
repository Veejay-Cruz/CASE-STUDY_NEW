<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Label2 = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        students = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        subjects = New Label()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        courses = New Label()
        Label5 = New Label()
        PictureBox3 = New PictureBox()
        currentTime = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(62, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 38)
        Label2.TabIndex = 1
        Label2.Text = "DASHBOARD"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(students)
        Panel1.Controls.Add(Label3)
        Panel1.Font = New Font("Century Gothic", 12F)
        Panel1.Location = New Point(62, 89)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(385, 167)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(95, 167)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' students
        ' 
        students.AutoSize = True
        students.Font = New Font("Century Gothic", 24F)
        students.ForeColor = Color.White
        students.Location = New Point(156, 81)
        students.Name = "students"
        students.Size = New Size(0, 39)
        students.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(122, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 28)
        Label3.TabIndex = 1
        Label3.Text = "Students"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Navy
        Panel2.Controls.Add(subjects)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Font = New Font("Century Gothic", 12F)
        Panel2.Location = New Point(537, 89)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(385, 167)
        Panel2.TabIndex = 3
        ' 
        ' subjects
        ' 
        subjects.AutoSize = True
        subjects.Font = New Font("Century Gothic", 24F)
        subjects.ForeColor = Color.White
        subjects.Location = New Point(178, 81)
        subjects.Name = "subjects"
        subjects.Size = New Size(0, 39)
        subjects.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(112, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 28)
        Label4.TabIndex = 2
        Label4.Text = "Subjects"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Left
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(89, 167)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Navy
        Panel3.Controls.Add(courses)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Font = New Font("Century Gothic", 12F)
        Panel3.Location = New Point(1014, 89)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(385, 167)
        Panel3.TabIndex = 4
        ' 
        ' courses
        ' 
        courses.AutoSize = True
        courses.Font = New Font("Century Gothic", 24F)
        courses.ForeColor = Color.White
        courses.Location = New Point(161, 81)
        courses.Name = "courses"
        courses.Size = New Size(0, 39)
        courses.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(113, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 28)
        Label5.TabIndex = 3
        Label5.Text = "Courses"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Dock = DockStyle.Left
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(0, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(82, 167)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1453, 802)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "dashboard"
        Text = "dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents students As Label
    Friend WithEvents subjects As Label
    Friend WithEvents courses As Label
    Friend WithEvents currentTime As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
