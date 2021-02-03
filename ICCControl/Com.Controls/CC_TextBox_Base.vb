
Imports System.ComponentModel

''' <summary>
''' CC_TextBox_Base
''' </summary>
Public Class CC_TextBox_Base
    Public Sub New()
        InitializeComponent()

    End Sub
    ''' <summary>
    ''' OnCreateControl Overrides
    ''' </summary>
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Me.Height <= 20 Then
            Me.Multiline = False
        Else
            Me.Multiline = True
        End If
       
        'Me.Height = 20
        If Me.BackColor = Color.White OrElse Me.BackColor = Color.FromArgb(240, 240, 240) Then
            If Not Me.ReadOnly Then
                Me.BackColor = Color.White
            Else
                Me.BackColor = Color.FromArgb(240, 240, 240)
            End If
        End If
    End Sub
#Region "CategoryAttribute"
    Private _DataNotNull As Boolean = False
    Private _dataMaxlength As Integer = 18
    Private _oldText As String
    Public _decimalLength = 0
    <CategoryAttribute("DataMaxlength"),
    DefaultValueAttribute(18)>
    Public Property DataMaxLength As Integer
        Get
            Return _dataMaxlength
        End Get
        Set(value As Integer)
            If _decimalLength > 0 Then
                Me.MaxLength = value + 1
            Else
                Me.MaxLength = value
            End If
            _dataMaxlength = value
        End Set
    End Property
    <CategoryAttribute("DataNotNull"),
    DefaultValueAttribute(False)>
    Public Property DataNotNull As Boolean
        Get
            Return _DataNotNull
        End Get
        Set(value As Boolean)
            _DataNotNull = value
        End Set
    End Property
    <CategoryAttribute("OldTextValue"),
    DefaultValueAttribute("")>
    Public Property OldTextValue As String
        Get
            Return _oldText
        End Get
        Set(value As String)
            _oldText = value
        End Set
    End Property

    Private _MessageSubject = ""
    <CategoryAttribute("MessageSubject"),
    DefaultValueAttribute("")>
    Public Property MessageSubject As String
        Get
            Return _MessageSubject
        End Get
        Set(value As String)
            _MessageSubject = value
        End Set
    End Property

    Private _ShowEnterMessage As Boolean = False
    <CategoryAttribute("ShowEnterMessage"),
    DefaultValueAttribute(False)>
    Public Property ShowEnterMessage As Boolean
        Get
            Return _ShowEnterMessage
        End Get
        Set(value As Boolean)
            _ShowEnterMessage = value
        End Set
    End Property
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
    Private _IsMultiline As Boolean = False
    <Category("IsMultiline"),
    DefaultValue(False)>
    Public Property IsMultiline As Boolean
        Get
            Return _IsMultiline
        End Get
        Set(value As Boolean)
            _IsMultiline = value
        End Set
    End Property

    Private _DataNotNullSpace As Boolean = False
    <Category("DataNotNullSpace"),
    DefaultValue(False)>
    Public Property DataNotNullSpace As Boolean
        Get
            Return _DataNotNullSpace
        End Get
        Set(value As Boolean)
            _DataNotNullSpace = value
        End Set
    End Property
    Private _CheckLengthSingleByte As Boolean = False
    <Category("CheckLengthSingleByte"),
DefaultValue(False)>
    Public Property CheckLengthSingleByte As Boolean
        Get
            Return _CheckLengthSingleByte
        End Get
        Set(value As Boolean)
            _CheckLengthSingleByte = value
        End Set
    End Property
#End Region
#Region "Make Enter work like Tab"
    Dim _IsEnter As Boolean
    Dim _isEnterSendTab As Boolean = False
    Public Property IsEnter As Boolean
        Get
            Return _IsEnter
        End Get
        Set(value As Boolean)
            _IsEnter = value
        End Set
    End Property
    ''' <summary>
    ''' Make Enter work like Tab
    ''' </summary>
    ''' <param name="msg">Message</param>
    ''' <param name="keyData">Keys</param>
    ''' <returns></returns>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) _
        As Boolean
        If (keyData = Keys.Enter) Then
            'MyBase.ProcessCmdKey(msg, keyData)
            IsEnter = True
            _isEnterSendTab = True
            If Not _IsMultiline Then
                SendKeys.Send("{TAB}")
                'Parent.SelectNextControl(Me, True, True, True, True)
                Return True
            End If
        End If
        If IsEnter And _isEnterSendTab Then
            _isEnterSendTab = False
        Else
            IsEnter = False
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
#End Region
#Region "Select All When focus"

    Private alreadyFocused As Boolean
    ''' <summary>
    ''' OnLeave
    ''' </summary>
    ''' <param name="e">EventArgs</param>
    Protected Overrides Sub OnLeave(ByVal e As EventArgs)
        MyBase.OnLeave(e)

        Me.alreadyFocused = False

    End Sub
    ''' <summary>
    ''' Select all when Got Focus
    ''' </summary>
    ''' <param name="e">EventArgs</param>
    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        Me.SelectAll()

    End Sub
    ''' <summary>
    ''' OnMouseUp
    ''' </summary>
    ''' <param name="mevent">MouseEventArgs</param>
    Protected Overrides Sub OnMouseUp(ByVal mevent As MouseEventArgs)
        MyBase.OnMouseUp(mevent)


        If Not Me.alreadyFocused AndAlso Me.SelectionLength = 0 Then

            Me.alreadyFocused = True
            Me.SelectAll()

        End If

    End Sub

#End Region

#Region "Validate"
    '''' <summary>
    '''' IsValidate MaxLength
    '''' </summary>
    '''' <returns></returns>
    'Public Overridable Function IsValidate() As CM_ValidateReturn
    '    Dim bRet As CM_ValidateReturn = New CM_ValidateReturn(True, "")
    '    Try
    '        If IsNothing(Me.Tag) Then
    '            Me.Tag = ""
    '        End If
    '        bRet = CheckLenAndReq(Me.Tag.ToString(), Me.Text, DataMaxLength, DataNotNull)
    '        If Not bRet.Value Then
    '            Me.Select()

    '        End If

    '    Catch ex As Exception
    '        bRet = New CM_ValidateReturn(False, ex.Message)
    '        Me.Select()
    '    End Try
    '    Return bRet
    'End Function

#End Region
    Public ReadOnly Property TextIsNothingToString As String
        Get

            Dim prmReturn As String
            prmReturn = Nothing

            Try
                '値がある場合
                If Not Me.Text Is DBNull.Value Then
                    If Not String.IsNullOrEmpty(Me.Text) Then
                        '数値型の場合
                        prmReturn = CStr(Me.Text)
                    End If
                End If
                Return prmReturn
            Catch ex As System.Exception
                Throw ex
            Finally
            End Try
        End Get
    End Property

#Region "OnBackColorChanged"
    ''' <summary>
    ''' OnBackColorChanged
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnBackColorChanged(e As EventArgs)
        MyBase.OnBackColorChanged(e)
        If Me.BackColor = Color.White OrElse Me.BackColor = Color.FromArgb(240, 240, 240) Then
            If Me.ReadOnly OrElse Not Me.Enabled Then
                Me.BackColor = Color.FromArgb(240, 240, 240)
            Else
                Me.BackColor = Color.White
            End If
        End If
    End Sub
#End Region

#Region "ReadOnly Changed"
    ''' <summary>
    ''' OnEnabledChanged
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnReadOnlyChanged(e As EventArgs)
        MyBase.OnReadOnlyChanged(e)
        Try
            If Me.BackColor = Color.White OrElse Me.BackColor = Color.FromArgb(240, 240, 240) Then
                If Not Me.ReadOnly Then
                    Me.BackColor = Color.White
                Else
                    Me.BackColor = Color.FromArgb(240, 240, 240)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "OnEnabledChanged"
    ''' <summary>
    ''' OnEnabledChanged
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnEnabledChanged(e As EventArgs)
        MyBase.OnEnabledChanged(e)
        Try
            If Me.BackColor = Color.White OrElse Me.BackColor = Color.FromArgb(240, 240, 240) Then
                If Me.Enabled Then
                    Me.BackColor = Color.White
                Else
                    Me.BackColor = Color.FromArgb(240, 240, 240)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class