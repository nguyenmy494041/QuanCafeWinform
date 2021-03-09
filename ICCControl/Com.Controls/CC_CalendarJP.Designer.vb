<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CC_CalendarJP
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpCalendar = New ICCControl.CC_Calendar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtValue
        '
        Me.txtValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValue.Location = New System.Drawing.Point(0, 1)
        Me.txtValue.Margin = New System.Windows.Forms.Padding(0)
        Me.txtValue.MaximumSize = New System.Drawing.Size(105, 19)
        Me.txtValue.MaxLength = 9
        Me.txtValue.MinimumSize = New System.Drawing.Size(105, 19)
        Me.txtValue.Multiline = True
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(105, 19)
        Me.txtValue.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpCalendar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.MinimumSize = New System.Drawing.Size(150, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(150, 22)
        Me.Panel1.TabIndex = 2
        '
        'dtpCalendar
        '
        Me.dtpCalendar.CustomFormat = "yyyy/MM/dd"
        Me.dtpCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCalendar.Location = New System.Drawing.Point(0, 1)
        Me.dtpCalendar.Margin = New System.Windows.Forms.Padding(0)
        Me.dtpCalendar.Name = "dtpCalendar"
        Me.dtpCalendar.Size = New System.Drawing.Size(150, 20)
        Me.dtpCalendar.TabIndex = 1
        '
        'CC_CalendarJP
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximumSize = New System.Drawing.Size(150, 22)
        Me.MinimumSize = New System.Drawing.Size(150, 22)
        Me.Name = "CC_CalendarJP"
        Me.Size = New System.Drawing.Size(150, 22)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValue As TextBox
    Friend WithEvents dtpCalendar As CC_Calendar
    Friend WithEvents Panel1 As Panel
End Class
