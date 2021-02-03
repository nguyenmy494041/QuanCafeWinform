Public Class CC_DataGridViewColumnNumber
    Inherits DataGridViewTextBoxColumn

#Region "FomatText"

    Private IsTextChange As Boolean = False



    'Protected Overrides Sub OnTextChanged(e As EventArgs)
    '    If IsTextChange Then
    '        MyBase.OnTextChanged(e)
    '        Return
    '    End If
    '    IsTextChange = True
    '    MyBase.OnTextChanged(e)
    '    Dim oldPosition As Integer = Me.SelectionStart
    '    Dim oldSelectLength = Me.SelectionLength
    '    Dim oldLength = Me.TextLength
    '    Me.Text = Me.Text
    '    If (oldPosition + Me.TextLength - oldLength) >= 0 Then
    '        Me.Select(oldPosition + Me.TextLength - oldLength, oldSelectLength)
    '    End If
    '    IsTextChange = False
    'End Sub
#End Region
End Class
