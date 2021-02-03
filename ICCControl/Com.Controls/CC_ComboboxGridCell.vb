Imports System.ComponentModel

Public Class CC_ComboboxGridCell

    Public Sub New()
        InitializeComponent()
        Me.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
    End Sub



#Region "Automatic text complex by input value"
    'Protected Overrides Sub OnLeave(rowIndex As Integer, throughMouseClick As Boolean)
    '    MyBase.OnLeave(rowIndex, throughMouseClick)
    '    Try
    '        ' Store the actual text that has been typed.
    '        Dim value As Integer = CInt(Me.Value)
    '        Me.SetValue(rowIndex, value)

    '    Catch ex As Exception

    '    End Try
    'End Sub


#End Region


End Class

