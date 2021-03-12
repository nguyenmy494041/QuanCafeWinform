<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBAITAP
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
        Me.pnlbody = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnsearch = New System.Windows.Forms.TextBox()
        Me.lblnofilter = New System.Windows.Forms.Label()
        Me.txbrecord = New System.Windows.Forms.TextBox()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnfirstrecord = New System.Windows.Forms.Button()
        Me.lblrecord = New System.Windows.Forms.Label()
        Me.btndeleterecord = New System.Windows.Forms.Button()
        Me.pnlschool = New System.Windows.Forms.Panel()
        Me.txbReturneeStudent = New System.Windows.Forms.TextBox()
        Me.txbAdultSpecial = New System.Windows.Forms.TextBox()
        Me.txbschoolname = New System.Windows.Forms.TextBox()
        Me.txbschoolcode = New System.Windows.Forms.TextBox()
        Me.lblschoolcode = New System.Windows.Forms.Label()
        Me.lblReturneeStudent = New System.Windows.Forms.Label()
        Me.lblAdultSpecial = New System.Windows.Forms.Label()
        Me.lblschoolname = New System.Windows.Forms.Label()
        Me.pnlcourseregion = New System.Windows.Forms.Panel()
        Me.txbcoursecode = New System.Windows.Forms.TextBox()
        Me.lblcoursecode = New System.Windows.Forms.Label()
        Me.txbregioncode = New System.Windows.Forms.TextBox()
        Me.lblregioncode = New System.Windows.Forms.Label()
        Me.txbregionname = New System.Windows.Forms.TextBox()
        Me.lblregionname = New System.Windows.Forms.Label()
        Me.txbcoursename = New System.Windows.Forms.TextBox()
        Me.lblcoursename = New System.Windows.Forms.Label()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.libCourse = New System.Windows.Forms.ListBox()
        Me.cbxRegion = New System.Windows.Forms.ComboBox()
        Me.lblListRegion = New System.Windows.Forms.Label()
        Me.lblListCourse = New System.Windows.Forms.Label()
        Me.CC_Label1 = New ICCControl.CC_Label()
        Me.pnlbody.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlschool.SuspendLayout()
        Me.pnlcourseregion.SuspendLayout()
        Me.pnlheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlbody
        '
        Me.pnlbody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlbody.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlbody.Controls.Add(Me.Panel1)
        Me.pnlbody.Controls.Add(Me.btndeleterecord)
        Me.pnlbody.Controls.Add(Me.pnlschool)
        Me.pnlbody.Controls.Add(Me.pnlcourseregion)
        Me.pnlbody.Controls.Add(Me.pnlheader)
        Me.pnlbody.Controls.Add(Me.CC_Label1)
        Me.pnlbody.Location = New System.Drawing.Point(2, 6)
        Me.pnlbody.Name = "pnlbody"
        Me.pnlbody.Size = New System.Drawing.Size(696, 380)
        Me.pnlbody.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnsearch)
        Me.Panel1.Controls.Add(Me.lblnofilter)
        Me.Panel1.Controls.Add(Me.txbrecord)
        Me.Panel1.Controls.Add(Me.btnprevious)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnfirstrecord)
        Me.Panel1.Controls.Add(Me.lblrecord)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 353)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 27)
        Me.Panel1.TabIndex = 5
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(346, 6)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(70, 20)
        Me.btnsearch.TabIndex = 7
        Me.btnsearch.Text = "Search"
        '
        'lblnofilter
        '
        Me.lblnofilter.AutoSize = True
        Me.lblnofilter.Location = New System.Drawing.Point(293, 10)
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
        Me.txbrecord.TabIndex = 5
        '
        'btnprevious
        '
        Me.btnprevious.Location = New System.Drawing.Point(88, 5)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(25, 21)
        Me.btnprevious.TabIndex = 4
        Me.btnprevious.Text = "<"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(204, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 21)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(235, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 21)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = ">I"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnfirstrecord
        '
        Me.btnfirstrecord.Location = New System.Drawing.Point(57, 5)
        Me.btnfirstrecord.Name = "btnfirstrecord"
        Me.btnfirstrecord.Size = New System.Drawing.Size(25, 21)
        Me.btnfirstrecord.TabIndex = 1
        Me.btnfirstrecord.Text = "I<"
        Me.btnfirstrecord.UseVisualStyleBackColor = True
        '
        'lblrecord
        '
        Me.lblrecord.AutoSize = True
        Me.lblrecord.Location = New System.Drawing.Point(7, 10)
        Me.lblrecord.Name = "lblrecord"
        Me.lblrecord.Size = New System.Drawing.Size(42, 13)
        Me.lblrecord.TabIndex = 0
        Me.lblrecord.Text = "Record"
        '
        'btndeleterecord
        '
        Me.btndeleterecord.Location = New System.Drawing.Point(13, 308)
        Me.btndeleterecord.Name = "btndeleterecord"
        Me.btndeleterecord.Size = New System.Drawing.Size(110, 30)
        Me.btndeleterecord.TabIndex = 4
        Me.btndeleterecord.Text = "レコードの削除"
        Me.btndeleterecord.UseVisualStyleBackColor = True
        '
        'pnlschool
        '
        Me.pnlschool.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlschool.Controls.Add(Me.txbReturneeStudent)
        Me.pnlschool.Controls.Add(Me.txbAdultSpecial)
        Me.pnlschool.Controls.Add(Me.txbschoolname)
        Me.pnlschool.Controls.Add(Me.txbschoolcode)
        Me.pnlschool.Controls.Add(Me.lblschoolcode)
        Me.pnlschool.Controls.Add(Me.lblReturneeStudent)
        Me.pnlschool.Controls.Add(Me.lblAdultSpecial)
        Me.pnlschool.Controls.Add(Me.lblschoolname)
        Me.pnlschool.Location = New System.Drawing.Point(3, 192)
        Me.pnlschool.Name = "pnlschool"
        Me.pnlschool.Size = New System.Drawing.Size(690, 100)
        Me.pnlschool.TabIndex = 3
        '
        'txbReturneeStudent
        '
        Me.txbReturneeStudent.Location = New System.Drawing.Point(435, 78)
        Me.txbReturneeStudent.Name = "txbReturneeStudent"
        Me.txbReturneeStudent.Size = New System.Drawing.Size(80, 20)
        Me.txbReturneeStudent.TabIndex = 7
        '
        'txbAdultSpecial
        '
        Me.txbAdultSpecial.Location = New System.Drawing.Point(435, 53)
        Me.txbAdultSpecial.Name = "txbAdultSpecial"
        Me.txbAdultSpecial.Size = New System.Drawing.Size(80, 20)
        Me.txbAdultSpecial.TabIndex = 6
        '
        'txbschoolname
        '
        Me.txbschoolname.Location = New System.Drawing.Point(191, 3)
        Me.txbschoolname.Name = "txbschoolname"
        Me.txbschoolname.Size = New System.Drawing.Size(324, 20)
        Me.txbschoolname.TabIndex = 5
        '
        'txbschoolcode
        '
        Me.txbschoolcode.Location = New System.Drawing.Point(192, 28)
        Me.txbschoolcode.Name = "txbschoolcode"
        Me.txbschoolcode.Size = New System.Drawing.Size(148, 20)
        Me.txbschoolcode.TabIndex = 4
        '
        'lblschoolcode
        '
        Me.lblschoolcode.AutoSize = True
        Me.lblschoolcode.Location = New System.Drawing.Point(12, 33)
        Me.lblschoolcode.Name = "lblschoolcode"
        Me.lblschoolcode.Size = New System.Drawing.Size(166, 13)
        Me.lblschoolcode.TabIndex = 3
        Me.lblschoolcode.Text = "学校コードを入力してください(8桁)"
        '
        'lblReturneeStudent
        '
        Me.lblReturneeStudent.AutoSize = True
        Me.lblReturneeStudent.Location = New System.Drawing.Point(13, 81)
        Me.lblReturneeStudent.Name = "lblReturneeStudent"
        Me.lblReturneeStudent.Size = New System.Drawing.Size(367, 13)
        Me.lblReturneeStudent.TabIndex = 2
        Me.lblReturneeStudent.Text = "帰国生徒区分を入力してください(1:り帰国生徒区分あり帰国生徒区分なし)"
        '
        'lblAdultSpecial
        '
        Me.lblAdultSpecial.AutoSize = True
        Me.lblAdultSpecial.Location = New System.Drawing.Point(13, 56)
        Me.lblAdultSpecial.Name = "lblAdultSpecial"
        Me.lblAdultSpecial.Size = New System.Drawing.Size(362, 13)
        Me.lblAdultSpecial.TabIndex = 1
        Me.lblAdultSpecial.Text = "成人特例区分を入力してください(1:成人特例区分あり:成人特例区分なし)"
        '
        'lblschoolname
        '
        Me.lblschoolname.AutoSize = True
        Me.lblschoolname.Location = New System.Drawing.Point(12, 8)
        Me.lblschoolname.Name = "lblschoolname"
        Me.lblschoolname.Size = New System.Drawing.Size(127, 13)
        Me.lblschoolname.TabIndex = 0
        Me.lblschoolname.Text = "学校名を入力してください"
        '
        'pnlcourseregion
        '
        Me.pnlcourseregion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlcourseregion.Controls.Add(Me.txbcoursecode)
        Me.pnlcourseregion.Controls.Add(Me.lblcoursecode)
        Me.pnlcourseregion.Controls.Add(Me.txbregioncode)
        Me.pnlcourseregion.Controls.Add(Me.lblregioncode)
        Me.pnlcourseregion.Controls.Add(Me.txbregionname)
        Me.pnlcourseregion.Controls.Add(Me.lblregionname)
        Me.pnlcourseregion.Controls.Add(Me.txbcoursename)
        Me.pnlcourseregion.Controls.Add(Me.lblcoursename)
        Me.pnlcourseregion.Enabled = False
        Me.pnlcourseregion.Location = New System.Drawing.Point(3, 142)
        Me.pnlcourseregion.Name = "pnlcourseregion"
        Me.pnlcourseregion.Size = New System.Drawing.Size(690, 44)
        Me.pnlcourseregion.TabIndex = 2
        '
        'txbcoursecode
        '
        Me.txbcoursecode.Location = New System.Drawing.Point(226, 22)
        Me.txbcoursecode.Name = "txbcoursecode"
        Me.txbcoursecode.Size = New System.Drawing.Size(80, 20)
        Me.txbcoursecode.TabIndex = 7
        '
        'lblcoursecode
        '
        Me.lblcoursecode.AutoSize = True
        Me.lblcoursecode.Location = New System.Drawing.Point(223, 6)
        Me.lblcoursecode.Name = "lblcoursecode"
        Me.lblcoursecode.Size = New System.Drawing.Size(61, 13)
        Me.lblcoursecode.TabIndex = 6
        Me.lblcoursecode.Text = "課程コード:"
        '
        'txbregioncode
        '
        Me.txbregioncode.Location = New System.Drawing.Point(570, 22)
        Me.txbregioncode.Name = "txbregioncode"
        Me.txbregioncode.Size = New System.Drawing.Size(80, 20)
        Me.txbregioncode.TabIndex = 5
        '
        'lblregioncode
        '
        Me.lblregioncode.AutoSize = True
        Me.lblregioncode.Location = New System.Drawing.Point(561, 6)
        Me.lblregioncode.Name = "lblregioncode"
        Me.lblregioncode.Size = New System.Drawing.Size(61, 13)
        Me.lblregioncode.TabIndex = 4
        Me.lblregioncode.Text = "地域コード:"
        '
        'txbregionname
        '
        Me.txbregionname.Location = New System.Drawing.Point(355, 22)
        Me.txbregionname.Name = "txbregionname"
        Me.txbregionname.Size = New System.Drawing.Size(160, 20)
        Me.txbregionname.TabIndex = 3
        '
        'lblregionname
        '
        Me.lblregionname.AutoSize = True
        Me.lblregionname.Location = New System.Drawing.Point(350, 6)
        Me.lblregionname.Name = "lblregionname"
        Me.lblregionname.Size = New System.Drawing.Size(46, 13)
        Me.lblregionname.TabIndex = 2
        Me.lblregionname.Text = "地域名:"
        '
        'txbcoursename
        '
        Me.txbcoursename.Location = New System.Drawing.Point(15, 22)
        Me.txbcoursename.Name = "txbcoursename"
        Me.txbcoursename.Size = New System.Drawing.Size(160, 20)
        Me.txbcoursename.TabIndex = 1
        '
        'lblcoursename
        '
        Me.lblcoursename.AutoSize = True
        Me.lblcoursename.Location = New System.Drawing.Point(12, 6)
        Me.lblcoursename.Name = "lblcoursename"
        Me.lblcoursename.Size = New System.Drawing.Size(46, 13)
        Me.lblcoursename.TabIndex = 0
        Me.lblcoursename.Text = "課程名:"
        '
        'pnlheader
        '
        Me.pnlheader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlheader.Controls.Add(Me.libCourse)
        Me.pnlheader.Controls.Add(Me.cbxRegion)
        Me.pnlheader.Controls.Add(Me.lblListRegion)
        Me.pnlheader.Controls.Add(Me.lblListCourse)
        Me.pnlheader.Location = New System.Drawing.Point(3, 42)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(690, 100)
        Me.pnlheader.TabIndex = 1
        '
        'libCourse
        '
        Me.libCourse.FormattingEnabled = True
        Me.libCourse.Location = New System.Drawing.Point(180, 3)
        Me.libCourse.Name = "libCourse"
        Me.libCourse.Size = New System.Drawing.Size(111, 95)
        Me.libCourse.TabIndex = 3
        '
        'cbxRegion
        '
        Me.cbxRegion.FormattingEnabled = True
        Me.cbxRegion.Location = New System.Drawing.Point(486, 1)
        Me.cbxRegion.Name = "cbxRegion"
        Me.cbxRegion.Size = New System.Drawing.Size(164, 21)
        Me.cbxRegion.TabIndex = 2
        '
        'lblListRegion
        '
        Me.lblListRegion.AutoSize = True
        Me.lblListRegion.Location = New System.Drawing.Point(328, 6)
        Me.lblListRegion.Name = "lblListRegion"
        Me.lblListRegion.Size = New System.Drawing.Size(142, 13)
        Me.lblListRegion.TabIndex = 1
        Me.lblListRegion.Text = "地域名を選択してください 印"
        '
        'lblListCourse
        '
        Me.lblListCourse.AutoSize = True
        Me.lblListCourse.Location = New System.Drawing.Point(7, 6)
        Me.lblListCourse.Name = "lblListCourse"
        Me.lblListCourse.Size = New System.Drawing.Size(163, 13)
        Me.lblListCourse.TabIndex = 0
        Me.lblListCourse.Text = "課程名を選択してください全日制"
        '
        'CC_Label1
        '
        Me.CC_Label1.AutoSize = True
        Me.CC_Label1.BackColor = System.Drawing.Color.Transparent
        Me.CC_Label1.Font = New System.Drawing.Font("MS Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CC_Label1.Location = New System.Drawing.Point(231, 6)
        Me.CC_Label1.Name = "CC_Label1"
        Me.CC_Label1.Size = New System.Drawing.Size(194, 21)
        Me.CC_Label1.TabIndex = 0
        Me.CC_Label1.Text = "学校コードの入力"
        Me.CC_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmBAITAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(701, 391)
        Me.Controls.Add(Me.pnlbody)
        Me.MaximizeBox = False
        Me.Name = "frmBAITAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "©学校コードの入力"
        Me.pnlbody.ResumeLayout(False)
        Me.pnlbody.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlschool.ResumeLayout(False)
        Me.pnlschool.PerformLayout()
        Me.pnlcourseregion.ResumeLayout(False)
        Me.pnlcourseregion.PerformLayout()
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlbody As Panel
    Friend WithEvents CC_Label1 As ICCControl.CC_Label
    Friend WithEvents pnlcourseregion As Panel
    Friend WithEvents txbcoursename As TextBox
    Friend WithEvents lblcoursename As Label
    Friend WithEvents pnlheader As Panel
    Friend WithEvents libCourse As ListBox
    Friend WithEvents cbxRegion As ComboBox
    Friend WithEvents lblListRegion As Label
    Friend WithEvents lblListCourse As Label
    Friend WithEvents txbcoursecode As TextBox
    Friend WithEvents lblcoursecode As Label
    Friend WithEvents txbregioncode As TextBox
    Friend WithEvents lblregioncode As Label
    Friend WithEvents txbregionname As TextBox
    Friend WithEvents lblregionname As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsearch As TextBox
    Friend WithEvents lblnofilter As Label
    Friend WithEvents txbrecord As TextBox
    Friend WithEvents btnprevious As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnfirstrecord As Button
    Friend WithEvents lblrecord As Label
    Friend WithEvents btndeleterecord As Button
    Friend WithEvents pnlschool As Panel
    Friend WithEvents txbReturneeStudent As TextBox
    Friend WithEvents txbAdultSpecial As TextBox
    Friend WithEvents txbschoolname As TextBox
    Friend WithEvents txbschoolcode As TextBox
    Friend WithEvents lblschoolcode As Label
    Friend WithEvents lblReturneeStudent As Label
    Friend WithEvents lblAdultSpecial As Label
    Friend WithEvents lblschoolname As Label
End Class
