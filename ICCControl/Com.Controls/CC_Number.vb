
Imports System.ComponentModel

''' <summary>
''' CC_Number
''' </summary>
Public Class CC_Number
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.Text = ""
        Me.Font = New System.Drawing.Font("MS Gothic", 9.0!)
    End Sub
    ''' <summary>
    ''' OnCreateControl Overrides
    ''' </summary>
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        'Me.Multiline = True
        Me.Height = 20
        If _AllowDashNumber Then
            Me.FormatMask = -1
        End If
        Select Case FormatMask
            Case 1
                Me.DataMaxLength = 7
        End Select
    End Sub
#Region "CategoryAttribute"

    'Protected _decimalLength As Integer = 0
    Private _isCurrency = False
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
            If _decimalLength > 0 Then
                Me.MaxLength = DataMaxLength + 1
            End If
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            If IsCurrency Then
                Return MyBase.Text.Replace(",", "")
            Else
                Return MyBase.Text
            End If


        End Get
        Set(value As String)
            If IsCurrency Then
                Try
                    If value.ToString.Replace(".", "").Length > 3 Then
                        Dim valueConvert = FormatNumber(value, DecimalLength,,, TriState.True)
                        Dim commaCount = valueConvert.ToString.Count(Function(c As Char) c = ",")
                        Dim dotCount = valueConvert.ToString.Count(Function(c As Char) c = ".")
                        Me.MaxLength = DataMaxLength + commaCount + dotCount

                        MyBase.Text = valueConvert
                    Else
                        MyBase.Text = value
                    End If

                    Me.Show()
                Catch ex As Exception
                    MyBase.Text = value
                End Try

            Else
                MyBase.Text = value
            End If
        End Set
    End Property
    <CategoryAttribute("IsCurrency"),
    DefaultValueAttribute(False)>
    Public Property IsCurrency As Boolean
        Get
            Return _isCurrency
        End Get
        Set(value As Boolean)
            _isCurrency = value
            If IsCurrency Then
                Me.TextAlign = HorizontalAlignment.Right
            End If
        End Set
    End Property

    Private _FormatMask As Integer
    <Category("FormatMask"),
   DefaultValue(0)>
    Public Property FormatMask As Integer
        Get
            Return _FormatMask
        End Get
        Set(value As Integer)
            _FormatMask = value
        End Set
    End Property


    Private _FocusKeepNumber As Boolean
    <Category("FocusKeepNumber"),
   DefaultValue(False)>
    Public Property FocusKeepNumber As Boolean
        Get
            Return _FocusKeepNumber
        End Get
        Set(value As Boolean)
            _FocusKeepNumber = value
        End Set
    End Property
    Private _AllowDashNumber As Boolean
    <Category("AllowDashNumber"),
   DefaultValue(False)>
    Public Property AllowDashNumber As Boolean
        Get
            Return _AllowDashNumber
        End Get
        Set(value As Boolean)
            _AllowDashNumber = value
        End Set
    End Property
    Private _ZeroIsNull As Boolean
    <Category("ZeroIsNull"),
   DefaultValue(False)>
    Public Property ZeroIsNull As Boolean
        Get
            Return _ZeroIsNull
        End Get
        Set(value As Boolean)
            _ZeroIsNull = value
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
                    If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "-" And _AllowDashNumber)) Then
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
#Region "FomatText"
    Private IsTextChange As Boolean = False
    Protected Overrides Sub OnTextChanged(e As EventArgs)
        If IsTextChange Then
            MyBase.OnTextChanged(e)
            Return
        End If
        IsTextChange = True
        MyBase.OnTextChanged(e)
        Dim oldPosition As Integer = Me.SelectionStart
        Dim oldSelectLength = Me.SelectionLength
        Dim oldLength = Me.TextLength
        Me.Text = Me.Text


        If (oldPosition + Me.TextLength - oldLength) >= 0 Then
            Me.Select(oldPosition + Me.TextLength - oldLength, oldSelectLength)
        End If
        IsTextChange = False
    End Sub
#End Region



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

#Region "Focus"
    ''' <summary>
    ''' OnGotFocus
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnEnter(e As EventArgs)
        MyBase.OnEnter(e)
        Try
            If Not String.IsNullOrEmpty(Me.Text) Then
                Select Case FormatMask
                    Case 0
                        If Not FocusKeepNumber Then
                            If Me.Text.Length > 0 Then
                                Me.Text = CDec(Me.Text).ToString
                            End If
                        End If
                    Case 1
                        Me.Text = Me.Text.Replace("-", "")
                        Me.Select(0, 7)
                    Case 3
                        Me.Text = ConvertJapaneseEra()
                End Select
            End If
        Catch ex As Exception
        End Try
    End Sub
    ''' <summary>
    ''' OnLostFocus
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)
        Try
            If Not String.IsNullOrEmpty(Me.Text) Then
                Select Case FormatMask
                    Case 0

                        Me.Text = Me.Text.PadLeft(Me.DataMaxLength, "0")
                    Case 1
                        Me.Text = Me.Text.PadRight(7, "0").Insert(3, "-")
                    Case 3
                        Me.Text = JapaneseEra(Me.Text)
                End Select
            Else
                If _ZeroIsNull Then
                    Me.Text = "0"
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    ''' <summary>
    ''' JapaneseEraName
    ''' </summary>
    ''' <returns></returns>
    Private Function JapaneseEra(ByVal pDate As Integer) As String
        Try
            'Reiwa(令和) :  01/05/2019 – Now
            'Heisei(平成) :  1989 – <=2019
            'Showa(昭和) :  1926–1989
            'Taisho(大正) :  1912–1926
            'Meiji(明治) :  1868–1912
            Dim strDate As String = ""
            Dim dtDateTime As System.DateTime
            Try
                If Me.DataMaxLength = 4 Then
                    dtDateTime = DateTime.ParseExact(pDate & "0101", "yyyyMMdd", New System.Globalization.CultureInfo("ja-JP"))
                ElseIf Me.DataMaxLength = 6 Then
                    dtDateTime = DateTime.ParseExact(pDate & "01", "yyyyMMdd", New System.Globalization.CultureInfo("ja-JP"))
                ElseIf Me.DataMaxLength = 8 Then
                    dtDateTime = DateTime.ParseExact(pDate, "yyyyMMdd", New System.Globalization.CultureInfo("ja-JP"))
                End If
            Catch
                Return ""
            End Try
            If Me.DataMaxLength = 4 Then
                Select Case True
                    Case pDate >= 1868 And pDate <= 1912
                        strDate = "M " & (pDate - 1868 + 1).ToString().PadLeft(2, "0")
                    Case pDate > 1912 And pDate <= 1926
                        strDate = "T " & (pDate - 1912 + 1).ToString().PadLeft(2, "0")
                    Case pDate > 1926 And pDate <= 1989
                        strDate = "S " & (pDate - 1926 + 1).ToString().PadLeft(2, "0")
                    Case pDate > 1989 And pDate < 2019
                        strDate = "H " & (pDate - 1989 + 1).ToString().PadLeft(2, "0")
                    Case pDate >= 2019
                        strDate = "R " & (pDate - 2019 + 1).ToString().PadLeft(2, "0")
                    Case Else
                        Return ""
                End Select
            ElseIf Me.DataMaxLength = 6 Then
                Select Case True
                    Case pDate >= 186811 And pDate <= 191207
                        strDate = "M " & ((pDate - 186800 + 100).ToString().PadLeft(4, "0").Insert(2, "/"))
                    Case pDate > 191207 And pDate <= 192612
                        strDate = "T " & ((pDate - 191200 + 100).ToString().PadLeft(4, "0").Insert(2, "/"))
                    Case pDate > 192612 And pDate <= 198901
                        strDate = "S " & ((pDate - 192600 + 100).ToString().PadLeft(4, "0").Insert(2, "/"))
                    Case pDate > 198901 And pDate < 201905
                        strDate = "H " & ((pDate - 198900 + 100).ToString().PadLeft(4, "0").Insert(2, "/"))
                    Case pDate >= 201905
                        strDate = "R " & ((pDate - 201900 + 100).ToString().PadLeft(4, "0").Insert(2, "/"))
                    Case Else
                        Return ""
                End Select
            ElseIf Me.DataMaxLength = 8 Then
                Select Case True
                    Case pDate >= 18681101 And pDate <= 19120729
                        strDate = "M " & ((pDate - 18680000 + 10000).ToString().PadLeft(6, "0").Insert(2, "/").Insert(5, "/"))
                    Case pDate > 19120729 And pDate <= 19261224
                        strDate = "T " & ((pDate - 19120000 + 10000).ToString().PadLeft(6, "0").Insert(2, "/").Insert(5, "/"))
                    Case pDate > 19261224 And pDate <= 19890107
                        strDate = "S " & ((pDate - 19260000 + 10000).ToString().PadLeft(6, "0").Insert(2, "/").Insert(5, "/"))
                    Case pDate > 19890107 And pDate < 20190501
                        strDate = "H " & ((pDate - 19890000 + 10000).ToString().PadLeft(6, "0").Insert(2, "/").Insert(5, "/"))
                    Case pDate >= 20190501
                        strDate = "R " & ((pDate - 20190000 + 10000).ToString().PadLeft(6, "0").Insert(2, "/").Insert(5, "/"))
                    Case Else
                        Return ""
                End Select
            End If
            Return strDate
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' JapaneseEraName
    ''' </summary>
    ''' <returns></returns>
    Private Function ConvertJapaneseEra() As String
        Try
            Dim JEraName = Me.Text
            If Me.DataMaxLength = 4 Then
                JEraName = JEraName & "0000"
            ElseIf Me.DataMaxLength = 6 Then
                JEraName = JEraName & "00"
            End If
            Select Case True
                Case JEraName.Contains("M")
                    JEraName = CInt(JEraName.Replace("M ", "").Replace("/", "")) + 18680000 - 10000
                Case JEraName.Contains("T")
                    JEraName = CInt(JEraName.Replace("T ", "").Replace("/", "")) + 19120000 - 10000
                Case JEraName.Contains("S")
                    JEraName = CInt(JEraName.Replace("S ", "").Replace("/", "")) + 19260000 - 10000
                Case JEraName.Contains("H")
                    JEraName = CInt(JEraName.Replace("H ", "").Replace("/", "")) + 19890000 - 10000
                Case JEraName.Contains("R")
                    JEraName = CInt(JEraName.Replace("R ", "").Replace("/", "")) + 20190000 - 10000
                Case Else
                    Return ""
            End Select
            If Me.DataMaxLength = 4 Then
                Return JEraName.Substring(0, 4)
            ElseIf Me.DataMaxLength = 6 Then
                Return JEraName.Substring(0, 6)
            ElseIf Me.DataMaxLength = 8 Then
                Return JEraName
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region



    Public ReadOnly Property TextIsMinToDateString As Date
        Get
            If Me.TextIsNothingToString IsNot Nothing Then
                Return Date.ParseExact(ConvertJapaneseEra(), "yyyyMMdd", Globalization.CultureInfo.CurrentCulture)
            End If
            Return Date.MinValue
        End Get
    End Property
    Public ReadOnly Property TextIsZeroToDecimal As Decimal
        Get
            Dim prmReturn As Decimal = 0
            If Me.TextIsNothingToString IsNot Nothing Then
                Try
                    'Check if there's text
                    If IsNothing(Me.Text) = False Then
                        If Not (Me.Text Is DBNull.Value) Then
                            'Check if numeric
                            If IsNumeric(Me.Text) = True Then
                                'Convert to decimal
                                prmReturn = CDec(Me.Text)
                            End If
                        End If
                    End If
                Catch ex As System.Exception
                    prmReturn = 0
                End Try
            End If
            Return prmReturn
        End Get
    End Property

    Public ReadOnly Property TextIsJapaneseEraToString As String
        Get
            If Me.TextIsNothingToString IsNot Nothing Then
                Return ConvertJapaneseEra()
            End If
            Return ""
        End Get
    End Property

End Class
