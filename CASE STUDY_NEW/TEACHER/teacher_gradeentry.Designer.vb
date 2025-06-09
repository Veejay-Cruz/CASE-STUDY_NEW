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
        DGVGradeEntry = New DataGridView()
        stud_id = New DataGridViewTextBoxColumn()
        subject = New DataGridViewTextBoxColumn()
        prelim = New DataGridViewTextBoxColumn()
        midterm = New DataGridViewTextBoxColumn()
        prefinal = New DataGridViewTextBoxColumn()
        final = New DataGridViewTextBoxColumn()
        finalgrade = New DataGridViewTextBoxColumn()
        remarks = New DataGridViewTextBoxColumn()
        DGVTeachingloads = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        Label8 = New Label()
        Label9 = New Label()
        Label1 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        lblTerm = New Label()
        Label2 = New Label()
        lblSem = New Label()
        Label3 = New Label()
        lblSchoolyr = New Label()
        Label6 = New Label()
        CType(DGVGradeEntry, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVTeachingloads, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGVGradeEntry
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DGVGradeEntry.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGVGradeEntry.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGVGradeEntry.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGVGradeEntry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVGradeEntry.Columns.AddRange(New DataGridViewColumn() {stud_id, subject, prelim, midterm, prefinal, final, finalgrade, remarks})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DGVGradeEntry.DefaultCellStyle = DataGridViewCellStyle5
        DGVGradeEntry.EnableHeadersVisualStyles = False
        DGVGradeEntry.Location = New Point(372, 134)
        DGVGradeEntry.Name = "DGVGradeEntry"
        DGVGradeEntry.ReadOnly = True
        DGVGradeEntry.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DGVGradeEntry.RowsDefaultCellStyle = DataGridViewCellStyle6
        DGVGradeEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVGradeEntry.Size = New Size(797, 541)
        DGVGradeEntry.TabIndex = 41
        ' 
        ' stud_id
        ' 
        stud_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        stud_id.DataPropertyName = "stud_id"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        stud_id.DefaultCellStyle = DataGridViewCellStyle3
        stud_id.HeaderText = "STUDENT ID"
        stud_id.Name = "stud_id"
        stud_id.ReadOnly = True
        stud_id.Width = 102
        ' 
        ' subject
        ' 
        subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        subject.DefaultCellStyle = DataGridViewCellStyle4
        subject.HeaderText = "SUBJECT"
        subject.Name = "subject"
        subject.ReadOnly = True
        ' 
        ' prelim
        ' 
        prelim.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        prelim.HeaderText = "PRELIM"
        prelim.Name = "prelim"
        prelim.ReadOnly = True
        prelim.Width = 76
        ' 
        ' midterm
        ' 
        midterm.HeaderText = "MIDTERM"
        midterm.Name = "midterm"
        midterm.ReadOnly = True
        ' 
        ' prefinal
        ' 
        prefinal.HeaderText = "PREFINAL"
        prefinal.Name = "prefinal"
        prefinal.ReadOnly = True
        ' 
        ' final
        ' 
        final.HeaderText = "FINALS"
        final.Name = "final"
        final.ReadOnly = True
        ' 
        ' finalgrade
        ' 
        finalgrade.HeaderText = "FINAL GRADE"
        finalgrade.Name = "finalgrade"
        finalgrade.ReadOnly = True
        ' 
        ' remarks
        ' 
        remarks.HeaderText = "REMARKS"
        remarks.Name = "remarks"
        remarks.ReadOnly = True
        ' 
        ' DGVTeachingloads
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DGVTeachingloads.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DGVTeachingloads.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle8.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DGVTeachingloads.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        DGVTeachingloads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVTeachingloads.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3})
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = Color.White
        DataGridViewCellStyle11.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle11.ForeColor = Color.Black
        DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle11.SelectionForeColor = Color.White
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        DGVTeachingloads.DefaultCellStyle = DataGridViewCellStyle11
        DGVTeachingloads.EnableHeadersVisualStyles = False
        DGVTeachingloads.Location = New Point(12, 134)
        DGVTeachingloads.Name = "DGVTeachingloads"
        DGVTeachingloads.ReadOnly = True
        DGVTeachingloads.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = Color.White
        DataGridViewCellStyle12.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle12.ForeColor = Color.Black
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle12.SelectionForeColor = Color.White
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DGVTeachingloads.RowsDefaultCellStyle = DataGridViewCellStyle12
        DGVTeachingloads.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVTeachingloads.Size = New Size(275, 541)
        DGVTeachingloads.TabIndex = 42
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewTextBoxColumn1.DataPropertyName = "course_code"
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.Black
        DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
        DataGridViewTextBoxColumn1.HeaderText = "COURSE"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 83
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn2.DataPropertyName = "sub_code"
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = Color.Black
        DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle10
        DataGridViewTextBoxColumn2.HeaderText = "SUBJECTS"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewTextBoxColumn3.DataPropertyName = "section"
        DataGridViewTextBoxColumn3.HeaderText = "SECTION"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Width = 87
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
        Label1.Location = New Point(372, 98)
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
        Label10.Location = New Point(672, 98)
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
        Label11.Location = New Point(908, 98)
        Label11.Name = "Label11"
        Label11.Size = New Size(66, 19)
        Label11.TabIndex = 50
        Label11.Text = "FAILED:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(519, 98)
        Label12.Name = "Label12"
        Label12.Size = New Size(24, 19)
        Label12.TabIndex = 51
        Label12.Text = "---"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(750, 98)
        Label13.Name = "Label13"
        Label13.Size = New Size(24, 19)
        Label13.TabIndex = 52
        Label13.Text = "---"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(980, 98)
        Label14.Name = "Label14"
        Label14.Size = New Size(24, 19)
        Label14.TabIndex = 53
        Label14.Text = "---"
        ' 
        ' lblTerm
        ' 
        lblTerm.AutoSize = True
        lblTerm.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTerm.ForeColor = Color.Black
        lblTerm.Location = New Point(1033, 20)
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
        Label2.Location = New Point(969, 20)
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
        lblSem.Location = New Point(888, 20)
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
        Label3.Location = New Point(790, 20)
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
        lblSchoolyr.Location = New Point(629, 20)
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
        Label6.Location = New Point(494, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 19)
        Label6.TabIndex = 54
        Label6.Text = "SCHOOL YEAR: "
        ' 
        ' teacher_gradeentry
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1181, 687)
        ControlBox = False
        Controls.Add(lblTerm)
        Controls.Add(Label2)
        Controls.Add(lblSem)
        Controls.Add(Label3)
        Controls.Add(lblSchoolyr)
        Controls.Add(Label6)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents stud_id As DataGridViewTextBoxColumn
    Friend WithEvents subject As DataGridViewTextBoxColumn
    Friend WithEvents prelim As DataGridViewTextBoxColumn
    Friend WithEvents midterm As DataGridViewTextBoxColumn
    Friend WithEvents prefinal As DataGridViewTextBoxColumn
    Friend WithEvents final As DataGridViewTextBoxColumn
    Friend WithEvents finalgrade As DataGridViewTextBoxColumn
    Friend WithEvents remarks As DataGridViewTextBoxColumn
    Friend WithEvents lblTerm As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSem As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSchoolyr As Label
    Friend WithEvents Label6 As Label
End Class
