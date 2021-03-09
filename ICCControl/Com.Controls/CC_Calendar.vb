Imports System.ComponentModel
Imports System.Globalization

Public Class CC_Calendar

    ''' <summary>
    ''' OnCreateControl Overrides
    ''' </summary>
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()

        Me.Height = 20
        Me.Format = DateTimePickerFormat.Custom
        'Me.CustomFormat = "yyyy/MM/dd"
    End Sub

    Public Sub New()
        Me.Height = 20
        Me.Format = DateTimePickerFormat.Custom
        Me.CustomFormat = "yyyy/MM/dd"
        InitializeComponent()
    End Sub
#Region "CategoryAttribute"
    Private _IsFirstControl As Boolean = False
    <CategoryAttribute("IsFirstControl"),
    DefaultValueAttribute(False)>
    Public Property IsFirstControl As Boolean
        Get
            Return _IsFirstControl
        End Get
        Set(value As Boolean)
            _IsFirstControl = value
        End Set
    End Property
    Private _DataNotNull As Boolean = False
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
    Private _MaxValueFomat As String = "9999/12/31"
    Private _MinValueFomat As String = "0000/00/00"
    <CategoryAttribute("MaxValueFomat"),
    DefaultValueAttribute("9999/12/31")>
    Public Property MaxValueFomat As String
        Get
            Return _MaxValueFomat
        End Get
        Set(value As String)
            _MaxValueFomat = value
        End Set
    End Property
    <CategoryAttribute("MaxValueFomat"),
    DefaultValueAttribute("0000/00/00")>
    Public Property MinValueFomat As String
        Get
            Return _MinValueFomat
        End Get
        Set(value As String)
            _MinValueFomat = value
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
#End Region

#Region "Get-Set Value"
    ''' <summary>
    ''' getValue
    ''' </summary>
    ''' <param name="_fomat">default is yyyyMMdd</param>
    ''' <returns></returns>
    Public Function getValue(Optional ByVal _fomat As String = "yyyyMMdd") As String
        Dim value As Object
        Try
            If Me.CustomFormat.Trim() = "" Then
                Return Nothing
            End If
            If Me.Value = Me.MaxDate Then
                value = "99991231"
            ElseIf Me.Value = Me.MinDate Then
                value = "00000000"
            Else
                value = Me.Value.ToString(_fomat)
            End If

        Catch ex As Exception
            Return Nothing
        End Try
        Return value
    End Function
    Enum ValueTypeEnum
        NormalValue = 0
        NothingValue = 1
        MinValue = 2
        Maxvalue = 3
    End Enum
    ''' <summary>
    ''' setFomat
    ''' </summary>
    ''' <param name="valueType">ValueTypeEnum</param>
    Private Sub setFomat(valueType As ValueTypeEnum)
        If Not (Me.CustomFormat = " " Or Me.CustomFormat = MaxValueFomat Or Me.CustomFormat = MinValueFomat) Then
            _currentFomat = Me.CustomFormat
        End If
        Select Case valueType
            Case 0 'Normal
                Me.CustomFormat = _currentFomat
            Case 1 'Nothing
                Me.CustomFormat = " "
            Case 2 'Minvalue
                Me.CustomFormat = MinValueFomat
            Case 3 'Maxvalue
                Me.CustomFormat = MaxValueFomat
        End Select

    End Sub
    ''' <summary>
    ''' CheckValueType
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns>ValueTypeEnum</returns>
    Private Function CheckValueType(ByVal value As Integer?) As ValueTypeEnum

        If IsNothing(value) Then
            Return ValueTypeEnum.NothingValue
        End If
        If value.ToString = Me.MaxDate.ToString("yyyyMMdd") Or value = 99991231 Or value = 9999 Then
            Return ValueTypeEnum.Maxvalue
        End If
        If value.ToString = Me.MinDate.ToString("yyyyMMdd") Or value = 101 Or value = 0 Or value = 10101 Then
            Return ValueTypeEnum.MinValue
        End If
        Return ValueTypeEnum.NormalValue
    End Function
    ''' <summary>
    ''' GetDateFromValue
    ''' </summary>
    ''' <param name="value">yyyyMMdd or yyMMdd</param>
    Public Sub setValue(ByVal value As Integer?)
        Try
            setFomat(CheckValueType(value))
            Dim valueParse As String = value.ToString()
            If valueParse = "101" Or valueParse = "0" Or valueParse = "10101" Then
                Me.Value = Me.MinDate
                Return
            End If

            If valueParse.Length = 8 Then
                If valueParse = "99991231" Then
                    Me.Value = MaxDate
                Else
                    Me.Value = New Date(CInt(valueParse.Substring(0, 4)), CInt(valueParse.Substring(4, 2)), CInt(valueParse.Substring(6, 2)))
                End If

            End If
            If valueParse.Length = 6 Then
                Dim year As String

                If CInt(valueParse.Substring(0, 2)) >= 40 Then
                    year = "19" + valueParse.Substring(0, 2)
                Else
                    year = "20" + valueParse.Substring(0, 2)
                End If
                Me.Value = New Date(CInt(year), CInt(valueParse.Substring(2, 2)), CInt(valueParse.Substring(4, 2)))
            End If
        Catch ex As Exception
            If Not (Me.CustomFormat = " " Or Me.CustomFormat = MaxValueFomat Or Me.CustomFormat = MinValueFomat) Then
                _currentFomat = Me.CustomFormat
            End If
            Me.CustomFormat = " "
        End Try

    End Sub



    ''' <summary>
    ''' setValue
    ''' </summary>
    ''' <param name="year"></param>
    ''' <param name="month"></param>
    ''' <param name="day"></param>
    Public Sub setValue(ByVal year As Integer?, ByVal month As Integer?, ByVal day As Integer?)
        Try
            If IsNothing(year) Or IsNothing(month) Or IsNothing(day) Then
                setFomat(CheckValueType(Nothing))
                Return
            ElseIf year = 0 And month = 0 And day = 0 Then
                setFomat(CheckValueType(0))
                Me.Value = Me.MinDate
                Return
            Else
                setFomat(CheckValueType(year))
            End If
            Me.Value = New Date(year, month, day)
        Catch ex As Exception
            If Not (Me.CustomFormat = " " Or Me.CustomFormat = MaxValueFomat Or Me.CustomFormat = MinValueFomat) Then
                _currentFomat = Me.CustomFormat
            End If
            Me.CustomFormat = " "
        End Try

    End Sub
    ''' <summary>
    ''' setValue
    ''' </summary>
    ''' <param name="year"></param>
    ''' <param name="month"></param>
    ''' <param name="day"></param>
    ''' <param name="hour"></param>
    ''' <param name="minute"></param>
    ''' <param name="second"></param>
    Public Sub setValue(ByVal year As Integer?, ByVal month As Integer?, ByVal day As Integer?, ByVal hour As Integer?, ByVal minute As Integer?, ByVal second As Integer?)
        Try
            If IsNothing(year) Or IsNothing(month) Or IsNothing(day) Or IsNothing(hour) Or IsNothing(minute) Or IsNothing(second) Then
                setFomat(CheckValueType(Nothing))
                Return
            Else
                setFomat(CheckValueType(year))
            End If
            If year = 9999 And month = 12 And day = 31 Then
                Me.Value = Me.MaxDate
            ElseIf year = 0 And month = 1 And day = 1 Then
                Me.Value = Me.MinDate
            Else
                Me.Value = New Date(year, month, day, hour, minute, second)
            End If
        Catch ex As Exception
            If Not (Me.CustomFormat = " " Or Me.CustomFormat = MaxValueFomat Or Me.CustomFormat = MinValueFomat) Then
                _currentFomat = Me.CustomFormat
            End If
            Me.CustomFormat = " "
        End Try

    End Sub
    ''' <summary>
    ''' getYearValue yyyy
    ''' </summary>
    ''' <returns></returns>
    Public Function getYearValue() As Integer?
        Try
            If String.IsNullOrEmpty(Me.getValue()) Then
                Return Nothing
            Else
                If Me.Value = Me.MaxDate Then
                    Return 9999
                ElseIf Me.Value = Me.MinDate Then
                    Return 0
                Else
                    Return Me.Value.Year
                End If
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' getMonthValue MM
    ''' </summary>
    ''' <returns></returns>
    Public Function getMonthValue() As Integer?
        Try
            If String.IsNullOrEmpty(Me.getValue()) Then
                Return Nothing
            Else
                If Me.Value = Me.MaxDate Then
                    Return 12
                ElseIf Me.Value = Me.MinDate Then
                    Return 0
                Else
                    Return Me.Value.Month
                End If
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' getYearValue dd
    ''' </summary>
    ''' <returns></returns>
    Public Function getDayValue() As Integer?
        Try
            If String.IsNullOrEmpty(Me.getValue()) Then
                Return Nothing
            Else
                If Me.Value = Me.MaxDate Then
                    Return 31
                ElseIf Me.Value = Me.MinDate Then
                    Return 0
                Else
                    Return Me.Value.Day
                End If
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' getHourValue hh
    ''' </summary>
    ''' <returns></returns>
    Public Function getHourValue() As Integer?
        Try
            If String.IsNullOrEmpty(Me.getValue()) Then
                Return Nothing
            Else
                Return Me.Value.Hour
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' getMinuteValue mm
    ''' </summary>
    ''' <returns></returns>
    Public Function getMinuteValue() As Integer?
        Try
            If String.IsNullOrEmpty(Me.getValue()) Then
                Return Nothing
            Else
                Return Me.Value.Minute
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' getSecondValue ss
    ''' </summary>
    ''' <returns></returns>
    Public Function getSecondValue() As Integer?
        Try
            If String.IsNullOrEmpty(Me.getValue()) Then
                Return Nothing
            Else
                Return Me.Value.Second
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region

#Region "Validate Input"
    Private _currentFomat As String = " "

    ''' <summary>
    ''' OnKeyDown
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        Dim str = Me.getValue
        Try
            If Not (Me.CustomFormat = " " Or Me.CustomFormat = MaxValueFomat Or Me.CustomFormat = MinValueFomat) Then
                _currentFomat = Me.CustomFormat
            End If
            If (e.KeyCode = Keys.Delete) Or (e.KeyCode = Keys.Clear) Then

                Me.CustomFormat = " "

                e.Handled = True
            Else
                Me.CustomFormat = _currentFomat
            End If
            ' [F4]キー押下時のドロップダウンを無効にする
            If (e.KeyCode = Keys.F4) Then
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub OnCloseUp(eventargs As EventArgs)
        MyBase.OnCloseUp(eventargs)
        Try
            If Not (Me.CustomFormat = " " Or Me.CustomFormat = MaxValueFomat Or Me.CustomFormat = MinValueFomat) Then
                _currentFomat = Me.CustomFormat
            End If
            Me.CustomFormat = _currentFomat
        Catch ex As Exception

        End Try
        Me.Refresh()

    End Sub


    Protected Overrides Sub OnGotFocus(e As EventArgs)
        'MyBase.OnGotFocus(e)
        If IsNothing(Me.getValue) Then
            If IsFirstControl Then
                IsFirstControl = False
            Else
                SendKeys.Send("{RIGHT 1}")
            End If
        End If
    End Sub



#End Region
    ''' <summary>
    ''' OnValueChanged
    ''' </summary>
    ''' <param name="eventargs"></param>
    Protected Overrides Sub OnValueChanged(eventargs As EventArgs)

        Try
            setFomat(CheckValueType(Me.getValue))
            MyBase.OnValueChanged(eventargs)
        Catch ex As Exception

        End Try
    End Sub




    Dim str As String = ""
    Private isdel As Boolean = False
    Private so As Integer = 0
    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        Try
            Dim b = Me.GetType.GetProperties

            Dim c = Me.GetType.GetFields
            str = Me.getValue()
            If Asc(e.KeyChar) = 8 Then
                str = Me.getValue()
                Dim y = CInt(str.Substring(0, 4)) \ 10
                'Me.Value = New DateTime(CInt(CInt(str.Substring(0, 4)) \ 10), CInt(str.Substring(4, 2)), CInt(str.Substring(6, 2)))
                Me.setValue(y, CInt(str.Substring(4, 2)), CInt(str.Substring(6, 2)))

                'Dim b = Me.GetType.GetProperties
                'Dim c = Me.GetType.GetFields
                Dim va = Me.Value
            End If
            'If Char.IsDigit(e.KeyChar) Then
            '    so += 1
            '    If so Mod 6 = 0 OrElse so Mod 4 = 0 Then
            '        SendKeys.Send("{right}")
            '    End If
            '    If so = 8 Then
            '        so = 0
            '    End If
            'End If
        Catch ex As Exception
        End Try
    End Sub






End Class
