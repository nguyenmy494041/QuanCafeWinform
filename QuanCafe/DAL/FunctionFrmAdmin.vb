Public Class FunctionFrmAdmin

    Function RemoveVietnameseSigns(ByVal str As String) As String
        Dim VietnameseSigns As String() = {"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ", "ÍÌỊỈĨ", "đ", "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"}
        Dim a As String = VietnameseSigns(1)(2)
        For i = 1 To VietnameseSigns.Length - 1
            For j = 0 To VietnameseSigns(i).Length - 1
                str = str.Replace(VietnameseSigns(i)(j), VietnameseSigns(0)(i - 1))
            Next
        Next
        Return str
    End Function
    '''thống kê doanh thu
    Function getdatabill() As List(Of Bill)
        Dim context = New QuanCafeEntities()
        Return context.Bills.Where(Function(x) x.TotalPrice <> 0).ToList()
    End Function

    Function searchbill(ByVal time1 As Date, ByVal time2 As Date) As List(Of Bill)
        Dim context = New QuanCafeEntities()
        Dim result = New List(Of Bill)
        If time1 < time2 Then
            result = context.Bills.Where(Function(x) x.DateCheckIn > time1 AndAlso x.DateCheckOut < time2 AndAlso x.TotalPrice <> 0.0).ToList()
        End If
        Return result
    End Function



    '' món ăn
    Function getdatafood() As List(Of Food)
        Dim context = New QuanCafeEntities()
        Return context.Foods.ToList()
    End Function

    Function searchNameFood(ByVal namefood As String) As List(Of Food)
        Dim context = New QuanCafeEntities()
        namefood = RemoveVietnameseSigns(namefood).ToLower()
        Dim data = context.Foods.ToList()
        Return data.Where(Function(x) RemoveVietnameseSigns(x.Name).ToLower().Contains(namefood)).ToList()
    End Function


    Sub addFood(ByVal name As String, ByVal price As Single, ByVal category As String)
        Dim context = New QuanCafeEntities()
        Dim myfun = New MyFunction()
        Dim idcategory = myfun.getIdCategoryByName(category)
        Dim food = context.Foods.Where(Function(x) x.Name = name).FirstOrDefault()
        If IsNothing(food) Then
            Dim newfood = New Food()
            newfood.Name = name
            newfood.Price = price
            newfood.CategoryId = idcategory
            context.Foods.Add(newfood)
            context.SaveChanges()
            MsgBox("Đã thêm mới món ăn", vbOKOnly)
        Else
            MsgBox("Tên món đã được sử dụng", vbOKOnly)
        End If

    End Sub


    '' danh mục
    Function getdatacategory() As List(Of Category)
        Dim context = New QuanCafeEntities()
        Return context.Categories.ToList()
    End Function
End Class
