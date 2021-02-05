Imports System.ComponentModel

Public Class frmvalidate
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        validate(TextBox1)
    End Sub
    Sub validate(ByVal txb As TextBox)
        If String.IsNullOrEmpty(txb.Text.Trim()) Then
            ErrorProvider1.SetError(txb, "không được để trống")
        Else
            ErrorProvider1.SetError(TextBox1, String.Empty)
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' validate(TextBox1)
        'TextBox1_Validating(Nothing, Nothing)
    End Sub

    Private Sub txbchinhapso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbchinhapso.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 OrElse Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class