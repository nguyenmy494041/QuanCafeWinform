Public Class MyFunction
    Private lvtable As ListView
    Private txbtotalprice As TextBox
    Private txbtable As TextBox
    Private cbswicthtable As ComboBox
    Function Checklogin(ByVal username As String, ByVal password As String) As Account
        Dim context = New QuanCafeEntities()
        Dim user = context.Accounts.Where(Function(x) x.UserName = username AndAlso x.Pasword = password).FirstOrDefault()
        If Not IsNothing(user) Then
            Return user
        End If
        Return New Account()

    End Function

    Function setMessageBox(ByVal messags As String) As Boolean
        Dim title = "Thông báo"
        If MsgBox(messags, vbOKCancel + vbInformation, title) = vbOK Then
            Return True
        End If
        Return False
    End Function

    Function getTable() As List(Of TableFood)
        Dim context = New QuanCafeEntities()
        Return context.TableFoods.ToList()
    End Function



    Function getCategory() As List(Of Category)
        Dim context = New QuanCafeEntities()
        Return context.Categories.ToList()
    End Function
    Sub fillcomboboxCategory(ByVal combo As ComboBox)
        combo.Items.Clear()
        For Each item In getCategory()
            combo.Items.Add(item.Name)
        Next
    End Sub
    Function getFoodBycategoryname(ByVal name As String) As List(Of Food)
        Dim context = New QuanCafeEntities()
        Dim idcategory = context.Categories.Where(Function(x) x.Name = name).FirstOrDefault().Id
        Return context.Foods.Where(Function(x) x.CategoryId = idcategory).ToList()
    End Function
    Sub fillcomboboxFoodByCategory(ByVal combo As ComboBox, ByVal name As String)
        combo.Items.Clear()
        For Each item In getFoodBycategoryname(name)
            combo.Items.Add(item.Name)
        Next
    End Sub

    Function getIdOfFoodName(ByVal name As String) As Integer
        Dim context = New QuanCafeEntities()
        Return context.Foods.Where(Function(x) x.Name = name).FirstOrDefault().Id
    End Function

    'them su kien dong
    Sub onButton_Click(sender As Object, e As EventArgs)
        Dim btn = New Button()
        btn = CType(sender, Button)
        fillDataListView(getIdTable(btn.Text), lvtable, txbtotalprice)
        txbtable.Text = Split(btn.Text, vbCrLf)(0).ToString()
        'cbswicthtable.Items.Remove(txbtable.Text)
    End Sub

    ' status = true là co người
    Sub filTableInFlowLayoutPanel(ByVal flowlayout As FlowLayoutPanel, ByRef lbtable As ListView,
                                   ByVal txttotal As TextBox, ByVal txttable As TextBox, ByVal combo As ComboBox)
        Dim tables = getTable()
        flowlayout.Controls.Clear()
        lvtable = lbtable
        txbtotalprice = txttotal
        txbtable = txttable
        cbswicthtable = combo
        For Each table In tables
            Dim btn = New Button()
            btn.Name = "btntable" & table.Id
            btn.AutoSize = True
            If table.Status Then
                btn.Text = table.Name & vbCrLf & "Có người"
                btn.BackColor = Color.Aqua
            Else
                btn.Text = table.Name & vbCrLf & "Còn trống"
            End If
            AddHandler btn.Click, AddressOf onButton_Click
            flowlayout.Controls.Add(btn)
        Next
    End Sub

    Sub fillDataInComboboxSwitchTable(ByVal cbx As ComboBox)
        Dim data = getTable()
        'cbx.Items.Clear()
        Dim data1 = data.Where(Function(x) x.Status = False)
        For Each i In data1
            cbx.Items.Add(i.Name)
        Next
    End Sub
    Function getIdTable(ByVal tableText As String) As Integer
        Dim arr = Split(tableText, vbCrLf)(0)
        Dim context = New QuanCafeEntities()
        Return context.TableFoods.Where(Function(x) x.Name = arr).FirstOrDefault().Id
    End Function

    Function getFoodInTable(ByVal idtable As Integer) As List(Of BillInfor)
        Dim context = New QuanCafeEntities()
        Dim result = New List(Of BillInfor)
        If CheckStatusTable(idtable) Then
            Dim idbill = getIdBillOfIdTable(idtable)
            result = context.BillInfors.Where(Function(x) x.IdBill = idbill).ToList()
        End If
        Return result
    End Function

    Function CheckStatusTable(ByVal idtable As Integer) As Boolean
        Dim context = New QuanCafeEntities()
        Return context.TableFoods.Where(Function(x) x.Id = idtable).FirstOrDefault().Status
    End Function

    Function getIdBillOfIdTable(ByVal idtable As Integer) As Integer
        Dim context = New QuanCafeEntities()
        Return context.Bills.Where(Function(x) x.IdTable = idtable AndAlso x.TotalPrice = 0.0).FirstOrDefault().Id
    End Function

    Function getDataListView(ByVal idtable As Integer) As List(Of ViewBill)
        Dim data = getFoodInTable(idtable)
        Dim result = New List(Of ViewBill)
        For Each item In data
            Dim viewbill = New ViewBill()
            viewbill.FoodName = item.Food.Name
            viewbill.Price = item.Food.Price
            viewbill.Quantity = item.FoodCount
            viewbill.TotalPrice = viewbill.Price * viewbill.Quantity
            result.Add(viewbill)
        Next
        Return result
    End Function

    Sub fillDataListView(ByVal idtable As Integer, ByVal lvtable As ListView, ByVal txttotal As TextBox)
        Dim data = getDataListView(idtable)
        lvtable.Items.Clear()
        Dim i As Integer = 0
        Dim totalprice As Single = 0
        For Each row In data
            lvtable.Items.Add(row.FoodName.ToString())
            lvtable.Items(i).SubItems.Add(row.Price)
            lvtable.Items(i).SubItems.Add(row.Quantity)
            lvtable.Items(i).SubItems.Add(row.TotalPrice)
            i += 1
            totalprice += row.Price * row.Quantity
        Next
        txttotal.Text = totalprice
    End Sub





    '''''''''''''''''''''''''
    Function getIdCategoryByName(ByVal categoryname As String) As Integer
        Dim context = New QuanCafeEntities()
        Return context.Categories.Where(Function(a) a.Name = categoryname).FirstOrDefault().Id
    End Function

    Sub changeStatusTable(ByVal idtable As Integer, ByVal status As Boolean)
        Dim context = New QuanCafeEntities()
        Dim table = context.TableFoods.Where(Function(x) x.Id = idtable).FirstOrDefault()
        table.Status = status
        context.SaveChanges()
    End Sub
    Sub CreateBill(ByVal idtable As Integer)
        Dim context = New QuanCafeEntities()
        Dim bill = New Bill()
        bill.DateCheckIn = DateTime.Now()
        bill.IdTable = idtable
        bill.DateCheckOut = DateTime.Now()
        bill.TotalPrice = 0.0
        context.Bills.Add(bill)
        context.SaveChanges()
    End Sub

    Sub addFoodNameInBill(ByVal idbill As Integer, ByVal idfoodname As Integer, ByVal count As Integer)
        Dim context = New QuanCafeEntities()
        Dim billinfor = New BillInfor()
        billinfor.IdBill = idbill
        billinfor.IdFood = idfoodname
        billinfor.FoodCount = count
        context.BillInfors.Add(billinfor)
        context.SaveChanges()
    End Sub

    Function getBillInfor(ByVal idbill As Integer, ByVal idfood As Integer) As BillInfor
        Dim context = New QuanCafeEntities()
        Return context.BillInfors.Where(Function(x) x.IdBill = idbill AndAlso x.IdFood = idfood).FirstOrDefault()
    End Function

    Sub editBillInforOfIdbill(ByVal idbill As Integer, ByVal idfoodname As Integer, ByVal count As Integer)

        Dim context = New QuanCafeEntities()
        Dim billinfor = context.BillInfors.Where(Function(x) x.IdBill = idbill AndAlso x.IdFood = idfoodname).FirstOrDefault()
        If IsNothing(billinfor) Then
            If count > 0 Then
                addFoodNameInBill(idbill, idfoodname, count)
                MsgBox("Đã thêm món")
            Else
                MsgBox("số lượng không thể nhỏ hơn 0")
            End If
        Else
            If billinfor.FoodCount + count > 0 Then
                billinfor.FoodCount = billinfor.FoodCount + count
                MsgBox("Thay đổi số lượng của món")
            Else
                context.BillInfors.Remove(billinfor)
                MsgBox("Đã hủy gọi món")
            End If
            context.SaveChanges()
        End If

    End Sub

    ''''''''''''''''''''''''
    Sub changeTable(ByVal tablename1 As String, ByVal tablename2 As String)
        Dim context = New QuanCafeEntities()
        Dim idtable1 = getIdTable(tablename1)
        Dim idtable2 = getIdTable(tablename2)
        Dim bill = context.Bills.Where(Function(x) x.IdTable = idtable1 AndAlso x.TotalPrice = 0.0).FirstOrDefault()
        'Dim billinfor = context.BillInfors.Where(Function(x) x.IdBill = bill.Id).ToList()
        bill.IdTable = idtable2
        changeStatusTable(idtable1, False)
        changeStatusTable(idtable2, True)
        context.SaveChanges()
    End Sub

    Sub paybill(ByVal tablename As String, ByVal sale As Integer, ByVal txttotal As TextBox)
        Dim context = New QuanCafeEntities()
        Dim idtable = getIdTable(tablename)
        Dim bill = context.Bills.Where(Function(x) x.IdTable = idtable AndAlso x.TotalPrice = 0.0).FirstOrDefault()
        bill.TotalPrice = Math.Round(Val(txttotal.Text) * (1 - sale / 100))
        bill.DateCheckOut = DateTime.Now()
        context.SaveChanges()
        changeStatusTable(idtable, False)

    End Sub
End Class
