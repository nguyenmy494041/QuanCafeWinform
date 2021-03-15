Public Class frmBaiTap2
    Private check As Boolean = False
    Private listcourse As List(Of Course) = New frmBAITAP().getCourse()
    Private listregion As List(Of Region) = New frmBAITAP().getRegion()
    Private listmodel As List(Of SchoolRowNum) = New List(Of SchoolRowNum)
    Private count As Integer = -1
    Private rownumber As Integer = 1
    Private Sub frmBaiTap2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDtgv()
    End Sub

    Sub loadDataDtgv()
        Dim fun As frmBAITAP = New frmBAITAP()
        listmodel = fun.getAllScholl()
        count = listmodel.Count
        dtgv.Rows.Clear()
        For Each row In listmodel
            Dim index = dtgv.Rows.Add()
            dtgv.Rows(index).Cells("Id").Value = row.SchoolCode
            dtgv.Rows(index).Cells("SchoolName").Value = row.SchoolName
            dtgv.Rows(index).Cells("RegionName").Value = row.RegionName
            dtgv.Rows(index).Cells("RegionCode").Value = row.RegionCode
            dtgv.Rows(index).Cells("CourseName").Value = row.CourseName
            dtgv.Rows(index).Cells("CourseCode").Value = row.CourseCode
            dtgv.Rows(index).Cells("AdultSpecial").Value = row.AdultSpecial
            dtgv.Rows(index).Cells("ReturneeStudent").Value = row.ReturneeStudent
        Next
        check = True
    End Sub

    Private Sub btnlastrecord_Click(sender As Object, e As EventArgs) Handles btnlastrecord.Click
        Dim j = dtgv.CurrentCell.ColumnIndex
        dtgv.Rows(count - 1).Cells(j).Selected = True
    End Sub

    Private Sub btnfirstrecord_Click(sender As Object, e As EventArgs) Handles btnfirstrecord.Click
        Dim j = dtgv.CurrentCell.ColumnIndex
        dtgv.Rows(0).Cells(j).Selected = True
    End Sub

    Private Sub dtgv_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv.CellValueChanged
        Dim exits As New SchoolRowNum()
        If check Then
            Dim i = e.RowIndex
            If i > -1 Then
                Dim j = e.ColumnIndex
                Select Case j
                    Case 0
                        Dim value = dtgv.Rows(i).Cells(j).Value
                        If IsNumeric(value) Then
                            exits = listmodel.Where(Function(x) x.SchoolCode = CInt(value)).FirstOrDefault()
                        End If
                        If Not (IsNumeric(value) AndAlso CInt(value) < 100000000 AndAlso CInt(value) > 9999999 AndAlso IsNothing(exits)) Then

                            SendKeys.Send("{LEFT}")

                        End If

                    Case 1
                        Dim value = dtgv.Rows(i).Cells(j).Value
                        MsgBox(value)
                    Case 2
                        Dim value = dtgv.Rows(i).Cells(j).Value
                        MsgBox(value)
                    Case 3
                        Dim value = dtgv.Rows(i).Cells(j).Value
                        MsgBox(value)
                    Case 4

                    Case 5
                    Case 6

                    Case 7

                End Select
            End If
        End If
    End Sub
End Class