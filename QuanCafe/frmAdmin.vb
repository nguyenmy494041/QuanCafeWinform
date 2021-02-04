Public Class frmAdmin
    ''form load
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fun = New FunctionFrmAdmin()
        dtpktime2.Value = DateTime.Now()
        Dim datarevenue = fun.getdatabill()
        filldataondtgvRevenue(datarevenue)
        Dim datafood = fun.getdatafood()
        filldataOnDtgvfood(datafood)
        fillcomboboxcategory()
    End Sub



    '' doanh thu
    Private Sub btnthongke_Click(sender As Object, e As EventArgs) Handles btnthongke.Click
        Dim fun = New FunctionFrmAdmin()
        Dim data = fun.searchbill(dtpktime1.Value, dtpktime2.Value)
        filldataondtgvRevenue(data)
    End Sub

    Private Sub dtpktime1_ValueChanged(sender As Object, e As EventArgs) Handles dtpktime1.ValueChanged
        If dtpktime1.Value > DateTime.Now() Then
            MsgBox("Ngày bắt đầu không hợp lệ")
            dtpktime1.Value = DateAdd("d", -1, DateTime.Now())
        End If
    End Sub

    Private Sub dtpktime2_ValueChanged(sender As Object, e As EventArgs) Handles dtpktime2.ValueChanged
        If dtpktime2.Value > DateTime.Now() OrElse dtpktime2.Value < dtpktime1.Value Then
            MsgBox("Chọn ngày không hợp lệ")
            dtpktime2.Value = DateTime.Now()
        End If
    End Sub

    Sub filldataondtgvRevenue(ByVal data As List(Of Bill))
        dtgvRevenue.Rows.Clear()
        For Each row In data
            Dim index = dtgvRevenue.Rows.Add()
            dtgvRevenue.Rows(index).Cells(0).Value = row.Id
            dtgvRevenue.Rows(index).Cells(1).Value = row.DateCheckOut
            dtgvRevenue.Rows(index).Cells(2).Value = row.TableFood.Name
            dtgvRevenue.Rows(index).Cells(3).Value = row.DateCheckOut
            dtgvRevenue.Rows(index).Cells(4).Value = row.TotalPrice
        Next
        dtgvRevenue.Rows(0).Selected = False
    End Sub


    ''món ăn
    Sub filldataOnDtgvfood(ByVal data As List(Of Food))
        dtgvfood.Rows.Clear()
        For Each row In data
            Dim index = dtgvfood.Rows.Add()
            dtgvfood.Rows(index).Cells(0).Value = row.Id
            dtgvfood.Rows(index).Cells(1).Value = row.Name
            dtgvfood.Rows(index).Cells(2).Value = row.Price
            dtgvfood.Rows(index).Cells(3).Value = row.Category.Name
        Next
        dtgvfood.Rows(0).Selected = False
    End Sub

    Sub fillcomboboxcategory()
        Dim fun = New FunctionFrmAdmin()
        cbcategoryfood.Items.Clear()
        Dim cate = fun.getdatacategory()
        For Each item In cate
            cbcategoryfood.Items.Add(item.Name)
        Next
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim fun = New FunctionFrmAdmin()
        If TextBox1.Text <> "" Then
            Dim data = fun.searchNameFood(TextBox1.Text)
            filldataOnDtgvfood(data)
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim fun = New FunctionFrmAdmin()
        Dim data = fun.searchNameFood(TextBox1.Text)
        filldataOnDtgvfood(data)
    End Sub

    Private Sub dtgvfood_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvfood.CellClick
        Dim i = e.RowIndex()
        If i > -1 Then
            Dim a = dtgvfood.Rows.Count()
            dtgvfood.Rows(i).Selected = True
            txbsothutu.Text = dtgvfood.Rows(i).Cells(0).Value
            txbnamefood.Text = dtgvfood.Rows(i).Cells(1).Value
            cbcategoryfood.Text = dtgvfood.Rows(i).Cells(3).Value
            nbrpricefood.Value = dtgvfood.Rows(i).Cells(2).Value
        End If
    End Sub

    Private Sub btnaddfood_Click(sender As Object, e As EventArgs) Handles btnaddfood.Click
        Dim fun = New FunctionFrmAdmin()
        If txbnamefood.Text <> "" AndAlso cbcategoryfood.Text <> "" AndAlso nbrpricefood.Value > 0 Then
            fun.addFood(txbnamefood.Text, nbrpricefood.Value, cbcategoryfood.Text)
        Else
            MsgBox("Các ô chưa có dữ liệu")
        End If
    End Sub
End Class