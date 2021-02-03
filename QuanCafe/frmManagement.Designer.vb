<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagement
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DanhMụcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinTàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.flptable = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnaddfood = New System.Windows.Forms.Button()
        Me.nupcount = New System.Windows.Forms.NumericUpDown()
        Me.cbfoodname = New System.Windows.Forms.ComboBox()
        Me.cbcategory = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lvbill = New System.Windows.Forms.ListView()
        Me.Foodname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txbtotalprice = New System.Windows.Forms.TextBox()
        Me.cbsale = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnthanhtoan = New System.Windows.Forms.Button()
        Me.cbswitchtable = New System.Windows.Forms.ComboBox()
        Me.btnswitchtable = New System.Windows.Forms.Button()
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.nupcount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DanhMụcToolStripMenuItem, Me.TàiKhoảnToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DanhMụcToolStripMenuItem
        '
        Me.DanhMụcToolStripMenuItem.Name = "DanhMụcToolStripMenuItem"
        Me.DanhMụcToolStripMenuItem.Size = New System.Drawing.Size(81, 21)
        Me.DanhMụcToolStripMenuItem.Text = "&Danh mục"
        '
        'TàiKhoảnToolStripMenuItem
        '
        Me.TàiKhoảnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinTàiKhoảnToolStripMenuItem, Me.ĐăngXuấtToolStripMenuItem})
        Me.TàiKhoảnToolStripMenuItem.Name = "TàiKhoảnToolStripMenuItem"
        Me.TàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(78, 21)
        Me.TàiKhoảnToolStripMenuItem.Text = "&Tài khoản"
        '
        'ThôngTinTàiKhoảnToolStripMenuItem
        '
        Me.ThôngTinTàiKhoảnToolStripMenuItem.Name = "ThôngTinTàiKhoảnToolStripMenuItem"
        Me.ThôngTinTàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ThôngTinTàiKhoảnToolStripMenuItem.Text = "&Thông tin tài khoản"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ĐăngXuấtToolStripMenuItem.Text = "&Đăng xuất"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.AdminToolStripMenuItem.Text = "&Admin"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.flptable)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 359)
        Me.Panel1.TabIndex = 1
        '
        'flptable
        '
        Me.flptable.Location = New System.Drawing.Point(3, 5)
        Me.flptable.Name = "flptable"
        Me.flptable.Size = New System.Drawing.Size(256, 348)
        Me.flptable.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnaddfood)
        Me.Panel2.Controls.Add(Me.nupcount)
        Me.Panel2.Controls.Add(Me.cbfoodname)
        Me.Panel2.Controls.Add(Me.cbcategory)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(284, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(353, 62)
        Me.Panel2.TabIndex = 2
        '
        'btnaddfood
        '
        Me.btnaddfood.Location = New System.Drawing.Point(240, 34)
        Me.btnaddfood.Name = "btnaddfood"
        Me.btnaddfood.Size = New System.Drawing.Size(90, 23)
        Me.btnaddfood.TabIndex = 3
        Me.btnaddfood.Text = "Thêm món"
        Me.btnaddfood.UseVisualStyleBackColor = True
        '
        'nupcount
        '
        Me.nupcount.Location = New System.Drawing.Point(250, 5)
        Me.nupcount.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nupcount.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.nupcount.Name = "nupcount"
        Me.nupcount.Size = New System.Drawing.Size(67, 24)
        Me.nupcount.TabIndex = 2
        Me.nupcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nupcount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbfoodname
        '
        Me.cbfoodname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbfoodname.FormattingEnabled = True
        Me.cbfoodname.Location = New System.Drawing.Point(6, 34)
        Me.cbfoodname.Name = "cbfoodname"
        Me.cbfoodname.Size = New System.Drawing.Size(220, 25)
        Me.cbfoodname.TabIndex = 1
        '
        'cbcategory
        '
        Me.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcategory.FormattingEnabled = True
        Me.cbcategory.Location = New System.Drawing.Point(6, 4)
        Me.cbcategory.Name = "cbcategory"
        Me.cbcategory.Size = New System.Drawing.Size(220, 25)
        Me.cbcategory.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lvbill)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(284, 103)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(353, 293)
        Me.Panel3.TabIndex = 3
        '
        'lvbill
        '
        Me.lvbill.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Foodname, Me.Price, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvbill.HideSelection = False
        Me.lvbill.Location = New System.Drawing.Point(6, 13)
        Me.lvbill.Name = "lvbill"
        Me.lvbill.Size = New System.Drawing.Size(344, 272)
        Me.lvbill.TabIndex = 0
        Me.lvbill.UseCompatibleStateImageBehavior = False
        Me.lvbill.View = System.Windows.Forms.View.Details
        '
        'Foodname
        '
        Me.Foodname.Text = "FoodName"
        Me.Foodname.Width = 160
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txbtotalprice)
        Me.Panel4.Controls.Add(Me.cbsale)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btnthanhtoan)
        Me.Panel4.Controls.Add(Me.cbswitchtable)
        Me.Panel4.Controls.Add(Me.btnswitchtable)
        Me.Panel4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(647, 38)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(141, 359)
        Me.Panel4.TabIndex = 3
        '
        'txbtotalprice
        '
        Me.txbtotalprice.Location = New System.Drawing.Point(23, 302)
        Me.txbtotalprice.Name = "txbtotalprice"
        Me.txbtotalprice.Size = New System.Drawing.Size(100, 24)
        Me.txbtotalprice.TabIndex = 10
        '
        'cbsale
        '
        Me.cbsale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsale.FormattingEnabled = True
        Me.cbsale.Items.AddRange(New Object() {"0 %", "5 %", "10 %", "15 %", "20 %", "30 %"})
        Me.cbsale.Location = New System.Drawing.Point(14, 229)
        Me.cbsale.Name = "cbsale"
        Me.cbsale.Size = New System.Drawing.Size(109, 25)
        Me.cbsale.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tổng tiền"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Giảm giá"
        '
        'btnthanhtoan
        '
        Me.btnthanhtoan.Location = New System.Drawing.Point(24, 129)
        Me.btnthanhtoan.Name = "btnthanhtoan"
        Me.btnthanhtoan.Size = New System.Drawing.Size(90, 42)
        Me.btnthanhtoan.TabIndex = 6
        Me.btnthanhtoan.Text = "Thanh toán"
        Me.btnthanhtoan.UseVisualStyleBackColor = True
        '
        'cbswitchtable
        '
        Me.cbswitchtable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbswitchtable.FormattingEnabled = True
        Me.cbswitchtable.Location = New System.Drawing.Point(14, 64)
        Me.cbswitchtable.Name = "cbswitchtable"
        Me.cbswitchtable.Size = New System.Drawing.Size(109, 25)
        Me.cbswitchtable.TabIndex = 5
        '
        'btnswitchtable
        '
        Me.btnswitchtable.Location = New System.Drawing.Point(24, 13)
        Me.btnswitchtable.Name = "btnswitchtable"
        Me.btnswitchtable.Size = New System.Drawing.Size(90, 40)
        Me.btnswitchtable.TabIndex = 4
        Me.btnswitchtable.Text = "Chuyển bàn"
        Me.btnswitchtable.UseVisualStyleBackColor = True
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 58
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "quantity"
        Me.ColumnHeader1.Width = 57
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "toal"
        '
        'frmManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 403)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý bàn"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.nupcount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DanhMụcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TàiKhoảnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThôngTinTàiKhoảnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐăngXuấtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents flptable As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnaddfood As Button
    Friend WithEvents nupcount As NumericUpDown
    Friend WithEvents cbfoodname As ComboBox
    Friend WithEvents cbcategory As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lvbill As ListView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txbtotalprice As TextBox
    Friend WithEvents cbsale As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnthanhtoan As Button
    Friend WithEvents cbswitchtable As ComboBox
    Friend WithEvents btnswitchtable As Button
    Friend WithEvents Foodname As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
