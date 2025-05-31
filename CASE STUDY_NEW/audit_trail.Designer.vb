<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class audit_trail
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        DGV2 = New DataGridView()
        uname = New DataGridViewTextBoxColumn()
        dt = New DataGridViewTextBoxColumn()
        action = New DataGridViewTextBoxColumn()
        closeLbl = New Label()
        searchTxt = New TextBox()
        Label2 = New Label()
        CType(DGV2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 38)
        Label1.TabIndex = 0
        Label1.Text = "AUDIT TRAIL"
        ' 
        ' DGV2
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DGV2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DGV2.BackgroundColor = SystemColors.ControlLight
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle8.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DGV2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        DGV2.ColumnHeadersHeight = 35
        DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGV2.Columns.AddRange(New DataGridViewColumn() {uname, dt, action})
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = SystemColors.Window
        DataGridViewCellStyle12.Font = New Font("Century Gothic", 9.75F)
        DataGridViewCellStyle12.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        DGV2.DefaultCellStyle = DataGridViewCellStyle12
        DGV2.EnableHeadersVisualStyles = False
        DGV2.Location = New Point(0, 103)
        DGV2.Name = "DGV2"
        DGV2.RowHeadersVisible = False
        DGV2.RowHeadersWidth = 51
        DGV2.Size = New Size(1610, 978)
        DGV2.TabIndex = 1
        ' 
        ' uname
        ' 
        uname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.Black
        uname.DefaultCellStyle = DataGridViewCellStyle9
        uname.FillWeight = 7.614212F
        uname.HeaderText = "USERNAME"
        uname.MinimumWidth = 6
        uname.Name = "uname"
        uname.Resizable = DataGridViewTriState.False
        uname.Width = 101
        ' 
        ' dt
        ' 
        dt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = Color.Black
        dt.DefaultCellStyle = DataGridViewCellStyle10
        dt.FillWeight = 7.614212F
        dt.HeaderText = "DATE & TIME"
        dt.MinimumWidth = 6
        dt.Name = "dt"
        dt.Width = 108
        ' 
        ' action
        ' 
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle11.ForeColor = Color.Black
        action.DefaultCellStyle = DataGridViewCellStyle11
        action.FillWeight = 284.771576F
        action.HeaderText = "ACTION"
        action.MinimumWidth = 6
        action.Name = "action"
        action.Width = 1527
        ' 
        ' closeLbl
        ' 
        closeLbl.AutoSize = True
        closeLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        closeLbl.ForeColor = Color.Black
        closeLbl.Location = New Point(1540, 9)
        closeLbl.Name = "closeLbl"
        closeLbl.Size = New Size(60, 19)
        closeLbl.TabIndex = 6
        closeLbl.Text = "[close]"
        ' 
        ' searchTxt
        ' 
        searchTxt.BackColor = Color.Gainsboro
        searchTxt.BorderStyle = BorderStyle.None
        searchTxt.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchTxt.Location = New Point(1307, 56)
        searchTxt.Multiline = True
        searchTxt.Name = "searchTxt"
        searchTxt.Size = New Size(293, 41)
        searchTxt.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(1307, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 16)
        Label2.TabIndex = 8
        Label2.Text = "SEARCH BY USERNAME OR ACTION"
        ' 
        ' audit_trail
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.White
        ClientSize = New Size(1612, 1080)
        Controls.Add(Label2)
        Controls.Add(searchTxt)
        Controls.Add(closeLbl)
        Controls.Add(DGV2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "audit_trail"
        StartPosition = FormStartPosition.CenterScreen
        Text = "audit_trail"
        CType(DGV2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents closeLbl As Label
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents uname As DataGridViewTextBoxColumn
    Friend WithEvents dt As DataGridViewTextBoxColumn
    Friend WithEvents action As DataGridViewTextBoxColumn
End Class
