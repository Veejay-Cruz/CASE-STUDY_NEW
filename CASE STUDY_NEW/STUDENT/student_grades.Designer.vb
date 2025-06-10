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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label2 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        AloneComboBox1 = New ReaLTaiizor.Controls.AloneComboBox()
        printBtn = New Button()
        DGVSub = New DataGridView()
        sub_code = New DataGridViewTextBoxColumn()
        ssub = New DataGridViewTextBoxColumn()
        unitt = New DataGridViewTextBoxColumn()
        CType(DGVSub, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 0
        Label1.Text = "View Grades"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 1
        Label2.Text = "School Year"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' AloneComboBox1
        ' 
        AloneComboBox1.DrawMode = DrawMode.OwnerDrawFixed
        AloneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        AloneComboBox1.EnabledCalc = True
        AloneComboBox1.FormattingEnabled = True
        AloneComboBox1.ItemHeight = 20
        AloneComboBox1.Location = New Point(47, 90)
        AloneComboBox1.Name = "AloneComboBox1"
        AloneComboBox1.Size = New Size(189, 26)
        AloneComboBox1.TabIndex = 4
        ' 
        ' printBtn
        ' 
        printBtn.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        printBtn.FlatAppearance.BorderSize = 0
        printBtn.FlatStyle = FlatStyle.Flat
        printBtn.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        printBtn.Image = CType(resources.GetObject("printBtn.Image"), Image)
        printBtn.ImageAlign = ContentAlignment.MiddleLeft
        printBtn.Location = New Point(779, 99)
        printBtn.Name = "printBtn"
        printBtn.Size = New Size(94, 34)
        printBtn.TabIndex = 14
        printBtn.Text = "PRINT"
        printBtn.TextAlign = ContentAlignment.MiddleRight
        printBtn.UseVisualStyleBackColor = False
        ' 
        ' DGVSub
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DGVSub.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGVSub.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGVSub.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGVSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVSub.Columns.AddRange(New DataGridViewColumn() {sub_code, ssub, unitt})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DGVSub.DefaultCellStyle = DataGridViewCellStyle5
        DGVSub.EnableHeadersVisualStyles = False
        DGVSub.Location = New Point(12, 139)
        DGVSub.Name = "DGVSub"
        DGVSub.ReadOnly = True
        DGVSub.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DGVSub.RowsDefaultCellStyle = DataGridViewCellStyle6
        DGVSub.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVSub.Size = New Size(861, 396)
        DGVSub.TabIndex = 41
        ' 
        ' sub_code
        ' 
        sub_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        sub_code.DefaultCellStyle = DataGridViewCellStyle3
        sub_code.HeaderText = "SUBJECT CODE"
        sub_code.Name = "sub_code"
        sub_code.ReadOnly = True
        sub_code.Width = 125
        ' 
        ' ssub
        ' 
        ssub.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        ssub.DefaultCellStyle = DataGridViewCellStyle4
        ssub.HeaderText = "SUBJECT"
        ssub.Name = "ssub"
        ssub.ReadOnly = True
        ' 
        ' unitt
        ' 
        unitt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        unitt.HeaderText = "UNIT"
        unitt.Name = "unitt"
        unitt.ReadOnly = True
        unitt.Width = 60
        ' 
        ' student_grades
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(885, 611)
        Controls.Add(DGVSub)
        Controls.Add(printBtn)
        Controls.Add(AloneComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "student_grades"
        StartPosition = FormStartPosition.CenterScreen
        Text = "student_grades"
        CType(DGVSub, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents AloneComboBox1 As ReaLTaiizor.Controls.AloneComboBox
    Friend WithEvents printBtn As Button
    Friend WithEvents DGVSub As DataGridView
    Friend WithEvents sub_code As DataGridViewTextBoxColumn
    Friend WithEvents ssub As DataGridViewTextBoxColumn
    Friend WithEvents unitt As DataGridViewTextBoxColumn
End Class
