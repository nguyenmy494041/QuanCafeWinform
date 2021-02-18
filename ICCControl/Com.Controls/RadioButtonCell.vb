Public Class RadioButtonCell
    Inherits DataGridViewTextBoxCell


    Public Sub New()
    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        ' 
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)
        Dim ctl As RadioButtonEditingControl = CType(DataGridView.EditingControl, RadioButtonEditingControl)
    End Sub
    Public Overrides ReadOnly Property EditType() As Type
        Get
            Return GetType(RadioButtonEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            Return GetType(Boolean)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            Return 0
        End Get
    End Property
End Class

