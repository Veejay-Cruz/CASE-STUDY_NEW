<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        deleteLbl = New Label()
        closeLbl = New Label()
        createLbl = New Label()
        DGV5 = New DataGridView()
        un = New DataGridViewTextBoxColumn()
        id = New DataGridViewTextBoxColumn()
        pass = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        CType(DGV5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' deleteLbl
        ' 
        deleteLbl.AutoSize = True
        deleteLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        deleteLbl.ForeColor = Color.Black
        deleteLbl.Location = New Point(1472, 60)
        deleteLbl.Name = "deleteLbl"
        deleteLbl.Size = New Size(128, 19)
        deleteLbl.TabIndex = 11
        deleteLbl.Text = "[delete record]"
        ' 
        ' closeLbl
        ' 
        closeLbl.AutoSize = True
        closeLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        closeLbl.ForeColor = Color.Black
        closeLbl.Location = New Point(1540, 15)
        closeLbl.Name = "closeLbl"
        closeLbl.Size = New Size(60, 19)
        closeLbl.TabIndex = 10
        closeLbl.Text = "[close]"
        ' 
        ' createLbl
        ' 
        createLbl.AutoSize = True
        createLbl.Font = New Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        createLbl.ForeColor = Color.Black
        createLbl.Location = New Point(1348, 60)
        createLbl.Name = "createLbl"
        createLbl.Size = New Size(112, 19)
        createLbl.TabIndex = 9
        createLbl.Text = "[create new]"
        ' 
        ' DGV5
        ' 
        DGV5.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DGV5.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV5.BackgroundColor = SystemColors.HighlightText
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV5.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV5.Columns.AddRange(New DataGridViewColumn() {un, id, pass})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        DGV5.DefaultCellStyle = DataGridViewCellStyle6
        DGV5.Location = New Point(0, 115)
        DGV5.Name = "DGV5"
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DGV5.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DGV5.RowHeadersVisible = False
        DGV5.RowHeadersWidth = 51
        DGV5.Size = New Size(1613, 966)
        DGV5.TabIndex = 12
        ' 
        ' un
        ' 
        un.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        un.DefaultCellStyle = DataGridViewCellStyle3
        un.HeaderText = "USERNAME"
        un.MinimumWidth = 6
        un.Name = "un"
        ' 
        ' id
        ' 
        id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        id.DefaultCellStyle = DataGridViewCellStyle4
        id.HeaderText = "STUDENT ID"
        id.MinimumWidth = 6
        id.Name = "id"
        ' 
        ' pass
        ' 
        pass.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        pass.DefaultCellStyle = DataGridViewCellStyle5
        pass.HeaderText = "PASSWORD"
        pass.MinimumWidth = 6
        pass.Name = "pass"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(344, 38)
        Label1.TabIndex = 13
        Label1.Text = "USERS MANAGEMENT"
        ' 
        ' users
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1612, 1080)
        Controls.Add(Label1)
        Controls.Add(DGV5)
        Controls.Add(deleteLbl)
        Controls.Add(closeLbl)
        Controls.Add(createLbl)
        FormBorderStyle = FormBorderStyle.None
        Name = "users"
        StartPosition = FormStartPosition.CenterScreen
        Text = "users"
        CType(DGV5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents deleteLbl As Label
    Friend WithEvents closeLbl As Label
    Friend WithEvents createLbl As Label
    Friend WithEvents DGV5 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents un As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents pass As DataGridViewTextBoxColumn
End Class
