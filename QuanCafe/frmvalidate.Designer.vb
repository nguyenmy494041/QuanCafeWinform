<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmvalidate
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CC_CalendarJP1 = New ICCControl.CC_CalendarJP()
        Me.CC_Calendar1 = New ICCControl.CC_Calendar()
        Me.Lich1 = New ICCControl.lich()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(254, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'CC_CalendarJP1
        '
        Me.CC_CalendarJP1.Location = New System.Drawing.Point(37, 204)
        Me.CC_CalendarJP1.Margin = New System.Windows.Forms.Padding(0)
        Me.CC_CalendarJP1.MaximumSize = New System.Drawing.Size(150, 22)
        Me.CC_CalendarJP1.MinimumSize = New System.Drawing.Size(150, 22)
        Me.CC_CalendarJP1.Name = "CC_CalendarJP1"
        Me.CC_CalendarJP1.Size = New System.Drawing.Size(150, 22)
        Me.CC_CalendarJP1.TabIndex = 7
        Me.CC_CalendarJP1.Value = ""
        '
        'CC_Calendar1
        '
        Me.CC_Calendar1.CustomFormat = "yyyy/MM/dd"
        Me.CC_Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CC_Calendar1.Location = New System.Drawing.Point(12, 41)
        Me.CC_Calendar1.Name = "CC_Calendar1"
        Me.CC_Calendar1.Size = New System.Drawing.Size(200, 20)
        Me.CC_Calendar1.TabIndex = 5
        Me.CC_Calendar1.Value = New Date(2021, 3, 9, 11, 30, 18, 0)
        '
        'Lich1
        '
        Me.Lich1.Location = New System.Drawing.Point(68, 104)
        Me.Lich1.MinimumSize = New System.Drawing.Size(130, 20)
        Me.Lich1.Name = "Lich1"
        Me.Lich1.Size = New System.Drawing.Size(130, 22)
        Me.Lich1.TabIndex = 9
        '
        'frmvalidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(498, 302)
        Me.Controls.Add(Me.Lich1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CC_CalendarJP1)
        Me.Controls.Add(Me.CC_Calendar1)
        Me.Name = "frmvalidate"
        Me.Text = "frmvalidate"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents CC_Calendar1 As ICCControl.CC_Calendar
    Friend WithEvents CC_CalendarJP1 As ICCControl.CC_CalendarJP
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Lich1 As ICCControl.lich
End Class
