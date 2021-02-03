Imports System.ComponentModel

Public Class CC_PostalCode

    ''' <summary>
    ''' OnCreateControl Overrides
    ''' </summary>
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        'Me.Multiline = True
        Me.Height = 20


    End Sub
#Region "CategoryAttribute"
    Private _fomatMask As String
    Private _fomatType As Integer
    <CategoryAttribute("FomatMask"),
    DefaultValueAttribute("")>
    Public Property FomatMask As String
        Get
            Return _fomatMask
        End Get
        Set(value As String)
            _fomatMask = value
            If String.IsNullOrEmpty(value) Then
                _fomatType = 0
            End If
        End Set
    End Property
    ''' <summary>
    ''' FomatType
    ''' 0: get MaskFomat value
    ''' 1: PostalCode Fomat
    ''' 2: PhoneNo Fomat
    ''' #: same as 0 value
    ''' </summary>
    ''' <returns></returns>
    <CategoryAttribute("FomatType"),
    DefaultValueAttribute(0)>
    Public Property FomatType As Integer
        Get
            Return _fomatType
        End Get
        Set(value As Integer)
            _fomatType = value
            If value = 0 Then
                _fomatMask = ""
            End If
        End Set
    End Property

#End Region

End Class
