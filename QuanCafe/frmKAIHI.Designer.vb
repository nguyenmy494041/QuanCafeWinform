<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKAIHI
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgvKAIHI = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnf5 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnesc = New Guna.UI2.WinForms.Guna2Button()
        Me.clmDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.clmSCHKAIHIKBN = New ICCControl.CC_DataGridViewColumnNumber()
        Me.clmName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmKAIHI = New ICCControl.CC_DataGridViewColumnNumber()
        Me.clmUPDDATE = New ICCControl.DataGridViewCalendarColumnStyle()
        Me.clmTANGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgvKAIHI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvKAIHI
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dtgvKAIHI.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvKAIHI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvKAIHI.BackgroundColor = System.Drawing.Color.White
        Me.dtgvKAIHI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvKAIHI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgvKAIHI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvKAIHI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgvKAIHI.ColumnHeadersHeight = 21
        Me.dtgvKAIHI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmDelete, Me.clmSCHKAIHIKBN, Me.clmName, Me.clmKAIHI, Me.clmUPDDATE, Me.clmTANGO})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvKAIHI.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgvKAIHI.EnableHeadersVisualStyles = False
        Me.dtgvKAIHI.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgvKAIHI.Location = New System.Drawing.Point(12, 26)
        Me.dtgvKAIHI.Name = "dtgvKAIHI"
        Me.dtgvKAIHI.RowHeadersVisible = False
        Me.dtgvKAIHI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvKAIHI.Size = New System.Drawing.Size(722, 235)
        Me.dtgvKAIHI.TabIndex = 0
        Me.dtgvKAIHI.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dtgvKAIHI.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgvKAIHI.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtgvKAIHI.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtgvKAIHI.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtgvKAIHI.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtgvKAIHI.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgvKAIHI.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgvKAIHI.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgvKAIHI.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgvKAIHI.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgvKAIHI.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgvKAIHI.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgvKAIHI.ThemeStyle.HeaderStyle.Height = 21
        Me.dtgvKAIHI.ThemeStyle.ReadOnly = False
        Me.dtgvKAIHI.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgvKAIHI.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgvKAIHI.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgvKAIHI.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgvKAIHI.ThemeStyle.RowsStyle.Height = 22
        Me.dtgvKAIHI.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgvKAIHI.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnf5
        '
        Me.btnf5.BorderRadius = 15
        Me.btnf5.CheckedState.Parent = Me.btnf5
        Me.btnf5.CustomImages.Parent = Me.btnf5
        Me.btnf5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnf5.ForeColor = System.Drawing.Color.White
        Me.btnf5.HoverState.Parent = Me.btnf5
        Me.btnf5.Location = New System.Drawing.Point(381, 279)
        Me.btnf5.Name = "btnf5"
        Me.btnf5.ShadowDecoration.Parent = Me.btnf5
        Me.btnf5.Size = New System.Drawing.Size(104, 33)
        Me.btnf5.TabIndex = 1
        Me.btnf5.Text = "F5"
        '
        'btnesc
        '
        Me.btnesc.BorderRadius = 15
        Me.btnesc.CheckedState.Parent = Me.btnesc
        Me.btnesc.CustomImages.Parent = Me.btnesc
        Me.btnesc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnesc.ForeColor = System.Drawing.Color.White
        Me.btnesc.HoverState.Parent = Me.btnesc
        Me.btnesc.Location = New System.Drawing.Point(204, 279)
        Me.btnesc.Name = "btnesc"
        Me.btnesc.ShadowDecoration.Parent = Me.btnesc
        Me.btnesc.Size = New System.Drawing.Size(104, 33)
        Me.btnesc.TabIndex = 2
        Me.btnesc.Text = "ESC"
        '
        'clmDelete
        '
        Me.clmDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmDelete.HeaderText = "DELETE"
        Me.clmDelete.Name = "clmDelete"
        Me.clmDelete.Width = 80
        '
        'clmSCHKAIHIKBN
        '
        Me.clmSCHKAIHIKBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmSCHKAIHIKBN.HeaderText = "SCH_KAIHI_KBN"
        Me.clmSCHKAIHIKBN.Name = "clmSCHKAIHIKBN"
        '
        'clmName
        '
        Me.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmName.HeaderText = "CD_NAME"
        Me.clmName.Name = "clmName"
        Me.clmName.Width = 150
        '
        'clmKAIHI
        '
        Me.clmKAIHI.HeaderText = "KAIHI"
        Me.clmKAIHI.Name = "clmKAIHI"
        '
        'clmUPDDATE
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmUPDDATE.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmUPDDATE.Format = ""
        Me.clmUPDDATE.HeaderText = "UPD_DATE"
        Me.clmUPDDATE.Name = "clmUPDDATE"
        Me.clmUPDDATE.ReadOnly = True
        '
        'clmTANGO
        '
        Me.clmTANGO.HeaderText = "TANGO"
        Me.clmTANGO.Name = "clmTANGO"
        Me.clmTANGO.ReadOnly = True
        '
        'frmKAIHI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 324)
        Me.Controls.Add(Me.btnesc)
        Me.Controls.Add(Me.btnf5)
        Me.Controls.Add(Me.dtgvKAIHI)
        Me.Name = "frmKAIHI"
        Me.Text = "frmKAIHI"
        CType(Me.dtgvKAIHI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgvKAIHI As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnf5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnesc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clmDelete As DataGridViewCheckBoxColumn
    Friend WithEvents clmSCHKAIHIKBN As ICCControl.CC_DataGridViewColumnNumber
    Friend WithEvents clmName As DataGridViewComboBoxColumn
    Friend WithEvents clmKAIHI As ICCControl.CC_DataGridViewColumnNumber
    Friend WithEvents clmUPDDATE As ICCControl.DataGridViewCalendarColumnStyle
    Friend WithEvents clmTANGO As DataGridViewTextBoxColumn
End Class
