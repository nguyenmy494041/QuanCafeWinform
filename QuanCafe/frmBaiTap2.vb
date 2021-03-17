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
        dtgv.Rows(0).Cells("SchoolName").Selected = True
        dtgv.ColumnHeadersHeight = 35
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

    End Sub

    Private Sub btnlastrecord_Click(sender As Object, e As EventArgs) Handles btnlastrecord.Click
        Dim j = dtgv.CurrentCell.ColumnIndex
        dtgv.Rows(count - 1).Cells(j).Selected = True
        txbrecord.Text = count & $" of {count}"
    End Sub

    Private Sub btnfirstrecord_Click(sender As Object, e As EventArgs) Handles btnfirstrecord.Click
        Dim j = dtgv.CurrentCell.ColumnIndex
        dtgv.Rows(0).Cells(j).Selected = True
        txbrecord.Text = 1 & $" of {count}"
    End Sub

    Private Sub btnNewrecord_Click(sender As Object, e As EventArgs) Handles btnNewrecord.Click
        btnlastrecord_Click(Nothing, Nothing)
        btnnextrecord_Click(Nothing, Nothing)
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
                    If Not IsNothing(value) Then
                        If IsNumeric(value) Then
                            exits = listmodel.Where(Function(x) x.SchoolCode = value And x.RowNum <> num).FirstOrDefault()
                        End If
                        If Not (IsNumeric(value) AndAlso value < 100000000 AndAlso value > 9999999 AndAlso IsNothing(exits)) Then
                            MsgBox(value)
                            e.Cancel = True
                        End If
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
        dong = dtgv.Rows(row).Cells("Rownum").Value
        dtgv.Rows(dong).Cells(col).Selected = True
        If row + 2 > count Then
            txbrecord.Text = dong + 1 & $" of {count + 1}"
        Else
            txbrecord.Text = dong + 1 & $" of {count}"
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
                    dtgv.Rows(row).Cells("Id").Value = result.Id

                    listmodel = New frmBAITAP().getAllScholl()
                    count = listmodel.Count
                    dtgv.Rows(row).Cells("Rownum").Value = listmodel.Where(Function(x) x.Id = result.Id).FirstOrDefault().RowNum
                    Dim i = dtgv.Rows(dtgv.CurrentRow.Index).Cells("Rownum").Value
                    'txbrecord.Text = i & $" of {count}"
                Else
                    MsgBox(result.Message)
                End If

            Else
                Dim result = New frmBAITAP().updateSchool(model)
                If result.Id > 0 Then
                    dtgv.Rows(row).Cells("id").Value = result.Id
                    'txbrecord.Text = dtgv.Rows(row).Cells("Rownum").Value + 1 & $" of {count}"
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
            Dim col = dtgv.CurrentCell.ColumnIndex

            Dim arr = CInt(txbrecord.Text.Split(" of")(0))
            dtgv.Rows(arr - 1).Cells(col).Selected = True
            txbrecord.Text = txbrecord.Text & $" of {count}"
        End If
    End Sub


    Private Sub txbrecord_Click(sender As Object, e As EventArgs) Handles txbrecord.Click
        Dim arr = txbrecord.Text.Split(" of")(0)
        txbrecord.Text = arr
        txbrecord.SelectionStart = arr.Length
    End Sub

    Private Sub dtgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv.CellClick
        Dim i = e.RowIndex
        If i > -1 Then
            Dim j = e.ColumnIndex
            Dim row = dtgv.Rows(i).Cells("Rownum").Value
            txbrecord.Text = row & $" of {count}"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rows = dtgv.SelectedRows()
        Dim frm As frmBAITAP = New frmBAITAP()
        If rows.Count > 0 Then
            For Each row In rows
                For col = 0 To dtgv.Columns.Count - 1
                    dtgv.Rows(row.Index).Cells(col).Selected = False
                Next
                Dim id = CInt(dtgv.Rows(row.Index).Cells("Id").Value)
                frm.deleteSchool(id)
                dtgv.Rows.Remove(row)
            Next
            listmodel = New frmBAITAP().getAllScholl()
            count = listmodel.Count
            Dim i = dtgv.Rows(dtgv.CurrentRow.Index).Cells("Rownum").Value
            txbrecord.Text = i & $" of {count}"
        End If

    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Dim row = dtgv.CurrentCell.RowIndex
        Dim col = dtgv.CurrentCell.ColumnIndex
        If row > 0 Then
            txbrecord.Text = row & $" of {count}"
            dtgv.Rows(row - 1).Cells(col).Selected = True
        End If
    End Sub


    Private Sub dtgv_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv.CellLeave
        Dim i = dtgv.CurrentCell.RowIndex
        Dim j = dtgv.CurrentCell.ColumnIndex
        If i > -1 AndAlso i < count - 1 Then
            If IsNothing(dtgv.CurrentCell.Value) Then
                Select Case j
                    Case 0
                        dtgv.CurrentCell.Value = listmodel(i).SchoolCode
                    Case 1
                        dtgv.CurrentCell.Value = listmodel(i).SchoolName
                    Case 2
                        dtgv.CurrentCell.Value = listmodel(i).RegionName
                    Case 4
                        dtgv.CurrentCell.Value = listmodel(i).CourseName
                End Select
            End If
        End If
    End Sub

    Function searchschool(ByVal str As String) As SchoolRowNum
        Dim model As New SchoolRowNum()
        model = listmodel.Where(Function(x) x.SchoolCode.ToString().Contains(str)).FirstOrDefault()
        If Not IsNothing(model) Then
            Return model
        End If
        model = listmodel.Where(Function(x) x.SchoolName.ToString().Contains(str)).FirstOrDefault()
        If Not IsNothing(model) Then
            Return model
        End If
        model = listmodel.Where(Function(x) x.RegionCode.ToString().Contains(str)).FirstOrDefault()
        If Not IsNothing(model) Then
            Return model
        End If
        model = listmodel.Where(Function(x) x.CourseCode.ToString().Contains(str)).FirstOrDefault()
        If Not IsNothing(model) Then
            Return model
        End If
        Return Nothing
    End Function

    Private Sub btnsearch_TextChanged(sender As Object, e As EventArgs)
        Dim model = searchschool(btnsearch.Text)
        If Not IsNothing(model) Then
            dtgv.Rows(model.RowNum).Cells("SchoolCode").Selected = True
            txbrecord.Text = model.RowNum & $" of {count}"
        End If
    End Sub

    Private Sub btnsearch_TextChanged_1(sender As Object, e As EventArgs) Handles btnsearch.TextChanged
        If btnsearch.Text <> "" AndAlso btnsearch.Text <> "Search" Then
            Dim model = searchschool(btnsearch.Text)
            If Not IsNothing(model) Then
                dtgv.Rows(model.RowNum - 1).Cells(0).Selected = True
                txbrecord.Text = model.RowNum & $" of {count}"
                btnsearch.Focus()
                btnsearch.SelectionStart = btnsearch.TextLength
            End If
        End If

    End Sub

    Private Sub dtgv_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dtgv.UserDeletingRow
        If dtgv.SelectedRows().Count > 0 Then
            Button1_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub dtgv_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dtgv.UserDeletedRow
        Dim row = dtgv.SelectedRows()
        For Each r As DataGridViewRow In row
            r.Selected = False
        Next
    End Sub
End Class