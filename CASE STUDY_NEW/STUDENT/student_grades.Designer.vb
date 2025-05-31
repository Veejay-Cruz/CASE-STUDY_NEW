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
        Label1 = New Label()
        Label2 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        AloneComboBox1 = New ReaLTaiizor.Controls.AloneComboBox()
        printBtn = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 0
        Label1.Text = "View Grades"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
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
        AloneComboBox1.Location = New Point(54, 120)
        AloneComboBox1.Margin = New Padding(3, 4, 3, 4)
        AloneComboBox1.Name = "AloneComboBox1"
        AloneComboBox1.Size = New Size(215, 26)
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
        printBtn.Location = New Point(855, 721)
        printBtn.Margin = New Padding(3, 4, 3, 4)
        printBtn.Name = "printBtn"
        printBtn.Size = New Size(107, 45)
        printBtn.TabIndex = 14
        printBtn.Text = "PRINT"
        printBtn.TextAlign = ContentAlignment.MiddleRight
        printBtn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(54, 179)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(909, 504)
        DataGridView1.TabIndex = 15
        ' 
        ' student_grades
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1011, 815)
        Controls.Add(DataGridView1)
        Controls.Add(printBtn)
        Controls.Add(AloneComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "student_grades"
        StartPosition = FormStartPosition.CenterScreen
        Text = "student_grades"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents AloneComboBox1 As ReaLTaiizor.Controls.AloneComboBox
    Friend WithEvents printBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
