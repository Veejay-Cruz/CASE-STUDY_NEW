<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dean_courseManagement
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
        Label1 = New Label()
        Label2 = New Label()
        txtSearchStudent = New TextBox()
        Label3 = New Label()
        txtStudname = New TextBox()
        txtCourse = New TextBox()
        Label4 = New Label()
        txtYearlvl = New TextBox()
        Label5 = New Label()
        btnApplySub = New Button()
        Label8 = New Label()
        txtStudentStatus = New TextBox()
        lblSchoolyr = New Label()
        Label9 = New Label()
        lblSem = New Label()
        Label12 = New Label()
        btnConfirm = New Button()
        btnConfirmSub = New Button()
        DGVSubject = New DataGridView()
        sub_id = New DataGridViewTextBoxColumn()
        sub_code = New DataGridViewTextBoxColumn()
        sub_name = New DataGridViewTextBoxColumn()
        unitt = New DataGridViewTextBoxColumn()
        prereqq = New DataGridViewTextBoxColumn()
        DGVStudentSubjects = New DataGridView()
        ssub_id = New DataGridViewTextBoxColumn()
        ssub_code = New DataGridViewTextBoxColumn()
        ssub_name = New DataGridViewTextBoxColumn()
        unit = New DataGridViewTextBoxColumn()
        sectionn = New DataGridViewTextBoxColumn()
        cboSection = New ComboBox()
        createPnl2 = New Panel()
        Label7 = New Label()
        btnCancel = New ReaLTaiizor.Controls.ForeverButton()
        btnSave = New ReaLTaiizor.Controls.ForeverButton()
        CType(DGVSubject, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVStudentSubjects, ComponentModel.ISupportInitialize).BeginInit()
        createPnl2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(305, 39)
        Label1.TabIndex = 5
        Label1.Text = "EVALUATE COURSE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 8
        Label2.Text = "Student Name:"
        ' 
        ' txtSearchStudent
        ' 
        txtSearchStudent.Location = New Point(110, 92)
        txtSearchStudent.Name = "txtSearchStudent"
        txtSearchStudent.Size = New Size(238, 23)
        txtSearchStudent.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 10
        Label3.Text = "Student No:"
        ' 
        ' txtStudname
        ' 
        txtStudname.Location = New Point(110, 140)
        txtStudname.Name = "txtStudname"
        txtStudname.ReadOnly = True
        txtStudname.Size = New Size(337, 23)
        txtStudname.TabIndex = 11
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(721, 143)
        txtCourse.Name = "txtCourse"
        txtCourse.ReadOnly = True
        txtCourse.Size = New Size(78, 23)
        txtCourse.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(647, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 12
        Label4.Text = "Course:"
        ' 
        ' txtYearlvl
        ' 
        txtYearlvl.Location = New Point(918, 92)
        txtYearlvl.Name = "txtYearlvl"
        txtYearlvl.ReadOnly = True
        txtYearlvl.Size = New Size(78, 23)
        txtYearlvl.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(850, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 15)
        Label5.TabIndex = 20
        Label5.Text = "Year Level:"
        ' 
        ' btnApplySub
        ' 
        btnApplySub.Location = New Point(590, 423)
        btnApplySub.Name = "btnApplySub"
        btnApplySub.Size = New Size(17, 23)
        btnApplySub.TabIndex = 24
        btnApplySub.Text = ">"
        btnApplySub.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(647, 92)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 15)
        Label8.TabIndex = 25
        Label8.Text = "Status:"
        ' 
        ' txtStudentStatus
        ' 
        txtStudentStatus.Location = New Point(721, 87)
        txtStudentStatus.Name = "txtStudentStatus"
        txtStudentStatus.ReadOnly = True
        txtStudentStatus.Size = New Size(78, 23)
        txtStudentStatus.TabIndex = 26
        ' 
        ' lblSchoolyr
        ' 
        lblSchoolyr.AutoSize = True
        lblSchoolyr.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSchoolyr.ForeColor = Color.Black
        lblSchoolyr.Location = New Point(599, 26)
        lblSchoolyr.Name = "lblSchoolyr"
        lblSchoolyr.Size = New Size(29, 19)
        lblSchoolyr.TabIndex = 28
        lblSchoolyr.Text = "----"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(464, 26)
        Label9.Name = "Label9"
        Label9.Size = New Size(129, 19)
        Label9.TabIndex = 27
        Label9.Text = "SCHOOL YEAR: "
        ' 
        ' lblSem
        ' 
        lblSem.AutoSize = True
        lblSem.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSem.ForeColor = Color.Black
        lblSem.Location = New Point(832, 26)
        lblSem.Name = "lblSem"
        lblSem.Size = New Size(29, 19)
        lblSem.TabIndex = 30
        lblSem.Text = "----"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(734, 26)
        Label12.Name = "Label12"
        Label12.Size = New Size(92, 19)
        Label12.TabIndex = 29
        Label12.Text = "SEMESTER: "
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Location = New Point(372, 92)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(75, 23)
        btnConfirm.TabIndex = 31
        btnConfirm.Text = "Apply"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnConfirmSub
        ' 
        btnConfirmSub.Location = New Point(1051, 211)
        btnConfirmSub.Name = "btnConfirmSub"
        btnConfirmSub.Size = New Size(75, 23)
        btnConfirmSub.TabIndex = 32
        btnConfirmSub.Text = "Confirm"
        btnConfirmSub.UseVisualStyleBackColor = True
        ' 
        ' DGVSubject
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DGVSubject.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGVSubject.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGVSubject.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGVSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVSubject.Columns.AddRange(New DataGridViewColumn() {sub_id, sub_code, sub_name, unitt, prereqq})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DGVSubject.DefaultCellStyle = DataGridViewCellStyle5
        DGVSubject.EnableHeadersVisualStyles = False
        DGVSubject.Location = New Point(11, 239)
        DGVSubject.Name = "DGVSubject"
        DGVSubject.ReadOnly = True
        DGVSubject.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DGVSubject.RowsDefaultCellStyle = DataGridViewCellStyle6
        DGVSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVSubject.Size = New Size(559, 460)
        DGVSubject.TabIndex = 40
        ' 
        ' sub_id
        ' 
        sub_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        sub_id.DefaultCellStyle = DataGridViewCellStyle3
        sub_id.HeaderText = "SUBJECT ID"
        sub_id.Name = "sub_id"
        sub_id.ReadOnly = True
        sub_id.Width = 101
        ' 
        ' sub_code
        ' 
        sub_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        sub_code.DefaultCellStyle = DataGridViewCellStyle4
        sub_code.HeaderText = "SUBJECT CODE"
        sub_code.Name = "sub_code"
        sub_code.ReadOnly = True
        sub_code.Width = 125
        ' 
        ' sub_name
        ' 
        sub_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        sub_name.HeaderText = "SUBJECT NAME"
        sub_name.Name = "sub_name"
        sub_name.ReadOnly = True
        sub_name.Width = 127
        ' 
        ' unitt
        ' 
        unitt.HeaderText = "UNIT"
        unitt.Name = "unitt"
        unitt.ReadOnly = True
        ' 
        ' prereqq
        ' 
        prereqq.HeaderText = "PRE-REQUISITE"
        prereqq.Name = "prereqq"
        prereqq.ReadOnly = True
        ' 
        ' DGVStudentSubjects
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DGVStudentSubjects.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DGVStudentSubjects.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle8.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DGVStudentSubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        DGVStudentSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVStudentSubjects.Columns.AddRange(New DataGridViewColumn() {ssub_id, ssub_code, ssub_name, unit, sectionn})
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = Color.White
        DataGridViewCellStyle11.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle11.ForeColor = Color.Black
        DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle11.SelectionForeColor = Color.White
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        DGVStudentSubjects.DefaultCellStyle = DataGridViewCellStyle11
        DGVStudentSubjects.EnableHeadersVisualStyles = False
        DGVStudentSubjects.Location = New Point(613, 239)
        DGVStudentSubjects.Name = "DGVStudentSubjects"
        DGVStudentSubjects.ReadOnly = True
        DGVStudentSubjects.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = Color.White
        DataGridViewCellStyle12.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle12.ForeColor = Color.Black
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle12.SelectionForeColor = Color.White
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DGVStudentSubjects.RowsDefaultCellStyle = DataGridViewCellStyle12
        DGVStudentSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVStudentSubjects.Size = New Size(513, 460)
        DGVStudentSubjects.TabIndex = 41
        ' 
        ' ssub_id
        ' 
        ssub_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.Black
        ssub_id.DefaultCellStyle = DataGridViewCellStyle9
        ssub_id.HeaderText = "SUBJECT ID"
        ssub_id.Name = "ssub_id"
        ssub_id.ReadOnly = True
        ssub_id.Width = 101
        ' 
        ' ssub_code
        ' 
        ssub_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = Color.Black
        ssub_code.DefaultCellStyle = DataGridViewCellStyle10
        ssub_code.HeaderText = "SUBJECT CODE"
        ssub_code.Name = "ssub_code"
        ssub_code.ReadOnly = True
        ' 
        ' ssub_name
        ' 
        ssub_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        ssub_name.HeaderText = "SUBJECT NAME"
        ssub_name.Name = "ssub_name"
        ssub_name.ReadOnly = True
        ssub_name.Width = 127
        ' 
        ' unit
        ' 
        unit.HeaderText = "UNIT"
        unit.Name = "unit"
        unit.ReadOnly = True
        ' 
        ' sectionn
        ' 
        sectionn.HeaderText = "SECTION"
        sectionn.Name = "sectionn"
        sectionn.ReadOnly = True
        ' 
        ' cboSection
        ' 
        cboSection.DropDownStyle = ComboBoxStyle.DropDownList
        cboSection.FormattingEnabled = True
        cboSection.Location = New Point(23, 87)
        cboSection.Name = "cboSection"
        cboSection.Size = New Size(297, 23)
        cboSection.TabIndex = 10
        ' 
        ' createPnl2
        ' 
        createPnl2.BackColor = Color.MidnightBlue
        createPnl2.Controls.Add(Label7)
        createPnl2.Controls.Add(btnCancel)
        createPnl2.Controls.Add(btnSave)
        createPnl2.Controls.Add(cboSection)
        createPnl2.Location = New Point(426, 469)
        createPnl2.Name = "createPnl2"
        createPnl2.Size = New Size(343, 202)
        createPnl2.TabIndex = 42
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MidnightBlue
        Label7.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(93, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(167, 25)
        Label7.TabIndex = 15
        Label7.Text = "APPLY SECTION"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Transparent
        btnCancel.BaseColor = Color.IndianRed
        btnCancel.Font = New Font("Segoe UI", 12F)
        btnCancel.Location = New Point(178, 132)
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
        btnSave.Location = New Point(57, 132)
        btnSave.Name = "btnSave"
        btnSave.Rounded = False
        btnSave.Size = New Size(115, 42)
        btnSave.TabIndex = 10
        btnSave.Text = "SAVE"
        btnSave.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' dean_courseManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = SystemColors.Control
        ClientSize = New Size(1138, 719)
        Controls.Add(createPnl2)
        Controls.Add(DGVStudentSubjects)
        Controls.Add(DGVSubject)
        Controls.Add(btnConfirmSub)
        Controls.Add(btnConfirm)
        Controls.Add(lblSem)
        Controls.Add(Label12)
        Controls.Add(lblSchoolyr)
        Controls.Add(Label9)
        Controls.Add(txtStudentStatus)
        Controls.Add(Label8)
        Controls.Add(btnApplySub)
        Controls.Add(txtYearlvl)
        Controls.Add(Label5)
        Controls.Add(txtCourse)
        Controls.Add(Label4)
        Controls.Add(txtStudname)
        Controls.Add(Label3)
        Controls.Add(txtSearchStudent)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "dean_courseManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "teacher_courseManagement"
        CType(DGVSubject, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVStudentSubjects, ComponentModel.ISupportInitialize).EndInit()
        createPnl2.ResumeLayout(False)
        createPnl2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchStudent As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStudname As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtYearlvl As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnApplySub As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStudentStatus As TextBox
    Friend WithEvents lblSchoolyr As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSem As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnConfirmSub As Button
    Friend WithEvents DGVSubject As DataGridView
    Friend WithEvents DGVStudentSubjects As DataGridView
    Friend WithEvents ssub_id As DataGridViewTextBoxColumn
    Friend WithEvents ssub_code As DataGridViewTextBoxColumn
    Friend WithEvents ssub_name As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents sectionn As DataGridViewTextBoxColumn
    Friend WithEvents sub_id As DataGridViewTextBoxColumn
    Friend WithEvents sub_code As DataGridViewTextBoxColumn
    Friend WithEvents sub_name As DataGridViewTextBoxColumn
    Friend WithEvents unitt As DataGridViewTextBoxColumn
    Friend WithEvents prereqq As DataGridViewTextBoxColumn
    Friend WithEvents cboSection As ComboBox
    Friend WithEvents createPnl2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents btnSave As ReaLTaiizor.Controls.ForeverButton
End Class
