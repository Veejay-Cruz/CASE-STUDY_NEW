<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentManagement
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
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DGV1 = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        lname = New DataGridViewTextBoxColumn()
        fname = New DataGridViewTextBoxColumn()
        mname = New DataGridViewTextBoxColumn()
        yr_level = New DataGridViewTextBoxColumn()
        dept = New DataGridViewTextBoxColumn()
        course = New DataGridViewTextBoxColumn()
        pass = New DataGridViewTextBoxColumn()
        stat = New DataGridViewTextBoxColumn()
        searchTxt = New TextBox()
        Label1 = New Label()
        createPnl = New Panel()
        cboYearlvl = New ComboBox()
        Label13 = New Label()
        Label11 = New Label()
        ComboBox1 = New ComboBox()
        cboDepartment = New ComboBox()
        status = New ComboBox()
        Label10 = New Label()
        ForeverButton2 = New ReaLTaiizor.Controls.ForeverButton()
        ForeverButton1 = New ReaLTaiizor.Controls.ForeverButton()
        password = New TextBox()
        middle_name = New TextBox()
        last_name = New TextBox()
        first_name = New TextBox()
        stud_id = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        deleteLbl = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Label6 = New Label()
        lblSchoolyr = New Label()
        lblSem = New Label()
        Label12 = New Label()
        lblTerm = New Label()
        Label14 = New Label()
        Label15 = New Label()
        cboFilter = New ComboBox()
        createLbl = New Label()
        CType(DGV1, ComponentModel.ISupportInitialize).BeginInit()
        createPnl.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGV1
        ' 
        DGV1.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DGV1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV1.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV1.ColumnHeadersHeight = 36
        DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGV1.Columns.AddRange(New DataGridViewColumn() {id, lname, fname, mname, yr_level, dept, course, pass, stat})
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = SystemColors.Window
        DataGridViewCellStyle12.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle12.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        DGV1.DefaultCellStyle = DataGridViewCellStyle12
        DGV1.EnableHeadersVisualStyles = False
        DGV1.Location = New Point(1, 133)
        DGV1.Name = "DGV1"
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = SystemColors.Control
        DataGridViewCellStyle13.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle13.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = DataGridViewTriState.True
        DGV1.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        DGV1.RowHeadersVisible = False
        DGV1.RowHeadersWidth = 51
        DGV1.Size = New Size(1610, 949)
        DGV1.TabIndex = 2
        ' 
        ' id
        ' 
        id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        id.DefaultCellStyle = DataGridViewCellStyle3
        id.HeaderText = "STUDENT ID"
        id.MinimumWidth = 6
        id.Name = "id"
        ' 
        ' lname
        ' 
        lname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        lname.DefaultCellStyle = DataGridViewCellStyle4
        lname.HeaderText = "LAST NAME"
        lname.MinimumWidth = 6
        lname.Name = "lname"
        ' 
        ' fname
        ' 
        fname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        fname.DefaultCellStyle = DataGridViewCellStyle5
        fname.HeaderText = "FIRST NAME"
        fname.MinimumWidth = 6
        fname.Name = "fname"
        ' 
        ' mname
        ' 
        mname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        mname.DefaultCellStyle = DataGridViewCellStyle6
        mname.HeaderText = "MIDDLE NAME"
        mname.MinimumWidth = 6
        mname.Name = "mname"
        ' 
        ' yr_level
        ' 
        yr_level.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        yr_level.DefaultCellStyle = DataGridViewCellStyle7
        yr_level.HeaderText = "YEAR LEVEL"
        yr_level.MinimumWidth = 6
        yr_level.Name = "yr_level"
        ' 
        ' dept
        ' 
        dept.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.Black
        dept.DefaultCellStyle = DataGridViewCellStyle8
        dept.HeaderText = "DEPARTMENT"
        dept.MinimumWidth = 6
        dept.Name = "dept"
        ' 
        ' course
        ' 
        course.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.Black
        course.DefaultCellStyle = DataGridViewCellStyle9
        course.HeaderText = "COURSE"
        course.MinimumWidth = 6
        course.Name = "course"
        ' 
        ' pass
        ' 
        pass.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = Color.Black
        pass.DefaultCellStyle = DataGridViewCellStyle10
        pass.HeaderText = "PASSWORD"
        pass.MinimumWidth = 6
        pass.Name = "pass"
        ' 
        ' stat
        ' 
        stat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle11.ForeColor = Color.Black
        stat.DefaultCellStyle = DataGridViewCellStyle11
        stat.HeaderText = "STATUS"
        stat.MinimumWidth = 6
        stat.Name = "stat"
        ' 
        ' searchTxt
        ' 
        searchTxt.BackColor = Color.LightGray
        searchTxt.BorderStyle = BorderStyle.None
        searchTxt.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchTxt.Location = New Point(1317, 87)
        searchTxt.Multiline = True
        searchTxt.Name = "searchTxt"
        searchTxt.Size = New Size(283, 40)
        searchTxt.TabIndex = 3
        searchTxt.Text = "Search by Student Number | Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 38)
        Label1.TabIndex = 4
        Label1.Text = "STUDENT MANAGEMENT"
        ' 
        ' createPnl
        ' 
        createPnl.BackColor = Color.MidnightBlue
        createPnl.Controls.Add(cboYearlvl)
        createPnl.Controls.Add(Label13)
        createPnl.Controls.Add(Label11)
        createPnl.Controls.Add(ComboBox1)
        createPnl.Controls.Add(cboDepartment)
        createPnl.Controls.Add(status)
        createPnl.Controls.Add(Label10)
        createPnl.Controls.Add(ForeverButton2)
        createPnl.Controls.Add(ForeverButton1)
        createPnl.Controls.Add(password)
        createPnl.Controls.Add(middle_name)
        createPnl.Controls.Add(last_name)
        createPnl.Controls.Add(first_name)
        createPnl.Controls.Add(stud_id)
        createPnl.Controls.Add(Label9)
        createPnl.Controls.Add(Label8)
        createPnl.Controls.Add(Label7)
        createPnl.Controls.Add(Label5)
        createPnl.Controls.Add(Label4)
        createPnl.Controls.Add(Label2)
        createPnl.Controls.Add(Label3)
        createPnl.Location = New Point(398, 182)
        createPnl.Name = "createPnl"
        createPnl.Size = New Size(569, 695)
        createPnl.TabIndex = 6
        ' 
        ' cboYearlvl
        ' 
        cboYearlvl.FormattingEnabled = True
        cboYearlvl.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        cboYearlvl.Location = New Point(199, 311)
        cboYearlvl.Name = "cboYearlvl"
        cboYearlvl.Size = New Size(305, 23)
        cboYearlvl.TabIndex = 23
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(62, 315)
        Label13.Name = "Label13"
        Label13.Size = New Size(89, 19)
        Label13.TabIndex = 22
        Label13.Text = "Year Level"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(62, 439)
        Label11.Name = "Label11"
        Label11.Size = New Size(62, 19)
        Label11.TabIndex = 21
        Label11.Text = "Course"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(199, 435)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(305, 23)
        ComboBox1.TabIndex = 20
        ' 
        ' cboDepartment
        ' 
        cboDepartment.FormattingEnabled = True
        cboDepartment.Location = New Point(199, 368)
        cboDepartment.Name = "cboDepartment"
        cboDepartment.Size = New Size(305, 23)
        cboDepartment.TabIndex = 19
        ' 
        ' status
        ' 
        status.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        status.FormattingEnabled = True
        status.Location = New Point(199, 571)
        status.Name = "status"
        status.Size = New Size(305, 25)
        status.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(181, 18)
        Label10.Name = "Label10"
        Label10.Size = New Size(201, 25)
        Label10.TabIndex = 17
        Label10.Text = "ADD NEW STUDENT"
        ' 
        ' ForeverButton2
        ' 
        ForeverButton2.BackColor = Color.Transparent
        ForeverButton2.BaseColor = Color.IndianRed
        ForeverButton2.Font = New Font("Century Gothic", 12F)
        ForeverButton2.Location = New Point(405, 623)
        ForeverButton2.Name = "ForeverButton2"
        ForeverButton2.Rounded = False
        ForeverButton2.Size = New Size(99, 36)
        ForeverButton2.TabIndex = 16
        ForeverButton2.Text = "CANCEL"
        ForeverButton2.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' ForeverButton1
        ' 
        ForeverButton1.BackColor = Color.Transparent
        ForeverButton1.BaseColor = Color.FromArgb(CByte(35), CByte(168), CByte(109))
        ForeverButton1.Font = New Font("Century Gothic", 12F)
        ForeverButton1.Location = New Point(299, 623)
        ForeverButton1.Name = "ForeverButton1"
        ForeverButton1.Rounded = False
        ForeverButton1.Size = New Size(100, 36)
        ForeverButton1.TabIndex = 15
        ForeverButton1.Text = "SAVE"
        ForeverButton1.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' password
        ' 
        password.Location = New Point(199, 503)
        password.Multiline = True
        password.Name = "password"
        password.Size = New Size(305, 32)
        password.TabIndex = 13
        ' 
        ' middle_name
        ' 
        middle_name.Location = New Point(199, 235)
        middle_name.Multiline = True
        middle_name.Name = "middle_name"
        middle_name.Size = New Size(305, 38)
        middle_name.TabIndex = 11
        ' 
        ' last_name
        ' 
        last_name.Location = New Point(199, 178)
        last_name.Multiline = True
        last_name.Name = "last_name"
        last_name.Size = New Size(305, 38)
        last_name.TabIndex = 10
        ' 
        ' first_name
        ' 
        first_name.Location = New Point(199, 121)
        first_name.Multiline = True
        first_name.Name = "first_name"
        first_name.Size = New Size(305, 38)
        first_name.TabIndex = 9
        ' 
        ' stud_id
        ' 
        stud_id.Location = New Point(199, 65)
        stud_id.Multiline = True
        stud_id.Name = "stud_id"
        stud_id.Size = New Size(305, 38)
        stud_id.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(66, 577)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 19)
        Label9.TabIndex = 7
        Label9.Text = "Status"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(62, 516)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 19)
        Label8.TabIndex = 6
        Label8.Text = "Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(62, 372)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 19)
        Label7.TabIndex = 5
        Label7.Text = "Department"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(62, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 19)
        Label5.TabIndex = 3
        Label5.Text = "Middle Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(62, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 19)
        Label4.TabIndex = 2
        Label4.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(62, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 19)
        Label2.TabIndex = 1
        Label2.Text = "Student No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(66, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 19)
        Label3.TabIndex = 0
        Label3.Text = "First Name"
        ' 
        ' deleteLbl
        ' 
        deleteLbl.AutoSize = True
        deleteLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        deleteLbl.ForeColor = Color.Black
        deleteLbl.Location = New Point(1527, 41)
        deleteLbl.Name = "deleteLbl"
        deleteLbl.Size = New Size(73, 19)
        deleteLbl.TabIndex = 8
        deleteLbl.Text = "[delete]"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(41, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 19)
        Label6.TabIndex = 9
        Label6.Text = "SCHOOL YEAR: "
        ' 
        ' lblSchoolyr
        ' 
        lblSchoolyr.AutoSize = True
        lblSchoolyr.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSchoolyr.ForeColor = Color.Black
        lblSchoolyr.Location = New Point(176, 87)
        lblSchoolyr.Name = "lblSchoolyr"
        lblSchoolyr.Size = New Size(29, 19)
        lblSchoolyr.TabIndex = 10
        lblSchoolyr.Text = "----"
        ' 
        ' lblSem
        ' 
        lblSem.AutoSize = True
        lblSem.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSem.ForeColor = Color.Black
        lblSem.Location = New Point(417, 87)
        lblSem.Name = "lblSem"
        lblSem.Size = New Size(29, 19)
        lblSem.TabIndex = 12
        lblSem.Text = "----"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(319, 87)
        Label12.Name = "Label12"
        Label12.Size = New Size(92, 19)
        Label12.TabIndex = 11
        Label12.Text = "SEMESTER: "
        ' 
        ' lblTerm
        ' 
        lblTerm.AutoSize = True
        lblTerm.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTerm.ForeColor = Color.Black
        lblTerm.Location = New Point(562, 87)
        lblTerm.Name = "lblTerm"
        lblTerm.Size = New Size(29, 19)
        lblTerm.TabIndex = 14
        lblTerm.Text = "----"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(498, 87)
        Label14.Name = "Label14"
        Label14.Size = New Size(58, 19)
        Label14.TabIndex = 13
        Label14.Text = "TERM: "
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.White
        Label15.FlatStyle = FlatStyle.System
        Label15.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(1085, 88)
        Label15.Name = "Label15"
        Label15.Size = New Size(61, 21)
        Label15.TabIndex = 44
        Label15.Text = "FILTER:"
        ' 
        ' cboFilter
        ' 
        cboFilter.FormattingEnabled = True
        cboFilter.Location = New Point(1152, 88)
        cboFilter.Name = "cboFilter"
        cboFilter.Size = New Size(121, 23)
        cboFilter.TabIndex = 43
        ' 
        ' createLbl
        ' 
        createLbl.AutoSize = True
        createLbl.Font = New Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        createLbl.ForeColor = Color.Black
        createLbl.Location = New Point(1317, 41)
        createLbl.Name = "createLbl"
        createLbl.Size = New Size(129, 22)
        createLbl.TabIndex = 0
        createLbl.Text = "[create new]"
        ' 
        ' studentManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1612, 1080)
        Controls.Add(Label15)
        Controls.Add(cboFilter)
        Controls.Add(lblTerm)
        Controls.Add(Label14)
        Controls.Add(lblSem)
        Controls.Add(Label12)
        Controls.Add(lblSchoolyr)
        Controls.Add(Label6)
        Controls.Add(deleteLbl)
        Controls.Add(createPnl)
        Controls.Add(Label1)
        Controls.Add(searchTxt)
        Controls.Add(DGV1)
        Controls.Add(createLbl)
        FormBorderStyle = FormBorderStyle.None
        Name = "studentManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "studentManagement"
        CType(DGV1, ComponentModel.ISupportInitialize).EndInit()
        createPnl.ResumeLayout(False)
        createPnl.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents createPnl As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents stud_id As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents middle_name As TextBox
    Friend WithEvents last_name As TextBox
    Friend WithEvents first_name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ForeverButton2 As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents ForeverButton1 As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents deleteLbl As Label
    Friend WithEvents status As ComboBox
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSchoolyr As Label
    Friend WithEvents lblSem As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTerm As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cboYearlvl As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents mname As DataGridViewTextBoxColumn
    Friend WithEvents yr_level As DataGridViewTextBoxColumn
    Friend WithEvents dept As DataGridViewTextBoxColumn
    Friend WithEvents course As DataGridViewTextBoxColumn
    Friend WithEvents pass As DataGridViewTextBoxColumn
    Friend WithEvents stat As DataGridViewTextBoxColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents cboFilter As ComboBox
    Friend WithEvents createLbl As Label
End Class
