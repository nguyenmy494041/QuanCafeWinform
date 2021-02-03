Imports System.ComponentModel
Imports ICCControl.CM_Enum

Public Class CC_TextBox
	Public Sub New()

		InitializeComponent()
		Me.Text = ""
		Me.Font = New System.Drawing.Font("MS Gothic", 9.0!)

	End Sub

	''' <summary>
	''' OnCreateControl Overrides
	''' </summary>
	Protected Overrides Sub OnCreateControl()
		MyBase.OnCreateControl()
		Me.Font = New System.Drawing.Font("MS Gothic", 9.0!)
		'Me.Multiline = True

	End Sub
	Protected Overrides Sub OnEnter(e As EventArgs)
		MyBase.OnEnter(e)

	End Sub
#Region "CategoryAttribute"
	Private _IsZenkaku = False
	<Category("IsZenkaku"),
DefaultValue(False)>
	Public Property IsZenkaku As Boolean
		Get
			Return _IsZenkaku
		End Get
		Set(value As Boolean)
			_IsZenkaku = value
		End Set
	End Property

	Private _EventZenkaku As CC_EVENT = CC_EVENT.Leave
	<Category("EventZenkaku"),
DefaultValue(CC_EVENT.Leave)>
	Public Property EventZenkaku As CC_EVENT
		Get
			Return _EventZenkaku
		End Get
		Set(value As CC_EVENT)
			_EventZenkaku = value
		End Set
	End Property

	Private _AllowFullWidth As Boolean = True
	<Category("AllowFullWidth"),
DefaultValue(True)>
	Public Property AllowFullWidth As Boolean
		Get
			Return _AllowFullWidth
		End Get
		Set(value As Boolean)
			_AllowFullWidth = value
		End Set
	End Property

	Private _ConvertString As VbStrConv
	<Category("ConvertString"),
DefaultValue(VbStrConv.None)>
	Public Property ConvertString As VbStrConv
		Get
			Return _ConvertString
		End Get
		Set(value As VbStrConv)
			_ConvertString = value
		End Set
	End Property
#End Region

#Region "Leave"
	''' <summary>
	''' 
	''' </summary>
	''' <param name="e"></param>
	Protected Overrides Sub OnLeave(e As EventArgs)
		MyBase.OnLeave(e)
		Try
			If EventZenkaku = CC_EVENT.Leave AndAlso _IsZenkaku Then
				Me.Text = FControl.ChangeStrWide(Me.Text)
			End If
		Catch ex As Exception
		End Try
	End Sub

	Protected Overrides Sub OnTextChanged(e As EventArgs)
		MyBase.OnTextChanged(e)
		Try

			If Not _AllowFullWidth Then

				Dim NewText As String = ""
				If String.IsNullOrEmpty(Me.OldTextValue) Then
					NewText = Me.Text
				Else
					NewText = Me.Text.Replace(Me.OldTextValue, "")
				End If
				If FControl.IsFullWidth(NewText) Then
					Me.Text = Me.OldTextValue
					Me.SelectionStart = Me.DataMaxLength
				End If
				Me.OldTextValue = Me.Text
			End If

			If _ConvertString <> VbStrConv.None Then
				Me.Text = StrConv(Me.Text, _ConvertString, New System.Globalization.CultureInfo("ja-JP", True).LCID)
				Me.SelectionStart = Me.DataMaxLength
			End If

			If EventZenkaku = CC_EVENT.TextChange AndAlso _IsZenkaku Then
				Me.Text = FControl.ChangeStrWide(Me.Text)
				Me.SelectionStart = Me.DataMaxLength
			End If
		Catch ex As Exception

		End Try
	End Sub
#End Region
End Class
