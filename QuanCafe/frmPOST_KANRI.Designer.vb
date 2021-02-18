<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOST_KANRI
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txbPOST_KANRI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txbPOST = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbADDRESS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dtpkTIME = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txbTANTO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dtpkDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtgvPOST_KANRI = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbaddress1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Chon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POST_KANRI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESS_KN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPD_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPD_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPD_TANTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dtgvPOST_KANRI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txbPOST_KANRI)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(33, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 33)
        Me.Panel1.TabIndex = 0
        '
        'txbPOST_KANRI
        '
        Me.txbPOST_KANRI.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPOST_KANRI.Location = New System.Drawing.Point(127, 4)
        Me.txbPOST_KANRI.Name = "txbPOST_KANRI"
        Me.txbPOST_KANRI.Size = New System.Drawing.Size(234, 24)
        Me.txbPOST_KANRI.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "POST_KANRI"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txbPOST)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(33, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(361, 33)
        Me.Panel2.TabIndex = 2
        '
        'txbPOST
        '
        Me.txbPOST.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPOST.Location = New System.Drawing.Point(127, 4)
        Me.txbPOST.Name = "txbPOST"
        Me.txbPOST.Size = New System.Drawing.Size(234, 24)
        Me.txbPOST.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "POST"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.txbADDRESS)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(33, 94)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(361, 33)
        Me.Panel3.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.TextBox1)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Location = New System.Drawing.Point(3, 41)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(361, 33)
        Me.Panel8.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(127, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 24)
        Me.TextBox1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ADDRESS_KN"
        '
        'txbADDRESS
        '
        Me.txbADDRESS.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbADDRESS.Location = New System.Drawing.Point(127, 4)
        Me.txbADDRESS.Name = "txbADDRESS"
        Me.txbADDRESS.Size = New System.Drawing.Size(234, 24)
        Me.txbADDRESS.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ADDRESS_KN"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dtpkTIME)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(427, 51)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(377, 33)
        Me.Panel4.TabIndex = 5
        '
        'dtpkTIME
        '
        Me.dtpkTIME.CalendarFont = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpkTIME.CustomFormat = "HH:mm:ss"
        Me.dtpkTIME.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpkTIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkTIME.Location = New System.Drawing.Point(127, 3)
        Me.dtpkTIME.Name = "dtpkTIME"
        Me.dtpkTIME.Size = New System.Drawing.Size(240, 24)
        Me.dtpkTIME.TabIndex = 2
        Me.dtpkTIME.Value = New Date(2021, 2, 2, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "UPD_TIME"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txbTANTO)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(427, 90)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(377, 33)
        Me.Panel5.TabIndex = 4
        '
        'txbTANTO
        '
        Me.txbTANTO.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTANTO.Location = New System.Drawing.Point(127, 4)
        Me.txbTANTO.Name = "txbTANTO"
        Me.txbTANTO.Size = New System.Drawing.Size(240, 24)
        Me.txbTANTO.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "UPD_TANTO"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dtpkDATE)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(427, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(377, 33)
        Me.Panel6.TabIndex = 3
        '
        'dtpkDATE
        '
        Me.dtpkDATE.CalendarFont = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpkDATE.CustomFormat = "MM/dd/yyyy"
        Me.dtpkDATE.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpkDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkDATE.Location = New System.Drawing.Point(127, 6)
        Me.dtpkDATE.Name = "dtpkDATE"
        Me.dtpkDATE.Size = New System.Drawing.Size(240, 24)
        Me.dtpkDATE.TabIndex = 1
        Me.dtpkDATE.Value = New Date(2021, 2, 2, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "UPD_DATE"
        '
        'dtgvPOST_KANRI
        '
        Me.dtgvPOST_KANRI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvPOST_KANRI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.POST_KANRI, Me.POST, Me.ADDRESS1, Me.ADDRESS_KN, Me.UPD_DATE, Me.UPD_TIME, Me.UPD_TANTO})
        Me.dtgvPOST_KANRI.Location = New System.Drawing.Point(8, 172)
        Me.dtgvPOST_KANRI.Name = "dtgvPOST_KANRI"
        Me.dtgvPOST_KANRI.ReadOnly = True
        Me.dtgvPOST_KANRI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvPOST_KANRI.Size = New System.Drawing.Size(839, 224)
        Me.dtgvPOST_KANRI.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btndelete)
        Me.Panel7.Controls.Add(Me.btnSave)
        Me.Panel7.Location = New System.Drawing.Point(281, 396)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(319, 59)
        Me.Panel7.TabIndex = 7
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(170, 17)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 1
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(32, 17)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.txbaddress1)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(33, 133)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(361, 33)
        Me.Panel9.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.TextBox2)
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Location = New System.Drawing.Point(3, 41)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(361, 33)
        Me.Panel10.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(127, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(234, 24)
        Me.TextBox2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ADDRESS_KN"
        '
        'txbaddress1
        '
        Me.txbaddress1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbaddress1.Location = New System.Drawing.Point(127, 4)
        Me.txbaddress1.Name = "txbaddress1"
        Me.txbaddress1.Size = New System.Drawing.Size(234, 24)
        Me.txbaddress1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ADDRESS1"
        '
        'Chon
        '
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.ReadOnly = True
        Me.Chon.Width = 50
        '
        'POST_KANRI
        '
        Me.POST_KANRI.HeaderText = "POST_KANRI"
        Me.POST_KANRI.Name = "POST_KANRI"
        Me.POST_KANRI.ReadOnly = True
        '
        'POST
        '
        Me.POST.HeaderText = "POST"
        Me.POST.Name = "POST"
        Me.POST.ReadOnly = True
        '
        'ADDRESS1
        '
        Me.ADDRESS1.HeaderText = "ADDRESS1"
        Me.ADDRESS1.Name = "ADDRESS1"
        Me.ADDRESS1.ReadOnly = True
        Me.ADDRESS1.Width = 160
        '
        'ADDRESS_KN
        '
        Me.ADDRESS_KN.HeaderText = "ADDRESS_KN"
        Me.ADDRESS_KN.Name = "ADDRESS_KN"
        Me.ADDRESS_KN.ReadOnly = True
        Me.ADDRESS_KN.Width = 160
        '
        'UPD_DATE
        '
        Me.UPD_DATE.HeaderText = "UPD_DATE"
        Me.UPD_DATE.Name = "UPD_DATE"
        Me.UPD_DATE.ReadOnly = True
        Me.UPD_DATE.Width = 80
        '
        'UPD_TIME
        '
        Me.UPD_TIME.HeaderText = "UPD_TIME"
        Me.UPD_TIME.Name = "UPD_TIME"
        Me.UPD_TIME.ReadOnly = True
        Me.UPD_TIME.Width = 80
        '
        'UPD_TANTO
        '
        Me.UPD_TANTO.HeaderText = "UPD_TANTO"
        Me.UPD_TANTO.Name = "UPD_TANTO"
        Me.UPD_TANTO.ReadOnly = True
        '
        'frmPOST_KANRI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 450)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.dtgvPOST_KANRI)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPOST_KANRI"
        Me.Text = "frmPOST_KANRI"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dtgvPOST_KANRI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txbPOST_KANRI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txbPOST As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txbADDRESS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txbTANTO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dtgvPOST_KANRI As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btndelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpkDATE As DateTimePicker
    Friend WithEvents dtpkTIME As DateTimePicker
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txbaddress1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Chon As DataGridViewTextBoxColumn
    Friend WithEvents POST_KANRI As DataGridViewTextBoxColumn
    Friend WithEvents POST As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS1 As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS_KN As DataGridViewTextBoxColumn
    Friend WithEvents UPD_DATE As DataGridViewTextBoxColumn
    Friend WithEvents UPD_TIME As DataGridViewTextBoxColumn
    Friend WithEvents UPD_TANTO As DataGridViewTextBoxColumn
End Class
