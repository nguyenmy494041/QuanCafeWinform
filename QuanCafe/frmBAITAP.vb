
Imports System.Data.SqlClient
Public Class frmBAITAP
    Dim conec As SqlConnection = New SqlConnection("Server = DESKTOP-4SNC87E\SQLEXPRESS01 ; Database = NCV ; Integrated Security = true")

    Function getCourse() As List(Of Course)
        Dim listresult = New List(Of Course)
        Dim Sql = $"EXEC getCourse"
        Dim result = New NCVEntities().Database.SqlQuery(Of Course)(Sql).ToList()
        Return result
    End Function

    Function getinfor(ByVal id As Int32) As SchoolRowNum
        Dim sql = $"EXEC getinformationstudent @rownum = '{id}'"
        Dim result = New NCVEntities().Database.SqlQuery(Of SchoolRowNum)(sql).FirstOrDefault()
        Return result
    End Function

    Private Sub frmBAITAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim list = getCourse()
        Dim b = 3
        Dim result = getinfor(18)
        txbcoursecode.Text = result.CourseCode
        txbcoursename.Text = result.CourseName
        cbxRegion.Text = result.RegionName

    End Sub
End Class