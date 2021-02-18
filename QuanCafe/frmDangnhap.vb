Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class frmDangnhap

    Sub Isnotnulldata(ByVal txb As TextBox)
        If String.IsNullOrEmpty(txb.Text.Trim()) Then
            ErrorProvider1.SetError(txb, "không được để trống")
        Else
            ErrorProvider1.SetError(txb, String.Empty)
        End If
    End Sub
    Function validateEmail(emailAddress) As Boolean
        ' Dim email As New Regex("^(?[^@]+)@(?.+)$")
        Dim email As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim myfun = New MyFunction()
            If txbusername.Text <> "" AndAlso txbpassword.Text <> "" Then
                Dim user = myfun.Checklogin(txbusername.Text, txbpassword.Text)
                If Not IsNothing(user.UserName) Then
                    MsgBox("Đăng nhập thành công", vbOKOnly, "Thông báo")
                    Dim frmManagement = New frmManagement()
                    If user.Kind <> "Quản lý" Then
                        frmManagement.AdminToolStripMenuItem.Enabled = False
                    End If
                    Me.Hide()
                    frmManagement.ShowDialog()
                    Me.Show()
                Else
                    MsgBox("Tên đăng nhập hoặc mật khẩu không đúng", vbOKOnly, "Thông báo")
                End If

            Else
                MsgBox("Tên đăng nhập và mật khẩu không được để trống", vbOK, "Thông báo")
            End If



    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If MsgBox("Bạn thật sự muốn thoát chương trình", vbOKCancel, "Thông báo") = vbOK Then
            Application.Exit()
        End If
    End Sub


    Private Sub txbusername_KeyUp(sender As Object, e As KeyEventArgs) Handles txbusername.KeyUp
        Dim c = txbusername.Text
        Dim b = e.KeyValue
        If (b = 32) Then
            txbusername.Text = Trim(c)
            txbusername.SelectionStart = txbusername.Text.Length
        End If
        Isnotnulldata(txbusername)
    End Sub

    Private Sub txbpassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txbpassword.KeyUp
        Dim c = txbpassword.Text
        Dim b = e.KeyValue
        If (b = 32) Then
            txbpassword.Text = Trim(c)
            txbpassword.SelectionStart = txbpassword.Text.Length
        End If
        Isnotnulldata(txbpassword)
    End Sub

    Private Sub txbusername_TextChanged(sender As Object, e As EventArgs) Handles txbusername.TextChanged

    End Sub
End Class
