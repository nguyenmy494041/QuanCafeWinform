<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSCH_KAIHI_KBN
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DELETE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SCH_KAIHI_KBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CD_NAME = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.KAIHI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPD_DATE = New ICCControl.DataGridViewCalendarColumnStyle()
        Me.UPD_TANGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE, Me.SCH_KAIHI_KBN, Me.CD_NAME, Me.KAIHI, Me.UPD_DATE, Me.UPD_TANGO})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(648, 176)
        Me.DataGridView1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(259, 261)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'DELETE
        '
        Me.DELETE.HeaderText = "DELETE"
        Me.DELETE.Name = "DELETE"
        '
        'SCH_KAIHI_KBN
        '
        Me.SCH_KAIHI_KBN.HeaderText = "SCH_KAIHI_KBN"
        Me.SCH_KAIHI_KBN.Name = "SCH_KAIHI_KBN"
        Me.SCH_KAIHI_KBN.ReadOnly = True
        Me.SCH_KAIHI_KBN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'CD_NAME
        '
        Me.CD_NAME.HeaderText = "CD_NAME"
        Me.CD_NAME.Name = "CD_NAME"
        '
        'KAIHI
        '
        Me.KAIHI.HeaderText = "KAIHI"
        Me.KAIHI.Name = "KAIHI"
        '
        'UPD_DATE
        '
        Me.UPD_DATE.Format = ""
        Me.UPD_DATE.HeaderText = "UPD_DATE"
        Me.UPD_DATE.Name = "UPD_DATE"
        '
        'UPD_TANGO
        '
        Me.UPD_TANGO.HeaderText = "UPD_TANGO"
        Me.UPD_TANGO.Name = "UPD_TANGO"
        '
        'frmSCH_KAIHI_KBN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 326)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmSCH_KAIHI_KBN"
        Me.Text = "frmSCH_KAIHI_KBN"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DELETE As DataGridViewCheckBoxColumn
    Friend WithEvents SCH_KAIHI_KBN As DataGridViewTextBoxColumn
    Friend WithEvents CD_NAME As DataGridViewComboBoxColumn
    Friend WithEvents KAIHI As DataGridViewTextBoxColumn
    Friend WithEvents UPD_DATE As ICCControl.DataGridViewCalendarColumnStyle
    Friend WithEvents UPD_TANGO As DataGridViewTextBoxColumn
End Class
