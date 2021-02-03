Imports System.ComponentModel
Imports System.Runtime.InteropServices.WindowsRuntime

Public Class CC_Combobox
    Public Sub New()
        InitializeComponent()
        Me.Font = New System.Drawing.Font("MS Gothic", 9.0!)
    End Sub
    ''' <summary>
    ''' OnCreateControl Overrides
    ''' </summary>
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        'Me.DrawMode = DrawMode.OwnerDrawVariable
        Me.ItemHeight = 14
    End Sub
    ''' <summary>
    ''' This handler is used when ComboBox is OwnerDraw
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CC_ComboBox_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
        Try
            'No Selection
            If e.Index < 0 Then Exit Sub

            'Manipulating the Item rectangle
            Dim rect As Rectangle = e.Bounds
            If e.State And DrawItemState.Selected Then
                'Modify the Rectangle color...
                e.Graphics.FillRectangle(Brushes.LightBlue, rect) 'change the selected color you like
            Else
                'By default the item will be ligthPink background.... not pretty but for showing the example
                e.Graphics.FillRectangle(Brushes.White, rect)
            End If
            Dim ItemText As System.Data.DataRowView = Me.Items(e.Index)

            'Draw the text in a black Brush...could be any color
            Dim ItemTextBrush As Brush = Brushes.Black
            e.Graphics.DrawString(ItemText.Row.ItemArray(1).ToString(), Me.Font, ItemTextBrush, rect.X, rect.Y)
        Catch ex As Exception

        End Try


    End Sub
#Region "GetValue"
    ''' <summary>
    ''' getValue
    ''' </summary>
    ''' <returns></returns>
    Public Function getValue() As Object
        Dim value As Object
        Try
            value = Me.SelectedValue
            If Not IsNothing(value) Then
                value = CDec(Me.SelectedValue)
                If value = -1 Then
                    value = Nothing
                End If
            End If
        Catch ex As Exception
            Return Nothing
        End Try
        Return value
    End Function
#End Region
#Region "SetValue"
    ''' <summary>
    ''' getValue
    ''' </summary>
    Public Sub setValue(_value As Object)

        Try
            Me.SelectedValue = _value
        Catch ex As Exception
            If _IsFirstBlank Then
                Me.SelectedIndex = 0
            Else
                Me.SelectedIndex = -1
            End If
        End Try
    End Sub
#End Region
#Region "Make Enter work like Tab"
    Dim _IsEnter As Boolean
    Dim _isEnterSendTab As Boolean = False
    Public Property IsEnter As Boolean
        Get
            Return _IsEnter
        End Get
        Set(value As Boolean)
            _IsEnter = value
        End Set
    End Property
    ''' <summary>
    ''' Make Enter work like Tab
    ''' </summary>
    ''' <param name="msg">Message</param>
    ''' <param name="keyData">Keys</param>
    ''' <returns></returns>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) _
        As Boolean
        If (keyData = Keys.Enter) Then
            IsEnter = True
            _isEnterSendTab = True
            SendKeys.Send("{TAB}")
            'Parent.SelectNextControl(Me, True, True, True, True)
            Return True
        End If
        If IsEnter And _isEnterSendTab Then
            _isEnterSendTab = False
        Else
            IsEnter = False
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
#End Region
#Region "Automatic text complex by input value"
    ''' <summary>
    ''' Automatic text complex by input value
    ''' </summary>
    ''' <param name="e">EventArgs</param>
    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)


        Try
            If Not String.IsNullOrEmpty(Me.Text) Then
                If IsNumeric(Me.Text) Then
                    ' Store the actual text that has been typed.
                    Dim value As Integer = CInt(Me.Text)
                    Me.SelectedValue = value
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "CategoryAttribute"
    Private _DataNotNull As Boolean = False
    Private _dataMaxlength As Integer = 8
    Private _DataMustMatchItemFlag As Boolean = False
    <CategoryAttribute("DataMaxlength"),
    DefaultValueAttribute(8)>
    Public Property DataMaxLength As Integer
        Get
            Return _dataMaxlength
        End Get
        Set(value As Integer)
            _dataMaxlength = value
        End Set
    End Property
    <CategoryAttribute("DataNotNull"),
    DefaultValueAttribute(False)>
    Public Property DataNotNull As Boolean
        Get
            Return _DataNotNull
        End Get
        Set(value As Boolean)
            _DataNotNull = value
        End Set
    End Property
    <CategoryAttribute("DataMustMatchItemFlag"),
    DefaultValueAttribute(True)>
    Public Property DataMustMatchItemFlag As Boolean
        Get
            Return _DataMustMatchItemFlag
        End Get
        Set(value As Boolean)
            _DataMustMatchItemFlag = value
        End Set
    End Property

    Private _ResetMode = False
    <Category("ResetMode"),
DefaultValue(False)>
    Public Property ResetMode As Boolean
        Get
            Return _ResetMode
        End Get
        Set(value As Boolean)
            _ResetMode = value
        End Set
    End Property
    Private _IsFirstBlank = False
    <Category("IsFirstBlank"),
DefaultValue(False)>
    Public Property IsFirstBlank As Boolean
        Get
            Return _IsFirstBlank
        End Get
        Set(value As Boolean)
            _IsFirstBlank = value
        End Set
    End Property

    Private _MessageSubject = ""
    <CategoryAttribute("MessageSubject"),
    DefaultValueAttribute("")>
    Public Property MessageSubject As String
        Get
            Return _MessageSubject
        End Get
        Set(value As String)
            _MessageSubject = value
        End Set
    End Property

    Private _ShowEnterMessage As Boolean = False
    <CategoryAttribute("ShowEnterMessage"),
    DefaultValueAttribute(False)>
    Public Property ShowEnterMessage As Boolean
        Get
            Return _ShowEnterMessage
        End Get
        Set(value As Boolean)
            _ShowEnterMessage = value
        End Set
    End Property

#End Region

#Region "GetDisplayText"
    ''' <summary>
    ''' GetDisplayText
    ''' </summary>
    ''' <param name="SelectedValue"></param>
    ''' <returns></returns>
    Public Function GetDisplayText(SelectedValue As Long?)
        Try
            If IsNothing(SelectedValue) Then
                Return ""
            End If
            Dim value = Me.Items(SelectedValue).CD_NAME
            Return value
        Catch ex As Exception
            Return ""
        End Try
    End Function
#End Region

End Class
