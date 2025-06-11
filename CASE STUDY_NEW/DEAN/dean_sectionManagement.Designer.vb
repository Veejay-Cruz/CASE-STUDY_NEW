<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dean_sectionManagement
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
        DGVSection = New DataGridView()
        Label1 = New Label()
        createLbl = New Label()
        createPnl2 = New Panel()
        TXTMclass = New MaskedTextBox()
        Label6 = New Label()
        cboSched = New ComboBox()
        Label4 = New Label()
        cboSEMESTER = New ComboBox()
        cboCourse = New ComboBox()
        cboYrlvl = New ComboBox()
        Label7 = New Label()
        btnCancel = New ReaLTaiizor.Controls.ForeverButton()
        btnSave = New ReaLTaiizor.Controls.ForeverButton()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label8 = New Label()
        course_code = New DataGridViewTextBoxColumn()
        section = New DataGridViewTextBoxColumn()
        yearlevel = New DataGridViewTextBoxColumn()
        semester = New DataGridViewTextBoxColumn()
        schedule = New DataGridViewTextBoxColumn()
        classs = New DataGridViewTextBoxColumn()
        editt = New DataGridViewButtonColumn()
        delete = New DataGridViewButtonColumn()
        CType(DGVSection, ComponentModel.ISupportInitialize).BeginInit()
        createPnl2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGVSection
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DGVSection.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGVSection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVSection.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DGVSection.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGVSection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGVSection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVSection.Columns.AddRange(New DataGridViewColumn() {course_code, section, yearlevel, semester, schedule, classs, editt, delete})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DGVSection.DefaultCellStyle = DataGridViewCellStyle5
        DGVSection.EnableHeadersVisualStyles = False
        DGVSection.Location = New Point(21, 169)
        DGVSection.Name = "DGVSection"
        DGVSection.ReadOnly = True
        DGVSection.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DGVSection.RowsDefaultCellStyle = DataGridViewCellStyle6
        DGVSection.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVSection.Size = New Size(1000, 479)
        DGVSection.TabIndex = 41
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(21, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(385, 39)
        Label1.TabIndex = 42
        Label1.Text = "SECTION MANAGEMENT"
        ' 
        ' createLbl
        ' 
        createLbl.AutoSize = True
        createLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        createLbl.ForeColor = Color.Black
        createLbl.Location = New Point(909, 129)
        createLbl.Name = "createLbl"
        createLbl.Size = New Size(112, 19)
        createLbl.TabIndex = 44
        createLbl.Text = "[create new]"
        ' 
        ' createPnl2
        ' 
        createPnl2.BackColor = Color.MidnightBlue
        createPnl2.Controls.Add(TXTMclass)
        createPnl2.Controls.Add(Label6)
        createPnl2.Controls.Add(cboSched)
        createPnl2.Controls.Add(Label4)
        createPnl2.Controls.Add(cboSEMESTER)
        createPnl2.Controls.Add(cboCourse)
        createPnl2.Controls.Add(cboYrlvl)
        createPnl2.Controls.Add(Label7)
        createPnl2.Controls.Add(btnCancel)
        createPnl2.Controls.Add(btnSave)
        createPnl2.Controls.Add(Label5)
        createPnl2.Controls.Add(Label3)
        createPnl2.Controls.Add(Label2)
        createPnl2.Location = New Point(248, 194)
        createPnl2.Name = "createPnl2"
        createPnl2.Size = New Size(552, 433)
        createPnl2.TabIndex = 45
        ' 
        ' TXTMclass
        ' 
        TXTMclass.Location = New Point(207, 318)
        TXTMclass.Mask = "00"
        TXTMclass.Name = "TXTMclass"
        TXTMclass.PromptChar = " "c
        TXTMclass.Size = New Size(302, 23)
        TXTMclass.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(41, 323)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 18)
        Label6.TabIndex = 21
        Label6.Text = "CLASS"
        ' 
        ' cboSched
        ' 
        cboSched.DropDownStyle = ComboBoxStyle.DropDownList
        cboSched.FormattingEnabled = True
        cboSched.Items.AddRange(New Object() {"MORNING", "AFTERNOON", "EVENING"})
        cboSched.Location = New Point(207, 262)
        cboSched.Name = "cboSched"
        cboSched.Size = New Size(303, 23)
        cboSched.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(41, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 18)
        Label4.TabIndex = 19
        Label4.Text = "SEMESTER"
        ' 
        ' cboSEMESTER
        ' 
        cboSEMESTER.DropDownStyle = ComboBoxStyle.DropDownList
        cboSEMESTER.FormattingEnabled = True
        cboSEMESTER.Items.AddRange(New Object() {"1st Sem", "2nd Sem"})
        cboSEMESTER.Location = New Point(207, 211)
        cboSEMESTER.Name = "cboSEMESTER"
        cboSEMESTER.Size = New Size(303, 23)
        cboSEMESTER.TabIndex = 18
        ' 
        ' cboCourse
        ' 
        cboCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(207, 104)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(303, 23)
        cboCourse.TabIndex = 17
        ' 
        ' cboYrlvl
        ' 
        cboYrlvl.DropDownStyle = ComboBoxStyle.DropDownList
        cboYrlvl.FormattingEnabled = True
        cboYrlvl.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        cboYrlvl.Location = New Point(207, 158)
        cboYrlvl.Name = "cboYrlvl"
        cboYrlvl.Size = New Size(303, 23)
        cboYrlvl.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MidnightBlue
        Label7.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(218, 29)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 25)
        Label7.TabIndex = 15
        Label7.Text = "ADD NEW"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Transparent
        btnCancel.BaseColor = Color.IndianRed
        btnCancel.Font = New Font("Segoe UI", 12F)
        btnCancel.Location = New Point(366, 361)
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
        btnSave.Location = New Point(245, 361)
        btnSave.Name = "btnSave"
        btnSave.Rounded = False
        btnSave.Size = New Size(115, 42)
        btnSave.TabIndex = 10
        btnSave.Text = "SAVE"
        btnSave.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(41, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 18)
        Label5.TabIndex = 3
        Label5.Text = "YEAR LEVEL"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(41, 267)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 18)
        Label3.TabIndex = 1
        Label3.Text = "SCHEDULE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(41, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 18)
        Label2.TabIndex = 0
        Label2.Text = "COURSE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(434, 129)
        Label8.Name = "Label8"
        Label8.Size = New Size(254, 19)
        Label8.TabIndex = 46
        Label8.Text = "edit and delete na lang sa row"
        ' 
        ' course_code
        ' 
        course_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        course_code.DataPropertyName = "course_code"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        course_code.DefaultCellStyle = DataGridViewCellStyle3
        course_code.HeaderText = "COURSE"
        course_code.Name = "course_code"
        course_code.ReadOnly = True
        course_code.Width = 83
        ' 
        ' section
        ' 
        section.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        section.DataPropertyName = "section"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        section.DefaultCellStyle = DataGridViewCellStyle4
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
        ' schedule
        ' 
        schedule.DataPropertyName = "schedule"
        schedule.HeaderText = "SCHEDULE"
        schedule.Name = "schedule"
        schedule.ReadOnly = True
        ' 
        ' classs
        ' 
        classs.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        classs.DataPropertyName = "class"
        classs.HeaderText = "CLASS"
        classs.Name = "classs"
        classs.ReadOnly = True
        classs.Width = 110
        ' 
        ' editt
        ' 
        editt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        editt.HeaderText = "EDIT"
        editt.Name = "editt"
        editt.ReadOnly = True
        editt.Text = "EDIT"
        editt.UseColumnTextForButtonValue = True
        editt.Width = 80
        ' 
        ' delete
        ' 
        delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        delete.HeaderText = "DELETE"
        delete.Name = "delete"
        delete.ReadOnly = True
        delete.Text = "DELETE"
        delete.UseColumnTextForButtonValue = True
        delete.Width = 80
        ' 
        ' dean_sectionManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1048, 660)
        Controls.Add(Label8)
        Controls.Add(createPnl2)
        Controls.Add(createLbl)
        Controls.Add(Label1)
        Controls.Add(DGVSection)
        FormBorderStyle = FormBorderStyle.None
        Name = "dean_sectionManagement"
        StartPosition = FormStartPosition.CenterParent
        Text = "dean_sectionManagement"
        WindowState = FormWindowState.Maximized
        CType(DGVSection, ComponentModel.ISupportInitialize).EndInit()
        createPnl2.ResumeLayout(False)
        createPnl2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGVSection As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents createLbl As Label
    Friend WithEvents createPnl2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSEMESTER As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents cboYrlvl As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents btnSave As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSched As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTMclass As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents course_code As DataGridViewTextBoxColumn
    Friend WithEvents section As DataGridViewTextBoxColumn
    Friend WithEvents yearlevel As DataGridViewTextBoxColumn
    Friend WithEvents semester As DataGridViewTextBoxColumn
    Friend WithEvents schedule As DataGridViewTextBoxColumn
    Friend WithEvents classs As DataGridViewTextBoxColumn
    Friend WithEvents editt As DataGridViewButtonColumn
    Friend WithEvents delete As DataGridViewButtonColumn
End Class
