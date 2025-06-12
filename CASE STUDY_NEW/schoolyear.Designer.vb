<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class schoolyear
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
        Panel3 = New Panel()
        radFinals = New ReaLTaiizor.Controls.ParrotRadioButton()
        radPrefinal = New ReaLTaiizor.Controls.ParrotRadioButton()
        Panel4 = New Panel()
        Label5 = New Label()
        radPrelim = New ReaLTaiizor.Controls.ParrotRadioButton()
        radMidterm = New ReaLTaiizor.Controls.ParrotRadioButton()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label4 = New Label()
        radFirstsem = New ReaLTaiizor.Controls.ParrotRadioButton()
        radSecsem = New ReaLTaiizor.Controls.ParrotRadioButton()
        Label8 = New Label()
        btnAddSchoolYear = New Button()
        DGVSchoolyear = New DataGridView()
        school_yr = New DataGridViewTextBoxColumn()
        schoolyr_status = New DataGridViewTextBoxColumn()
        pnlAddSchoolYear = New Panel()
        Label3 = New Label()
        btnCancel = New Button()
        btnSave = New Button()
        Label2 = New Label()
        cboStatus = New ComboBox()
        txtSchoolYear = New TextBox()
        Label1 = New Label()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DGVSchoolyear, ComponentModel.ISupportInitialize).BeginInit()
        pnlAddSchoolYear.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonHighlight
        Panel3.Controls.Add(radFinals)
        Panel3.Controls.Add(radPrefinal)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(radPrelim)
        Panel3.Controls.Add(radMidterm)
        Panel3.Location = New Point(42, 352)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 216)
        Panel3.TabIndex = 34
        ' 
        ' radFinals
        ' 
        radFinals.Checked = False
        radFinals.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radFinals.ForeColor = Color.Black
        radFinals.Location = New Point(35, 171)
        radFinals.Name = "radFinals"
        radFinals.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        radFinals.RadioColor = Color.Gold
        radFinals.RadioHoverColor = Color.FromArgb(CByte(0), CByte(162), CByte(250))
        radFinals.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material
        radFinals.Size = New Size(132, 21)
        radFinals.SmoothingType = Drawing2D.SmoothingMode.AntiAlias
        radFinals.TabIndex = 31
        radFinals.Text = "FINALS"
        radFinals.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' radPrefinal
        ' 
        radPrefinal.Checked = False
        radPrefinal.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radPrefinal.ForeColor = Color.Black
        radPrefinal.Location = New Point(34, 135)
        radPrefinal.Name = "radPrefinal"
        radPrefinal.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        radPrefinal.RadioColor = Color.Gold
        radPrefinal.RadioHoverColor = Color.FromArgb(CByte(0), CByte(162), CByte(250))
        radPrefinal.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material
        radPrefinal.Size = New Size(132, 21)
        radPrefinal.SmoothingType = Drawing2D.SmoothingMode.AntiAlias
        radPrefinal.TabIndex = 30
        radPrefinal.Text = "PREFINAL"
        radPrefinal.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 44)
        Panel4.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(76, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 21)
        Label5.TabIndex = 30
        Label5.Text = "TERM"
        ' 
        ' radPrelim
        ' 
        radPrelim.Checked = False
        radPrelim.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radPrelim.ForeColor = Color.Black
        radPrelim.Location = New Point(35, 63)
        radPrelim.Name = "radPrelim"
        radPrelim.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        radPrelim.RadioColor = Color.Gold
        radPrelim.RadioHoverColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        radPrelim.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material
        radPrelim.Size = New Size(132, 21)
        radPrelim.SmoothingType = Drawing2D.SmoothingMode.AntiAlias
        radPrelim.TabIndex = 27
        radPrelim.Text = "PRELIM"
        radPrelim.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' radMidterm
        ' 
        radMidterm.Checked = False
        radMidterm.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radMidterm.ForeColor = Color.Black
        radMidterm.Location = New Point(35, 99)
        radMidterm.Name = "radMidterm"
        radMidterm.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        radMidterm.RadioColor = Color.Gold
        radMidterm.RadioHoverColor = Color.FromArgb(CByte(0), CByte(162), CByte(250))
        radMidterm.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material
        radMidterm.Size = New Size(132, 21)
        radMidterm.SmoothingType = Drawing2D.SmoothingMode.AntiAlias
        radMidterm.TabIndex = 28
        radMidterm.Text = "MIDTERM"
        radMidterm.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(radFirstsem)
        Panel1.Controls.Add(radSecsem)
        Panel1.Location = New Point(42, 180)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 151)
        Panel1.TabIndex = 33
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 44)
        Panel2.TabIndex = 29
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(61, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 21)
        Label4.TabIndex = 30
        Label4.Text = "SEMESTER"
        ' 
        ' radFirstsem
        ' 
        radFirstsem.Checked = False
        radFirstsem.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radFirstsem.ForeColor = Color.Black
        radFirstsem.Location = New Point(35, 63)
        radFirstsem.Name = "radFirstsem"
        radFirstsem.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        radFirstsem.RadioColor = Color.Gold
        radFirstsem.RadioHoverColor = Color.FromArgb(CByte(0), CByte(162), CByte(250))
        radFirstsem.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material
        radFirstsem.Size = New Size(132, 21)
        radFirstsem.SmoothingType = Drawing2D.SmoothingMode.AntiAlias
        radFirstsem.TabIndex = 27
        radFirstsem.Text = "1ST SEMESTER"
        radFirstsem.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' radSecsem
        ' 
        radSecsem.Checked = False
        radSecsem.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radSecsem.ForeColor = Color.Black
        radSecsem.Location = New Point(35, 99)
        radSecsem.Name = "radSecsem"
        radSecsem.PixelOffsetType = Drawing2D.PixelOffsetMode.HighQuality
        radSecsem.RadioColor = Color.Gold
        radSecsem.RadioHoverColor = Color.FromArgb(CByte(0), CByte(162), CByte(250))
        radSecsem.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material
        radSecsem.Size = New Size(132, 21)
        radSecsem.SmoothingType = Drawing2D.SmoothingMode.AntiAlias
        radSecsem.TabIndex = 28
        radSecsem.Text = "2ND SEMESTER"
        radSecsem.TextRenderingType = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(31, 35)
        Label8.Name = "Label8"
        Label8.Size = New Size(238, 39)
        Label8.TabIndex = 32
        Label8.Text = "SCHOOL YEAR"
        ' 
        ' btnAddSchoolYear
        ' 
        btnAddSchoolYear.Location = New Point(42, 91)
        btnAddSchoolYear.Name = "btnAddSchoolYear"
        btnAddSchoolYear.Size = New Size(199, 30)
        btnAddSchoolYear.TabIndex = 31
        btnAddSchoolYear.Text = "Add School Year"
        btnAddSchoolYear.UseVisualStyleBackColor = True
        ' 
        ' DGVSchoolyear
        ' 
        DGVSchoolyear.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DGVSchoolyear.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGVSchoolyear.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGVSchoolyear.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGVSchoolyear.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVSchoolyear.Columns.AddRange(New DataGridViewColumn() {school_yr, schoolyr_status})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DGVSchoolyear.DefaultCellStyle = DataGridViewCellStyle5
        DGVSchoolyear.EnableHeadersVisualStyles = False
        DGVSchoolyear.Location = New Point(321, 91)
        DGVSchoolyear.Name = "DGVSchoolyear"
        DGVSchoolyear.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(44), CByte(60), CByte(79))
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DGVSchoolyear.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DGVSchoolyear.Size = New Size(573, 554)
        DGVSchoolyear.TabIndex = 35
        ' 
        ' school_yr
        ' 
        school_yr.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        school_yr.DefaultCellStyle = DataGridViewCellStyle3
        school_yr.HeaderText = "SCHOOL YEAR"
        school_yr.Name = "school_yr"
        school_yr.ReadOnly = True
        ' 
        ' schoolyr_status
        ' 
        schoolyr_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        schoolyr_status.DefaultCellStyle = DataGridViewCellStyle4
        schoolyr_status.HeaderText = "STATUS"
        schoolyr_status.Name = "schoolyr_status"
        schoolyr_status.ReadOnly = True
        ' 
        ' pnlAddSchoolYear
        ' 
        pnlAddSchoolYear.BackColor = SystemColors.Highlight
        pnlAddSchoolYear.Controls.Add(Label3)
        pnlAddSchoolYear.Controls.Add(btnCancel)
        pnlAddSchoolYear.Controls.Add(btnSave)
        pnlAddSchoolYear.Controls.Add(Label2)
        pnlAddSchoolYear.Controls.Add(cboStatus)
        pnlAddSchoolYear.Controls.Add(txtSchoolYear)
        pnlAddSchoolYear.Controls.Add(Label1)
        pnlAddSchoolYear.Location = New Point(468, 243)
        pnlAddSchoolYear.Name = "pnlAddSchoolYear"
        pnlAddSchoolYear.Size = New Size(297, 321)
        pnlAddSchoolYear.TabIndex = 36
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Gold
        Label3.Location = New Point(106, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 15)
        Label3.TabIndex = 6
        Label3.Text = "Add School Year"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(159, 273)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 5
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(61, 273)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 4
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gold
        Label2.Location = New Point(61, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 3
        Label2.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Open", "Closed"})
        cboStatus.Location = New Point(61, 216)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(173, 23)
        cboStatus.TabIndex = 2
        ' 
        ' txtSchoolYear
        ' 
        txtSchoolYear.Location = New Point(61, 126)
        txtSchoolYear.Name = "txtSchoolYear"
        txtSchoolYear.Size = New Size(173, 23)
        txtSchoolYear.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Gold
        Label1.Location = New Point(61, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 0
        Label1.Text = "School Year"
        ' 
        ' schoolyear
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(906, 657)
        Controls.Add(pnlAddSchoolYear)
        Controls.Add(DGVSchoolyear)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Label8)
        Controls.Add(btnAddSchoolYear)
        FormBorderStyle = FormBorderStyle.None
        Name = "schoolyear"
        Text = "schoolyear"
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DGVSchoolyear, ComponentModel.ISupportInitialize).EndInit()
        pnlAddSchoolYear.ResumeLayout(False)
        pnlAddSchoolYear.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents radFinals As ReaLTaiizor.Controls.ParrotRadioButton
    Friend WithEvents radPrefinal As ReaLTaiizor.Controls.ParrotRadioButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents radPrelim As ReaLTaiizor.Controls.ParrotRadioButton
    Friend WithEvents radMidterm As ReaLTaiizor.Controls.ParrotRadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents radFirstsem As ReaLTaiizor.Controls.ParrotRadioButton
    Friend WithEvents radSecsem As ReaLTaiizor.Controls.ParrotRadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddSchoolYear As Button
    Friend WithEvents DGVSchoolyear As DataGridView
    Friend WithEvents school_yr As DataGridViewTextBoxColumn
    Friend WithEvents schoolyr_status As DataGridViewTextBoxColumn
    Friend WithEvents pnlAddSchoolYear As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents txtSchoolYear As TextBox
    Friend WithEvents Label1 As Label
End Class
