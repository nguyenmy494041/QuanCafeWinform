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
        Dim dataaccount = fun.getaccount()
        filldataOndtgvaccount(dataaccount)
        Dim datacategory = fun.getdatacategory()
        filldataOndtgvcategory(datacategory)
    End Sub



    '' doanh thu
    Private Sub btnthongke_Click(sender As Object, e As EventArgs) Handles btnthongke.Click
        Dim fun = New FunctionFrmAdmin()
        Dim data = fun.searchbill(dtpktime1.Value, dtpktime2.Value)
        filldataondtgvRevenue(data)
    End Sub

    Private Sub dtpktime1_ValueChanged(sender As Object, e As EventArgs) Handles dtpktime1.ValueChanged
        If dtpktime1.Value > DateTime.Now() OrElse dtpktime1.Value > dtpktime2.Value Then
            MsgBox("Ngày bắt đầu không hợp lệ")
            dtpktime1.Value = DateAdd("d", -1, dtpktime2.Value)
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
            dtgvRevenue.Rows(index).Cells(1).Value = row.DateCheckIn
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
            Dim datafood = fun.getdatafood()
            filldataOnDtgvfood(datafood)
            cleartxbfood()
        Else
            MsgBox("Các giá trị nhập vào không hợp lệ")
        End If
    End Sub

    Sub cleartxbfood()
        txbsothutu.Clear()
        txbnamefood.Clear()
        cbcategoryfood.Text = ""
        nbrpricefood.Value = 0
    End Sub

    Private Sub btnviewfood_Click(sender As Object, e As EventArgs) Handles btnviewfood.Click
        Dim fun = New FunctionFrmAdmin()
        Dim datafood = fun.getdatafood()
        filldataOnDtgvfood(datafood)
        cleartxbfood()
    End Sub

    Private Sub btneditfood_Click(sender As Object, e As EventArgs) Handles btneditfood.Click
        Dim i = dtgvfood.SelectedRows(0).Index
        Dim fun = New FunctionFrmAdmin()
        If txbsothutu.Text <> "" Then
            If txbnamefood.Text <> "" AndAlso cbcategoryfood.Text <> "" AndAlso nbrpricefood.Value > 0 Then
                fun.editfood(Val(txbsothutu.Text), txbnamefood.Text, cbcategoryfood.Text, nbrpricefood.Value)
                Dim datafood = fun.getdatafood()
                filldataOnDtgvfood(datafood)
                dtgvfood.Rows(i).Selected = True
            Else
                MsgBox("Thông tin thay đổi không hợp lệ")
            End If
        Else
            MsgBox("Chưa chọn món cần thay đổi thông tin")
        End If
    End Sub

    Private Sub btndeletefood_Click(sender As Object, e As EventArgs) Handles btndeletefood.Click
        Dim fun = New FunctionFrmAdmin()
        If txbsothutu.Text <> "" Then
            fun.deletefood(Val(txbsothutu.Text))
            Dim datafood = fun.getdatafood()
            filldataOnDtgvfood(datafood)
            cleartxbfood()
        Else
            MsgBox("Chưa chọn món cần xóa")
        End If
    End Sub


    '' tai khoản
    Sub filldataOndtgvaccount(ByVal data As List(Of Account))
        dtgvaccount.Rows.Clear()
        For Each row In data
            Dim index = dtgvaccount.Rows.Add()
            dtgvaccount.Rows(index).Cells(0).Value = row.Id
            dtgvaccount.Rows(index).Cells(1).Value = row.UserName
            dtgvaccount.Rows(index).Cells(2).Value = row.Pasword
            dtgvaccount.Rows(index).Cells(3).Value = row.Kind
        Next
        dtgvaccount.Rows(0).Selected = False
    End Sub

    Sub cleartxbaccount()
        txbsttaccount.Clear()
        txbnameaccount.Clear()
        txbpass.Clear()
        radioadmin.Checked = False
        radiouser.Checked = False
    End Sub
    Private Sub btnviewaccount_Click(sender As Object, e As EventArgs) Handles btnviewaccount.Click
        Dim fun = New FunctionFrmAdmin()
        Dim dataaccount = fun.getaccount()
        filldataOndtgvaccount(dataaccount)
        cleartxbaccount()
        txbsearchaccount.Clear()
    End Sub

    Private Sub btnaddaccount_Click(sender As Object, e As EventArgs) Handles btnaddaccount.Click
        Dim adimuser As String = ""
        Dim fun = New FunctionFrmAdmin()
        If radioadmin.Checked = True Then
            adimuser = "Quản lý"
        End If
        If radiouser.Checked = True Then
            adimuser = "Nhân viên"
        End If
        If txbnameaccount.Text <> "" AndAlso txbpass.Text <> "" AndAlso adimuser <> "" Then
            fun.addaccount(txbnameaccount.Text, txbpass.Text, adimuser)
            Dim dataaccount = fun.getaccount()
            filldataOndtgvaccount(dataaccount)
            cleartxbaccount()
        End If
    End Sub

    Private Sub btndeleteaccount_Click(sender As Object, e As EventArgs) Handles btndeleteaccount.Click
        Dim fun = New FunctionFrmAdmin()
        If txbsttaccount.Text <> "" Then
            fun.deleteaccount(Val(txbsttaccount.Text))
            Dim dataaccount = fun.getaccount()
            filldataOndtgvaccount(dataaccount)
            cleartxbaccount()
        Else
            MsgBox("Chưa chọn tài khoản cần xóa")
        End If
    End Sub

    Private Sub dtgvaccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvaccount.CellClick
        Dim i = e.RowIndex()
        CheckBox1.Checked = False
        If i > -1 Then
            Dim a = dtgvaccount.Rows.Count()
            dtgvaccount.Rows(i).Selected = True
            txbsttaccount.Text = dtgvaccount.Rows(i).Cells(0).Value
            txbnameaccount.Text = dtgvaccount.Rows(i).Cells(1).Value
            txbpass.Text = dtgvaccount.Rows(i).Cells(2).Value
            If Not IsNothing(dtgvaccount.Rows(i).Cells(3).Value) Then
                If dtgvaccount.Rows(i).Cells(3).Value.ToString() = "Quản lý" Then
                    radioadmin.Checked = True
                Else
                    radiouser.Checked = True
                End If
            End If

        End If
    End Sub

    Private Sub txbsearchaccount_TextChanged(sender As Object, e As EventArgs) Handles txbsearchaccount.TextChanged
        Dim fun = New FunctionFrmAdmin()
        Dim dataaccount = fun.searchAccount(txbsearchaccount.Text)
        filldataOndtgvaccount(dataaccount)
        cleartxbaccount()
    End Sub

    Private Sub txbnameaccount_KeyUp(sender As Object, e As KeyEventArgs) Handles txbnameaccount.KeyUp

        Dim c = txbnameaccount.Text
        Dim b = e.KeyValue
        If (b = 32) Then
            txbnameaccount.Text = Trim(c)
            txbnameaccount.SelectionStart = txbnameaccount.Text.Length
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txbpass.UseSystemPasswordChar = False
        Else
            txbpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txbpass_KeyUp(sender As Object, e As KeyEventArgs) Handles txbpass.KeyUp
        Dim c = txbpass.Text
        Dim b = e.KeyValue
        If (b = 32) Then
            txbpass.Text = Trim(c)
            txbpass.SelectionStart = txbpass.Text.Length
        End If
    End Sub

    Private Sub btnviewcategory_Click(sender As Object, e As EventArgs) Handles btnviewcategory.Click
        Dim fun = New FunctionFrmAdmin()
        Dim datacategory = fun.getdatacategory()
        filldataOndtgvcategory(datacategory)
    End Sub
    Sub filldataOndtgvcategory(ByVal data As List(Of Category))
        dtgvcategory.Rows.Clear()
        For Each row In data
            Dim index = dtgvcategory.Rows.Add()
            dtgvcategory.Rows(index).Cells(0).Value = row.Id
            dtgvcategory.Rows(index).Cells(1).Value = row.Name
        Next
        dtgvcategory.Rows(0).Selected = False
    End Sub

    Private Sub btnaddcategory_Click(sender As Object, e As EventArgs) Handles btnaddcategory.Click
        Dim fun = New FunctionFrmAdmin()
        If txbnamecategory.Text <> "" Then
            fun.addcategory(txbnamecategory.Text)
            Dim datacategory = fun.getdatacategory()
            filldataOndtgvcategory(datacategory)
            txbnamecategory.Clear()
        Else
            MsgBox("Tên danh mục chưa được nhập")
        End If
    End Sub

    Private Sub btneditcategory_Click(sender As Object, e As EventArgs) Handles btneditcategory.Click
        Dim i = dtgvcategory.SelectedRows(0).Index
        Dim fun = New FunctionFrmAdmin()
        If txbidcategory.Text <> "" Then
            If txbnamecategory.Text <> "" Then
                fun.editcategory(Val(txbidcategory.Text), txbnamecategory.Text)
                Dim datacategory = fun.getdatacategory()
                filldataOndtgvcategory(datacategory)
                dtgvcategory.Rows(i).Selected = True
            Else
                MsgBox("Tên danh mục chưa được nhập")
            End If
        Else
            MsgBox("Danh mục càn sữa chưa được chọn")
        End If
    End Sub

    Private Sub btndeletecategory_Click(sender As Object, e As EventArgs) Handles btndeletecategory.Click
        Dim fun = New FunctionFrmAdmin()
        If txbidcategory.Text <> "" Then
            fun.deletecategory(Val(txbidcategory.Text))
            Dim datacategory = fun.getdatacategory()
            filldataOndtgvcategory(datacategory)
            txbnamecategory.Clear()
            txbidcategory.Clear()
        Else
            MsgBox("Danh mục càn xóa chưa được chọn")
        End If
    End Sub

    Private Sub dtgvcategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvcategory.CellClick
        Dim i = e.RowIndex()
        If i > -1 Then
            Dim a = dtgvcategory.Rows.Count()
            dtgvcategory.Rows(i).Selected = True
            txbidcategory.Text = dtgvcategory.Rows(i).Cells(0).Value
            txbnamecategory.Text = dtgvcategory.Rows(i).Cells(1).Value
        End If
    End Sub
End Class