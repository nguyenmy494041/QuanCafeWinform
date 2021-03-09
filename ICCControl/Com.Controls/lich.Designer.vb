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
        Me.txtValue = New System.Windows.Forms.TextBox()
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
        'txtValue
        '
        Me.txtValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValue.Location = New System.Drawing.Point(3, 1)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(116, 20)
        Me.txtValue.TabIndex = 1
        '
        'lich
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.calendar)
        Me.MinimumSize = New System.Drawing.Size(130, 20)
        Me.Name = "lich"
        Me.Size = New System.Drawing.Size(151, 22)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calendar As CC_Calendar
    Friend WithEvents txtValue As TextBox
End Class
