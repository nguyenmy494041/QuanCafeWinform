''' <summary>
''' JP カレンダー
''' </summary>
Public Class CC_CalendarJP
#Region "Public Properties"
    ''' <summary>
    ''' Full text without  年 月 日
    ''' </summary>
    ''' <returns></returns>
    Public Property Value
        Get
            Return txtValue.Text.Replace("年", "").Replace("月", "").Replace("日", "")
        End Get
        Set
            txtValue.Text = Value
        End Set
    End Property
    ''' <summary>
    ''' 年
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Year As Integer
        Get
            Dim value As String = txtValue.Text.Replace("年", "").Replace("月", "").Replace("日", "")
            If value.Length < 6 Then
                value = value.PadRight(6, "0")

            End If
            Dim _year As Integer = CInt(value.Substring(0, 2))
            Return _year
        End Get

    End Property
    ''' <summary>
    ''' 月
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Month As Integer
        Get
            Dim value As String = txtValue.Text.Replace("年", "").Replace("月", "").Replace("日", "")
            If value.Length < 6 Then
                value = value.PadRight(6, "0")

            End If
            Dim _month As Integer = CInt(value.Substring(2, 2))
            Return _month
        End Get

    End Property
    ''' <summary>
    ''' 日
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Day As Integer
        Get
            Dim value As String = txtValue.Text.Replace("年", "").Replace("月", "").Replace("日", "")
            If value.Length < 6 Then
                value = value.PadRight(6, "0")

            End If
            Dim _day As Integer = CInt(value.Substring(4, 2))
            Return _day
        End Get

    End Property
#End Region

#Region "TextBox Event"
    ''' <summary>
    ''' Just input Digit
    ''' </summary>
    ''' <param name="e"></param>
    Private Sub txtValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValue.KeyPress
        Try
            If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
                e.Handled = True
            End If
        Catch ex As Exception

        End Try

    End Sub
    ''' <summary>
    ''' Catch press delete
    ''' </summary>
    ''' <param name="e"></param>
    Private Sub txtValue_KeyUp(sender As Object, e As KeyEventArgs) Handles txtValue.KeyUp
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            IsDelete = True
        Else
            IsDelete = False
        End If
    End Sub

    Private IsTextChange As Boolean = False
    Private IsDelete As Boolean = False
    Private Sub txtValue_TextChanged(sender As Object, e As EventArgs) Handles txtValue.TextChanged
        ' Set Value for textbox
        Try
            If IsTextChange Then
                IsTextChange = False
                Return
            End If
            IsTextChange = True
            If Not IsDelete Then
                Dim oldPosition As Integer = txtValue.SelectionStart
                Dim oldSelectLength = txtValue.SelectionLength
                Dim oldLength = txtValue.TextLength
                Dim value As String = txtValue.Text.Replace("年", "").Replace("月", "").Replace("日", "")
                If value.Length = 2 Then
                    value = value.Substring(0, 2) + "年"
                    oldPosition += 1
                    txtValue.Text = value
                    txtValue.Select(oldPosition, oldSelectLength)

                ElseIf value.Length = 4 Then
                    value = value.Substring(0, 2) + "年" + value.Substring(2, 2) + "月"
                    oldPosition += 2
                    txtValue.Text = value
                    txtValue.Select(oldPosition, oldSelectLength)

                ElseIf value.Length >= 6 Then
                    value = value.Substring(0, 6)
                    value = value.Substring(0, 2) + "年" + value.Substring(2, 2) + "月" + value.Substring(4, 2) + "日"
                    oldPosition += 3
                    txtValue.Text = value
                    txtValue.Select(oldPosition, oldSelectLength)
                End If
            End If
        Catch ex As Exception
        Finally
            IsTextChange = False

        End Try

        'Set Value for DateTimePicker
        IsPickDate = True
        Try
            Dim value As String = txtValue.Text.Replace("年", "").Replace("月", "").Replace("日", "")
            If value.Length < 6 Then
                value = value.PadRight(6, "0")
            End If
            Dim _year As Integer = CInt(value.Substring(0, 2)) - 12 + 2000
            Dim _month As Integer = CInt(value.Substring(2, 2))
            Dim _day As Integer = CInt(value.Substring(4, 2))
            dtpCalendar.setValue(_year, _month, _day)
        Catch ex As Exception
            dtpCalendar.Value = Date.Now
        Finally
            IsPickDate = False
        End Try

        IsDelete = False
    End Sub


#End Region
#Region "Picker Event"
    Private IsPickDate As Boolean = False
    Private _Value As Object
    Private _Year As Object
    Private _Month As Object
    Private _Day As Object


    ''' <summary>
    ''' Set Value from DateTimePicker To TextBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dtpCalendar_ValueChanged(sender As Object, e As EventArgs) Handles dtpCalendar.ValueChanged
        Try
            IsDelete = False
            If IsPickDate Then
                IsPickDate = False
                Return
            End If

            Dim _year As Integer = dtpCalendar.Value.Year + 12 - 2000
            txtValue.Text = _year.ToString + dtpCalendar.Value.Month.ToString.PadLeft(2, "0") + dtpCalendar.Value.Day.ToString.PadLeft(2, "0")
        Catch ex As Exception

        End Try
    End Sub


#End Region
#Region "[F4]キー押下時にこれらのドロップダウンを無効にするには、コントロール毎にKeyDownイベントで無効にする方法があります。"
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        Try
            ' [F4]キー押下時のドロップダウンを無効にする
            If (e.KeyCode = Keys.F4) Then
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
