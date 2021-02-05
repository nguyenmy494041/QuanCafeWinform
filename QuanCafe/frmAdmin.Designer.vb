<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabrevenue = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtgvRevenue = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datecheckin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idtable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datecheckout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnthongke = New System.Windows.Forms.Button()
        Me.dtpktime2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpktime1 = New System.Windows.Forms.DateTimePicker()
        Me.tabfood = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.nbrpricefood = New System.Windows.Forms.NumericUpDown()
        Me.cbcategoryfood = New System.Windows.Forms.ComboBox()
        Me.txbnamefood = New System.Windows.Forms.TextBox()
        Me.txbsothutu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btndeletefood = New System.Windows.Forms.Button()
        Me.btnaddfood = New System.Windows.Forms.Button()
        Me.btneditfood = New System.Windows.Forms.Button()
        Me.btnviewfood = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtgvfood = New System.Windows.Forms.DataGridView()
        Me.Idfood = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Namefood = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pricefood = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namecate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabtable = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnsearchtable = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txbnametable = New System.Windows.Forms.TextBox()
        Me.txbidtable = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btndeletetable = New System.Windows.Forms.Button()
        Me.btnaddtable = New System.Windows.Forms.Button()
        Me.btnedittable = New System.Windows.Forms.Button()
        Me.btnviewtable = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.dtgvtable = New System.Windows.Forms.DataGridView()
        Me.Idtablee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nametablee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabcategory = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txbnamecategory = New System.Windows.Forms.TextBox()
        Me.txbidcategory = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btndeletecategory = New System.Windows.Forms.Button()
        Me.btnaddcategory = New System.Windows.Forms.Button()
        Me.btneditcategory = New System.Windows.Forms.Button()
        Me.btnviewcategory = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.dtgvcategory = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabaccount = New System.Windows.Forms.TabPage()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.txbsearchaccount = New System.Windows.Forms.TextBox()
        Me.btnsearchaccount = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.radiouser = New System.Windows.Forms.RadioButton()
        Me.radioadmin = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txbpass = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txbnameaccount = New System.Windows.Forms.TextBox()
        Me.txbsttaccount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.btndeleteaccount = New System.Windows.Forms.Button()
        Me.btnaddaccount = New System.Windows.Forms.Button()
        Me.btnviewaccount = New System.Windows.Forms.Button()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.dtgvaccount = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.tabrevenue.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgvRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tabfood.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.nbrpricefood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dtgvfood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabtable.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.dtgvtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabcategory.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.dtgvcategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabaccount.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        CType(Me.dtgvaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabrevenue)
        Me.TabControl1.Controls.Add(Me.tabfood)
        Me.TabControl1.Controls.Add(Me.tabtable)
        Me.TabControl1.Controls.Add(Me.tabcategory)
        Me.TabControl1.Controls.Add(Me.tabaccount)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(797, 448)
        Me.TabControl1.TabIndex = 0
        '
        'tabrevenue
        '
        Me.tabrevenue.Controls.Add(Me.Panel2)
        Me.tabrevenue.Controls.Add(Me.Panel1)
        Me.tabrevenue.Location = New System.Drawing.Point(4, 26)
        Me.tabrevenue.Name = "tabrevenue"
        Me.tabrevenue.Padding = New System.Windows.Forms.Padding(3)
        Me.tabrevenue.Size = New System.Drawing.Size(789, 418)
        Me.tabrevenue.TabIndex = 0
        Me.tabrevenue.Text = "Doanh thu"
        Me.tabrevenue.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgvRevenue)
        Me.Panel2.Location = New System.Drawing.Point(7, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(774, 342)
        Me.Panel2.TabIndex = 1
        '
        'dtgvRevenue
        '
        Me.dtgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvRevenue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.datecheckin, Me.Idtable, Me.datecheckout, Me.totalprice})
        Me.dtgvRevenue.Location = New System.Drawing.Point(4, 4)
        Me.dtgvRevenue.Name = "dtgvRevenue"
        Me.dtgvRevenue.Size = New System.Drawing.Size(767, 335)
        Me.dtgvRevenue.TabIndex = 0
        '
        'Id
        '
        Me.Id.HeaderText = "Số thứ tự"
        Me.Id.Name = "Id"
        Me.Id.Width = 90
        '
        'datecheckin
        '
        Me.datecheckin.HeaderText = "Giờ vào"
        Me.datecheckin.Name = "datecheckin"
        Me.datecheckin.Width = 160
        '
        'Idtable
        '
        Me.Idtable.HeaderText = "Bàn"
        Me.Idtable.Name = "Idtable"
        Me.Idtable.Width = 120
        '
        'datecheckout
        '
        Me.datecheckout.HeaderText = "Giờ ra về"
        Me.datecheckout.Name = "datecheckout"
        Me.datecheckout.Width = 160
        '
        'totalprice
        '
        Me.totalprice.HeaderText = "Tổng tiền thanh toán"
        Me.totalprice.Name = "totalprice"
        Me.totalprice.Width = 180
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnthongke)
        Me.Panel1.Controls.Add(Me.dtpktime2)
        Me.Panel1.Controls.Add(Me.dtpktime1)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(7, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 43)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Từ ngày"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "đến ngày"
        '
        'btnthongke
        '
        Me.btnthongke.Location = New System.Drawing.Point(597, 10)
        Me.btnthongke.Name = "btnthongke"
        Me.btnthongke.Size = New System.Drawing.Size(75, 23)
        Me.btnthongke.TabIndex = 2
        Me.btnthongke.Text = "Thống kê"
        Me.btnthongke.UseVisualStyleBackColor = True
        '
        'dtpktime2
        '
        Me.dtpktime2.CustomFormat = "dd/MM/yyyy"
        Me.dtpktime2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpktime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpktime2.Location = New System.Drawing.Point(357, 9)
        Me.dtpktime2.Name = "dtpktime2"
        Me.dtpktime2.Size = New System.Drawing.Size(200, 24)
        Me.dtpktime2.TabIndex = 1
        '
        'dtpktime1
        '
        Me.dtpktime1.CustomFormat = "dd/MM/yyyy"
        Me.dtpktime1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpktime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpktime1.Location = New System.Drawing.Point(83, 9)
        Me.dtpktime1.Name = "dtpktime1"
        Me.dtpktime1.Size = New System.Drawing.Size(200, 24)
        Me.dtpktime1.TabIndex = 0
        Me.dtpktime1.Value = New Date(2019, 6, 12, 0, 0, 0, 0)
        '
        'tabfood
        '
        Me.tabfood.Controls.Add(Me.Panel6)
        Me.tabfood.Controls.Add(Me.Panel5)
        Me.tabfood.Controls.Add(Me.Panel4)
        Me.tabfood.Controls.Add(Me.Panel3)
        Me.tabfood.Location = New System.Drawing.Point(4, 26)
        Me.tabfood.Name = "tabfood"
        Me.tabfood.Padding = New System.Windows.Forms.Padding(3)
        Me.tabfood.Size = New System.Drawing.Size(789, 418)
        Me.tabfood.TabIndex = 1
        Me.tabfood.Text = "Món ăn"
        Me.tabfood.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.btnsearch)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(7, 7)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(773, 43)
        Me.Panel6.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(445, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(231, 24)
        Me.TextBox1.TabIndex = 5
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(682, 12)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Tìm kiếm"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Danh sách các món ăn"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.nbrpricefood)
        Me.Panel5.Controls.Add(Me.cbcategoryfood)
        Me.Panel5.Controls.Add(Me.txbnamefood)
        Me.Panel5.Controls.Add(Me.txbsothutu)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(511, 56)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(262, 282)
        Me.Panel5.TabIndex = 2
        '
        'nbrpricefood
        '
        Me.nbrpricefood.Location = New System.Drawing.Point(72, 157)
        Me.nbrpricefood.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nbrpricefood.Name = "nbrpricefood"
        Me.nbrpricefood.Size = New System.Drawing.Size(187, 24)
        Me.nbrpricefood.TabIndex = 9
        '
        'cbcategoryfood
        '
        Me.cbcategoryfood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcategoryfood.FormattingEnabled = True
        Me.cbcategoryfood.Location = New System.Drawing.Point(72, 114)
        Me.cbcategoryfood.Name = "cbcategoryfood"
        Me.cbcategoryfood.Size = New System.Drawing.Size(187, 25)
        Me.cbcategoryfood.TabIndex = 8
        '
        'txbnamefood
        '
        Me.txbnamefood.Location = New System.Drawing.Point(72, 74)
        Me.txbnamefood.Name = "txbnamefood"
        Me.txbnamefood.Size = New System.Drawing.Size(187, 24)
        Me.txbnamefood.TabIndex = 6
        '
        'txbsothutu
        '
        Me.txbsothutu.Location = New System.Drawing.Point(72, 27)
        Me.txbsothutu.Name = "txbsothutu"
        Me.txbsothutu.ReadOnly = True
        Me.txbsothutu.Size = New System.Drawing.Size(187, 24)
        Me.txbsothutu.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Đơn giá"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Danh mục"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tên món"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Số TT"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btndeletefood)
        Me.Panel4.Controls.Add(Me.btnaddfood)
        Me.Panel4.Controls.Add(Me.btneditfood)
        Me.Panel4.Controls.Add(Me.btnviewfood)
        Me.Panel4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(6, 348)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(567, 59)
        Me.Panel4.TabIndex = 1
        '
        'btndeletefood
        '
        Me.btndeletefood.Location = New System.Drawing.Point(388, 10)
        Me.btndeletefood.Name = "btndeletefood"
        Me.btndeletefood.Size = New System.Drawing.Size(75, 39)
        Me.btndeletefood.TabIndex = 3
        Me.btndeletefood.Text = "Xóa"
        Me.btndeletefood.UseVisualStyleBackColor = True
        '
        'btnaddfood
        '
        Me.btnaddfood.Location = New System.Drawing.Point(172, 10)
        Me.btnaddfood.Name = "btnaddfood"
        Me.btnaddfood.Size = New System.Drawing.Size(91, 39)
        Me.btnaddfood.TabIndex = 2
        Me.btnaddfood.Text = "Thêm mới"
        Me.btnaddfood.UseVisualStyleBackColor = True
        '
        'btneditfood
        '
        Me.btneditfood.Location = New System.Drawing.Point(286, 10)
        Me.btneditfood.Name = "btneditfood"
        Me.btneditfood.Size = New System.Drawing.Size(75, 39)
        Me.btneditfood.TabIndex = 1
        Me.btneditfood.Text = "Sửa đổi"
        Me.btneditfood.UseVisualStyleBackColor = True
        '
        'btnviewfood
        '
        Me.btnviewfood.Location = New System.Drawing.Point(31, 10)
        Me.btnviewfood.Name = "btnviewfood"
        Me.btnviewfood.Size = New System.Drawing.Size(117, 39)
        Me.btnviewfood.TabIndex = 0
        Me.btnviewfood.Text = "Xem danh sách"
        Me.btnviewfood.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtgvfood)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(6, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(496, 282)
        Me.Panel3.TabIndex = 0
        '
        'dtgvfood
        '
        Me.dtgvfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvfood.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idfood, Me.Namefood, Me.Pricefood, Me.namecate})
        Me.dtgvfood.Location = New System.Drawing.Point(4, 4)
        Me.dtgvfood.Name = "dtgvfood"
        Me.dtgvfood.Size = New System.Drawing.Size(489, 275)
        Me.dtgvfood.TabIndex = 0
        '
        'Idfood
        '
        Me.Idfood.HeaderText = "Số TT"
        Me.Idfood.Name = "Idfood"
        Me.Idfood.Width = 70
        '
        'Namefood
        '
        Me.Namefood.HeaderText = "Tên món ăn"
        Me.Namefood.Name = "Namefood"
        Me.Namefood.Width = 200
        '
        'Pricefood
        '
        Me.Pricefood.HeaderText = "Đơn giá"
        Me.Pricefood.Name = "Pricefood"
        Me.Pricefood.Width = 80
        '
        'namecate
        '
        Me.namecate.HeaderText = "Danh mục"
        Me.namecate.Name = "namecate"
        Me.namecate.Width = 110
        '
        'tabtable
        '
        Me.tabtable.Controls.Add(Me.Panel7)
        Me.tabtable.Controls.Add(Me.Panel8)
        Me.tabtable.Controls.Add(Me.Panel9)
        Me.tabtable.Controls.Add(Me.Panel10)
        Me.tabtable.Location = New System.Drawing.Point(4, 26)
        Me.tabtable.Name = "tabtable"
        Me.tabtable.Padding = New System.Windows.Forms.Padding(3)
        Me.tabtable.Size = New System.Drawing.Size(789, 418)
        Me.tabtable.TabIndex = 2
        Me.tabtable.Text = "Bàn"
        Me.tabtable.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TextBox3)
        Me.Panel7.Controls.Add(Me.btnsearchtable)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(8, 9)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(773, 43)
        Me.Panel7.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(445, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(231, 24)
        Me.TextBox3.TabIndex = 5
        '
        'btnsearchtable
        '
        Me.btnsearchtable.Location = New System.Drawing.Point(682, 12)
        Me.btnsearchtable.Name = "btnsearchtable"
        Me.btnsearchtable.Size = New System.Drawing.Size(75, 23)
        Me.btnsearchtable.TabIndex = 4
        Me.btnsearchtable.Text = "Tìm kiếm"
        Me.btnsearchtable.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Danh sách các bàn trong quán"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txbnametable)
        Me.Panel8.Controls.Add(Me.txbidtable)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(512, 58)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(262, 282)
        Me.Panel8.TabIndex = 6
        '
        'txbnametable
        '
        Me.txbnametable.Location = New System.Drawing.Point(72, 74)
        Me.txbnametable.Name = "txbnametable"
        Me.txbnametable.Size = New System.Drawing.Size(187, 24)
        Me.txbnametable.TabIndex = 6
        '
        'txbidtable
        '
        Me.txbidtable.Location = New System.Drawing.Point(72, 27)
        Me.txbidtable.Name = "txbidtable"
        Me.txbidtable.ReadOnly = True
        Me.txbidtable.Size = New System.Drawing.Size(187, 24)
        Me.txbidtable.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Tên bàn"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Số TT"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btndeletetable)
        Me.Panel9.Controls.Add(Me.btnaddtable)
        Me.Panel9.Controls.Add(Me.btnedittable)
        Me.Panel9.Controls.Add(Me.btnviewtable)
        Me.Panel9.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(7, 350)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(567, 59)
        Me.Panel9.TabIndex = 5
        '
        'btndeletetable
        '
        Me.btndeletetable.Location = New System.Drawing.Point(388, 10)
        Me.btndeletetable.Name = "btndeletetable"
        Me.btndeletetable.Size = New System.Drawing.Size(75, 39)
        Me.btndeletetable.TabIndex = 3
        Me.btndeletetable.Text = "Xóa"
        Me.btndeletetable.UseVisualStyleBackColor = True
        '
        'btnaddtable
        '
        Me.btnaddtable.Location = New System.Drawing.Point(172, 10)
        Me.btnaddtable.Name = "btnaddtable"
        Me.btnaddtable.Size = New System.Drawing.Size(91, 39)
        Me.btnaddtable.TabIndex = 2
        Me.btnaddtable.Text = "Thêm mới"
        Me.btnaddtable.UseVisualStyleBackColor = True
        '
        'btnedittable
        '
        Me.btnedittable.Location = New System.Drawing.Point(286, 10)
        Me.btnedittable.Name = "btnedittable"
        Me.btnedittable.Size = New System.Drawing.Size(75, 39)
        Me.btnedittable.TabIndex = 1
        Me.btnedittable.Text = "Sửa đổi"
        Me.btnedittable.UseVisualStyleBackColor = True
        '
        'btnviewtable
        '
        Me.btnviewtable.Location = New System.Drawing.Point(31, 10)
        Me.btnviewtable.Name = "btnviewtable"
        Me.btnviewtable.Size = New System.Drawing.Size(117, 39)
        Me.btnviewtable.TabIndex = 0
        Me.btnviewtable.Text = "Xem danh sách"
        Me.btnviewtable.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.dtgvtable)
        Me.Panel10.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(7, 58)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(496, 282)
        Me.Panel10.TabIndex = 4
        '
        'dtgvtable
        '
        Me.dtgvtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvtable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idtablee, Me.Nametablee})
        Me.dtgvtable.Location = New System.Drawing.Point(3, 3)
        Me.dtgvtable.Name = "dtgvtable"
        Me.dtgvtable.Size = New System.Drawing.Size(489, 275)
        Me.dtgvtable.TabIndex = 0
        '
        'Idtablee
        '
        Me.Idtablee.HeaderText = "Số TT"
        Me.Idtablee.Name = "Idtablee"
        '
        'Nametablee
        '
        Me.Nametablee.HeaderText = "Tên bàn"
        Me.Nametablee.Name = "Nametablee"
        Me.Nametablee.Width = 345
        '
        'tabcategory
        '
        Me.tabcategory.Controls.Add(Me.Panel11)
        Me.tabcategory.Controls.Add(Me.Panel12)
        Me.tabcategory.Controls.Add(Me.Panel13)
        Me.tabcategory.Controls.Add(Me.Panel14)
        Me.tabcategory.Location = New System.Drawing.Point(4, 26)
        Me.tabcategory.Name = "tabcategory"
        Me.tabcategory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabcategory.Size = New System.Drawing.Size(789, 418)
        Me.tabcategory.TabIndex = 3
        Me.tabcategory.Text = "Danh mục"
        Me.tabcategory.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel11.Location = New System.Drawing.Point(8, 9)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(773, 43)
        Me.Panel11.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Danh sách các loại  danh mục"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.txbnamecategory)
        Me.Panel12.Controls.Add(Me.txbidcategory)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Controls.Add(Me.Label13)
        Me.Panel12.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(512, 58)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(262, 282)
        Me.Panel12.TabIndex = 10
        '
        'txbnamecategory
        '
        Me.txbnamecategory.Location = New System.Drawing.Point(72, 74)
        Me.txbnamecategory.Name = "txbnamecategory"
        Me.txbnamecategory.Size = New System.Drawing.Size(187, 24)
        Me.txbnamecategory.TabIndex = 6
        '
        'txbidcategory
        '
        Me.txbidcategory.Location = New System.Drawing.Point(72, 27)
        Me.txbidcategory.Name = "txbidcategory"
        Me.txbidcategory.ReadOnly = True
        Me.txbidcategory.Size = New System.Drawing.Size(187, 24)
        Me.txbidcategory.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Danh mục"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Số TT"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.btndeletecategory)
        Me.Panel13.Controls.Add(Me.btnaddcategory)
        Me.Panel13.Controls.Add(Me.btneditcategory)
        Me.Panel13.Controls.Add(Me.btnviewcategory)
        Me.Panel13.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel13.Location = New System.Drawing.Point(7, 350)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(567, 59)
        Me.Panel13.TabIndex = 9
        '
        'btndeletecategory
        '
        Me.btndeletecategory.Location = New System.Drawing.Point(388, 10)
        Me.btndeletecategory.Name = "btndeletecategory"
        Me.btndeletecategory.Size = New System.Drawing.Size(75, 39)
        Me.btndeletecategory.TabIndex = 3
        Me.btndeletecategory.Text = "Xóa"
        Me.btndeletecategory.UseVisualStyleBackColor = True
        '
        'btnaddcategory
        '
        Me.btnaddcategory.Location = New System.Drawing.Point(172, 10)
        Me.btnaddcategory.Name = "btnaddcategory"
        Me.btnaddcategory.Size = New System.Drawing.Size(91, 39)
        Me.btnaddcategory.TabIndex = 2
        Me.btnaddcategory.Text = "Thêm mới"
        Me.btnaddcategory.UseVisualStyleBackColor = True
        '
        'btneditcategory
        '
        Me.btneditcategory.Location = New System.Drawing.Point(286, 10)
        Me.btneditcategory.Name = "btneditcategory"
        Me.btneditcategory.Size = New System.Drawing.Size(75, 39)
        Me.btneditcategory.TabIndex = 1
        Me.btneditcategory.Text = "Sửa đổi"
        Me.btneditcategory.UseVisualStyleBackColor = True
        '
        'btnviewcategory
        '
        Me.btnviewcategory.Location = New System.Drawing.Point(31, 10)
        Me.btnviewcategory.Name = "btnviewcategory"
        Me.btnviewcategory.Size = New System.Drawing.Size(117, 39)
        Me.btnviewcategory.TabIndex = 0
        Me.btnviewcategory.Text = "Xem danh sách"
        Me.btnviewcategory.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.dtgvcategory)
        Me.Panel14.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(7, 58)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(496, 282)
        Me.Panel14.TabIndex = 8
        '
        'dtgvcategory
        '
        Me.dtgvcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvcategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dtgvcategory.Location = New System.Drawing.Point(1, 3)
        Me.dtgvcategory.Name = "dtgvcategory"
        Me.dtgvcategory.Size = New System.Drawing.Size(492, 276)
        Me.dtgvcategory.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Số TT"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tên danh mục"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 349
        '
        'tabaccount
        '
        Me.tabaccount.Controls.Add(Me.Panel15)
        Me.tabaccount.Controls.Add(Me.Panel16)
        Me.tabaccount.Controls.Add(Me.Panel17)
        Me.tabaccount.Controls.Add(Me.Panel18)
        Me.tabaccount.Location = New System.Drawing.Point(4, 26)
        Me.tabaccount.Name = "tabaccount"
        Me.tabaccount.Size = New System.Drawing.Size(789, 418)
        Me.tabaccount.TabIndex = 4
        Me.tabaccount.Text = "Tài khoản"
        Me.tabaccount.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.txbsearchaccount)
        Me.Panel15.Controls.Add(Me.btnsearchaccount)
        Me.Panel15.Controls.Add(Me.Label14)
        Me.Panel15.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel15.Location = New System.Drawing.Point(8, 9)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(773, 43)
        Me.Panel15.TabIndex = 15
        '
        'txbsearchaccount
        '
        Me.txbsearchaccount.Location = New System.Drawing.Point(445, 12)
        Me.txbsearchaccount.Name = "txbsearchaccount"
        Me.txbsearchaccount.Size = New System.Drawing.Size(231, 24)
        Me.txbsearchaccount.TabIndex = 5
        '
        'btnsearchaccount
        '
        Me.btnsearchaccount.Location = New System.Drawing.Point(682, 12)
        Me.btnsearchaccount.Name = "btnsearchaccount"
        Me.btnsearchaccount.Size = New System.Drawing.Size(75, 23)
        Me.btnsearchaccount.TabIndex = 4
        Me.btnsearchaccount.Text = "Tìm kiếm"
        Me.btnsearchaccount.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(172, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Danh sách tài khoản "
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.CheckBox1)
        Me.Panel16.Controls.Add(Me.Panel19)
        Me.Panel16.Controls.Add(Me.txbpass)
        Me.Panel16.Controls.Add(Me.Label17)
        Me.Panel16.Controls.Add(Me.txbnameaccount)
        Me.Panel16.Controls.Add(Me.txbsttaccount)
        Me.Panel16.Controls.Add(Me.Label15)
        Me.Panel16.Controls.Add(Me.Label16)
        Me.Panel16.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel16.Location = New System.Drawing.Point(484, 58)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(290, 282)
        Me.Panel16.TabIndex = 14
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(100, 147)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 19)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Hiện mật khẩu"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.radiouser)
        Me.Panel19.Controls.Add(Me.radioadmin)
        Me.Panel19.Controls.Add(Me.Label18)
        Me.Panel19.Location = New System.Drawing.Point(6, 170)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(281, 89)
        Me.Panel19.TabIndex = 10
        '
        'radiouser
        '
        Me.radiouser.AutoSize = True
        Me.radiouser.Location = New System.Drawing.Point(180, 4)
        Me.radiouser.Name = "radiouser"
        Me.radiouser.Size = New System.Drawing.Size(86, 21)
        Me.radiouser.TabIndex = 13
        Me.radiouser.TabStop = True
        Me.radiouser.Text = "Nhân viên"
        Me.radiouser.UseVisualStyleBackColor = True
        '
        'radioadmin
        '
        Me.radioadmin.AutoSize = True
        Me.radioadmin.Location = New System.Drawing.Point(94, 4)
        Me.radioadmin.Name = "radioadmin"
        Me.radioadmin.Size = New System.Drawing.Size(72, 21)
        Me.radioadmin.TabIndex = 12
        Me.radioadmin.TabStop = True
        Me.radioadmin.Text = "Quản lý"
        Me.radioadmin.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(-3, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 17)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Quyền"
        '
        'txbpass
        '
        Me.txbpass.Location = New System.Drawing.Point(100, 116)
        Me.txbpass.Name = "txbpass"
        Me.txbpass.Size = New System.Drawing.Size(187, 24)
        Me.txbpass.TabIndex = 9
        Me.txbpass.UseSystemPasswordChar = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 17)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Mật khẩu"
        '
        'txbnameaccount
        '
        Me.txbnameaccount.Location = New System.Drawing.Point(100, 73)
        Me.txbnameaccount.Name = "txbnameaccount"
        Me.txbnameaccount.Size = New System.Drawing.Size(187, 24)
        Me.txbnameaccount.TabIndex = 6
        '
        'txbsttaccount
        '
        Me.txbsttaccount.Location = New System.Drawing.Point(100, 32)
        Me.txbsttaccount.Name = "txbsttaccount"
        Me.txbsttaccount.ReadOnly = True
        Me.txbsttaccount.Size = New System.Drawing.Size(187, 24)
        Me.txbsttaccount.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Tên người dùng"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Số TT"
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.btndeleteaccount)
        Me.Panel17.Controls.Add(Me.btnaddaccount)
        Me.Panel17.Controls.Add(Me.btnviewaccount)
        Me.Panel17.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel17.Location = New System.Drawing.Point(7, 350)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(567, 59)
        Me.Panel17.TabIndex = 13
        '
        'btndeleteaccount
        '
        Me.btndeleteaccount.Location = New System.Drawing.Point(292, 10)
        Me.btndeleteaccount.Name = "btndeleteaccount"
        Me.btndeleteaccount.Size = New System.Drawing.Size(75, 39)
        Me.btndeleteaccount.TabIndex = 3
        Me.btndeleteaccount.Text = "Xóa"
        Me.btndeleteaccount.UseVisualStyleBackColor = True
        '
        'btnaddaccount
        '
        Me.btnaddaccount.Location = New System.Drawing.Point(172, 10)
        Me.btnaddaccount.Name = "btnaddaccount"
        Me.btnaddaccount.Size = New System.Drawing.Size(91, 39)
        Me.btnaddaccount.TabIndex = 2
        Me.btnaddaccount.Text = "Thêm mới"
        Me.btnaddaccount.UseVisualStyleBackColor = True
        '
        'btnviewaccount
        '
        Me.btnviewaccount.Location = New System.Drawing.Point(31, 10)
        Me.btnviewaccount.Name = "btnviewaccount"
        Me.btnviewaccount.Size = New System.Drawing.Size(117, 39)
        Me.btnviewaccount.TabIndex = 0
        Me.btnviewaccount.Text = "Xem danh sách"
        Me.btnviewaccount.UseVisualStyleBackColor = True
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.dtgvaccount)
        Me.Panel18.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel18.Location = New System.Drawing.Point(7, 58)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(471, 282)
        Me.Panel18.TabIndex = 12
        '
        'dtgvaccount
        '
        Me.dtgvaccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvaccount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dtgvaccount.Location = New System.Drawing.Point(4, 4)
        Me.dtgvaccount.Name = "dtgvaccount"
        Me.dtgvaccount.ReadOnly = True
        Me.dtgvaccount.Size = New System.Drawing.Size(464, 275)
        Me.dtgvaccount.TabIndex = 0
        '
        'Column3
        '
        Me.Column3.HeaderText = "Số TT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tên đăng nhập"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 180
        '
        'Column5
        '
        Me.Column5.HeaderText = "Mật khẩu"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 90
        '
        'Column6
        '
        Me.Column6.HeaderText = "Quyền"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 81
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmAdmin"
        Me.Text = "frmAdmin"
        Me.TabControl1.ResumeLayout(False)
        Me.tabrevenue.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgvRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabfood.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.nbrpricefood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dtgvfood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabtable.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.dtgvtable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabcategory.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.dtgvcategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabaccount.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        CType(Me.dtgvaccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabrevenue As TabPage
    Friend WithEvents tabfood As TabPage
    Friend WithEvents tabtable As TabPage
    Friend WithEvents tabcategory As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtgvRevenue As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnthongke As Button
    Friend WithEvents dtpktime2 As DateTimePicker
    Friend WithEvents dtpktime1 As DateTimePicker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents nbrpricefood As NumericUpDown
    Friend WithEvents cbcategoryfood As ComboBox
    Friend WithEvents txbnamefood As TextBox
    Friend WithEvents txbsothutu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btndeletefood As Button
    Friend WithEvents btnaddfood As Button
    Friend WithEvents btneditfood As Button
    Friend WithEvents btnviewfood As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnsearchtable As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txbnametable As TextBox
    Friend WithEvents txbidtable As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btndeletetable As Button
    Friend WithEvents btnaddtable As Button
    Friend WithEvents btnedittable As Button
    Friend WithEvents btnviewtable As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents tabaccount As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txbnamecategory As TextBox
    Friend WithEvents txbidcategory As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btndeletecategory As Button
    Friend WithEvents btnaddcategory As Button
    Friend WithEvents btneditcategory As Button
    Friend WithEvents btnviewcategory As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents txbsearchaccount As TextBox
    Friend WithEvents btnsearchaccount As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents txbpass As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txbnameaccount As TextBox
    Friend WithEvents txbsttaccount As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents btndeleteaccount As Button
    Friend WithEvents btnaddaccount As Button
    Friend WithEvents btnviewaccount As Button
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents datecheckin As DataGridViewTextBoxColumn
    Friend WithEvents Idtable As DataGridViewTextBoxColumn
    Friend WithEvents datecheckout As DataGridViewTextBoxColumn
    Friend WithEvents totalprice As DataGridViewTextBoxColumn
    Friend WithEvents dtgvfood As DataGridView
    Friend WithEvents Idfood As DataGridViewTextBoxColumn
    Friend WithEvents Namefood As DataGridViewTextBoxColumn
    Friend WithEvents Pricefood As DataGridViewTextBoxColumn
    Friend WithEvents namecate As DataGridViewTextBoxColumn
    Friend WithEvents dtgvtable As DataGridView
    Friend WithEvents dtgvcategory As DataGridView
    Friend WithEvents dtgvaccount As DataGridView
    Friend WithEvents Idtablee As DataGridViewTextBoxColumn
    Friend WithEvents Nametablee As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents radiouser As RadioButton
    Friend WithEvents radioadmin As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
End Class
