Public Class frmManagement
    Private Sub frmManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myfun = New MyFunction()

        myfun.fillcomboboxCategory(cbcategory)
        myfun.filTableInFlowLayoutPanel(flptable, lvbill, txbtotalprice, txbbanhientai, cbswitchtable)
        myfun.fillDataInComboboxSwitchTable(cbswitchtable)

    End Sub

    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
        Dim myfun = New MyFunction()
        cbfoodname.Items.Clear()
        myfun.fillcomboboxFoodByCategory(cbfoodname, cbcategory.Text)
    End Sub

    Private Sub btnaddfood_Click(sender As Object, e As EventArgs) Handles btnaddfood.Click
        Dim fun = New MyFunction()

        If cbcategory.Text <> "" AndAlso cbfoodname.Text <> "" Then
            Dim idcategory = fun.getIdCategoryByName(cbcategory.Text)
            Dim idfoodname = fun.getIdOfFoodName(cbfoodname.Text)
            Dim idtable = fun.getIdTable(txbbanhientai.Text)
            If fun.CheckStatusTable(idtable) Then
                ' có người
                Dim idbill = fun.getIdBillOfIdTable(idtable)
                fun.editBillInforOfIdbill(idbill, idfoodname, nupcount.Value)
                fun.filTableInFlowLayoutPanel(flptable, lvbill, txbtotalprice, txbbanhientai, cbswitchtable)
            Else
                ' không có người
                If nupcount.Value > 0 Then
                    fun.CreateBill(idtable)
                    fun.changeStatusTable(idtable, True)
                    Dim idbill = fun.getIdBillOfIdTable(idtable)
                    fun.addFoodNameInBill(idbill, idfoodname, nupcount.Value())
                    MsgBox("Đã thêm món")
                    fun.filTableInFlowLayoutPanel(flptable, lvbill, txbtotalprice, txbbanhientai, cbswitchtable)
                Else
                    MsgBox("Số lượng của món không hợp lệ")
                End If
            End If
            frmManagement_Load(Nothing, Nothing)
            fun.fillDataListView(idtable, lvbill, txbtotalprice)
        Else
            MsgBox("Chưa chọn món và số lượng")
        End If

    End Sub

    Private Sub btnswitchtable_Click(sender As Object, e As EventArgs) Handles btnswitchtable.Click
        Dim fun = New MyFunction()
        fun.changeTable(txbbanhientai.Text, cbswitchtable.Text)
        MsgBox("Đã chuyển bàn")
        frmManagement_Load(Nothing, Nothing)
        txbbanhientai.Text = cbswitchtable.Text
        fun.fillDataListView(fun.getIdTable(cbswitchtable.Text), lvbill, txbtotalprice)
        cbswitchtable.Items.Clear()
        fun.fillDataInComboboxSwitchTable(cbswitchtable)
    End Sub

    Private Sub btnthanhtoan_Click(sender As Object, e As EventArgs) Handles btnthanhtoan.Click
        Dim fun = New MyFunction()
        If cbsale.Text = "" Then
            cbsale.Text = "0"
        End If
        fun.paybill(txbbanhientai.Text, Val(cbsale.Text), txbtotalprice)
        frmManagement_Load(Nothing, Nothing)
    End Sub
End Class