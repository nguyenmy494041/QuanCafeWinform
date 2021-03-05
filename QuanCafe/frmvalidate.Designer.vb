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
        Me.components = New System.ComponentModel.Container()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlresult = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CC_Button1 = New ICCControl.CC_Button()
        Me.lblerror = New ICCControl.CC_Label()
        Me.CC_Button2 = New ICCControl.CC_Button()
        Me.CC_TextBox1 = New ICCControl.CC_TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CC_Button3 = New ICCControl.CC_Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlresult.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.LightCyan
        Me.Panel1.Controls.Add(Me.pnlresult)
        Me.Panel1.Controls.Add(Me.lblerror)
        Me.Panel1.Location = New System.Drawing.Point(15, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 173)
        Me.Panel1.TabIndex = 0
        '
        'pnlresult
        '
        Me.pnlresult.AutoSize = True
        Me.pnlresult.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlresult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlresult.Location = New System.Drawing.Point(0, 12)
        Me.pnlresult.Name = "pnlresult"
        Me.pnlresult.Size = New System.Drawing.Size(615, 161)
        Me.pnlresult.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Blue
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CC_TextBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(36, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(134, 129)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CC_Button1
        '
        Me.CC_Button1.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.CC_Button1.Location = New System.Drawing.Point(819, 277)
        Me.CC_Button1.Name = "CC_Button1"
        Me.CC_Button1.Size = New System.Drawing.Size(75, 23)
        Me.CC_Button1.TabIndex = 1
        Me.CC_Button1.Text = "CC_Button1"
        Me.CC_Button1.UseVisualStyleBackColor = True
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.Color.Transparent
        Me.lblerror.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblerror.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.lblerror.ForeColor = System.Drawing.Color.Red
        Me.lblerror.Location = New System.Drawing.Point(0, 0)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(71, 12)
        Me.lblerror.TabIndex = 0
        Me.lblerror.Text = "errormessge"
        Me.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CC_Button2
        '
        Me.CC_Button2.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.CC_Button2.Location = New System.Drawing.Point(975, 277)
        Me.CC_Button2.Name = "CC_Button2"
        Me.CC_Button2.Size = New System.Drawing.Size(75, 23)
        Me.CC_Button2.TabIndex = 2
        Me.CC_Button2.Text = "CC_Button2"
        Me.CC_Button2.UseVisualStyleBackColor = True
        '
        'CC_TextBox1
        '
        Me.CC_TextBox1.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.CC_TextBox1.IsEnter = False
        Me.CC_TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.CC_TextBox1.Name = "CC_TextBox1"
        Me.CC_TextBox1.OldTextValue = Nothing
        Me.CC_TextBox1.Size = New System.Drawing.Size(61, 19)
        Me.CC_TextBox1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(22, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(732, 212)
        Me.Panel2.TabIndex = 3
        '
        'CC_Button3
        '
        Me.CC_Button3.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.CC_Button3.Location = New System.Drawing.Point(845, 174)
        Me.CC_Button3.Name = "CC_Button3"
        Me.CC_Button3.Size = New System.Drawing.Size(75, 23)
        Me.CC_Button3.TabIndex = 4
        Me.CC_Button3.Text = "CC_Button3"
        Me.CC_Button3.UseVisualStyleBackColor = True
        '
        'frmvalidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1058, 478)
        Me.Controls.Add(Me.CC_Button3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CC_Button2)
        Me.Controls.Add(Me.CC_Button1)
        Me.Name = "frmvalidate"
        Me.Text = "frmvalidate"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlresult.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents CC_Button1 As ICCControl.CC_Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlresult As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblerror As ICCControl.CC_Label
    Friend WithEvents CC_Button2 As ICCControl.CC_Button
    Friend WithEvents CC_TextBox1 As ICCControl.CC_TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CC_Button3 As ICCControl.CC_Button
End Class
