<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class teacher_gradeentry
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
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DGVGradeEntry = New DataGridView()
        stud_id = New DataGridViewTextBoxColumn()
        lastname = New DataGridViewTextBoxColumn()
        firstname = New DataGridViewTextBoxColumn()
        middlename = New DataGridViewTextBoxColumn()
        subject = New DataGridViewTextBoxColumn()
        prelim = New DataGridViewTextBoxColumn()
        midterm = New DataGridViewTextBoxColumn()
        prefinal = New DataGridViewTextBoxColumn()
        final = New DataGridViewTextBoxColumn()
        final_grade = New DataGridViewTextBoxColumn()
        remarks = New DataGridViewTextBoxColumn()
        DGVTeachingloads = New DataGridView()
        course_code = New DataGridViewTextBoxColumn()
        sub_code = New DataGridViewTextBoxColumn()
        section = New DataGridViewTextBoxColumn()
        subload = New DataGridViewButtonColumn()
        Label8 = New Label()
        Label9 = New Label()
        Label1 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        lblstudentcounter = New Label()
        lblpassedcounter = New Label()
        lblfailedcounter = New Label()
        lblTerm = New Label()
        Label2 = New Label()
        lblSem = New Label()
        Label3 = New Label()
        lblSchoolyr = New Label()
        Label6 = New Label()
        btnSave = New Button()
        CType(DGVGradeEntry, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVTeachingloads, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGVGradeEntry
        ' 
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = Color.White
        DataGridViewCellStyle13.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle13.ForeColor = Color.Black
        DGVGradeEntry.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        DGVGradeEntry.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle14.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle14.ForeColor = Color.White
        DataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True
        DGVGradeEntry.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        DGVGradeEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVGradeEntry.Columns.AddRange(New DataGridViewColumn() {stud_id, lastname, firstname, middlename, subject, prelim, midterm, prefinal, final, final_grade, remarks})
        DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = Color.White
        DataGridViewCellStyle17.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle17.ForeColor = Color.Black
        DataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle17.SelectionForeColor = Color.White
        DataGridViewCellStyle17.WrapMode = DataGridViewTriState.True
        DGVGradeEntry.DefaultCellStyle = DataGridViewCellStyle17
        DGVGradeEntry.EnableHeadersVisualStyles = False
        DGVGradeEntry.Location = New Point(468, 134)
        DGVGradeEntry.Name = "DGVGradeEntry"
        DGVGradeEntry.RowHeadersVisible = False
        DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = Color.White
        DataGridViewCellStyle18.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle18.ForeColor = Color.Black
        DataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle18.SelectionForeColor = Color.White
        DataGridViewCellStyle18.WrapMode = DataGridViewTriState.True
        DGVGradeEntry.RowsDefaultCellStyle = DataGridViewCellStyle18
        DGVGradeEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVGradeEntry.Size = New Size(1087, 541)
        DGVGradeEntry.TabIndex = 41
        ' 
        ' stud_id
        ' 
        stud_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        stud_id.DataPropertyName = "stud_id"
        DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle15.ForeColor = Color.Black
        stud_id.DefaultCellStyle = DataGridViewCellStyle15
        stud_id.HeaderText = "STUDENT ID"
        stud_id.Name = "stud_id"
        stud_id.ReadOnly = True
        stud_id.Width = 102
        ' 
        ' lastname
        ' 
        lastname.HeaderText = "LAST NAME"
        lastname.Name = "lastname"
        lastname.ReadOnly = True
        ' 
        ' firstname
        ' 
        firstname.HeaderText = "FIRST NAME"
        firstname.Name = "firstname"
        firstname.ReadOnly = True
        ' 
        ' middlename
        ' 
        middlename.HeaderText = "MIDDLE NAME"
        middlename.Name = "middlename"
        middlename.ReadOnly = True
        ' 
        ' subject
        ' 
        subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        subject.DataPropertyName = "sub_code"
        DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle16.ForeColor = Color.Black
        subject.DefaultCellStyle = DataGridViewCellStyle16
        subject.HeaderText = "SUBJECT"
        subject.Name = "subject"
        subject.ReadOnly = True
        ' 
        ' prelim
        ' 
        prelim.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        prelim.DataPropertyName = "prelim"
        prelim.HeaderText = "PRELIM"
        prelim.Name = "prelim"
        prelim.Width = 76
        ' 
        ' midterm
        ' 
        midterm.DataPropertyName = "midterm"
        midterm.HeaderText = "MIDTERM"
        midterm.Name = "midterm"
        ' 
        ' prefinal
        ' 
        prefinal.DataPropertyName = "prefinal"
        prefinal.HeaderText = "PREFINAL"
        prefinal.Name = "prefinal"
        ' 
        ' final
        ' 
        final.DataPropertyName = "final"
        final.HeaderText = "FINALS"
        final.Name = "final"
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
        ' DGVTeachingloads
        ' 
        DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = Color.White
        DataGridViewCellStyle19.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle19.ForeColor = Color.Black
        DGVTeachingloads.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        DGVTeachingloads.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle20.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle20.ForeColor = Color.White
        DataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = DataGridViewTriState.True
        DGVTeachingloads.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        DGVTeachingloads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVTeachingloads.Columns.AddRange(New DataGridViewColumn() {course_code, sub_code, section, subload})
        DataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = Color.White
        DataGridViewCellStyle23.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle23.ForeColor = Color.Black
        DataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle23.SelectionForeColor = Color.White
        DataGridViewCellStyle23.WrapMode = DataGridViewTriState.True
        DGVTeachingloads.DefaultCellStyle = DataGridViewCellStyle23
        DGVTeachingloads.EnableHeadersVisualStyles = False
        DGVTeachingloads.Location = New Point(12, 134)
        DGVTeachingloads.Name = "DGVTeachingloads"
        DGVTeachingloads.ReadOnly = True
        DGVTeachingloads.RowHeadersVisible = False
        DataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = Color.White
        DataGridViewCellStyle24.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle24.ForeColor = Color.Black
        DataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle24.SelectionForeColor = Color.White
        DataGridViewCellStyle24.WrapMode = DataGridViewTriState.True
        DGVTeachingloads.RowsDefaultCellStyle = DataGridViewCellStyle24
        DGVTeachingloads.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVTeachingloads.Size = New Size(374, 541)
        DGVTeachingloads.TabIndex = 42
        ' 
        ' course_code
        ' 
        course_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        course_code.DataPropertyName = "course_code"
        DataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle21.ForeColor = Color.Black
        course_code.DefaultCellStyle = DataGridViewCellStyle21
        course_code.HeaderText = "COURSE"
        course_code.Name = "course_code"
        course_code.ReadOnly = True
        course_code.Width = 83
        ' 
        ' sub_code
        ' 
        sub_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        sub_code.DataPropertyName = "sub_code"
        DataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle22.ForeColor = Color.Black
        sub_code.DefaultCellStyle = DataGridViewCellStyle22
        sub_code.HeaderText = "SUBJECTS"
        sub_code.Name = "sub_code"
        sub_code.ReadOnly = True
        ' 
        ' section
        ' 
        section.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        section.DataPropertyName = "section"
        section.HeaderText = "SECTION"
        section.Name = "section"
        section.ReadOnly = True
        section.Width = 87
        ' 
        ' subload
        ' 
        subload.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        subload.HeaderText = "LOAD STUDENTS"
        subload.Name = "subload"
        subload.ReadOnly = True
        subload.Text = "APPLY"
        subload.UseColumnTextForButtonValue = True
        subload.Width = 75
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(12, 20)
        Label8.Name = "Label8"
        Label8.Size = New Size(228, 39)
        Label8.TabIndex = 43
        Label8.Text = "GRADE ENTRY"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(12, 98)
        Label9.Name = "Label9"
        Label9.Size = New Size(147, 19)
        Label9.TabIndex = 47
        Label9.Text = "TEACHING LOADS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(484, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 19)
        Label1.TabIndex = 48
        Label1.Text = "NO. OF STUDENTS"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(784, 98)
        Label10.Name = "Label10"
        Label10.Size = New Size(72, 19)
        Label10.TabIndex = 49
        Label10.Text = "PASSED:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(1020, 98)
        Label11.Name = "Label11"
        Label11.Size = New Size(66, 19)
        Label11.TabIndex = 50
        Label11.Text = "FAILED:"
        ' 
        ' lblstudentcounter
        ' 
        lblstudentcounter.AutoSize = True
        lblstudentcounter.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblstudentcounter.ForeColor = Color.Black
        lblstudentcounter.Location = New Point(631, 98)
        lblstudentcounter.Name = "lblstudentcounter"
        lblstudentcounter.Size = New Size(24, 19)
        lblstudentcounter.TabIndex = 51
        lblstudentcounter.Text = "---"
        ' 
        ' lblpassedcounter
        ' 
        lblpassedcounter.AutoSize = True
        lblpassedcounter.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblpassedcounter.ForeColor = Color.Black
        lblpassedcounter.Location = New Point(862, 98)
        lblpassedcounter.Name = "lblpassedcounter"
        lblpassedcounter.Size = New Size(24, 19)
        lblpassedcounter.TabIndex = 52
        lblpassedcounter.Text = "---"
        ' 
        ' lblfailedcounter
        ' 
        lblfailedcounter.AutoSize = True
        lblfailedcounter.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblfailedcounter.ForeColor = Color.Black
        lblfailedcounter.Location = New Point(1092, 98)
        lblfailedcounter.Name = "lblfailedcounter"
        lblfailedcounter.Size = New Size(24, 19)
        lblfailedcounter.TabIndex = 53
        lblfailedcounter.Text = "---"
        ' 
        ' lblTerm
        ' 
        lblTerm.AutoSize = True
        lblTerm.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTerm.ForeColor = Color.Black
        lblTerm.Location = New Point(1145, 20)
        lblTerm.Name = "lblTerm"
        lblTerm.Size = New Size(29, 19)
        lblTerm.TabIndex = 59
        lblTerm.Text = "----"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(1081, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 19)
        Label2.TabIndex = 58
        Label2.Text = "TERM: "
        ' 
        ' lblSem
        ' 
        lblSem.AutoSize = True
        lblSem.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSem.ForeColor = Color.Black
        lblSem.Location = New Point(1000, 20)
        lblSem.Name = "lblSem"
        lblSem.Size = New Size(29, 19)
        lblSem.TabIndex = 57
        lblSem.Text = "----"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(902, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 19)
        Label3.TabIndex = 56
        Label3.Text = "SEMESTER: "
        ' 
        ' lblSchoolyr
        ' 
        lblSchoolyr.AutoSize = True
        lblSchoolyr.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSchoolyr.ForeColor = Color.Black
        lblSchoolyr.Location = New Point(741, 20)
        lblSchoolyr.Name = "lblSchoolyr"
        lblSchoolyr.Size = New Size(29, 19)
        lblSchoolyr.TabIndex = 55
        lblSchoolyr.Text = "----"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(606, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 19)
        Label6.TabIndex = 54
        Label6.Text = "SCHOOL YEAR: "
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(1467, 98)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 60
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' teacher_gradeentry
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1567, 687)
        ControlBox = False
        Controls.Add(btnSave)
        Controls.Add(lblTerm)
        Controls.Add(Label2)
        Controls.Add(lblSem)
        Controls.Add(Label3)
        Controls.Add(lblSchoolyr)
        Controls.Add(Label6)
        Controls.Add(lblfailedcounter)
        Controls.Add(lblpassedcounter)
        Controls.Add(lblstudentcounter)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(DGVTeachingloads)
        Controls.Add(DGVGradeEntry)
        FormBorderStyle = FormBorderStyle.None
        Name = "teacher_gradeentry"
        StartPosition = FormStartPosition.CenterScreen
        Text = "teacher_gradeentry"
        CType(DGVGradeEntry, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVTeachingloads, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DGVGradeEntry As DataGridView
    Friend WithEvents DGVTeachingloads As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblstudentcounter As Label
    Friend WithEvents lblpassedcounter As Label
    Friend WithEvents lblfailedcounter As Label
    Friend WithEvents lblTerm As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSem As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSchoolyr As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents course_code As DataGridViewTextBoxColumn
    Friend WithEvents sub_code As DataGridViewTextBoxColumn
    Friend WithEvents section As DataGridViewTextBoxColumn
    Friend WithEvents subload As DataGridViewButtonColumn
    Friend WithEvents btnSave As Button
    Friend WithEvents stud_id As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents middlename As DataGridViewTextBoxColumn
    Friend WithEvents subject As DataGridViewTextBoxColumn
    Friend WithEvents prelim As DataGridViewTextBoxColumn
    Friend WithEvents midterm As DataGridViewTextBoxColumn
    Friend WithEvents prefinal As DataGridViewTextBoxColumn
    Friend WithEvents final As DataGridViewTextBoxColumn
    Friend WithEvents final_grade As DataGridViewTextBoxColumn
    Friend WithEvents remarks As DataGridViewTextBoxColumn
End Class
