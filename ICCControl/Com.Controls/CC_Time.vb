
Imports System.ComponentModel

''' <summary>
''' CC_Number
''' </summary>
Public Class CC_Time
    ''' <summary>
    ''' OnCreateControl Overrides
    ''' </summary>
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        'Me.Multiline = True
        Me.Height = 20


    End Sub
#Region "Get Set Value"
    Dim _hour As String
    Dim _minute As String
    Dim _second As String

    Public Overrides Property Text As String
        Get
            Return MyBase.Text.Replace(":", "")
        End Get
        Set(value As String)
            If IsNothing(value) Then
                MyBase.Text = ""
            Else
                If value.Length < 6 Then
                    value = value.PadLeft(6, "0")
                End If
                MyBase.Text = String.Format("{0:00}:{1:00}:{2:00}", value.Substring(0, 2), value.Substring(2, 2), value.Substring(4, 2))
            End If


        End Set
    End Property
    ''' <summary>
    ''' SetTime
    ''' </summary>
    ''' <param name="phour"></param>
    ''' <param name="pMinute"></param>
    ''' <param name="pSecond"></param>
    Public Sub SetTime(ByVal phour As String, ByVal pMinute As String, ByVal pSecond As String)
        If IsNothing(phour) Then
            phour = ""
        End If
        If IsNothing(pMinute) Then
            pMinute = ""
        End If
        If IsNothing(pSecond) Then
            pSecond = ""
        End If
        'Set Nothing
        If phour = "" And pMinute = "" And pSecond = "" Then
            Me.Text = Nothing
            'Set Value
        Else
            If phour.Length < 2 Then
                phour = phour.PadLeft(2, "0")
            End If
            If pMinute.Length < 2 Then
                pMinute = pMinute.PadLeft(2, "0")
            End If
            If pSecond.Length < 2 Then
                pSecond = pSecond.PadLeft(2, "0")
            End If
            Me.Text = String.Format("{0:00}{1:00}{2:00}", phour, pMinute, pSecond)
        End If

    End Sub
    Public ReadOnly Property Hour As String
        Get
            If Me.Text.Length = 0 Then
                Return Nothing
            End If
            Return Me.Text.Substring(0, 2)
        End Get

    End Property

    Public ReadOnly Property Minute As String
        Get
            If Me.Text.Length = 0 Then
                Return Nothing
            End If
            Return Me.Text.Substring(2, 2)
        End Get

    End Property

    Public ReadOnly Property Second As String
        Get
            If Me.Text.Length = 0 Then
                Return Nothing
            End If
            Return Me.Text.Substring(4, 2)
        End Get

    End Property
#End Region
#Region "CategoryAttribute"

    'Private _decimalLength As Integer = 0

    Public Sub New()
        InitializeComponent()
        Me.DataMaxLength = 6
    End Sub

    <CategoryAttribute("DecimalLength"),
    DefaultValueAttribute(0)>
    Public Property DecimalLength As Integer
        Get
            Return _decimalLength
        End Get
        Set(value As Integer)
            If IsNothing(value) Then
                _decimalLength = 0
            Else
                _decimalLength = 0
                If value > 0 Then
                    _decimalLength = value
                End If
            End If
            If _decimalLength > DataMaxLength Then
                _decimalLength = DataMaxLength
            End If
        End Set
    End Property





#End Region

#Region "Validate Input"

    ''' <summary>
    ''' Just input Digit
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnKeyPress(ByVal e As _
     System.Windows.Forms.KeyPressEventArgs)
        Try
            Select Case DecimalLength
                Case 0
                    If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "-" And Me.Text.Length = 0)) Then
                        e.Handled = True
                    End If
                Case Else
                    If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "." And Me.Text.IndexOf(".") < 0) Or (e.KeyChar = "-" And Me.Text.Length = 0)) Then
                        e.Handled = True
                    End If
            End Select
        Catch ex As Exception

        End Try

    End Sub
    ''' <summary>
    ''' Valid when paste value
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)

        Try
            e.SuppressKeyPress = True 'Start by blocking all key presses.
            Select Case e.KeyData 'In order to not block some standard keyboard shortcuts.
                Case Keys.Control Or Keys.C 'Copy
                    Me.Copy()
                Case Keys.Control Or Keys.X 'Cut
                    Me.Cut()
                Case Keys.Control Or Keys.V 'Paste
                    Select Case Me.DecimalLength
                        'Int
                        Case 0
                            Dim oldValue As Integer
                            Integer.TryParse(Me.Text, oldValue)
                            Me.Paste()
                            Dim tempValue As Integer
                            If Not Integer.TryParse(Me.Text, tempValue) Then
                                Me.Text = oldValue.ToString()
                            End If
                            'Deciaml
                        Case Else
                            Dim oldValue As Decimal
                            Decimal.TryParse(Me.Text, oldValue)
                            Me.Paste()
                            Dim tempValue As Decimal
                            If Not Decimal.TryParse(Me.Text, tempValue) Then
                                Me.Text = oldValue.ToString()
                            End If
                    End Select

                Case Keys.Control Or Keys.A 'Select all.
                    Me.SelectAll()
                Case Else
                    e.SuppressKeyPress = False 'Allow all other key presses to be passed on to the KeyPress event.
            End Select
        Catch ex As Exception
            e.SuppressKeyPress = False 'Allow all other key presses to be passed on to the KeyPress event.
        End Try

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
    '        Select Case DecimalLength
    '            Case 0
    '                bRet = CheckLenAndReq(Me.Tag.ToString(), Me.Text, DataMaxLength, DataNotNull)
    '            Case Else
    '                If Me.Text.Contains(".") Then
    '                    Dim value = Me.Text.Split(".")
    '                    If value(0) > 0 Then
    '                        If value(0).Length > (DataMaxLength - DecimalLength) Or value(1).Length > DecimalLength Then
    '                            bRet = New CM_ValidateReturn(False, CM_Message.MESS_ERROR_LENGTH.Replace("{0}", CStr(Me.Tag.ToString() & ":(" & DataMaxLength & "," & DecimalLength & ")")))
    '                            Exit Select
    '                        End If
    '                        bRet = CheckLenAndReq(Me.Tag.ToString(), Me.Text.Replace(".", ""), DataMaxLength, DataNotNull)
    '                    Else
    '                        If value(1).Length > DecimalLength Then
    '                            bRet = New CM_ValidateReturn(False, CM_Message.MESS_ERROR_LENGTH.Replace("{0}", CStr(Me.Tag.ToString() & ":(" & DataMaxLength & "," & DecimalLength & ")")))
    '                            Exit Select
    '                        End If
    '                        '     bRet = CheckLenAndReq(Me.Tag.ToString(), Me.Text.Replace(".", ""), DataMaxLength, DataNotNull)
    '                    End If
    '                Else
    '                        If Me.Text.Length > (DataMaxLength - DecimalLength) Then
    '                        If Me.Text = 0 Then
    '                        Else
    '                            bRet = New CM_ValidateReturn(False, CM_Message.MESS_ERROR_LENGTH.Replace("{0}", CStr(Me.Tag.ToString() & ":(" & DataMaxLength & "," & DecimalLength & ")")))
    '                            Exit Select
    '                        End If
    '                    End If
    '                    bRet = CheckLenAndReq(Me.Tag.ToString(), Me.Text, DataMaxLength - DecimalLength, DataNotNull)
    '                End If

    '        End Select
    '        If Not bRet.Value Then
    '            Me.Select()

    '        End If

    '    Catch ex As Exception
    '        bRet = New CM_ValidateReturn(False, ex.Message)
    '        Me.Select()
    '    End Try
    '    Return bRet
    'End Function
    '''' <summary>
    '''' Validate Input value type is MMdd
    '''' </summary>
    '''' <returns>CM_ValidateReturn</returns>
    'Public Function IsValidateMonthDate() As CM_ValidateReturn
    '    Dim bRet As CM_ValidateReturn = New CM_ValidateReturn(True, "")
    '    Try
    '        If IsNothing(Me.Tag) Then
    '            Me.Tag = ""
    '        End If
    '        bRet = CheckLenAndReq(Me.Tag.ToString(), Me.Text, 4, DataNotNull)
    '        If bRet.Value Then
    '            If Me.Text.Length <> 4 Then
    '                Throw New Exception(CM_Message.MESS_ERROR_LENGTH.Replace("{0}", CStr(Me.Tag.ToString() & ":" & 4)))
    '            End If
    '            Dim month As Integer
    '            Dim day As Integer
    '            ' TryParse value
    '            If Integer.TryParse(Me.Text.Substring(0, 2), month) And Integer.TryParse(Me.Text.Substring(2, 2), day) Then
    '                ' Check Month valid
    '                If month < 1 Or month > 12 Then
    '                    Throw New Exception(CM_Message.MESS_ERROR_INPUT_CHECK)
    '                End If
    '                'Check Date Valid
    '                Dim numDays As Integer = DateTime.DaysInMonth(Now.Year, month)
    '                If day < 1 Or day > numDays Then
    '                    Throw New Exception(CM_Message.MESS_ERROR_INPUT_CHECK)
    '                End If
    '            Else
    '                    Throw New Exception(CM_Message.MESS_ERROR_INPUT_CHECK)
    '            End If


    '        Else
    '                Me.Select()
    '        End If

    '    Catch ex As Exception
    '        bRet = New CM_ValidateReturn(False, ex.Message)
    '        Me.Select()
    '    End Try
    '    Return bRet
    'End Function
#End Region

End Class
