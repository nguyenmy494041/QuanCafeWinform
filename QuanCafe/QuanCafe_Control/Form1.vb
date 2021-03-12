Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "CSV File (*.xlsx) | *.xlsx"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            Dim str As String = ""
            Dim listresult = New List(Of List(Of String))
            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
            Do Until EOF(1)
                Dim LineOfText = LineInput(1)


                Dim arr = LineOfText.Split("&")
                str &= "insert into School values(" & arr(0) & ",N'" & arr(1) & "'," & arr(2) & "," & arr(3) & "," & arr(4) & "," & arr(5) & "," & arr(6) & ")" & vbCrLf
            Loop
            FileClose()
            TextBox1.Text = str

        End If
    End Sub
End Class




