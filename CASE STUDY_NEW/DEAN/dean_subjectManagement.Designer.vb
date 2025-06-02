<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dean_subjectManagement
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DGVDepartment = New DataGridView()
        Label1 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        DGVSection = New DataGridView()
        teach_id = New DataGridViewTextBoxColumn()
        lname = New DataGridViewTextBoxColumn()
        fname = New DataGridViewTextBoxColumn()
        apply = New DataGridViewButtonColumn()
        Label3 = New Label()
        Label4 = New Label()
        createPnl2 = New Panel()
        Label7 = New Label()
        btnCancel = New ReaLTaiizor.Controls.ForeverButton()
        btnSave = New ReaLTaiizor.Controls.ForeverButton()
        cboSubject = New ComboBox()
        Label5 = New Label()
        txtProfname = New TextBox()
        Label6 = New Label()
        Label9 = New Label()
        cboSection = New ComboBox()
        course_code = New DataGridViewTextBoxColumn()
        teacher_id = New DataGridViewTextBoxColumn()
        teachername = New DataGridViewTextBoxColumn()
        section = New DataGridViewTextBoxColumn()
        yearlevel = New DataGridViewTextBoxColumn()
        semester = New DataGridViewTextBoxColumn()
        CType(DGVDepartment, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVSection, ComponentModel.ISupportInitialize).BeginInit()
        createPnl2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGVDepartment
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DGVDepartment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGVDepartment.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGVDepartment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGVDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVDepartment.Columns.AddRange(New DataGridViewColumn() {teach_id, lname, fname, apply})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DGVDepartment.DefaultCellStyle = DataGridViewCellStyle5
        DGVDepartment.EnableHeadersVisualStyles = False
        DGVDepartment.Location = New Point(12, 202)
        DGVDepartment.Name = "DGVDepartment"
        DGVDepartment.ReadOnly = True
        DGVDepartment.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DGVDepartment.RowsDefaultCellStyle = DataGridViewCellStyle6
        DGVDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVDepartment.Size = New Size(634, 460)
        DGVDepartment.TabIndex = 40
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(28, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(379, 39)
        Label1.TabIndex = 41
        Label1.Text = "SUBJECT MANAGEMENT"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(735, 156)
        Label8.Name = "Label8"
        Label8.Size = New Size(221, 19)
        Label8.TabIndex = 47
        Label8.Text = "LOAD SECTION NG STUDENT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(144, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(316, 19)
        Label2.TabIndex = 48
        Label2.Text = "LOAD TEACHER BASED ON DEPARTMENT"
        ' 
        ' DGVSection
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DGVSection.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DGVSection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVSection.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DGVSection.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle8.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DGVSection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        DGVSection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVSection.Columns.AddRange(New DataGridViewColumn() {course_code, teacher_id, teachername, section, yearlevel, semester})
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = Color.White
        DataGridViewCellStyle11.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle11.ForeColor = Color.Black
        DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle11.SelectionForeColor = Color.White
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        DGVSection.DefaultCellStyle = DataGridViewCellStyle11
        DGVSection.EnableHeadersVisualStyles = False
        DGVSection.Location = New Point(735, 202)
        DGVSection.Name = "DGVSection"
        DGVSection.ReadOnly = True
        DGVSection.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = Color.White
        DataGridViewCellStyle12.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle12.ForeColor = Color.Black
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle12.SelectionForeColor = Color.White
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DGVSection.RowsDefaultCellStyle = DataGridViewCellStyle12
        DGVSection.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVSection.Size = New Size(634, 479)
        DGVSection.TabIndex = 49
        ' 
        ' teach_id
        ' 
        teach_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        teach_id.DefaultCellStyle = DataGridViewCellStyle3
        teach_id.HeaderText = "TEACHER ID"
        teach_id.Name = "teach_id"
        teach_id.ReadOnly = True
        teach_id.Width = 106
        ' 
        ' lname
        ' 
        lname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        lname.DefaultCellStyle = DataGridViewCellStyle4
        lname.HeaderText = "LAST NAME"
        lname.Name = "lname"
        lname.ReadOnly = True
        ' 
        ' fname
        ' 
        fname.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        fname.HeaderText = "FIRST NAME"
        fname.Name = "fname"
        fname.ReadOnly = True
        fname.Width = 106
        ' 
        ' apply
        ' 
        apply.HeaderText = "APPLY TEACHER"
        apply.Name = "apply"
        apply.ReadOnly = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(463, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(235, 19)
        Label3.TabIndex = 50
        Label3.Text = "APPLY TEACHER TO A SUBJECT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(463, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(239, 19)
        Label4.TabIndex = 51
        Label4.Text = "APPLY TEACHER TO A SECTION"
        ' 
        ' createPnl2
        ' 
        createPnl2.BackColor = Color.MidnightBlue
        createPnl2.Controls.Add(cboSection)
        createPnl2.Controls.Add(Label9)
        createPnl2.Controls.Add(Label6)
        createPnl2.Controls.Add(txtProfname)
        createPnl2.Controls.Add(Label5)
        createPnl2.Controls.Add(Label7)
        createPnl2.Controls.Add(btnCancel)
        createPnl2.Controls.Add(btnSave)
        createPnl2.Controls.Add(cboSubject)
        createPnl2.Location = New Point(364, 295)
        createPnl2.Name = "createPnl2"
        createPnl2.Size = New Size(493, 303)
        createPnl2.TabIndex = 52
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MidnightBlue
        Label7.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(154, 31)
        Label7.Name = "Label7"
        Label7.Size = New Size(211, 25)
        Label7.TabIndex = 15
        Label7.Text = "ASSIGN PROFESSOR"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Transparent
        btnCancel.BaseColor = Color.IndianRed
        btnCancel.Font = New Font("Segoe UI", 12F)
        btnCancel.Location = New Point(302, 243)
        btnCancel.Name = "btnCancel"
        btnCancel.Rounded = False
        btnCancel.Size = New Size(115, 42)
        btnCancel.TabIndex = 11
        btnCancel.Text = "CANCEL"
        btnCancel.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Transparent
        btnSave.BaseColor = Color.FromArgb(CByte(35), CByte(168), CByte(109))
        btnSave.Font = New Font("Segoe UI", 12F)
        btnSave.Location = New Point(181, 243)
        btnSave.Name = "btnSave"
        btnSave.Rounded = False
        btnSave.Size = New Size(115, 42)
        btnSave.TabIndex = 10
        btnSave.Text = "SAVE"
        btnSave.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' cboSubject
        ' 
        cboSubject.FormattingEnabled = True
        cboSubject.Location = New Point(141, 147)
        cboSubject.Name = "cboSubject"
        cboSubject.Size = New Size(297, 23)
        cboSubject.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(20, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 19)
        Label5.TabIndex = 53
        Label5.Text = "PROFESSOR"
        ' 
        ' txtProfname
        ' 
        txtProfname.Location = New Point(141, 79)
        txtProfname.Name = "txtProfname"
        txtProfname.ReadOnly = True
        txtProfname.Size = New Size(297, 23)
        txtProfname.TabIndex = 54
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(20, 147)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 19)
        Label6.TabIndex = 55
        Label6.Text = "SUBJECT"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(25, 203)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 19)
        Label9.TabIndex = 56
        Label9.Text = "SECTION"
        ' 
        ' cboSection
        ' 
        cboSection.DropDownStyle = ComboBoxStyle.DropDownList
        cboSection.FormattingEnabled = True
        cboSection.Location = New Point(141, 204)
        cboSection.Name = "cboSection"
        cboSection.Size = New Size(297, 23)
        cboSection.TabIndex = 57
        ' 
        ' course_code
        ' 
        course_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        course_code.DataPropertyName = "course_code"
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.Black
        course_code.DefaultCellStyle = DataGridViewCellStyle9
        course_code.HeaderText = "COURSE"
        course_code.Name = "course_code"
        course_code.ReadOnly = True
        course_code.Width = 83
        ' 
        ' teacher_id
        ' 
        teacher_id.DataPropertyName = "teacher_id"
        teacher_id.HeaderText = "PROFESSOR ID"
        teacher_id.Name = "teacher_id"
        teacher_id.ReadOnly = True
        ' 
        ' teachername
        ' 
        teachername.HeaderText = "PROFESSOR NAME"
        teachername.Name = "teachername"
        teachername.ReadOnly = True
        ' 
        ' section
        ' 
        section.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        section.DataPropertyName = "section"
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = Color.Black
        section.DefaultCellStyle = DataGridViewCellStyle10
        section.HeaderText = "SECTION"
        section.Name = "section"
        section.ReadOnly = True
        section.Width = 87
        ' 
        ' yearlevel
        ' 
        yearlevel.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        yearlevel.DataPropertyName = "yearlevel"
        yearlevel.HeaderText = "YEAR LEVEL"
        yearlevel.Name = "yearlevel"
        yearlevel.ReadOnly = True
        yearlevel.Width = 104
        ' 
        ' semester
        ' 
        semester.DataPropertyName = "semester"
        semester.HeaderText = "SEMESTER"
        semester.Name = "semester"
        semester.ReadOnly = True
        ' 
        ' dean_subjectManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1381, 674)
        Controls.Add(createPnl2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DGVSection)
        Controls.Add(Label2)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Controls.Add(DGVDepartment)
        FormBorderStyle = FormBorderStyle.None
        Name = "dean_subjectManagement"
        Text = "dean_subjectManagement"
        CType(DGVDepartment, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVSection, ComponentModel.ISupportInitialize).EndInit()
        createPnl2.ResumeLayout(False)
        createPnl2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGVDepartment As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVSection As DataGridView
    Friend WithEvents teach_id As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents apply As DataGridViewButtonColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents createPnl2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents btnSave As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents cboSubject As ComboBox
    Friend WithEvents txtProfname As TextBox
    Friend WithEvents cboSection As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents course_code As DataGridViewTextBoxColumn
    Friend WithEvents teacher_id As DataGridViewTextBoxColumn
    Friend WithEvents teachername As DataGridViewTextBoxColumn
    Friend WithEvents section As DataGridViewTextBoxColumn
    Friend WithEvents yearlevel As DataGridViewTextBoxColumn
    Friend WithEvents semester As DataGridViewTextBoxColumn
End Class
