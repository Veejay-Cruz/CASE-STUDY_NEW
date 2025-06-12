<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class department
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
        DGVDepartment = New DataGridView()
        dept_id = New DataGridViewTextBoxColumn()
        dept = New DataGridViewTextBoxColumn()
        course = New DataGridViewTextBoxColumn()
        edit = New DataGridViewButtonColumn()
        delete = New DataGridViewButtonColumn()
        Label1 = New Label()
        createLbl = New Label()
        createPnl2 = New Panel()
        cboStatus = New ComboBox()
        Label7 = New Label()
        btnCancel = New ReaLTaiizor.Controls.ForeverButton()
        btnSave = New ReaLTaiizor.Controls.ForeverButton()
        txtdeptname = New TextBox()
        txtdept_id = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        cboFilter = New ComboBox()
        Label4 = New Label()
        CType(DGVDepartment, ComponentModel.ISupportInitialize).BeginInit()
        createPnl2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGVDepartment
        ' 
        DGVDepartment.AllowUserToAddRows = False
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
        DGVDepartment.Columns.AddRange(New DataGridViewColumn() {dept_id, dept, course, edit, delete})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DGVDepartment.DefaultCellStyle = DataGridViewCellStyle5
        DGVDepartment.EnableHeadersVisualStyles = False
        DGVDepartment.Location = New Point(12, 90)
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
        DGVDepartment.Size = New Size(1022, 460)
        DGVDepartment.TabIndex = 39
        ' 
        ' dept_id
        ' 
        dept_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        dept_id.DefaultCellStyle = DataGridViewCellStyle3
        dept_id.HeaderText = "DEPARTMENT ID"
        dept_id.Name = "dept_id"
        dept_id.ReadOnly = True
        dept_id.Width = 131
        ' 
        ' dept
        ' 
        dept.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        dept.DefaultCellStyle = DataGridViewCellStyle4
        dept.HeaderText = "DEPARTMENT"
        dept.Name = "dept"
        dept.ReadOnly = True
        ' 
        ' course
        ' 
        course.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        course.HeaderText = "COURSE"
        course.Name = "course"
        course.ReadOnly = True
        course.Width = 83
        ' 
        ' edit
        ' 
        edit.HeaderText = "EDIT"
        edit.Name = "edit"
        edit.ReadOnly = True
        edit.Text = "EDIT"
        edit.UseColumnTextForButtonValue = True
        ' 
        ' delete
        ' 
        delete.HeaderText = "DELETE"
        delete.Name = "delete"
        delete.ReadOnly = True
        delete.Text = "DELETE"
        delete.UseColumnTextForButtonValue = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 38)
        Label1.TabIndex = 37
        Label1.Text = "DEPARTMENT LIST"
        ' 
        ' createLbl
        ' 
        createLbl.AutoSize = True
        createLbl.BackColor = Color.White
        createLbl.FlatStyle = FlatStyle.System
        createLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        createLbl.ForeColor = Color.Black
        createLbl.Location = New Point(928, 59)
        createLbl.Name = "createLbl"
        createLbl.Size = New Size(91, 19)
        createLbl.TabIndex = 38
        createLbl.Text = "[add new]"
        ' 
        ' createPnl2
        ' 
        createPnl2.BackColor = Color.MidnightBlue
        createPnl2.Controls.Add(cboStatus)
        createPnl2.Controls.Add(Label7)
        createPnl2.Controls.Add(btnCancel)
        createPnl2.Controls.Add(btnSave)
        createPnl2.Controls.Add(txtdeptname)
        createPnl2.Controls.Add(txtdept_id)
        createPnl2.Controls.Add(Label5)
        createPnl2.Controls.Add(Label3)
        createPnl2.Controls.Add(Label2)
        createPnl2.Location = New Point(257, 216)
        createPnl2.Name = "createPnl2"
        createPnl2.Size = New Size(552, 417)
        createPnl2.TabIndex = 40
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboStatus.Location = New Point(207, 241)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(303, 23)
        cboStatus.TabIndex = 16
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
        btnCancel.Location = New Point(348, 334)
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
        btnSave.Location = New Point(227, 334)
        btnSave.Name = "btnSave"
        btnSave.Rounded = False
        btnSave.Size = New Size(115, 42)
        btnSave.TabIndex = 10
        btnSave.Text = "SAVE"
        btnSave.TextColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        ' 
        ' txtdeptname
        ' 
        txtdeptname.Font = New Font("Century Gothic", 9F)
        txtdeptname.Location = New Point(207, 157)
        txtdeptname.Multiline = True
        txtdeptname.Name = "txtdeptname"
        txtdeptname.Size = New Size(303, 41)
        txtdeptname.TabIndex = 6
        ' 
        ' txtdept_id
        ' 
        txtdept_id.Font = New Font("Century Gothic", 9F)
        txtdept_id.Location = New Point(207, 86)
        txtdept_id.Multiline = True
        txtdept_id.Name = "txtdept_id"
        txtdept_id.Size = New Size(303, 41)
        txtdept_id.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(41, 246)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 18)
        Label5.TabIndex = 3
        Label5.Text = "STATUS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(41, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 18)
        Label3.TabIndex = 1
        Label3.Text = "DEPARTMENT NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(41, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 18)
        Label2.TabIndex = 0
        Label2.Text = "DEPARTMENT ID"
        ' 
        ' cboFilter
        ' 
        cboFilter.FormattingEnabled = True
        cboFilter.Location = New Point(757, 59)
        cboFilter.Name = "cboFilter"
        cboFilter.Size = New Size(121, 23)
        cboFilter.TabIndex = 41
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.FlatStyle = FlatStyle.System
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(690, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 21)
        Label4.TabIndex = 42
        Label4.Text = "FILTER:"
        ' 
        ' department
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1046, 656)
        Controls.Add(Label4)
        Controls.Add(cboFilter)
        Controls.Add(createPnl2)
        Controls.Add(createLbl)
        Controls.Add(Label1)
        Controls.Add(DGVDepartment)
        FormBorderStyle = FormBorderStyle.None
        Name = "department"
        Text = "department"
        CType(DGVDepartment, ComponentModel.ISupportInitialize).EndInit()
        createPnl2.ResumeLayout(False)
        createPnl2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGVDepartment As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents createLbl As Label
    Friend WithEvents createPnl2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents btnSave As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents txtdeptname As TextBox
    Friend WithEvents txtdept_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboFilter As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dept_id As DataGridViewTextBoxColumn
    Friend WithEvents dept As DataGridViewTextBoxColumn
    Friend WithEvents course As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents delete As DataGridViewButtonColumn
End Class
