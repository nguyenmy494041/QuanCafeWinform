Public Class RadioButtonColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New RadioButtonCell())
    End Sub


    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)
            If Not (value Is Nothing) AndAlso
                Not value.GetType().IsAssignableFrom(GetType(RadioButtonCell)) _
                Then
                Throw New InvalidCastException("Must be a RadioButtonCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property
End Class



