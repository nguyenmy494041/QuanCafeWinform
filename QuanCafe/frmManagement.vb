Public Class frmManagement
    Private Sub frmManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myfun = New MyFunction()
        Dim tables = myfun.getTable()
        myfun.fillcomboboxCategory(cbcategory)
        myfun.filTableInFlowLayoutPanel(flptable, lvbill)
    End Sub

    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
        Dim myfun = New MyFunction()
        cbfoodname.Items.Clear()
        myfun.fillcomboboxFoodByCategory(cbfoodname, cbcategory.Text)
    End Sub


End Class