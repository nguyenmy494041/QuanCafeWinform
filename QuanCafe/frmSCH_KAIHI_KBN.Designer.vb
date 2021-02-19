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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCalendarColumnStyle1 = New ICCControl.DataGridViewCalendarColumnStyle()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnesc = New ICCControl.CC_Button()
        Me.btnf5 = New ICCControl.CC_Button()
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
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE, Me.SCH_KAIHI_KBN, Me.CD_NAME, Me.KAIHI, Me.UPD_DATE, Me.UPD_TANGO})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 185)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "SCH_KAIHI_KBN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "CD_NAME"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "KAIHI"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewCalendarColumnStyle1
        '
        Me.DataGridViewCalendarColumnStyle1.Format = ""
        Me.DataGridViewCalendarColumnStyle1.HeaderText = "UPD_DATE"
        Me.DataGridViewCalendarColumnStyle1.Name = "DataGridViewCalendarColumnStyle1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "UPD_TANGO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'btnesc
        '
        Me.btnesc.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnesc.Location = New System.Drawing.Point(209, 215)
        Me.btnesc.Name = "btnesc"
        Me.btnesc.Size = New System.Drawing.Size(75, 23)
        Me.btnesc.TabIndex = 2
        Me.btnesc.Text = "ESC"
        Me.btnesc.UseVisualStyleBackColor = True
        '
        'btnf5
        '
        Me.btnf5.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnf5.Location = New System.Drawing.Point(320, 215)
        Me.btnf5.Name = "btnf5"
        Me.btnf5.Size = New System.Drawing.Size(75, 23)
        Me.btnf5.TabIndex = 1
        Me.btnf5.Text = "F5"
        Me.btnf5.UseVisualStyleBackColor = True
        '
        'DELETE
        '
        Me.DELETE.HeaderText = "DELETE"
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Width = 50
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
        Me.CD_NAME.Width = 200
        '
        'KAIHI
        '
        Me.KAIHI.HeaderText = "KAIHI"
        Me.KAIHI.Name = "KAIHI"
        Me.KAIHI.Width = 70
        '
        'UPD_DATE
        '
        Me.UPD_DATE.Format = ""
        Me.UPD_DATE.HeaderText = "UPD_DATE"
        Me.UPD_DATE.Name = "UPD_DATE"
        Me.UPD_DATE.Width = 80
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
        Me.ClientSize = New System.Drawing.Size(668, 247)
        Me.Controls.Add(Me.btnesc)
        Me.Controls.Add(Me.btnf5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmSCH_KAIHI_KBN"
        Me.Text = "frmSCH_KAIHI_KBN"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnf5 As ICCControl.CC_Button
    Friend WithEvents btnesc As ICCControl.CC_Button
    Friend WithEvents DELETE As DataGridViewCheckBoxColumn
    Friend WithEvents SCH_KAIHI_KBN As DataGridViewTextBoxColumn
    Friend WithEvents CD_NAME As DataGridViewComboBoxColumn
    Friend WithEvents KAIHI As DataGridViewTextBoxColumn
    Friend WithEvents UPD_DATE As ICCControl.DataGridViewCalendarColumnStyle
    Friend WithEvents UPD_TANGO As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCalendarColumnStyle1 As ICCControl.DataGridViewCalendarColumnStyle
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
