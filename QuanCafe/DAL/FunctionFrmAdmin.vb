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
        Return context.Bills.Where(Function(x) x.TotalPrice <> 0).OrderByDescending(Function(x) x.DateCheckOut).ToList()
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

    Sub editfood(ByVal id As Integer, ByVal name As String, ByVal categoryname As String, ByVal price As Single)
        Dim context = New QuanCafeEntities()
        Dim myfun = New MyFunction()
        Dim idcategory = myfun.getIdCategoryByName(categoryname)
        Dim edit = context.Foods.Where(Function(x) x.Id = id).FirstOrDefault()
        Dim exited = context.Foods.Where(Function(x) x.Name = name AndAlso x.Id <> id).FirstOrDefault()
        If Not IsNothing(edit) Then
            If IsNothing(exited) Then
                edit.Name = name
                edit.CategoryId = idcategory
                edit.Price = price
                context.SaveChanges()
                MsgBox("Đã thay đổi thông tin món ăn", vbOKOnly)
            Else
                MsgBox("Tên món đã được sử dụng", vbOKOnly)
            End If
        Else
            MsgBox("Chưa chọn món cần thay đổi thông tin")
        End If
    End Sub

    Sub deletefood(ByVal id As Integer)
        Dim context = New QuanCafeEntities()
        Dim delete = context.Foods.Where(Function(x) x.Id = id).FirstOrDefault()
        If Not IsNothing(delete) Then
            context.Foods.Remove(delete)
            context.SaveChanges()
            MsgBox("Món ăn đã được xóa", vbOKOnly)
        Else
            MsgBox("Chưa chọn món để xóa")
        End If
    End Sub

    '' danh mục
    Function getdatacategory() As List(Of Category)
        Dim context = New QuanCafeEntities()
        Return context.Categories.ToList()
    End Function

    Sub addcategory(ByVal categoryname As String)
        Dim context = New QuanCafeEntities()
        Dim categoryexit = context.Categories.Where(Function(x) x.Name = categoryname).FirstOrDefault()
        If IsNothing(categoryexit) Then
            Dim newcate = New Category()
            newcate.Name = categoryname
            context.Categories.Add(newcate)
            context.SaveChanges()
            MsgBox("Đã thêm danh mục mới", vbOKOnly)
        Else
            MsgBox("Tên danh mục đã được sử dụng ", vbOKOnly)
        End If
    End Sub

    Sub editcategory(ByVal id As Integer, ByVal categoryname As String)
        Dim context = New QuanCafeEntities()
        Dim categoryedit = context.Categories.Where(Function(x) x.Id = id).FirstOrDefault()
        Dim categoryexit = context.Categories.Where(Function(x) x.Name = categoryname AndAlso x.Id <> id).FirstOrDefault()
        If Not IsNothing(categoryedit) Then
            If IsNothing(categoryexit) Then
                categoryedit.Name = categoryname
                context.SaveChanges()
                MsgBox("Đã đổi tên danh mục", vbOKOnly)
            Else
                MsgBox("Tên danh mục đã được sử dụng", vbOKOnly)
            End If
        Else
            MsgBox("Chưa chọn danh mục thay đổi thông tin")
        End If
    End Sub

    Sub deletecategory(ByVal id As Integer)
        Dim context = New QuanCafeEntities()
        Dim delete = context.Categories.Where(Function(x) x.Id = id).FirstOrDefault()
        If Not IsNothing(delete) Then
            context.Categories.Remove(delete)
            context.SaveChanges()
            MsgBox("Danh mục đã được xóa", vbOKOnly)
        Else
            MsgBox("Chưa chọn danh mục để xóa")
        End If
    End Sub

    '' tài khoản
    Function getaccount() As List(Of Account)
        Dim context = New QuanCafeEntities()
        Return context.Accounts.ToList()
    End Function

    Sub addaccount(ByVal name As String, ByVal pass As String, ByVal kind As String)
        Dim context = New QuanCafeEntities()
        Dim acc = context.Accounts.Where(Function(x) x.UserName = name).FirstOrDefault()
        name = name.Trim()
        If IsNothing(acc) Then
            Dim newacc = New Account()
            newacc.UserName = name
            newacc.Pasword = pass
            newacc.Kind = kind
            context.Accounts.Add(newacc)
            context.SaveChanges()
            MsgBox("Đã tạo mới một tài khoản")
        Else
            MsgBox("Tên tài khoản đã được sử dụng")
        End If
    End Sub

    Sub deleteaccount(ByVal id As Integer)
        Dim context = New QuanCafeEntities()
        Dim acc = context.Accounts.Where(Function(x) x.Id = id).FirstOrDefault()
        If Not IsNothing(acc) Then
            context.Accounts.Remove(acc)
            context.SaveChanges()
            MsgBox("Đã xóa tài khoản")
        Else
            MsgBox("Chưa chọn tài khoản để xóa")
        End If
    End Sub

    Function searchAccount(ByVal name As String) As List(Of Account)
        name = RemoveVietnameseSigns(name).ToLower()
        Dim context = New QuanCafeEntities()
        Dim dataaccount = context.Accounts.ToList()
        If name <> "" Then
            dataaccount = dataaccount.Where(Function(x) RemoveVietnameseSigns(x.UserName).ToLower().Contains(name)).ToList()
        End If
        Return dataaccount
    End Function
End Class
