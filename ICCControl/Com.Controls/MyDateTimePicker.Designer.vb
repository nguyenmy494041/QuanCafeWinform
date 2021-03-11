Imports System.ComponentModel
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices



#Region "MyDateTimePicker - Component"

Partial Class MyDateTimePicker
	Inherits System.Windows.Forms.DateTimePicker

#Region "UserEntry - Helper Class"
	' This class is used to figure out the user entry information and to validate it.
	' There are functions that are never used in the class. I built it and realized it would be useful to me in furute projects so I completed some extra functionality and left it for another day.
	Friend Class UserEntry
		Private pm As String = ""
		Private fpm As String = ""
		Private Mask As String = ""

		Public DateSeperator As Char = ""

		Friend Text As String = ""

		''' <summary>
		''' Constructor for class
		''' </summary>
		''' <param name="Mask">The mask for displaying and user entry fo the date (MM/dd/yyyy)</param>
		''' <remarks></remarks>
		Sub New(ByVal Mask As String)
			pm = Regex.Replace(Mask.ToLower(), "\w+(?=\w)(.).", "$1") 'PrivateMask
			fpm = Regex.Replace(pm, "\W", "") ' Filtered Private Mask
			DateSeperator = Regex.Match(pm, "[^mdy]").Value(0)
		End Sub

		Friend Function Month(ByRef Value As String) As String
			Return ReturnPart(Value, "m")
		End Function
		Friend Function Month() As String
			Return Month(Text)
		End Function
		Friend Function Day(ByRef Value As String) As String
			Return ReturnPart(Value, "d")
		End Function
		Friend Function Day() As String
			Return Day(Text)
		End Function
		Friend Function Year(ByRef Value As String) As String
			Return ReturnPart(Value, "y")
		End Function
		Friend Function Year() As String
			Return Year(Text)
		End Function

		Friend Function GetLocType(ByRef i As Integer) As Char
			Return GetLocType(Text, i)
		End Function
		Friend Function GetLocType(ByRef Value As String, ByRef i As Integer) As Char
			Dim s1 As Integer = (InStr(Value, DateSeperator) - 1)
			Dim s2 As Integer = (InStrRev(Value, DateSeperator) - 1)

			If i = s1 Or i = s2 Then Return DateSeperator
			If i < s1 Then Return fpm(0)
			If i < s2 Then Return fpm(1)
			Return fpm(2)
		End Function

		Friend Function Validate(ByRef value As String) As Boolean
			Return Not IsNothing(GetDate(value))
		End Function

		Friend Function Validate() As Boolean
			Return Validate(Text)
		End Function

		Private Function ReturnPart(ByRef Value As String, ByVal p As Char) As String
			Dim re As New Regex("([^" & DateSeperator & "])+")
			Dim MatchResults As Match = re.Match(Value)
			For i = 1 To InStr(fpm, p) - 1
				MatchResults = MatchResults.NextMatch
			Next
			Return MatchResults.Value
		End Function

		Private Function GetDate(ByRef value As String) As Object
			Dim y As String = Trim(Year(value))
			Dim m As String = Trim(Month(value))
			Dim d As String = Trim(Day(value))
			If y.Length = 0 Then
				y = 2008
			ElseIf Integer.Parse(y) < 100 Then
				If Integer.Parse(y) > (Now.Year - 2000) Then y = (Integer.Parse(y) + 1900).ToString Else y = (Integer.Parse(y) + 2000).ToString
			End If
			If m.Length = 0 Then
				If Integer.Parse("0" & d) < 30 Then m = "2" Else m = "1"
			End If
			If d.Length = 0 Then
				If Integer.Parse(m) = 2 Then d = "29" Else d = "1"
			End If
			Try
				Return New Date(y, m, d)
			Catch ex As Exception
				Return Nothing
			End Try
		End Function
	End Class

#End Region

	Partial Class DateTimePickerMaskedTextBox
		Inherits Windows.Forms.MaskedTextBox

		<System.Diagnostics.DebuggerNonUserCode()> _
		Public Sub New(ByVal container As System.ComponentModel.IContainer)
			MyClass.New()

			'Required for Windows.Forms Class Composition Designer support
			If (container IsNot Nothing) Then
				container.Add(Me)
			End If

		End Sub

		<System.Diagnostics.DebuggerNonUserCode()> _
		Public Sub New()
			MyBase.New()

			Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)

			'This call is required by the Component Designer.
			InitializeComponent()
		End Sub

		'Component overrides dispose to clean up the component list.
		<System.Diagnostics.DebuggerNonUserCode()> _
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			Try
				If disposing AndAlso components IsNot Nothing Then
					components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		'Required by the Component Designer
		Private components As System.ComponentModel.IContainer

		'NOTE: The following procedure is required by the Component Designer
		'It can be modified using the Component Designer.
		'Do not modify it using the code editor.
		<System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			components = New System.ComponentModel.Container()
		End Sub

		Friend Enum LastEvents
			Undefined = -1
			Enter = 1
			GotFocus = 2
			Leave = 3
			Validating = 4
			Validated = 5
			LostFocus = 6
			ParentPopulate = 0
		End Enum

		Friend _LastEvent As LastEvents = LastEvents.Undefined
		Protected Friend _DTP As MyDateTimePicker
		Public _Mask As String = ""

		Private ue As New UserEntry(UseMask())

		Private _EnterDate As String = ""
		Private _Modified As Boolean = False

		Public Overloads Property Modified() As Boolean
			Get
				Return _Modified
			End Get
			Set(ByVal value As Boolean)
				_Modified = value
			End Set
		End Property

		Public Property UseMask() As String
			Get
				If _Mask.Length = 0 Then Return DateTimeFormatInfo.CurrentInfo.ShortDatePattern Else Return _Mask
			End Get
			Set(ByVal value As String)
				_Mask = value
			End Set
		End Property

		' makes the local mask that will be used in the MTB - based on the regional settings. Make it a function rather than string so if the region settings have changed while in the program we use it right away
		Private Function RegionMask() As String
			'            Return "09/09/0099"
			Dim s As String
			If _Mask.Length = 0 Then
				s = DateTimeFormatInfo.CurrentInfo.ShortDatePattern
			Else
				s = _Mask
			End If
			' deal with 2 digit month and day
			s = Regex.Replace(s, "\bMM+\b|\bdd+\b", "00", RegexOptions.IgnoreCase)
			' deal with single digit day and month
			s = Regex.Replace(s, "\bM\b|\bd\b", "90", RegexOptions.IgnoreCase)
			' deal with year that may be left
			s = Regex.Replace(s, "\byy\b", "00", RegexOptions.IgnoreCase)
			s = Regex.Replace(s, "\byyyy+\b", "0000", RegexOptions.IgnoreCase)
			Return s
		End Function

		Private Function DateEmpty() As Boolean
			Return Regex.Replace(Text, "\D", "").Length = 0
		End Function

		Delegate Sub InvokeDelegate()

		Friend Sub DelegateMethod()
			If Not _LastEvent = LastEvents.ParentPopulate Then Me.SelectAll() Else Me.SelectionStart = 0
		End Sub

		Protected Overrides Sub OnEnter(ByVal e As System.EventArgs)
			If _LastEvent <> LastEvents.Validating Then
				If Not DateEmpty() Then Text = _DTP.Value.ToString(Regex.Replace(Regex.Replace(UseMask, "M+", "MM"), "d+", "dd"))
				_EnterDate = Text
				Mask = RegionMask()
				BeginInvoke(New InvokeDelegate(AddressOf DelegateMethod))
			End If
			_LastEvent = LastEvents.Enter

			MyBase.OnEnter(e)
		End Sub

		Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
			_LastEvent = LastEvents.GotFocus

			MyBase.OnGotFocus(e)
		End Sub

		Protected Overrides Sub OnLeave(ByVal e As System.EventArgs)
			_LastEvent = LastEvents.Leave

			MyBase.OnLeave(e)
		End Sub

		Protected Overrides Sub OnValidating(ByVal e As System.ComponentModel.CancelEventArgs)
			_LastEvent = LastEvents.Validating
			If Not DateEmpty() And Not IsDate(Text) Then
				e.Cancel = True
				Ping()
			End If

			MyBase.OnValidating(e)
		End Sub

		Protected Overrides Sub OnValidated(ByVal e As System.EventArgs)
			If DateEmpty() Then
				_DTP.Value = Nothing
				If Not Modified And Regex.Replace(_EnterDate, "\D", "").Length <> 0 Then Modified = True
			Else
				_DTP.Value = CDate(Text)
				If Not Modified Then Modified = Not (Regex.Replace(_EnterDate, "\D", "").Length = Regex.Replace(_DTP.Value.ToString(Regex.Replace(Regex.Replace(UseMask, "M+", "MM"), "d+", "dd")), "\D", ""))
			End If
			MyBase.OnValidated(e)
			_LastEvent = LastEvents.Validated
		End Sub

		Protected Overrides Sub OnLostFocus(ByVal e As System.EventArgs)
			If _LastEvent = LastEvents.Validated Then
				_LastEvent = LastEvents.LostFocus
				Mask = ""
				If Not DateEmpty() Then Text = _DTP.ShowDate
			End If
			MyBase.OnLostFocus(e)
		End Sub


		' used to convert keycode to the actual char
		' nMapType values are...
		'MAPVK_VK_TO_VSC - 0: uCode is a virtual-key code and is translated into a scan code. If it is a virtual-key code that does not distinguish between left- and right-hand keys, the left-hand scan code is returned. If there is no translation, the function returns 0.
		'MAPVK_VSC_TO_VK - 1: uCode is a scan code and is translated into a virtual-key code that does not distinguish between left- and right-hand keys. If there is no translation, the function returns 0.
		'MAPVK_VK_TO_CHAR - 2: uCode is a virtual-key code and is translated into an unshifted character value in the low-order word of the return value. Dead keys (diacritics) are indicated by setting the top bit of the return value. If there is no translation, the function returns 0.
		'MAPVK_VSC_TO_VK_EX - 3: uCode is a scan code and is translated into a virtual-key code that distinguishes between left- and right-hand keys. If there is no translation, the function returns 0. 
		<DllImport("user32.dll", CharSet:=CharSet.Auto)> _
		Private Shared Function MapVirtualKey(ByVal uCode As Integer, ByVal nMapType As Integer) As Integer
		End Function
		Private Function KeyValueToChar(ByVal kv As Integer) As Char
			Return Chr(MapVirtualKey(kv, 2))
		End Function


		Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
			Dim key As Char = KeyValueToChar(e.KeyValue)
			If e.KeyCode = Keys.Delete Then
				Text = ""
				e.Handled = True
			ElseIf e.KeyCode = Keys.Escape Then
				Text = _EnterDate
				SelectionStart = 0
				e.Handled = True
			ElseIf KeyValueToChar(e.KeyValue) = ue.DateSeperator Or e.KeyData = Keys.Space Then
				If Not ue.Validate(Text) Then
					e.Handled = True
					e.SuppressKeyPress = True
					Ping()
				End If

				If ue.GetLocType(Text, SelectionStart) = ue.DateSeperator Then
					e.Handled = True
					e.SuppressKeyPress = True
					SelectionStart = SelectionStart + 1
				End If
			ElseIf InStr("0123456789", key) > 0 Then
				ue.Text = Text
				' see if they are typing to the next section
				If ue.GetLocType(SelectionStart) = ue.DateSeperator Then
					If Not ue.Validate(Text) Then
						e.Handled = True
						e.SuppressKeyPress = True
						Ping()
					End If
				End If
			End If
			MyBase.OnKeyDown(e)
		End Sub

		Private Sub Ping()
			System.Media.SystemSounds.Beep.Play()
		End Sub

		Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
			If e.KeyChar = DateTimeFormatInfo.CurrentInfo.DateSeparator Or e.KeyChar = " " Then
				If ue.GetLocType(Text, SelectionStart) = ue.DateSeperator Then
					e.KeyChar = Convert.ToChar(Keys.Space)
					e.Handled = True
				End If
			End If
			MyBase.OnKeyPress(e)
		End Sub
	End Class

#Region " Component Designer generated code "
	Private pnl As Panel
	Private mtb As DateTimePickerMaskedTextBox
	Private _calAbort As Boolean = False
	Private _inCal As Boolean = False
	'Private _StartEmpty As Boolean = False

	Public Sub New()
		MyBase.New()

		' This call is required by the Component Designer.
		InitializeComponent()

		'Add any initialization after the InitializeComponent() call

		pnl = New Panel
		With pnl
			pnl.Top = 1
			pnl.Left = 1
			pnl.Height = Me.ClientRectangle.Height
			pnl.Width = Me.ClientRectangle.Width - 34
			pnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			pnl.BackColor = System.Drawing.SystemColors.Window
			pnl.Name = "pnl"
			pnl.Margin = New System.Windows.Forms.Padding(0)
			pnl.Padding = New System.Windows.Forms.Padding(0)
		End With
		Me.Controls.Add(pnl)

		mtb = New DateTimePickerMaskedTextBox
		With mtb
			mtb.AutoSize = True
			.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			  Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			.BorderStyle = Windows.Forms.BorderStyle.None
			.Size = New System.Drawing.Size(pnl.Width - 2, pnl.Height - 0)
			.BackColor = Color.Transparent
			.Font = Me.Font
			.Location = New System.Drawing.Size(2, (pnl.Height - .Height) / 2)
			.Mask = ""
			.Text = ShowDate()
			._DTP = Me
			.TabIndex = Me.TabIndex
		End With
		pnl.Controls.Add(mtb)

		MyBase.TabStop = False
		MyBase.ShowCheckBox = False
	End Sub

	Private Function ShowDate(Optional ByVal Force As Boolean = False) As String
		If (mtb.TextLength > 0) Or Force Then
			With MyBase.Value
				Select Case Format
					Case DateTimePickerFormat.Long
						Return .ToString("D")
					Case DateTimePickerFormat.Short
						Return .ToString("d")
					Case DateTimePickerFormat.Time
						Return .ToString("t")
					Case DateTimePickerFormat.Custom
						Return .ToString(CustomFormat)
				End Select
			End With
		End If
		Return ""
	End Function

	' Hide this property from the user since it will cause issues
	<EditorBrowsable(EditorBrowsableState.Never)> _
	Public Shadows ReadOnly Property ShowCheckBox() As Boolean
		Get
			Return MyBase.ShowCheckBox
		End Get
	End Property

	Public Overloads Property Text() As String
		Get
			Return mtb.Text
		End Get
		Set(ByVal value As String)
			MyBase.Text = value
			MyBase.Checked = value.Length = 0
			If value.Length = 0 Then
				mtb.Mask = ""
				mtb.Text = ""
			Else
				mtb.Mask = ""
				mtb.Text = ShowDate(True)
			End If
		End Set
	End Property

	Public Overloads Property TabStop() As Boolean
		Get
			Return mtb.TabStop
		End Get
		Set(ByVal value As Boolean)
			mtb.TabStop = value
		End Set
	End Property

	Public Overloads Property Value() As Date
		Get
			If mtb.TextLength = 0 Then
				Return Nothing
			Else
				If DesignMode Then
					Return MyBase.Value
				Else
					Return Date.Parse(mtb.Text)
				End If
			End If
		End Get
		Set(ByVal value As DateTime)
			MyBase.Checked = value = DirectCast(Nothing, DateTime)
			If value = DirectCast(Nothing, DateTime) Then
				mtb.Mask = ""
				mtb.Text = ""
				MyBase.Value = Now()	'Nothing
			Else
				MyBase.Value = value
				mtb.Mask = ""
				mtb.Text = ShowDate(True)
			End If
			' If the change is through code then reset the modified flag
			If mtb._LastEvent = DateTimePickerMaskedTextBox.LastEvents.Validated Or mtb._LastEvent = DateTimePickerMaskedTextBox.LastEvents.Undefined Then mtb.Modified = False
		End Set
	End Property

	Public Overloads Property TabIndex() As Integer
		Get
			Return MyBase.TabIndex
		End Get
		Set(ByVal value As Integer)
			mtb.TabIndex = 0
			MyBase.TabIndex = value
		End Set
	End Property

	<EditorBrowsable(EditorBrowsableState.Never)> _
	Public Property Modified() As Boolean
		Get
			Return mtb.Modified
		End Get
		Set(ByVal value As Boolean)
			mtb.Modified = value
		End Set
	End Property

	<Category("Behavior"), Description("Gets/Sets input mask to use. If blank will build mask from regional settings")> _
	Public Property Mask() As String
		Get
			Return mtb.UseMask
		End Get
		Set(ByVal value As String)
			mtb._Mask = value
		End Set
	End Property

	Private Function getCoverSize() As Integer
		Dim g As Graphics = Me.CreateGraphics()
		Dim bmp As New Bitmap(Me.Width, Me.Height)
		Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
		'        Clipboard.SetImage(bmp) - Used while debugging
		Dim cc As Color
		Dim y As Integer
		' find the first blank column
		For x = bmp.Width - 3 To 0 Step -1
			y = bmp.Height - 2
			While y > 1
				cc = bmp.GetPixel(x, y)
				If (cc.A <> Color.White.A Or cc.R <> Color.White.R Or cc.G <> Color.White.G Or cc.B <> Color.White.B) Then
					If cc.R = 0 And cc.G = 0 And cc.B = 0 Then
						Return Me.Width - 18
					Else
						Return Me.Width - 35
					End If
				Else
					y = y - 1
				End If
			End While
		Next
		Return 1
	End Function

	Public Sub adjustSizes()
		pnl.Width = getCoverSize()
		Invalidate()
		Update()
	End Sub

	Protected Overrides Sub OnSizeChanged(ByVal e As System.EventArgs)
		adjustSizes()

		MyBase.OnSizeChanged(e)
	End Sub

	Public Overloads Property Format() As DateTimePickerFormat
		Get
			Return MyBase.Format
		End Get
		Set(ByVal value As DateTimePickerFormat)
			MyBase.Format = value
			mtb.Text = ShowDate()
			adjustSizes()
		End Set
	End Property

	Public Overloads Property CustomFormat() As String
		Get
			Return MyBase.CustomFormat
		End Get
		Set(ByVal value As String)
			MyBase.CustomFormat = value
			mtb.Text = ShowDate()
		End Set
	End Property

	Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
		If Not _inCal Then
			mtb.Text = ShowDate()
			MyBase.OnTextChanged(e)
		End If
	End Sub

	Protected Overrides Sub OnCloseUp(ByVal eventargs As System.EventArgs)
		'If _calDate <> MyBase.Value Then
		If Not _calAbort Then
			mtb._LastEvent = DateTimePickerMaskedTextBox.LastEvents.ParentPopulate
			mtb.Mask = ""
			mtb.Text = ShowDate(True)
			mtb.Modified = True
			mtb.Focus()
		End If
		_inCal = False
		MyBase.OnCloseUp(eventargs)
	End Sub

	Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
		_calAbort = (e.KeyChar = Convert.ToChar(Keys.Escape))
		MyBase.OnKeyPress(e)
	End Sub

	Protected Overrides Sub OnDropDown(ByVal eventargs As System.EventArgs)
		_inCal = True
		_calAbort = False
		MyBase.OnDropDown(eventargs)
	End Sub

	'Control overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Control Designer
	Private components As System.ComponentModel.IContainer

	' NOTE: The following procedure is required by the Component Designer
	' It can be modified using the Component Designer. Do not modify it
	' using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.SuspendLayout()
		'
		'DTP
		'
		Me.ResumeLayout(False)

	End Sub

#End Region

End Class
#End Region
