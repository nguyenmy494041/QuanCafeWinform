<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaiTap2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaiTap2))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txbrow = New System.Windows.Forms.TextBox()
        Me.txbId = New System.Windows.Forms.TextBox()
        Me.btnNewrecord = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.TextBox()
        Me.lblnofilter = New System.Windows.Forms.Label()
        Me.txbrecord = New System.Windows.Forms.TextBox()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnnextrecord = New System.Windows.Forms.Button()
        Me.btnlastrecord = New System.Windows.Forms.Button()
        Me.btnfirstrecord = New System.Windows.Forms.Button()
        Me.lblrecord = New System.Windows.Forms.Label()
        Me.dtgv = New ICCControl.CC_DataGridViewMergeHeader()
        Me.SchoolCode = New ICCControl.CC_DataGridViewColumnNumber()
        Me.SchoolName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionCode = New ICCControl.CC_DataGridViewColumnNumber()
        Me.CourseName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseCode = New ICCControl.CC_DataGridViewColumnNumber()
        Me.AdultSpecial = New ICCControl.CC_DataGridViewColumnNumber()
        Me.ReturneeStudent = New ICCControl.CC_DataGridViewColumnNumber()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rownum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.dtgv)
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 445)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txbrow)
        Me.Panel2.Controls.Add(Me.txbId)
        Me.Panel2.Controls.Add(Me.btnNewrecord)
        Me.Panel2.Controls.Add(Me.btnsearch)
        Me.Panel2.Controls.Add(Me.lblnofilter)
        Me.Panel2.Controls.Add(Me.txbrecord)
        Me.Panel2.Controls.Add(Me.btnprevious)
        Me.Panel2.Controls.Add(Me.btnnextrecord)
        Me.Panel2.Controls.Add(Me.btnlastrecord)
        Me.Panel2.Controls.Add(Me.btnfirstrecord)
        Me.Panel2.Controls.Add(Me.lblrecord)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 418)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 27)
        Me.Panel2.TabIndex = 6
        '
        'txbrow
        '
        Me.txbrow.Location = New System.Drawing.Point(675, 4)
        Me.txbrow.Name = "txbrow"
        Me.txbrow.Size = New System.Drawing.Size(53, 20)
        Me.txbrow.TabIndex = 10
        Me.txbrow.TabStop = False
        Me.txbrow.Visible = False
        '
        'txbId
        '
        Me.txbId.Location = New System.Drawing.Point(618, 4)
        Me.txbId.Name = "txbId"
        Me.txbId.Size = New System.Drawing.Size(53, 20)
        Me.txbId.TabIndex = 9
        Me.txbId.TabStop = False
        Me.txbId.Visible = False
        '
        'btnNewrecord
        '
        Me.btnNewrecord.Location = New System.Drawing.Point(266, 5)
        Me.btnNewrecord.Name = "btnNewrecord"
        Me.btnNewrecord.Size = New System.Drawing.Size(30, 21)
        Me.btnNewrecord.TabIndex = 10000
        Me.btnNewrecord.TabStop = False
        Me.btnNewrecord.Text = ">*I"
        Me.btnNewrecord.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(386, 5)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(122, 20)
        Me.btnsearch.TabIndex = 10000
        Me.btnsearch.TabStop = False
        Me.btnsearch.Text = "Search"
        '
        'lblnofilter
        '
        Me.lblnofilter.AutoSize = True
        Me.lblnofilter.Location = New System.Drawing.Point(333, 9)
        Me.lblnofilter.Name = "lblnofilter"
        Me.lblnofilter.Size = New System.Drawing.Size(46, 13)
        Me.lblnofilter.TabIndex = 6
        Me.lblnofilter.Text = "No Filter"
        '
        'txbrecord
        '
        Me.txbrecord.Location = New System.Drawing.Point(118, 6)
        Me.txbrecord.Name = "txbrecord"
        Me.txbrecord.Size = New System.Drawing.Size(80, 20)
        Me.txbrecord.TabIndex = 10000
        Me.txbrecord.TabStop = False
        '
        'btnprevious
        '
        Me.btnprevious.Location = New System.Drawing.Point(88, 5)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(25, 21)
        Me.btnprevious.TabIndex = 10000
        Me.btnprevious.TabStop = False
        Me.btnprevious.Text = "<"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnnextrecord
        '
        Me.btnnextrecord.Location = New System.Drawing.Point(204, 5)
        Me.btnnextrecord.Name = "btnnextrecord"
        Me.btnnextrecord.Size = New System.Drawing.Size(25, 21)
        Me.btnnextrecord.TabIndex = 7
        Me.btnnextrecord.TabStop = False
        Me.btnnextrecord.Text = ">"
        Me.btnnextrecord.UseVisualStyleBackColor = True
        '
        'btnlastrecord
        '
        Me.btnlastrecord.Location = New System.Drawing.Point(235, 5)
        Me.btnlastrecord.Name = "btnlastrecord"
        Me.btnlastrecord.Size = New System.Drawing.Size(25, 21)
        Me.btnlastrecord.TabIndex = 10000
        Me.btnlastrecord.TabStop = False
        Me.btnlastrecord.Text = ">I"
        Me.btnlastrecord.UseVisualStyleBackColor = True
        '
        'btnfirstrecord
        '
        Me.btnfirstrecord.Location = New System.Drawing.Point(57, 5)
        Me.btnfirstrecord.Name = "btnfirstrecord"
        Me.btnfirstrecord.Size = New System.Drawing.Size(25, 21)
        Me.btnfirstrecord.TabIndex = 10000
        Me.btnfirstrecord.TabStop = False
        Me.btnfirstrecord.Text = "I<"
        Me.btnfirstrecord.UseVisualStyleBackColor = True
        '
        'lblrecord
        '
        Me.lblrecord.AutoSize = True
        Me.lblrecord.Location = New System.Drawing.Point(7, 9)
        Me.lblrecord.Name = "lblrecord"
        Me.lblrecord.Size = New System.Drawing.Size(42, 13)
        Me.lblrecord.TabIndex = 0
        Me.lblrecord.Text = "Record"
        '
        'dtgv
        '
        Me.dtgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv.ColumnHeadersHeight = 40
        Me.dtgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SchoolCode, Me.SchoolName, Me.RegionName, Me.RegionCode, Me.CourseName, Me.CourseCode, Me.AdultSpecial, Me.ReturneeStudent, Me.Id, Me.Rownum})
        Me.dtgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgv.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.dtgv.ListColMapping = CType(resources.GetObject("dtgv.ListColMapping"), System.Collections.Generic.List(Of System.Collections.Generic.KeyValuePair(Of String, String)))
        Me.dtgv.Location = New System.Drawing.Point(10, 8)
        Me.dtgv.MultiSelect = False
        Me.dtgv.Name = "dtgv"
        Me.dtgv.Size = New System.Drawing.Size(872, 404)
        Me.dtgv.TabIndex = 0
        '
        'SchoolCode
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolCode.DefaultCellStyle = DataGridViewCellStyle2
        Me.SchoolCode.HeaderText = "学校コード"
        Me.SchoolCode.Name = "SchoolCode"
        Me.SchoolCode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SchoolCode.Width = 80
        '
        'SchoolName
        '
        Me.SchoolName.HeaderText = "学校名"
        Me.SchoolName.Name = "SchoolName"
        Me.SchoolName.Width = 200
        '
        'RegionName
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.RegionName.DefaultCellStyle = DataGridViewCellStyle3
        Me.RegionName.HeaderText = "地域名"
        Me.RegionName.Name = "RegionName"
        Me.RegionName.Width = 150
        '
        'RegionCode
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.RegionCode.DefaultCellStyle = DataGridViewCellStyle4
        Me.RegionCode.HeaderText = "地域コード"
        Me.RegionCode.Name = "RegionCode"
        Me.RegionCode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RegionCode.Width = 60
        '
        'CourseName
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CourseName.DefaultCellStyle = DataGridViewCellStyle5
        Me.CourseName.HeaderText = "課程名"
        Me.CourseName.Name = "CourseName"
        Me.CourseName.Width = 130
        '
        'CourseCode
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CourseCode.DefaultCellStyle = DataGridViewCellStyle6
        Me.CourseCode.HeaderText = "課程コード"
        Me.CourseCode.Name = "CourseCode"
        Me.CourseCode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CourseCode.Width = 60
        '
        'AdultSpecial
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AdultSpecial.DefaultCellStyle = DataGridViewCellStyle7
        Me.AdultSpecial.HeaderText = "成人特例区分"
        Me.AdultSpecial.Name = "AdultSpecial"
        Me.AdultSpecial.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdultSpecial.Width = 60
        '
        'ReturneeStudent
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ReturneeStudent.DefaultCellStyle = DataGridViewCellStyle8
        Me.ReturneeStudent.HeaderText = "帰国生徒区分"
        Me.ReturneeStudent.Name = "ReturneeStudent"
        Me.ReturneeStudent.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReturneeStudent.Width = 60
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'Rownum
        '
        Me.Rownum.HeaderText = "num"
        Me.Rownum.Name = "Rownum"
        Me.Rownum.Visible = False
        '
        'frmBaiTap2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmBaiTap2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBaiTap2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtgv As ICCControl.CC_DataGridViewMergeHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txbrow As TextBox
    Friend WithEvents txbId As TextBox
    Friend WithEvents btnNewrecord As Button
    Friend WithEvents btnsearch As TextBox
    Friend WithEvents lblnofilter As Label
    Friend WithEvents txbrecord As TextBox
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnnextrecord As Button
    Friend WithEvents btnlastrecord As Button
    Friend WithEvents btnfirstrecord As Button
    Friend WithEvents lblrecord As Label
    Friend WithEvents SchoolCode As ICCControl.CC_DataGridViewColumnNumber
    Friend WithEvents SchoolName As DataGridViewTextBoxColumn
    Friend WithEvents RegionName As DataGridViewTextBoxColumn
    Friend WithEvents RegionCode As ICCControl.CC_DataGridViewColumnNumber
    Friend WithEvents CourseName As DataGridViewTextBoxColumn
    Friend WithEvents CourseCode As ICCControl.CC_DataGridViewColumnNumber
    Friend WithEvents AdultSpecial As ICCControl.CC_DataGridViewColumnNumber
    Friend WithEvents ReturneeStudent As ICCControl.CC_DataGridViewColumnNumber
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Rownum As DataGridViewTextBoxColumn
End Class
