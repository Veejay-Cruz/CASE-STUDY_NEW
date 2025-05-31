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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        studentDataGridView1 = New ReaLTaiizor.Controls.PoisonDataGridView()
        subjectsAssignedDataGridView2 = New ReaLTaiizor.Controls.PoisonDataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(studentDataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(subjectsAssignedDataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' studentDataGridView1
        ' 
        studentDataGridView1.AllowUserToResizeRows = False
        studentDataGridView1.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        studentDataGridView1.BorderStyle = BorderStyle.None
        studentDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        studentDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(174), CByte(219))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        studentDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        studentDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        studentDataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        studentDataGridView1.EnableHeadersVisualStyles = False
        studentDataGridView1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        studentDataGridView1.GridColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        studentDataGridView1.Location = New Point(367, 135)
        studentDataGridView1.Margin = New Padding(3, 4, 3, 4)
        studentDataGridView1.Name = "studentDataGridView1"
        studentDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(0), CByte(174), CByte(219))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        studentDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        studentDataGridView1.RowHeadersWidth = 51
        studentDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        studentDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        studentDataGridView1.Size = New Size(615, 612)
        studentDataGridView1.TabIndex = 0
        ' 
        ' subjectsAssignedDataGridView2
        ' 
        subjectsAssignedDataGridView2.AllowUserToResizeRows = False
        subjectsAssignedDataGridView2.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        subjectsAssignedDataGridView2.BorderStyle = BorderStyle.None
        subjectsAssignedDataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None
        subjectsAssignedDataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(0), CByte(174), CByte(219))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        subjectsAssignedDataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        subjectsAssignedDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        subjectsAssignedDataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        subjectsAssignedDataGridView2.EnableHeadersVisualStyles = False
        subjectsAssignedDataGridView2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        subjectsAssignedDataGridView2.GridColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        subjectsAssignedDataGridView2.Location = New Point(14, 135)
        subjectsAssignedDataGridView2.Margin = New Padding(3, 4, 3, 4)
        subjectsAssignedDataGridView2.Name = "subjectsAssignedDataGridView2"
        subjectsAssignedDataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(0), CByte(174), CByte(219))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        subjectsAssignedDataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        subjectsAssignedDataGridView2.RowHeadersWidth = 51
        subjectsAssignedDataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        subjectsAssignedDataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        subjectsAssignedDataGridView2.Size = New Size(291, 612)
        subjectsAssignedDataGridView2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 20)
        Label1.TabIndex = 2
        Label1.Text = "Teaching Loads"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(374, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 20)
        Label2.TabIndex = 3
        Label2.Text = "No. of Students"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(717, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 4
        Label3.Text = "Passed"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(818, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 20)
        Label4.TabIndex = 5
        Label4.Text = "Failed"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(482, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 6
        Label5.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(765, 99)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 7
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(859, 99)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 20)
        Label7.TabIndex = 8
        Label7.Text = "Label7"
        ' 
        ' teacher_gradeentry
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1011, 815)
        ControlBox = False
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(subjectsAssignedDataGridView2)
        Controls.Add(studentDataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "teacher_gradeentry"
        StartPosition = FormStartPosition.CenterScreen
        Text = "teacher_gradeentry"
        CType(studentDataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(subjectsAssignedDataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents studentDataGridView1 As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents subjectsAssignedDataGridView2 As ReaLTaiizor.Controls.PoisonDataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
