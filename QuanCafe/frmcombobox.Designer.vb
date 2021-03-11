<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcombobox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcombobox))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnopoen = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSCHKAIHI = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.dtgv = New ICCControl.CC_DataGridView()
        Me.DELETE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SCH_KAIHI_KBN = New ICCControl.CC_DataGridViewColumnNumber()
        Me.CD_NAME = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.KAIHI = New ICCControl.CC_DataGridViewColumnNumber()
        Me.UPD_DATE = New ICCControl.DataGridViewCalendarColumnStyle()
        Me.TANGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrint.Location = New System.Drawing.Point(216, 225)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.OriginAtMargins = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Location = New System.Drawing.Point(345, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "export"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnopoen
        '
        Me.btnopoen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnopoen.Location = New System.Drawing.Point(476, 225)
        Me.btnopoen.Name = "btnopoen"
        Me.btnopoen.Size = New System.Drawing.Size(75, 23)
        Me.btnopoen.TabIndex = 4
        Me.btnopoen.Text = "Open"
        Me.btnopoen.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnupdate.Location = New System.Drawing.Point(74, 225)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 5
        Me.btnupdate.Text = "UpdateDB"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSCHKAIHI
        '
        Me.btnSCHKAIHI.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSCHKAIHI.Location = New System.Drawing.Point(585, 225)
        Me.btnSCHKAIHI.Name = "btnSCHKAIHI"
        Me.btnSCHKAIHI.Size = New System.Drawing.Size(75, 23)
        Me.btnSCHKAIHI.TabIndex = 6
        Me.btnSCHKAIHI.Text = "exportSCHKAIHI"
        Me.btnSCHKAIHI.UseVisualStyleBackColor = True
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'dtgv
        '
        Me.dtgv.AllowUserToDeleteRows = False
        Me.dtgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE, Me.SCH_KAIHI_KBN, Me.CD_NAME, Me.KAIHI, Me.UPD_DATE, Me.TANGO})
        Me.dtgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgv.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.dtgv.ListColMapping = CType(resources.GetObject("dtgv.ListColMapping"), System.Collections.Generic.List(Of System.Collections.Generic.KeyValuePair(Of String, String)))
        Me.dtgv.Location = New System.Drawing.Point(13, 13)
        Me.dtgv.MultiSelect = False
        Me.dtgv.Name = "dtgv"
        Me.dtgv.Size = New System.Drawing.Size(647, 185)
        Me.dtgv.TabIndex = 2
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.UPD_DATE.DefaultCellStyle = DataGridViewCellStyle1
        Me.UPD_DATE.Format = ""
        Me.UPD_DATE.HeaderText = "UPD_DATE"
        Me.UPD_DATE.Name = "UPD_DATE"
        '
        'TANGO
        '
        Me.TANGO.HeaderText = "TANGO"
        Me.TANGO.Name = "TANGO"
        '
        'frmcombobox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 275)
        Me.Controls.Add(Me.btnSCHKAIHI)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnopoen)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtgv)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "frmcombobox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmcombobox"
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents dtgv As ICCControl.CC_DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button2 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnopoen As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSCHKAIHI As Button
    Friend WithEvents DELETE As DataGridViewCheckBoxColumn
    Friend WithEvents SCH_KAIHI_KBN As ICCControl.CC_DataGridViewColumnNumber
    Friend WithEvents CD_NAME As DataGridViewComboBoxColumn
    Friend WithEvents KAIHI As ICCControl.CC_DataGridViewColumnNumber
    Friend WithEvents UPD_DATE As ICCControl.DataGridViewCalendarColumnStyle
    Friend WithEvents TANGO As DataGridViewTextBoxColumn
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
End Class
