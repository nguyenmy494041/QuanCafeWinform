
Imports System.Data.SqlClient
Public Class frmBAITAP
    'Dim conec As SqlConnection = New SqlConnection("Server = DESKTOP-4SNC87E\SQLEXPRESS01 ; Database = NCV ; Integrated Security = true")

#Region "Funntion"

    Function getCourse() As List(Of Course)
        Dim listresult = New List(Of Course)
        Dim Sql = $"EXEC getCourse"
        Dim result = New NCVEntities().Database.SqlQuery(Of Course)(Sql).ToList()
        Return result
    End Function

    Function getRegion() As List(Of Region)
        Dim Sql = $"EXEC getRegion"
        Return New NCVEntities().Database.SqlQuery(Of Region)(Sql).ToList()
    End Function
    Function getinforByRow(ByVal row As Integer) As SchoolRowNum
        Dim sql = $"EXEC getinformationstudentByRownum @rownum = '{row}'"
        Dim result = New NCVEntities().Database.SqlQuery(Of SchoolRowNum)(sql).FirstOrDefault()
        Return result
    End Function

    Function getinforByIdById(ByVal row As Integer) As SchoolRowNum
        Dim Sql = $"EXEC getinformationByIdstudent {row}"
        Return New NCVEntities().Database.SqlQuery(Of SchoolRowNum)(Sql).FirstOrDefault()
    End Function

    Function getAllScholl() As List(Of SchoolRowNum)
        Dim Sql = $"EXEC getdatatablescholl"
        Return New NCVEntities().Database.SqlQuery(Of SchoolRowNum)(Sql).ToList()
    End Function
    Function getmodel() As School
        If checkModelInvalid() Then
            Dim model = New School()
            With model
                .SchoolName = txbschoolname.Text
                .SchoolCode = CInt(Val(txbschoolcode.Text))
                .RegionCode = CInt(Val(txbregioncode.Text))
                .CourseCode = CInt(Val(txbcoursecode.Text))
                .AdultSpecial = CInt(Val(txbAdultSpecial.Text))
                .ReturneeStudent = CInt(Val(txbReturneeStudent.Text))
                If txbId.Text <> "" Then
                    .Id = CInt(Val(txbId.Text))
                Else
                    .Id = CInt(-1)
                End If
            End With
            Return model
        Else
            Return Nothing
        End If
    End Function

    Function checkModelInvalid() As Boolean
        If txbschoolname.TextLength > 0 AndAlso Val(txbschoolcode.Text) > 9999999 AndAlso Val(txbschoolcode.Text) < 100000000 _
            AndAlso txbrecord.TextLength > 0 AndAlso txbcoursecode.TextLength > 0 AndAlso Val(txbAdultSpecial.Text) >= 0 _
            AndAlso Val(txbAdultSpecial.Text) < 2 AndAlso Val(txbReturneeStudent.Text) >= 0 AndAlso Val(txbAdultSpecial.Text) < 2 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function updateSchool(ByVal school As School) As Reponse
        Dim Sql = $"EXEC UpdateSchool @id ={school.Id},@SchoolName ={school.SchoolName},@SchoolCode={school.SchoolCode},@RegionCode={school.RegionCode},@CourseCode={school.CourseCode},@AdultSpecial={school.AdultSpecial},@ReturneeStudent={school.ReturneeStudent}"
        Return New NCVEntities().Database.SqlQuery(Of Reponse)(Sql).FirstOrDefault()
    End Function

    Function createSchool(ByVal school As School) As Reponse
        Dim Sql = $"EXEC createSchool @SchoolName ={school.SchoolName},@SchoolCode={school.SchoolCode},@RegionCode={school.RegionCode},@CourseCode={school.CourseCode},@AdultSpecial={school.AdultSpecial},@ReturneeStudent={school.ReturneeStudent}"
        Return New NCVEntities().Database.SqlQuery(Of Reponse)(Sql).FirstOrDefault()
    End Function

    Function deleteSchool(ByVal id As Integer) As Reponse
        Dim sql = $"EXEC deleteSchool {id}"
        Return New NCVEntities().Database.SqlQuery(Of Reponse)(sql).FirstOrDefault()
    End Function

    Function getnameCourse(ByVal code As Integer) As String
        Return courses.Where(Function(x) x.CourseCode = code).FirstOrDefault().CourseName
    End Function
    Function getnameRegion(ByVal code As Integer) As String
        Return regions.Where(Function(x) x.RegionCode = code).FirstOrDefault().RegionName
    End Function

#End Region





#Region "even textbox"
    Private Sub libCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles libCourse.SelectedIndexChanged
        Dim courses = getCourse()
        Dim coursename = libCourse.SelectedItem
        Dim course = courses.Where(Function(x) x.CourseName = libCourse.SelectedItem).FirstOrDefault()
        txbcoursename.Text = course.CourseName
        txbcoursecode.Text = course.CourseCode
    End Sub

    Private Sub cbxRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRegion.SelectedIndexChanged
        Dim regions = getRegion()
        Dim regionname = cbxRegion.SelectedItem
        Dim region = regions.Where(Function(x) x.RegionName = regionname).FirstOrDefault()
        txbregionname.Text = region.RegionName
        txbregioncode.Text = region.RegionCode
    End Sub

    Private Sub cbxRegion_Leave(sender As Object, e As EventArgs) Handles cbxRegion.Leave
        Dim regions = getRegion()
        Dim regionname = cbxRegion.Text
        Dim region = regions.Where(Function(x) x.RegionName = regionname).FirstOrDefault()
        If Not IsNothing(region) Then
            txbregionname.Text = region.RegionName
            txbregioncode.Text = region.RegionCode
        Else
            MsgBox("Region name invalid", vbObjectError)
            cbxRegion.SelectAll()

        End If

    End Sub

    Private Sub txbschoolcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbschoolcode.KeyPress
        Dim k = Asc(e.KeyChar)
        If Asc(e.KeyChar) <> 8 Then
            If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
                e.Handled = True
            End If
            If txbschoolcode.TextLength >= 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txbAdultSpecial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbAdultSpecial.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) <> 48 AndAlso Asc(e.KeyChar) <> 49 Then
                e.Handled = True
            End If
            If txbAdultSpecial.TextLength >= 1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txbReturneeStudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbReturneeStudent.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) <> 48 AndAlso Asc(e.KeyChar) <> 49 Then
                e.Handled = True
            End If
            If txbReturneeStudent.TextLength >= 1 Then
                e.Handled = True
            End If
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
            lblAdultSpecial.Focus()
        End If
    End Sub
#End Region








#Region "main"


    Private listmodelSchool As List(Of SchoolRowNum) = New List(Of SchoolRowNum)
    Dim courses As List(Of Course) = getCourse()
    Dim regions As List(Of Region) = getRegion()
    Dim rownumber As Long = 0
    Dim count As Integer = 0
    Sub Clear()
        txbcoursename.Clear()
        txbcoursecode.Clear()
        txbregioncode.Clear()
        txbregionname.Clear()
        txbschoolcode.Clear()
        txbschoolname.Clear()
        txbAdultSpecial.Clear()
        txbReturneeStudent.Clear()
    End Sub
    Sub filldata(ByVal model As SchoolRowNum)
        If Not IsNothing(model) Then
            txbcoursecode.Text = model.CourseCode
            txbcoursename.Text = getnameCourse(model.CourseCode)
            txbregioncode.Text = model.RegionCode
            txbregionname.Text = getnameRegion(model.RegionCode)
            libCourse.SelectedItem = getnameCourse(model.CourseCode)
            cbxRegion.SelectedItem = getnameRegion(model.RegionCode)
            txbschoolname.Text = model.SchoolName
            txbschoolcode.Text = model.SchoolCode
            txbAdultSpecial.Text = model.AdultSpecial
            txbReturneeStudent.Text = model.ReturneeStudent
            txbId.Text = model.Id
            txbrow.Text = model.RowNum
            rownumber = model.RowNum

        End If
    End Sub


    Private Sub frmBAITAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listmodelSchool = getAllScholl()
        count = listmodelSchool.Count()
        For Each item In courses
            libCourse.Items.Add(item.CourseName)
        Next
        For Each item In regions
            cbxRegion.Items.Add(item.RegionName)
        Next
        filldata(listmodelSchool(0))
        txbrecord.Text = 1 & $" of {count}"

    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        If CInt(txbrecord.Text.Split(" of")(0)) - 1 < count Then
            rownumber -= 1
        End If
        If rownumber > 1 Then
            txbrecord.Text = rownumber & $" of {count}"
            filldata(listmodelSchool(rownumber - 1))
        End If
    End Sub
    Private Sub btnnextrecord_Click(sender As Object, e As EventArgs) Handles btnnextrecord.Click
        If rownumber <= count - 1 Then
            rownumber += 1
            txbrecord.Text = rownumber & $" of {count}"
            filldata(listmodelSchool(rownumber - 1))
        Else
            txbrecord.Text = count + 1 & $" of {count + 1}"
            Clear()
        End If
    End Sub

    Private Sub txbrecord_Leave(sender As Object, e As EventArgs) Handles txbrecord.Leave
        txbrecord.Text = txbrecord.Text & $" of {count}"
        Dim arr = CInt(txbrecord.Text.Split(" of")(0)) - 1
        If arr = count Then

            btnNewrecord_Click(Nothing, Nothing)
        ElseIf arr < count Then
            filldata(listmodelSchool(arr))
        Else
            txbrecord.Text = rownumber - 1
            txbrecord.SelectionStart = rownumber.ToString.Length
        End If
    End Sub

    Private Sub txbrecord_Click(sender As Object, e As EventArgs) Handles txbrecord.Click
        Dim arr = txbrecord.Text.Split(" of")(0)
        txbrecord.Text = arr
        txbrecord.SelectionStart = arr.Length
    End Sub

    Private Sub btnfirstrecord_Click(sender As Object, e As EventArgs) Handles btnfirstrecord.Click
        filldata(listmodelSchool(0))
        txbrecord.Text = 1 & $" of {count}"
    End Sub

    Private Sub btnlastrecord_Click(sender As Object, e As EventArgs) Handles btnlastrecord.Click
        filldata(listmodelSchool(count - 1))
        txbrecord.Text = count & $" of {count}"
    End Sub

    Private Sub btnNewrecord_Click(sender As Object, e As EventArgs) Handles btnNewrecord.Click
        rownumber = count
        txbrecord.Text = count + 1 & $" of {count + 1}"
        Clear()
    End Sub





















#End Region


End Class