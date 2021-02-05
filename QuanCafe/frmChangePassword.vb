Public Class frmChangePassword

    Private Sub txbusernamechange_KeyUp(sender As Object, e As KeyEventArgs) Handles txbusernamechange.KeyUp
        Dim c = txbusernamechange.Text
        Dim b = e.KeyValue
        If (b = 32) Then
            txbusernamechange.Text = Trim(c)
            txbusernamechange.SelectionStart = txbusernamechange.Text.Length
        End If
    End Sub

    Private Sub txboldpass_KeyUp(sender As Object, e As KeyEventArgs) Handles txboldpass.KeyUp
        Dim c = txboldpass.Text
        Dim b = e.KeyValue
        If (b = 32) Then
            txboldpass.Text = Trim(c)
            txboldpass.SelectionStart = txboldpass.Text.Length
        End If
    End Sub

    Private Sub txbpassconform_KeyUp(sender As Object, e As KeyEventArgs) Handles txbpassconform.KeyUp
        Dim c = txbpassconform.Text
        Dim b = e.KeyValue
        If (b = 32) Then
            txbpassconform.Text = Trim(c)
            txbpassconform.SelectionStart = txbpassconform.Text.Length
        End If
    End Sub

    Private Sub txbnewpass_KeyUp(sender As Object, e As KeyEventArgs) Handles txbnewpass.KeyUp
        Dim c = txbnewpass.Text
        Dim b = e.KeyValue
        If (b = 32) Then
            txbnewpass.Text = Trim(c)
            txbnewpass.SelectionStart = txbnewpass.Text.Length
        End If
    End Sub

    Private Sub btnchangepass_Click(sender As Object, e As EventArgs) Handles btnchangepass.Click
        If txbusernamechange.Text <> "" AndAlso txboldpass.Text <> "" AndAlso txbnewpass.Text <> "" AndAlso txbpassconform.Text <> "" Then
            If txbnewpass.Text = txbpassconform.Text Then
                Dim context = New QuanCafeEntities()
                Dim user = context.Accounts.Where(Function(x) x.UserName = txbusernamechange.Text AndAlso x.Pasword = txboldpass.Text).FirstOrDefault()
                If Not IsNothing(user) Then
                    user.Pasword = txbnewpass.Text
                    context.SaveChanges()
                    MsgBox("Đã thay đổi mật khẩu")
                Else
                    MsgBox("Tên đăng nhập hoặc mật khẩu không đúng")
                End If
            Else
                MsgBox("Mật khẩu nhập lại không trùng khớp")
            End If
        Else
            MsgBox("Chưa nhập dữ liệu ở các ô.", vbExclamation)
        End If
    End Sub

    Private Sub tbnexit_Click(sender As Object, e As EventArgs) Handles tbnexit.Click
        Me.Close()
    End Sub
End Class