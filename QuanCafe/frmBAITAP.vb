
Imports System.Data.SqlClient
Public Class frmBAITAP
    Dim conec As SqlConnection = New SqlConnection("Server = DESKTOP-4SNC87E\SQLEXPRESS01 ; Database = NCV ; Integrated Security = true")

    Function getCourse() As List(Of Course)
        Dim listresult = New List(Of Course)
        conec.Open()
        Dim cmd As SqlCommand = New SqlCommand("getCourse", conec)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()

        conec.Close()
        Return listresult
    End Function

    Private Sub frmBAITAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list = getCourse()
    End Sub
End Class