'Public Class Form1
'    Dim ColType(,) As Integer
'    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
'    Handles MyBase.Load
'        With DataGridView1
'            .RowCount = 5
'            .ColumnCount = 3
'            For i As Integer = 0 To .RowCount - 1
'                .Rows(i).Cells(2) = New DataGridViewImageCell
'                .Rows(i).Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'                .Rows(i).Cells(2).Value = My.Resources.RadioUnsel
'                .Rows(i).Cells(2).Tag = 2
'            Next
'        End With
'    End Sub



'    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
'        With DataGridView1
'            If .Rows(e.RowIndex).Cells(e.ColumnIndex).Tag = 2 Then
'                For i As Integer = 0 To .RowCount - 1
'                    If e.RowIndex <> i Then
'                        .Rows(i).Cells(e.ColumnIndex).Value = My.Resources.RadioUnsel
'                    Else
'                        .Rows(i).Cells(e.ColumnIndex).Value = My.Resources.RadioButtonSel
'                    End If
'                Next
'            End If
'        End With
'    End Sub
'End Class