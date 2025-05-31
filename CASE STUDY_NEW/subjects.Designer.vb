<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subjects
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
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        DGV4 = New DataGridView()
        subject_id = New DataGridViewTextBoxColumn()
        subject_code = New DataGridViewTextBoxColumn()
        subjectt_name = New DataGridViewTextBoxColumn()
        unitt = New DataGridViewTextBoxColumn()
        yr_level = New DataGridViewTextBoxColumn()
        coursee = New DataGridViewTextBoxColumn()
        prerequisite = New DataGridViewTextBoxColumn()
        editBtn = New DataGridViewButtonColumn()
        Label2 = New Label()
        deleteLbl = New Label()
        createLbl = New Label()
        createPnl = New Panel()
        txtprereq = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        ForeverButton2 = New ReaLTaiizor.Controls.ForeverButton()
        ForeverButton1 = New ReaLTaiizor.Controls.ForeverButton()
        course = New TextBox()
        year_level = New TextBox()
        unit = New TextBox()
        sub_code = New TextBox()
        subject_name = New TextBox()
        sub_id = New TextBox()
        Label8 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        CType(DGV4, ComponentModel.ISupportInitialize).BeginInit()
        createPnl.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 38)
        Label1.TabIndex = 5
        Label1.Text = "SUBJECT MANAGEMENT"
        ' 
        ' DGV4
        ' 
        DGV4.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DGV4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV4.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGV4.Columns.AddRange(New DataGridViewColumn() {subject_id, subject_code, subjectt_name, unitt, yr_level, coursee, prerequisite, editBtn})
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = Color.White
        DataGridViewCellStyle11.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle11.ForeColor = Color.Black
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        DGV4.DefaultCellStyle = DataGridViewCellStyle11
        DGV4.EnableHeadersVisualStyles = False
        DGV4.Location = New Point(-3, 63)
        DGV4.Name = "DGV4"
        DGV4.ReadOnly = True
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle12.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle12.ForeColor = Color.White
        DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DGV4.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DGV4.RowHeadersVisible = False
        DGV4.Size = New Size(1616, 1017)
        DGV4.TabIndex = 6
        ' 
        ' subject_id
        ' 
        subject_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        subject_id.DefaultCellStyle = DataGridViewCellStyle3
        subject_id.HeaderText = "SUBJECT ID"
        subject_id.Name = "subject_id"
        subject_id.ReadOnly = True
        subject_id.Width = 101
        ' 
        ' subject_code
        ' 
        subject_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        subject_code.DefaultCellStyle = DataGridViewCellStyle4
        subject_code.HeaderText = "SUBJECT CODE"
        subject_code.Name = "subject_code"
        subject_code.ReadOnly = True
        subject_code.Width = 125
        ' 
        ' subjectt_name
        ' 
        subjectt_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        subjectt_name.DefaultCellStyle = DataGridViewCellStyle5
        subjectt_name.HeaderText = "SUBJECT NAME"
        subjectt_name.Name = "subjectt_name"
        subjectt_name.ReadOnly = True
        ' 
        ' unitt
        ' 
        unitt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        unitt.DefaultCellStyle = DataGridViewCellStyle6
        unitt.HeaderText = "UNIT"
        unitt.Name = "unitt"
        unitt.ReadOnly = True
        unitt.Width = 60
        ' 
        ' yr_level
        ' 
        yr_level.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        yr_level.DefaultCellStyle = DataGridViewCellStyle7
        yr_level.HeaderText = "YEAR LEVEL"
        yr_level.Name = "yr_level"
        yr_level.ReadOnly = True
        yr_level.Width = 104
        ' 
        ' coursee
        ' 
        coursee.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.Black
        coursee.DefaultCellStyle = DataGridViewCellStyle8
        coursee.HeaderText = "COURSE"
        coursee.Name = "coursee"
        coursee.ReadOnly = True
        ' 
        ' prerequisite
        ' 
        prerequisite.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.Black
        prerequisite.DefaultCellStyle = DataGridViewCellStyle9
        prerequisite.HeaderText = "PRE-REQUISITE"
        prerequisite.Name = "prerequisite"
        prerequisite.ReadOnly = True
        ' 
        ' editBtn
        ' 
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = Color.White
        DataGridViewCellStyle10.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = Color.Black
        editBtn.DefaultCellStyle = DataGridViewCellStyle10
        editBtn.HeaderText = ""
        editBtn.Name = "editBtn"
        editBtn.ReadOnly = True
        editBtn.Text = "Edit"
        editBtn.UseColumnTextForButtonValue = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(1540, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 19)
        Label2.TabIndex = 7
        Label2.Text = "[close]"
        ' 
        ' deleteLbl
        ' 
        deleteLbl.AutoSize = True
        deleteLbl.BackColor = Color.White
        deleteLbl.FlatStyle = FlatStyle.System
        deleteLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        deleteLbl.ForeColor = Color.Black
        deleteLbl.Location = New Point(1527, 37)
        deleteLbl.Name = "deleteLbl"
        deleteLbl.Size = New Size(73, 19)
        deleteLbl.TabIndex = 13
        deleteLbl.Text = "[delete]"
        ' 
        ' createLbl
        ' 
        createLbl.AutoSize = True
        createLbl.BackColor = Color.White
        createLbl.FlatStyle = FlatStyle.System
        createLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        createLbl.ForeColor = Color.Black
        createLbl.Location = New Point(1421, 37)
        createLbl.Name = "createLbl"
        createLbl.Size = New Size(112, 19)
        createLbl.TabIndex = 12
        createLbl.Text = "[create new]"
        ' 
        ' createPnl
        ' 
        createPnl.BackColor = Color.MidnightBlue
        createPnl.Controls.Add(txtprereq)
        createPnl.Controls.Add(Label9)
        createPnl.Controls.Add(Label10)
        createPnl.Controls.Add(ForeverButton2)
        createPnl.Controls.Add(ForeverButton1)
        createPnl.Controls.Add(course)
        createPnl.Controls.Add(year_level)
        createPnl.Controls.Add(unit)
        createPnl.Controls.Add(sub_code)
        createPnl.Controls.Add(subject_name)
        createPnl.Controls.Add(sub_id)
        createPnl.Controls.Add(Label8)
        createPnl.Controls.Add(Label6)
        createPnl.Controls.Add(Label7)
        createPnl.Controls.Add(Label5)
        createPnl.Controls.Add(Label4)
        createPnl.Controls.Add(Label3)
        createPnl.Location = New Point(591, 277)
        createPnl.Name = "createPnl"
        createPnl.Size = New Size(576, 522)
        createPnl.TabIndex = 14
        ' 
        ' txtprereq
        ' 
        txtprereq.BackColor = Color.Gainsboro
        txtprereq.BorderStyle = BorderStyle.None
        txtprereq.Font = New Font("Century Gothic", 9.75F)
        txtprereq.Location = New Point(196, 407)
        txtprereq.Multiline = True
        txtprereq.Name = "txtprereq"
        txtprereq.Size = New Size(332, 41)
        txtprereq.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(29, 430)
        Label9.Name = "Label9"
        Label9.Size = New Size(109, 18)
        Label9.TabIndex = 19
        Label9.Text = "PRE-REQUISITE"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(159, 13)
        Label10.Name = "Label10"
        Label10.Size = New Size(199, 25)
        Label10.TabIndex = 18
        Label10.Text = "ADD NEW SUBJECT"
        ' 
        ' ForeverButton2
        ' 
        ForeverButton2.BackColor = Color.Transparent
        ForeverButton2.BaseColor = Color.IndianRed
        ForeverButton2.Font = New Font("Segoe UI", 12F)
        ForeverButton2.Location = New Point(424, 467)
        ForeverButton2.Name = "ForeverButton2"
        ForeverButton2.Rounded = False
        ForeverButton2.Size = New Size(104, 38)
        ForeverButton2.TabIndex = 12
        ForeverButton2.Text = "CANCEL"
        ForeverButton2.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' ForeverButton1
        ' 
        ForeverButton1.BackColor = Color.Transparent
        ForeverButton1.BaseColor = Color.FromArgb(CByte(35), CByte(168), CByte(109))
        ForeverButton1.Font = New Font("Segoe UI", 12F)
        ForeverButton1.Location = New Point(297, 467)
        ForeverButton1.Name = "ForeverButton1"
        ForeverButton1.Rounded = False
        ForeverButton1.Size = New Size(104, 38)
        ForeverButton1.TabIndex = 11
        ForeverButton1.Text = "SAVE"
        ForeverButton1.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' course
        ' 
        course.BackColor = Color.Gainsboro
        course.BorderStyle = BorderStyle.None
        course.Font = New Font("Century Gothic", 9.75F)
        course.Location = New Point(196, 350)
        course.Multiline = True
        course.Name = "course"
        course.Size = New Size(332, 41)
        course.TabIndex = 10
        ' 
        ' year_level
        ' 
        year_level.BackColor = Color.Gainsboro
        year_level.BorderStyle = BorderStyle.None
        year_level.Font = New Font("Century Gothic", 9.75F)
        year_level.Location = New Point(196, 289)
        year_level.Multiline = True
        year_level.Name = "year_level"
        year_level.Size = New Size(332, 41)
        year_level.TabIndex = 9
        ' 
        ' unit
        ' 
        unit.BackColor = Color.Gainsboro
        unit.BorderStyle = BorderStyle.None
        unit.Font = New Font("Century Gothic", 9.75F)
        unit.Location = New Point(196, 232)
        unit.Multiline = True
        unit.Name = "unit"
        unit.Size = New Size(332, 41)
        unit.TabIndex = 8
        ' 
        ' sub_code
        ' 
        sub_code.BackColor = Color.Gainsboro
        sub_code.BorderStyle = BorderStyle.None
        sub_code.Font = New Font("Century Gothic", 9.75F)
        sub_code.Location = New Point(196, 115)
        sub_code.Multiline = True
        sub_code.Name = "sub_code"
        sub_code.Size = New Size(332, 41)
        sub_code.TabIndex = 7
        ' 
        ' subject_name
        ' 
        subject_name.BackColor = Color.Gainsboro
        subject_name.BorderStyle = BorderStyle.None
        subject_name.Font = New Font("Century Gothic", 9.75F)
        subject_name.Location = New Point(196, 171)
        subject_name.Multiline = True
        subject_name.Name = "subject_name"
        subject_name.Size = New Size(332, 41)
        subject_name.TabIndex = 7
        ' 
        ' sub_id
        ' 
        sub_id.BackColor = Color.Gainsboro
        sub_id.BorderStyle = BorderStyle.None
        sub_id.Font = New Font("Century Gothic", 9.75F)
        sub_id.Location = New Point(196, 61)
        sub_id.Multiline = True
        sub_id.Name = "sub_id"
        sub_id.Size = New Size(332, 41)
        sub_id.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(32, 373)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 18)
        Label8.TabIndex = 5
        Label8.Text = "COURSE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(32, 312)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 18)
        Label6.TabIndex = 4
        Label6.Text = "YEAR LEVEL"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(32, 255)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 18)
        Label7.TabIndex = 3
        Label7.Text = "UNIT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(29, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 18)
        Label5.TabIndex = 2
        Label5.Text = "SUBJECT NAME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(26, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 18)
        Label4.TabIndex = 1
        Label4.Text = "SUBJECT CODE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(32, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 18)
        Label3.TabIndex = 0
        Label3.Text = "SUBJECT ID"
        ' 
        ' subjects
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1612, 1080)
        Controls.Add(createPnl)
        Controls.Add(deleteLbl)
        Controls.Add(createLbl)
        Controls.Add(Label2)
        Controls.Add(DGV4)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "subjects"
        StartPosition = FormStartPosition.CenterScreen
        Text = "subjects"
        CType(DGV4, ComponentModel.ISupportInitialize).EndInit()
        createPnl.ResumeLayout(False)
        createPnl.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGV4 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents deleteLbl As Label
    Friend WithEvents createLbl As Label
    Friend WithEvents createPnl As Panel
    Friend WithEvents sub_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Public WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents course As TextBox
    Friend WithEvents year_level As TextBox
    Friend WithEvents unit As TextBox
    Friend WithEvents sub_code As TextBox
    Friend WithEvents subject_name As TextBox
    Friend WithEvents ForeverButton1 As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents ForeverButton2 As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents Label10 As Label
    Friend WithEvents txtprereq As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents subject_id As DataGridViewTextBoxColumn
    Friend WithEvents subject_code As DataGridViewTextBoxColumn
    Friend WithEvents subjectt_name As DataGridViewTextBoxColumn
    Friend WithEvents unitt As DataGridViewTextBoxColumn
    Friend WithEvents yr_level As DataGridViewTextBoxColumn
    Friend WithEvents coursee As DataGridViewTextBoxColumn
    Friend WithEvents prerequisite As DataGridViewTextBoxColumn
    Friend WithEvents editBtn As DataGridViewButtonColumn
End Class
