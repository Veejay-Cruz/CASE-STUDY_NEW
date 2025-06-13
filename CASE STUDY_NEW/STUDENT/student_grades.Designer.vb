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
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label7 = New Label()
        lblSem = New Label()
        Label9 = New Label()
        lblSchoolYr = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
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
        section = New DataGridViewTextBoxColumn()
        prelim = New DataGridViewTextBoxColumn()
        midterm = New DataGridViewTextBoxColumn()
        prefinal = New DataGridViewTextBoxColumn()
        final = New DataGridViewTextBoxColumn()
        final_grade = New DataGridViewTextBoxColumn()
        remarks = New DataGridViewTextBoxColumn()
        lblCourse = New Label()
        lblStudentID = New Label()
        LblYearLevel = New Label()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEnrolledSubjects, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lblSem)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(lblSchoolYr)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1612, 144)
        Panel1.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(444, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(1105, 56)
        Label7.TabIndex = 56
        Label7.Text = "LYCEUM OF ALABANG GRADING KIOSK SYSTEM"
        ' 
        ' lblSem
        ' 
        lblSem.AutoSize = True
        lblSem.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSem.ForeColor = Color.White
        lblSem.Location = New Point(1195, 110)
        lblSem.Name = "lblSem"
        lblSem.Size = New Size(30, 19)
        lblSem.TabIndex = 55
        lblSem.Text = "---"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(1077, 110)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 19)
        Label9.TabIndex = 55
        Label9.Text = "SEMESTER:"
        ' 
        ' lblSchoolYr
        ' 
        lblSchoolYr.AutoSize = True
        lblSchoolYr.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSchoolYr.ForeColor = Color.White
        lblSchoolYr.Location = New Point(892, 110)
        lblSchoolYr.Name = "lblSchoolYr"
        lblSchoolYr.Size = New Size(30, 19)
        lblSchoolYr.TabIndex = 55
        lblSchoolYr.Text = "---"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(762, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 19)
        Label4.TabIndex = 54
        Label4.Text = "SCHOOL YEAR: "
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(374, 212)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 36)
        Label1.TabIndex = 1
        Label1.Text = "NAME: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(978, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 36)
        Label2.TabIndex = 2
        Label2.Text = "STUDENT ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(374, 282)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 36)
        Label3.TabIndex = 3
        Label3.Text = "COURSE:"
        ' 
        ' LblFullName
        ' 
        LblFullName.AutoSize = True
        LblFullName.Font = New Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblFullName.Location = New Point(534, 212)
        LblFullName.Name = "LblFullName"
        LblFullName.Size = New Size(45, 36)
        LblFullName.TabIndex = 4
        LblFullName.Text = "---"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1192, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 36)
        Label5.TabIndex = 5
        Label5.Text = "GRADES"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(519, 346)
        Label6.Name = "Label6"
        Label6.Size = New Size(291, 36)
        Label6.TabIndex = 6
        Label6.Text = "ENROLLED SUBJECTS"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(978, 279)
        Label8.Name = "Label8"
        Label8.Size = New Size(178, 36)
        Label8.TabIndex = 8
        Label8.Text = "YEAR LEVEL:"
        ' 
        ' printBtn
        ' 
        printBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
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
        logoutBtn.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
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
        DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = Color.White
        DataGridViewCellStyle19.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle19.ForeColor = Color.Black
        dgvEnrolledSubjects.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        dgvEnrolledSubjects.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle20.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle20.ForeColor = Color.White
        DataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = DataGridViewTriState.True
        dgvEnrolledSubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        dgvEnrolledSubjects.ColumnHeadersHeight = 47
        dgvEnrolledSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvEnrolledSubjects.Columns.AddRange(New DataGridViewColumn() {subcode, subject_name, section, prelim, midterm, prefinal, final, final_grade, remarks})
        DataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = Color.White
        DataGridViewCellStyle23.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle23.ForeColor = Color.Black
        DataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle23.SelectionForeColor = Color.White
        DataGridViewCellStyle23.WrapMode = DataGridViewTriState.True
        dgvEnrolledSubjects.DefaultCellStyle = DataGridViewCellStyle23
        dgvEnrolledSubjects.EnableHeadersVisualStyles = False
        dgvEnrolledSubjects.Location = New Point(374, 385)
        dgvEnrolledSubjects.Name = "dgvEnrolledSubjects"
        dgvEnrolledSubjects.ReadOnly = True
        dgvEnrolledSubjects.RowHeadersVisible = False
        DataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = Color.White
        DataGridViewCellStyle24.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle24.ForeColor = Color.Black
        DataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle24.SelectionForeColor = Color.White
        DataGridViewCellStyle24.WrapMode = DataGridViewTriState.True
        dgvEnrolledSubjects.RowsDefaultCellStyle = DataGridViewCellStyle24
        dgvEnrolledSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEnrolledSubjects.Size = New Size(1175, 587)
        dgvEnrolledSubjects.TabIndex = 49
        ' 
        ' subcode
        ' 
        subcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        subcode.DataPropertyName = "sub_code"
        DataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle21.ForeColor = Color.Black
        subcode.DefaultCellStyle = DataGridViewCellStyle21
        subcode.HeaderText = "SUBJECT CODE"
        subcode.Name = "subcode"
        subcode.ReadOnly = True
        subcode.Width = 115
        ' 
        ' subject_name
        ' 
        subject_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        subject_name.DataPropertyName = "subject_name"
        DataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle22.ForeColor = Color.Black
        subject_name.DefaultCellStyle = DataGridViewCellStyle22
        subject_name.HeaderText = "SUBJECT NAME"
        subject_name.Name = "subject_name"
        subject_name.ReadOnly = True
        ' 
        ' section
        ' 
        section.DataPropertyName = "section"
        section.HeaderText = "SECTION"
        section.Name = "section"
        section.ReadOnly = True
        ' 
        ' prelim
        ' 
        prelim.DataPropertyName = "prelim"
        prelim.HeaderText = "PRELIM"
        prelim.Name = "prelim"
        prelim.ReadOnly = True
        ' 
        ' midterm
        ' 
        midterm.DataPropertyName = "midterm"
        midterm.HeaderText = "MIDTERM"
        midterm.Name = "midterm"
        midterm.ReadOnly = True
        ' 
        ' prefinal
        ' 
        prefinal.DataPropertyName = "prefinal"
        prefinal.HeaderText = "PREFINAL"
        prefinal.Name = "prefinal"
        prefinal.ReadOnly = True
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
        lblCourse.Font = New Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCourse.Location = New Point(534, 282)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(45, 36)
        lblCourse.TabIndex = 51
        lblCourse.Text = "---"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Font = New Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStudentID.Location = New Point(1221, 209)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(45, 36)
        lblStudentID.TabIndex = 52
        lblStudentID.Text = "---"
        ' 
        ' LblYearLevel
        ' 
        LblYearLevel.AutoSize = True
        LblYearLevel.Font = New Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblYearLevel.Location = New Point(1221, 282)
        LblYearLevel.Name = "LblYearLevel"
        LblYearLevel.Size = New Size(45, 36)
        LblYearLevel.TabIndex = 53
        LblYearLevel.Text = "---"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' student_grades
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1612, 1080)
        Controls.Add(LblYearLevel)
        Controls.Add(lblStudentID)
        Controls.Add(lblCourse)
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
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEnrolledSubjects, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents LblYearLevel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSem As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSchoolYr As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents subcode As DataGridViewTextBoxColumn
    Friend WithEvents subject_name As DataGridViewTextBoxColumn
    Friend WithEvents section As DataGridViewTextBoxColumn
    Friend WithEvents prelim As DataGridViewTextBoxColumn
    Friend WithEvents midterm As DataGridViewTextBoxColumn
    Friend WithEvents prefinal As DataGridViewTextBoxColumn
    Friend WithEvents final As DataGridViewTextBoxColumn
    Friend WithEvents final_grade As DataGridViewTextBoxColumn
    Friend WithEvents remarks As DataGridViewTextBoxColumn
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
