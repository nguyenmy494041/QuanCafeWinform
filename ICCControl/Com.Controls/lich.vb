Public Class lich



    Private check As Boolean = True
    Private luu As String = ""

    Public Property Format As String
        Get
            Return calendar.CustomFormat
        End Get
        Set(value As String)
            calendar.CustomFormat = value
        End Set
    End Property



    Public Property Value
        Get
            Dim val = txtValue.Text
            Dim str = txtValue.Text.Replace("/", "")
            Dim len = str.Length
            If len < 5 Then
                Return Nothing
                'ElseIf len = 4 Then
                '    val = str & "/01/01"
            ElseIf len < 6 Then
                val = str.Substring(0, 4) & "/" & str.Substring(4, len - 4) & "/01"
            ElseIf len < 7 Then
                val = str.Substring(0, 4) & "/" & str.Substring(4, 2) & str.Substring(6, len - 6)
            End If
            Return CDate(val)
        End Get
        Set
            txtValue.Text = Value
        End Set
    End Property

    Public ReadOnly Property Year As Integer?
        Get
            Dim value As String = txtValue.Text.Replace("/", "")
            If value.Length < 5 Then
                Return Nothing
            Else
                Return value.Substring(0, 4)
            End If

        End Get
    End Property

    Public ReadOnly Property Month As Integer?
        Get
            Dim value As String = txtValue.Text.Replace("/", "")
            If value.Length < 5 Then
                Return Nothing
            ElseIf value.Length < 7 Then
                Return CInt(value.Substring(4, value.Length - 4))
            Else
                Dim a = value.Substring(4, 2)
                Return CInt(a)
            End If
        End Get
    End Property

    Public ReadOnly Property Day As Integer?
        Get
            Dim value As String = txtValue.Text.Replace("/", "")
            If value.Length < 5 Then
                Return Nothing
            ElseIf value.Length < 7 Then
                Return 1
            Else
                Return CInt(value.Substring(6, value.Length - 6))
            End If
        End Get
    End Property

    Private Sub txtValue_TextChanged(sender As Object, e As EventArgs) Handles txtValue.TextChanged
        'Try
        Dim str = txtValue.Text
            Dim len = str.Length
            Dim count As Integer = 0
            For Each key As Char In str
                If key = CChar("/") Then
                    count += 1
                End If
            Next
            Dim arr = str.Split("/")
            If len = 3 Or len = 6 Then
                check = True
            End If
            If check Then
                If len = 4 Or len = 7 Then
                    str &= "/"
                    txtValue.Text = str
                    txtValue.SelectionStart = str.Length
                End If
            End If

        If count = 2 AndAlso arr(2) <> "" Then
            Dim day = CInt(arr(2))
            Dim month = CInt(arr(1))
            Dim year = CInt(arr(0))
            If year < 1000 OrElse year > 9999 Or month > 12 Then
                txtValue.Text = luu
                txtValue.SelectionStart = luu.Length
            Else


                If year Mod 400 = 0 Or (year Mod 4 = 0 And year Mod 100 > 0) Then
                    If month = 2 Then
                        If day > 29 Then
                            txtValue.Text = str.Substring(0, 8)
                            txtValue.SelectionStart = 8
                        End If
                    End If
                Else
                    If month = 2 Then
                        If day > 28 Then
                            txtValue.Text = str.Substring(0, 8)
                            txtValue.SelectionStart = 8
                        End If
                    End If
                End If
                Select Case month
                    Case 1, 3, 5, 7, 8, 10, 12
                        If day > 31 Then
                            txtValue.Text = str.Substring(0, 8)
                            txtValue.SelectionStart = 8
                        End If
                    Case 4, 6, 9, 11
                        If day > 30 Then
                            txtValue.Text = str.Substring(0, 8)
                            txtValue.SelectionStart = 8
                        End If
                End Select
            End If
        ElseIf count = 1 AndAlso arr(1) <> "" Then
            If arr(0) > 9999 Or arr(0) < 1000 Then
                txtValue.Text = luu
                txtValue.SelectionStart = luu.Length
            Else


                Dim month = CInt(arr(1))
                If month > 12 Then
                    txtValue.Text = str.Substring(0, 5)
                    txtValue.SelectionStart = 5
                End If
            End If
        Else
            If len > 3 Then
                Dim year = CInt(arr(0))
                If year < 1753 Or year > 9999 Then
                    Dim yy = str.Substring(2, 2)
                    Dim y = CInt(yy)
                    If y < CInt(DateTime.Now.ToString("yy")) Then
                        txtValue.Text = "20" & yy & "/"
                    Else
                        txtValue.Text = "19" & yy & "/"
                    End If
                    txtValue.SelectionStart = 5
                End If
            End If

            End If





            'If len = 5 Then
        '    Dim yearstr = str.Substring(0, 4)
        '    Dim year = CInt(yearstr)
        '    If year < 1753 Then
        '        Dim yy = yearstr.Substring(2, 2)
        '        Dim y = CInt(yy)
        '        If y < CInt(DateTime.Now.ToString("yy")) Then
        '            txtValue.Text = "20" & yy & "/"
        '        Else
        '            txtValue.Text = "19" & yy & "/"
        '        End If
        '        txtValue.SelectionStart = 5
        '    End If
        'End If
        'If len = 8 Then

        '    Dim monthstr As String
        '    If arr.Length > 1 AndAlso arr(1) <> "" Then
        '        monthstr = arr(1)
        '    Else
        '        monthstr = str.Substring(5, 2)
        '    End If
        '    Dim month = CInt(monthstr)
        '    If month > 12 Then
        '        txtValue.Text = str.Substring(0, 5)
        '        txtValue.SelectionStart = 5
        '    End If
        'End If
        'If len = 10 Then
        '    Dim day = CInt(str.Substring(8, 2))
        '    Dim month = CInt(str.Substring(5, 2))
        '    Dim year = CInt(str.Substring(0, 4))
        '    If year Mod 400 = 0 Or (year Mod 4 = 0 And year Mod 100 > 0) Then
        '        If month = 2 Then
        '            If day > 29 Then
        '                txtValue.Text = str.Substring(0, 8)
        '                txtValue.SelectionStart = 8
        '            End If
        '        End If
        '    Else
        '        If month = 2 Then
        '            If day > 28 Then
        '                txtValue.Text = str.Substring(0, 8)
        '                txtValue.SelectionStart = 8
        '            End If
        '        End If
        '    End If
        '    Select Case month
        '        Case 1, 3, 5, 7, 8, 10, 12
        '            If day > 31 Then
        '                txtValue.Text = str.Substring(0, 8)
        '                txtValue.SelectionStart = 8
        '            End If
        '        Case 4, 6, 9, 11
        '            If day > 30 Then
        '                txtValue.Text = str.Substring(0, 8)
        '                txtValue.SelectionStart = 8
        '            End If
        '    End Select
        'End If

        'Catch ex As Exception
        '    txtValue.Text = luu
        '    txtValue.SelectionStart = luu.Length
        'End Try

    End Sub

    Private Sub txtValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValue.KeyPress
        Dim len = txtValue.TextLength
        Dim str = txtValue.Text
        luu = str
        If Asc(e.KeyChar) <> 8 Then
            If len = 4 Or len = 7 Then
                str &= "/"
                txtValue.Text = str
                txtValue.SelectionStart = str.Length
            End If
            If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
                e.Handled = True
            End If
            If len > 9 Then
                e.Handled = True
            End If
        Else
            If len > 1 Then
                If str.Substring(len - 1, 1) = "/" Then
                    check = False
                End If
            End If

        End If

    End Sub

    Private Sub calendar_ValueChanged(sender As Object, e As EventArgs) Handles calendar.ValueChanged
        txtValue.Text = calendar.Value.ToString("yyyy/MM/dd")
    End Sub
End Class
