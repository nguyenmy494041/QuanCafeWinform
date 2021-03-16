Public Class frmBaiTap2
    Private check As Boolean = False
    Private listcourse As List(Of Course) = New frmBAITAP().getCourse()
    Private listregion As List(Of Region) = New frmBAITAP().getRegion()
    Private listmodel As List(Of SchoolRowNum) = New List(Of SchoolRowNum)
    Private count As Integer = -1
    Private rownumber As Integer = 1
    Private dong As Integer = 1
    Private Sub frmBaiTap2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDtgv()
        txbrecord.Text = dong & $" of {count}"
    End Sub

    Function getmodel(ByVal index As Integer) As School
        If IsNothing(dtgv.Rows(index).Cells("SchoolName").Value) OrElse IsNothing(dtgv.Rows(index).Cells("SchoolCode").Value) _
            OrElse IsNothing(dtgv.Rows(index).Cells("RegionCode").Value) OrElse IsNothing(dtgv.Rows(index).Cells("CourseCode").Value) _
            OrElse IsNothing(dtgv.Rows(index).Cells("AdultSpecial").Value) OrElse IsNothing(dtgv.Rows(index).Cells("ReturneeStudent").Value) _
            OrElse IsNothing(dtgv.Rows(index).Cells("RegionName").Value) OrElse IsNothing(dtgv.Rows(index).Cells("CourseName").Value) Then
            Return Nothing
        Else
            Dim model = New School()
            With model
                .SchoolName = dtgv.Rows(index).Cells("SchoolName").Value
                .SchoolCode = dtgv.Rows(index).Cells("SchoolCode").Value
                .RegionCode = dtgv.Rows(index).Cells("RegionCode").Value
                .CourseCode = dtgv.Rows(index).Cells("CourseCode").Value
                .AdultSpecial = dtgv.Rows(index).Cells("AdultSpecial").Value
                .ReturneeStudent = dtgv.Rows(index).Cells("ReturneeStudent").Value
                If Not IsNothing(dtgv.Rows(index).Cells("id").Value) Then
                    .Id = dtgv.Rows(index).Cells("id").Value
                Else
                    .Id = CInt(-1)
                End If
            End With
            Return model
        End If
    End Function

    Sub loadDataDtgv()
        check = False
        Dim fun As frmBAITAP = New frmBAITAP()
        listmodel = fun.getAllScholl()
        count = listmodel.Count
        dtgv.Rows.Clear()
        For Each row In listmodel
            Dim index = dtgv.Rows.Add()
            dtgv.Rows(index).Cells("SchoolCode").Value = row.SchoolCode
            dtgv.Rows(index).Cells("SchoolName").Value = row.SchoolName
            dtgv.Rows(index).Cells("RegionName").Value = row.RegionName
            dtgv.Rows(index).Cells("RegionCode").Value = row.RegionCode
            dtgv.Rows(index).Cells("CourseName").Value = row.CourseName
            dtgv.Rows(index).Cells("CourseCode").Value = row.CourseCode
            dtgv.Rows(index).Cells("AdultSpecial").Value = row.AdultSpecial
            dtgv.Rows(index).Cells("ReturneeStudent").Value = row.ReturneeStudent
            dtgv.Rows(index).Cells("Rownum").Value = row.RowNum
            dtgv.Rows(index).Cells("Id").Value = row.Id
        Next
        check = True
        dtgv.Rows(0).Cells(0).Selected = False
    End Sub

    Private Sub btnlastrecord_Click(sender As Object, e As EventArgs) Handles btnlastrecord.Click
        Dim j = dtgv.CurrentCell.ColumnIndex
        dtgv.Rows(count - 1).Cells(j).Selected = True
    End Sub

    Private Sub btnfirstrecord_Click(sender As Object, e As EventArgs) Handles btnfirstrecord.Click
        Dim j = dtgv.CurrentCell.ColumnIndex
        dtgv.Rows(0).Cells(j).Selected = True
    End Sub

    Private Sub btnNewrecord_Click(sender As Object, e As EventArgs) Handles btnNewrecord.Click
        dtgv.CurrentCell = dtgv(2, 4)
    End Sub

    Private Sub dtgv_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dtgv.CellValidating
        If check Then
            Dim exits As New SchoolRowNum()
            Dim value = dtgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            Dim i = e.RowIndex
            ' If i > -1 Then
            Dim j = e.ColumnIndex
                Dim num = dtgv.Rows(i).Cells("Rownum").Value
                Select Case j
                Case 0
                    If IsNumeric(value) Then
                        exits = listmodel.Where(Function(x) x.SchoolCode = value And x.RowNum <> num).FirstOrDefault()
                    End If
                    If Not (IsNumeric(value) AndAlso value < 100000000 AndAlso value > 9999999 AndAlso IsNothing(exits)) Then
                        MsgBox(value)
                        e.Cancel = True
                    End If
                Case 1
                    If IsNothing(value) Then
                        e.Cancel = True
                    End If
                Case 2
                    If Not IsNothing(value) Then
                        If IsNothing(listregion.Where(Function(x) x.RegionName = value).FirstOrDefault()) Then
                            MsgBox(value)
                            e.Cancel = True
                        Else
                            dtgv.Rows(i).Cells("RegionCode").Value = listregion.Where(Function(x) x.RegionName = value).FirstOrDefault().RegionCode
                        End If
                    End If
                Case 3
                    If Not IsNumeric(value) OrElse IsNothing(listregion.Where(Function(x) x.RegionCode = value).FirstOrDefault()) Then
                        MsgBox(value)
                        e.Cancel = True
                    Else
                        dtgv.Rows(i).Cells("RegionName").Value = listregion.Where(Function(x) x.RegionCode = value).FirstOrDefault().RegionName
                    End If
                Case 4
                    If Not IsNothing(value) Then
                        If IsNothing(listcourse.Where(Function(x) x.CourseName = value).FirstOrDefault()) Then
                            MsgBox(value)
                            e.Cancel = True
                        Else
                            dtgv.Rows(i).Cells("CourseCode").Value = listcourse.Where(Function(x) x.CourseName = value).FirstOrDefault().CourseCode
                        End If
                    End If
                Case 5
                    If Not IsNumeric(value) OrElse IsNothing(listcourse.Where(Function(x) x.CourseCode = value).FirstOrDefault()) Then
                        MsgBox(value)
                        e.Cancel = True
                    Else
                        dtgv.Rows(i).Cells("CourseName").Value = listcourse.Where(Function(x) x.CourseCode = value).FirstOrDefault().CourseName
                    End If
                Case 6, 7
                    If Not IsNumeric(value) OrElse value > 1 OrElse value < 0 Then
                        MsgBox(value)
                        e.Cancel = True
                    End If
            End Select
            
        End If
    End Sub

    Private Sub dtgv_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dtgv.CurrentCellDirtyStateChanged
        If dtgv.IsCurrentCellDirty Then
            dtgv.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub btnnextrecord_Click(sender As Object, e As EventArgs) Handles btnnextrecord.Click
        Dim row = dtgv.CurrentCell.RowIndex
        Dim col = dtgv.CurrentCell.ColumnIndex
        Dim model = getmodel(row)
        If Not IsNothing(model) Then
            If row >= count Then
                Dim result = New frmBAITAP().createSchool(model)
                If result.Id > 0 Then
                    dtgv.Rows(row).Cells("id").Value = result.Id
                    listmodel = New frmBAITAP().getAllScholl()
                    count = listmodel.Count
                Else
                    MsgBox(result.Message)
                End If

            Else
                Dim result = New frmBAITAP().updateSchool(model)
                If result.Id > 0 Then
                    dtgv.Rows(row).Cells("id").Value = result.Id
                    dtgv.Rows(row + 1).Cells(col).Selected = True
                    txbrecord.Text = row + 2 & $" of {count}"
                Else
                    MsgBox(result.Message)
                End If
            End If
        Else
            MsgBox("OO trong du lieu")
        End If

    End Sub

    Private Sub dtgv_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv.RowLeave
        Dim row = dtgv.CurrentCell.RowIndex
        Dim col = dtgv.CurrentCell.ColumnIndex
        Dim model = getmodel(row)
        If Not IsNothing(model) Then
            If row >= count Then
                Dim result = New frmBAITAP().createSchool(model)
                If result.Id > 0 Then
                    dtgv.Rows(row).Cells("id").Value = result.Id
                    listmodel = New frmBAITAP().getAllScholl()
                    count = listmodel.Count
                Else
                    MsgBox(result.Message)
                End If

            Else
                Dim result = New frmBAITAP().updateSchool(model)
                If result.Id > 0 Then
                    dtgv.Rows(row).Cells("id").Value = result.Id
                    'txbrecord.Text = row + 2 & $" of {count}"
                Else
                    MsgBox(result.Message)
                End If
            End If
        Else
            MsgBox("OO trong du lieu")
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        btnsearch.Clear()
    End Sub

    Private Sub btnsearch_Leave(sender As Object, e As EventArgs) Handles btnsearch.Leave
        If btnsearch.Text = "" Then
            btnsearch.Text = "Search"
        End If
    End Sub

    Private Sub txbrecord_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbrecord.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
                e.Handled = True
            End If
            If Val(txbrecord.Text & $"{e.KeyChar}") > count Then
                e.Handled = True
            End If
        Else
            lblrecord.Focus()
        End If
    End Sub
    Private Sub txbrecord_Leave(sender As Object, e As EventArgs) Handles txbrecord.Leave
        txbrecord.Text = txbrecord.Text & $" of {count}"
        Dim arr = CInt(txbrecord.Text.Split(" of")(0))
        dtgv.Rows(arr).Cells(1).Selected = True
    End Sub

    Private Sub txbrecord_Click(sender As Object, e As EventArgs) Handles txbrecord.Click
        Dim arr = txbrecord.Text.Split(" of")(0)
        txbrecord.Text = arr - 1
        txbrecord.SelectionStart = arr.Length
    End Sub

End Class