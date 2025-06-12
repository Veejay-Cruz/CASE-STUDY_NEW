<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class courses
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
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        deleteLbl = New Label()
        createLbl = New Label()
        Label1 = New Label()
        DGV3 = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        code = New DataGridViewTextBoxColumn()
        cname = New DataGridViewTextBoxColumn()
        major = New DataGridViewTextBoxColumn()
        dept = New DataGridViewTextBoxColumn()
        createPnl2 = New Panel()
        department = New ComboBox()
        Label7 = New Label()
        ForeverButton2 = New ReaLTaiizor.Controls.ForeverButton()
        ForeverButton1 = New ReaLTaiizor.Controls.ForeverButton()
        majorr = New TextBox()
        course_name = New TextBox()
        course_code = New TextBox()
        course_id = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        CType(DGV3, ComponentModel.ISupportInitialize).BeginInit()
        createPnl2.SuspendLayout()
        SuspendLayout()
        ' 
        ' deleteLbl
        ' 
        deleteLbl.AutoSize = True
        deleteLbl.BackColor = Color.White
        deleteLbl.FlatStyle = FlatStyle.System
        deleteLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        deleteLbl.ForeColor = Color.Black
        deleteLbl.Location = New Point(1527, 47)
        deleteLbl.Name = "deleteLbl"
        deleteLbl.Size = New Size(73, 19)
        deleteLbl.TabIndex = 11
        deleteLbl.Text = "[delete]"
        ' 
        ' createLbl
        ' 
        createLbl.AutoSize = True
        createLbl.BackColor = Color.White
        createLbl.FlatStyle = FlatStyle.System
        createLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        createLbl.ForeColor = Color.Black
        createLbl.Location = New Point(1424, 47)
        createLbl.Name = "createLbl"
        createLbl.Size = New Size(91, 19)
        createLbl.TabIndex = 9
        createLbl.Text = "[add new]"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(379, 38)
        Label1.TabIndex = 12
        Label1.Text = "COURSE MANAGEMENT"
        ' 
        ' DGV3
        ' 
        DGV3.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DGV3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV3.BackgroundColor = SystemColors.ControlLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV3.ColumnHeadersHeight = 30
        DGV3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGV3.Columns.AddRange(New DataGridViewColumn() {id, code, cname, major, dept})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        DGV3.DefaultCellStyle = DataGridViewCellStyle8
        DGV3.EnableHeadersVisualStyles = False
        DGV3.Location = New Point(12, 73)
        DGV3.Name = "DGV3"
        DGV3.RowHeadersVisible = False
        DGV3.RowHeadersWidth = 51
        DGV3.Size = New Size(1600, 1009)
        DGV3.TabIndex = 13
        ' 
        ' id
        ' 
        id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        id.DefaultCellStyle = DataGridViewCellStyle3
        id.HeaderText = "COURSE ID"
        id.MinimumWidth = 6
        id.Name = "id"
        ' 
        ' code
        ' 
        code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        code.DefaultCellStyle = DataGridViewCellStyle4
        code.HeaderText = "COURSE CODE"
        code.MinimumWidth = 6
        code.Name = "code"
        ' 
        ' cname
        ' 
        cname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        cname.DefaultCellStyle = DataGridViewCellStyle5
        cname.HeaderText = "COURSE NAME"
        cname.MinimumWidth = 6
        cname.Name = "cname"
        ' 
        ' major
        ' 
        major.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        major.DefaultCellStyle = DataGridViewCellStyle6
        major.HeaderText = "MAJOR"
        major.MinimumWidth = 6
        major.Name = "major"
        ' 
        ' dept
        ' 
        dept.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        dept.DefaultCellStyle = DataGridViewCellStyle7
        dept.HeaderText = "DEPARTMENT"
        dept.MinimumWidth = 6
        dept.Name = "dept"
        ' 
        ' createPnl2
        ' 
        createPnl2.BackColor = Color.MidnightBlue
        createPnl2.Controls.Add(department)
        createPnl2.Controls.Add(Label7)
        createPnl2.Controls.Add(ForeverButton2)
        createPnl2.Controls.Add(ForeverButton1)
        createPnl2.Controls.Add(majorr)
        createPnl2.Controls.Add(course_name)
        createPnl2.Controls.Add(course_code)
        createPnl2.Controls.Add(course_id)
        createPnl2.Controls.Add(Label6)
        createPnl2.Controls.Add(Label5)
        createPnl2.Controls.Add(Label4)
        createPnl2.Controls.Add(Label3)
        createPnl2.Controls.Add(Label2)
        createPnl2.Location = New Point(612, 294)
        createPnl2.Name = "createPnl2"
        createPnl2.Size = New Size(536, 500)
        createPnl2.TabIndex = 14
        ' 
        ' department
        ' 
        department.FormattingEnabled = True
        department.Location = New Point(188, 375)
        department.Name = "department"
        department.Size = New Size(303, 23)
        department.TabIndex = 16
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
        ' ForeverButton2
        ' 
        ForeverButton2.BackColor = Color.Transparent
        ForeverButton2.BaseColor = Color.IndianRed
        ForeverButton2.Font = New Font("Segoe UI", 12F)
        ForeverButton2.Location = New Point(376, 433)
        ForeverButton2.Name = "ForeverButton2"
        ForeverButton2.Rounded = False
        ForeverButton2.Size = New Size(115, 42)
        ForeverButton2.TabIndex = 11
        ForeverButton2.Text = "CANCEL"
        ForeverButton2.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' ForeverButton1
        ' 
        ForeverButton1.BackColor = Color.Transparent
        ForeverButton1.BaseColor = Color.FromArgb(CByte(35), CByte(168), CByte(109))
        ForeverButton1.Font = New Font("Segoe UI", 12F)
        ForeverButton1.Location = New Point(255, 433)
        ForeverButton1.Name = "ForeverButton1"
        ForeverButton1.Rounded = False
        ForeverButton1.Size = New Size(115, 42)
        ForeverButton1.TabIndex = 10
        ForeverButton1.Text = "SAVE"
        ForeverButton1.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' majorr
        ' 
        majorr.Font = New Font("Century Gothic", 9F)
        majorr.Location = New Point(188, 304)
        majorr.Multiline = True
        majorr.Name = "majorr"
        majorr.Size = New Size(303, 41)
        majorr.TabIndex = 8
        ' 
        ' course_name
        ' 
        course_name.Font = New Font("Century Gothic", 9F)
        course_name.Location = New Point(188, 233)
        course_name.Multiline = True
        course_name.Name = "course_name"
        course_name.Size = New Size(303, 41)
        course_name.TabIndex = 7
        ' 
        ' course_code
        ' 
        course_code.Font = New Font("Century Gothic", 9F)
        course_code.Location = New Point(188, 157)
        course_code.Multiline = True
        course_code.Name = "course_code"
        course_code.Size = New Size(303, 41)
        course_code.TabIndex = 6
        ' 
        ' course_id
        ' 
        course_id.Font = New Font("Century Gothic", 9F)
        course_id.Location = New Point(188, 86)
        course_id.Multiline = True
        course_id.Name = "course_id"
        course_id.Size = New Size(303, 41)
        course_id.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(41, 380)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 18)
        Label6.TabIndex = 4
        Label6.Text = "DEPARTMENT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(41, 327)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 18)
        Label5.TabIndex = 3
        Label5.Text = "MAJOR"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(41, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 18)
        Label4.TabIndex = 2
        Label4.Text = "COURSE NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(41, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 18)
        Label3.TabIndex = 1
        Label3.Text = "COURSE CODE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(41, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 18)
        Label2.TabIndex = 0
        Label2.Text = "COURSE ID"
        ' 
        ' courses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1612, 1080)
        Controls.Add(createPnl2)
        Controls.Add(DGV3)
        Controls.Add(Label1)
        Controls.Add(deleteLbl)
        Controls.Add(createLbl)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "courses"
        StartPosition = FormStartPosition.CenterScreen
        Text = "courses"
        CType(DGV3, ComponentModel.ISupportInitialize).EndInit()
        createPnl2.ResumeLayout(False)
        createPnl2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents deleteLbl As Label
    Friend WithEvents createLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV3 As DataGridView
    Friend WithEvents createPnl2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents majorr As TextBox
    Friend WithEvents course_name As TextBox
    Friend WithEvents course_code As TextBox
    Friend WithEvents course_id As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ForeverButton2 As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents ForeverButton1 As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents Label7 As Label
    Friend WithEvents department As ComboBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents cname As DataGridViewTextBoxColumn
    Friend WithEvents major As DataGridViewTextBoxColumn
    Friend WithEvents dept As DataGridViewTextBoxColumn
End Class
