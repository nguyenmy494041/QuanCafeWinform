''' <summary>
''' CM_Enum
''' </summary>
Public Class CM_Enum
    ''' <summary>
    ''' CC_DATA_TYPE
    ''' </summary>
    Public Enum CC_DATA_TYPE As Integer
        Text = 0
        NumberInt = 1
        NumberDecimal = 2
        PostalCode = 3
    End Enum

    Public Enum CC_EVENT As Integer
        None = -1
        Leave = 0
        TextChange = 1
    End Enum
End Class
