<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits dungform.FormBasic

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CC_Label2 = New ICCControl.CC_Label()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CC_Label2)
        Me.Panel4.Location = New System.Drawing.Point(13, 118)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(775, 320)
        Me.Panel4.TabIndex = 1
        '
        'CC_Label2
        '
        Me.CC_Label2.AutoSize = True
        Me.CC_Label2.BackColor = System.Drawing.Color.Transparent
        Me.CC_Label2.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.CC_Label2.Location = New System.Drawing.Point(98, 50)
        Me.CC_Label2.Name = "CC_Label2"
        Me.CC_Label2.Size = New System.Drawing.Size(59, 12)
        Me.CC_Label2.TabIndex = 0
        Me.CC_Label2.Text = "CC_Label2"
        Me.CC_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Form3"
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents CC_Label2 As ICCControl.CC_Label
End Class
