<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_grades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(student_grades))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        MetroLabel1 = New ReaLTaiizor.Controls.MetroLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        LblFullName = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        printBtn = New Button()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        logoutBtn = New Button()
        dgvEnrolledSubjects = New DataGridView()
        subcode = New DataGridViewTextBoxColumn()
        subject_name = New DataGridViewTextBoxColumn()
        dgvgrades = New DataGridView()
        prelim = New DataGridViewTextBoxColumn()
        midterm = New DataGridViewTextBoxColumn()
        prefinal = New DataGridViewTextBoxColumn()
        final = New DataGridViewTextBoxColumn()
        final_grade = New DataGridViewTextBoxColumn()
        remarks = New DataGridViewTextBoxColumn()
        lblCourse = New Label()
        lblStudentID = New Label()
        LblYearLevel = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEnrolledSubjects, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvgrades, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(44, 60, 79)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(MetroLabel1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1612, 144)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(215, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(165, 144)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' MetroLabel1
        ' 
        MetroLabel1.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0)
        MetroLabel1.IsDerivedStyle = True
        MetroLabel1.Location = New Point(396, 39)
        MetroLabel1.Name = "MetroLabel1"
        MetroLabel1.Size = New Size(1374, 71)
        MetroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light
        MetroLabel1.StyleManager = Nothing
        MetroLabel1.TabIndex = 0
        MetroLabel1.Text = "LYCEUM OF ALABANG GRADING KIOSK SYSTEM"
        MetroLabel1.ThemeAuthor = "Taiizor"
        MetroLabel1.ThemeName = "MetroLight"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.Location = New Point(374, 212)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 36)
        Label1.TabIndex = 1
        Label1.Text = "NAME: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label2.Location = New Point(978, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 36)
        Label2.TabIndex = 2
        Label2.Text = "STUDENT ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label3.Location = New Point(374, 282)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 36)
        Label3.TabIndex = 3
        Label3.Text = "COURSE:"
        ' 
        ' LblFullName
        ' 
        LblFullName.AutoSize = True
        LblFullName.Font = New Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        LblFullName.Location = New Point(534, 212)
        LblFullName.Name = "LblFullName"
        LblFullName.Size = New Size(45, 36)
        LblFullName.TabIndex = 4
        LblFullName.Text = "---"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label5.Location = New Point(1192, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 36)
        Label5.TabIndex = 5
        Label5.Text = "GRADES"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label6.Location = New Point(534, 346)
        Label6.Name = "Label6"
        Label6.Size = New Size(291, 36)
        Label6.TabIndex = 6
        Label6.Text = "ENROLLED SUBJECTS"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label8.Location = New Point(978, 279)
        Label8.Name = "Label8"
        Label8.Size = New Size(178, 36)
        Label8.TabIndex = 8
        Label8.Text = "YEAR LEVEL:"
        ' 
        ' printBtn
        ' 
        printBtn.BackColor = Color.FromArgb(39, 60, 117)
        printBtn.FlatAppearance.BorderSize = 0
        printBtn.FlatStyle = FlatStyle.Flat
        printBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        printBtn.ForeColor = Color.White
        printBtn.Image = CType(resources.GetObject("printBtn.Image"), Image)
        printBtn.ImageAlign = ContentAlignment.MiddleLeft
        printBtn.Location = New Point(1349, 978)
        printBtn.Name = "printBtn"
        printBtn.Size = New Size(200, 52)
        printBtn.TabIndex = 47
        printBtn.Text = "PRINT GRADES"
        printBtn.UseVisualStyleBackColor = False
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = Color.FromArgb(39, 60, 117)
        logoutBtn.FlatAppearance.BorderSize = 0
        logoutBtn.FlatStyle = FlatStyle.Flat
        logoutBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        logoutBtn.ForeColor = Color.White
        logoutBtn.ImageAlign = ContentAlignment.MiddleLeft
        logoutBtn.Location = New Point(23, 1016)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(200, 52)
        logoutBtn.TabIndex = 48
        logoutBtn.Text = "LOG OUT"
        logoutBtn.UseVisualStyleBackColor = False
        ' 
        ' dgvEnrolledSubjects
        ' 
        dgvEnrolledSubjects.AllowUserToAddRows = False
        dgvEnrolledSubjects.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle1.ForeColor = Color.Black
        dgvEnrolledSubjects.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvEnrolledSubjects.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(44, 60, 79)
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvEnrolledSubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvEnrolledSubjects.ColumnHeadersHeight = 47
        dgvEnrolledSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvEnrolledSubjects.Columns.AddRange(New DataGridViewColumn() {subcode, subject_name})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(44, 60, 79)
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvEnrolledSubjects.DefaultCellStyle = DataGridViewCellStyle5
        dgvEnrolledSubjects.EnableHeadersVisualStyles = False
        dgvEnrolledSubjects.Location = New Point(374, 385)
        dgvEnrolledSubjects.Name = "dgvEnrolledSubjects"
        dgvEnrolledSubjects.ReadOnly = True
        dgvEnrolledSubjects.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(44, 60, 79)
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvEnrolledSubjects.RowsDefaultCellStyle = DataGridViewCellStyle6
        dgvEnrolledSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEnrolledSubjects.Size = New Size(571, 587)
        dgvEnrolledSubjects.TabIndex = 49
        ' 
        ' subcode
        ' 
        subcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        subcode.DataPropertyName = "sub_code"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        DataGridViewCellStyle3.ForeColor = Color.Black
        subcode.DefaultCellStyle = DataGridViewCellStyle3
        subcode.HeaderText = "SUBJECT CODE"
        subcode.Name = "subcode"
        subcode.ReadOnly = True
        subcode.Width = 115
        ' 
        ' subject_name
        ' 
        subject_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        subject_name.DataPropertyName = "subject_name"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        DataGridViewCellStyle4.ForeColor = Color.Black
        subject_name.DefaultCellStyle = DataGridViewCellStyle4
        subject_name.HeaderText = "SUBJECT NAME"
        subject_name.Name = "subject_name"
        subject_name.ReadOnly = True
        ' 
        ' dgvgrades
        ' 
        dgvgrades.AllowUserToAddRows = False
        dgvgrades.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle7.ForeColor = Color.Black
        dgvgrades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        dgvgrades.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.FromArgb(44, 60, 79)
        DataGridViewCellStyle8.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvgrades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvgrades.ColumnHeadersHeight = 47
        dgvgrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvgrades.Columns.AddRange(New DataGridViewColumn() {prelim, midterm, prefinal, final, final_grade, remarks})
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = Color.White
        DataGridViewCellStyle11.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle11.ForeColor = Color.Black
        DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(44, 60, 79)
        DataGridViewCellStyle11.SelectionForeColor = Color.White
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        dgvgrades.DefaultCellStyle = DataGridViewCellStyle11
        dgvgrades.EnableHeadersVisualStyles = False
        dgvgrades.Location = New Point(978, 385)
        dgvgrades.Name = "dgvgrades"
        dgvgrades.ReadOnly = True
        dgvgrades.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = Color.White
        DataGridViewCellStyle12.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle12.ForeColor = Color.Black
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(44, 60, 79)
        DataGridViewCellStyle12.SelectionForeColor = Color.White
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        dgvgrades.RowsDefaultCellStyle = DataGridViewCellStyle12
        dgvgrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvgrades.Size = New Size(571, 587)
        dgvgrades.TabIndex = 50
        ' 
        ' prelim
        ' 
        prelim.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        prelim.DataPropertyName = "prelim"
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        DataGridViewCellStyle9.ForeColor = Color.Black
        prelim.DefaultCellStyle = DataGridViewCellStyle9
        prelim.HeaderText = "PRELIM"
        prelim.Name = "prelim"
        prelim.ReadOnly = True
        prelim.Width = 76
        ' 
        ' midterm
        ' 
        midterm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        midterm.DataPropertyName = "midterm"
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        DataGridViewCellStyle10.ForeColor = Color.Black
        midterm.DefaultCellStyle = DataGridViewCellStyle10
        midterm.HeaderText = "MIDTERM"
        midterm.Name = "midterm"
        midterm.ReadOnly = True
        ' 
        ' prefinal
        ' 
        prefinal.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        prefinal.DataPropertyName = "prefinal"
        prefinal.HeaderText = "PREFINAL"
        prefinal.Name = "prefinal"
        prefinal.ReadOnly = True
        prefinal.Width = 90
        ' 
        ' final
        ' 
        final.DataPropertyName = "final"
        final.HeaderText = "FINAL"
        final.Name = "final"
        final.ReadOnly = True
        ' 
        ' final_grade
        ' 
        final_grade.DataPropertyName = "final_grade"
        final_grade.HeaderText = "FINAL GRADE"
        final_grade.Name = "final_grade"
        final_grade.ReadOnly = True
        ' 
        ' remarks
        ' 
        remarks.DataPropertyName = "remarks"
        remarks.HeaderText = "REMARKS"
        remarks.Name = "remarks"
        remarks.ReadOnly = True
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblCourse.Location = New Point(534, 282)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(45, 36)
        lblCourse.TabIndex = 51
        lblCourse.Text = "---"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Font = New Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblStudentID.Location = New Point(1221, 209)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(45, 36)
        lblStudentID.TabIndex = 52
        lblStudentID.Text = "---"
        ' 
        ' LblYearLevel
        ' 
        LblYearLevel.AutoSize = True
        LblYearLevel.Font = New Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        LblYearLevel.Location = New Point(1221, 282)
        LblYearLevel.Name = "LblYearLevel"
        LblYearLevel.Size = New Size(45, 36)
        LblYearLevel.TabIndex = 53
        LblYearLevel.Text = "---"
        ' 
        ' student_grades
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1612, 1080)
        Controls.Add(LblYearLevel)
        Controls.Add(lblStudentID)
        Controls.Add(lblCourse)
        Controls.Add(dgvgrades)
        Controls.Add(dgvEnrolledSubjects)
        Controls.Add(logoutBtn)
        Controls.Add(printBtn)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(LblFullName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "student_grades"
        StartPosition = FormStartPosition.CenterScreen
        Text = "student_grades"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEnrolledSubjects, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvgrades, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel1 As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblFullName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents printBtn As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents logoutBtn As Button
    Friend WithEvents dgvEnrolledSubjects As DataGridView
    Friend WithEvents dgvgrades As DataGridView
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents LblYearLevel As Label
    Friend WithEvents subcode As DataGridViewTextBoxColumn
    Friend WithEvents subject_name As DataGridViewTextBoxColumn
    Friend WithEvents prelim As DataGridViewTextBoxColumn
    Friend WithEvents midterm As DataGridViewTextBoxColumn
    Friend WithEvents prefinal As DataGridViewTextBoxColumn
    Friend WithEvents final As DataGridViewTextBoxColumn
    Friend WithEvents final_grade As DataGridViewTextBoxColumn
    Friend WithEvents remarks As DataGridViewTextBoxColumn
End Class
