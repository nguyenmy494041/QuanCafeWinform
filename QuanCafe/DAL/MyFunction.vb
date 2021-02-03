Public Class MyFunction
    Private lvtable As ListView
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

    Function isEmptyTable(ByVal id As Integer) As Boolean
        If id = 3 Then
            Return True
        End If
        Return False
    End Function

    Function getCategory() As List(Of Category)
        Dim context = New QuanCafeEntities()
        Return context.Categories.ToList()
    End Function
    Sub fillcomboboxCategory(ByVal combo As ComboBox)
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
        fillDataListView(getIdTable(btn.Text), lvtable)
        'MsgBox(getIdTable(btn.Text), vbOKOnly, "thông báo")
    End Sub

    ' status = true là co người
    Sub filTableInFlowLayoutPanel(ByVal flowlayout As FlowLayoutPanel, ByRef lbtable As ListView)
        Dim tables = getTable()
        flowlayout.Controls.Clear()
        lvtable = lbtable
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


    Function getIdTable(ByVal tableText As String) As Integer
        Dim arr = Split(tableText, vbCrLf)(0)
        Return CType(Split(arr)(2), Integer)
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

    Sub fillDataListView(ByVal idtable As Integer, ByVal lvtable As ListView)
        Dim data = getDataListView(idtable)
        lvtable.Items.Clear()
        Dim i As Integer = 0
        For Each row In data
            lvtable.Items.Add(row.FoodName.ToString())
            lvtable.Items(i).SubItems.Add(row.Price)
            lvtable.Items(i).SubItems.Add(row.Quantity)
            lvtable.Items(i).SubItems.Add(row.TotalPrice)
            i += 1
        Next
    End Sub

End Class
