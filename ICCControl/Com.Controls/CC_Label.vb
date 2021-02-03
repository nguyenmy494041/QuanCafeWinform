Imports System.ComponentModel
Public Class CC_Label
    ''' <summary>
    ''' OnCreateControl Overrides
    ''' </summary>
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.AutoSize = False
        Me.Height = 20
        Me.BackColor = Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.Text = ""
    End Sub

    ''' <summary>
    ''' Set Disabled colors
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        If Enabled Then
            MyBase.OnPaint(e)
            Return
        End If

        TextRenderer.DrawText(e.Graphics, Me.Text, Me.Font, ClientRectangle, Color.FromArgb(37, 74, 92))
    End Sub
#Region "CategoryAttribute"
    Private _ResetMode = False
    <Category("ResetMode"),
DefaultValue(False)>
    Public Property ResetMode As Boolean
        Get
            Return _ResetMode
        End Get
        Set(value As Boolean)
            _ResetMode = value
        End Set
    End Property
#End Region

#Region "Validate"
    Private _validFlag As Boolean = True
    <CategoryAttribute("ValidFlag"),
    DefaultValueAttribute(True)>
    Public Property ValidFlag As Boolean
        Get
            Return _validFlag
        End Get
        Set(value As Boolean)
            _validFlag = value
        End Set
    End Property

    '''' <summary>
    '''' IsValidate 
    '''' </summary>
    '''' <returns></returns>
    'Public Overridable Function IsValidate() As CM_ValidateReturn
    '    Dim bRet As CM_ValidateReturn = New CM_ValidateReturn(True, "")
    '    Try
    '        If IsNothing(Me.Tag) Then
    '            Me.Tag = ""
    '        End If
    '        If Not ValidFlag And Me.Text.Trim().Length = 0 Then
    '            Throw New Exception(CM_Message.MESS_ERROR_INPUT_CHECK)
    '        End If

    '    Catch ex As Exception
    '        bRet = New CM_ValidateReturn(False, ex.Message)
    '        Me.Select()
    '    End Try
    '    Return bRet
    'End Function
#End Region
End Class
