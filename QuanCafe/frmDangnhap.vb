Imports System.ComponentModel

Public Class frmDangnhap
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim myfun = New MyFunction()
        If txbusername.Text <> "" AndAlso txbpassword.Text <> "" Then
            Dim user = myfun.Checklogin(txbusername.Text, txbpassword.Text)
            If Not IsNothing(user.UserName) Then
                MsgBox("Đăng nhập thành công", vbOKOnly, "Thông báo")
                Dim frmManagement = New frmManagement()
                If user.Kind <> "Admin" Then
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
End Class
