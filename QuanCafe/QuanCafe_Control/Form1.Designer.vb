<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dtpk = New System.Windows.Forms.DateTimePicker()
        Me.CCdtpk = New ICCControl.CC_Calendar()
        Me.SuspendLayout()
        '
        'dtpk
        '
        Me.dtpk.CustomFormat = "ddd  dd/MM/yyyy"
        Me.dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpk.Location = New System.Drawing.Point(36, 48)
        Me.dtpk.Name = "dtpk"
        Me.dtpk.Size = New System.Drawing.Size(200, 20)
        Me.dtpk.TabIndex = 0
        '
        'CCdtpk
        '
        Me.CCdtpk.CustomFormat = "ddd   yyyy/MM/dd"
        Me.CCdtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CCdtpk.Location = New System.Drawing.Point(36, 94)
        Me.CCdtpk.Name = "CCdtpk"
        Me.CCdtpk.Size = New System.Drawing.Size(200, 20)
        Me.CCdtpk.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 179)
        Me.Controls.Add(Me.CCdtpk)
        Me.Controls.Add(Me.dtpk)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpk As DateTimePicker
    Friend WithEvents CCdtpk As ICCControl.CC_Calendar
End Class
