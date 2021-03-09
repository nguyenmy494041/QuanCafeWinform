<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lich
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
        Me.calendar = New ICCControl.CC_Calendar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'calendar
        '
        Me.calendar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.calendar.CustomFormat = "yyyy/MM/dd"
        Me.calendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calendar.Location = New System.Drawing.Point(2, 1)
        Me.calendar.Name = "calendar"
        Me.calendar.Size = New System.Drawing.Size(146, 20)
        Me.calendar.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(3, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lich
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.calendar)
        Me.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Name = "lich"
        Me.Size = New System.Drawing.Size(151, 22)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calendar As CC_Calendar
    Friend WithEvents TextBox1 As TextBox
End Class
