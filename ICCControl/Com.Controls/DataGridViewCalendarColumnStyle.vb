Imports System.ComponentModel

Public Class DataGridViewCalendarColumnStyle
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New CalendarCell())
    End Sub
    ''' <summary>
    ''' Format
    ''' </summary>
    <Category("FormatStyle")>
    Public Property Format As String = ""

    ''' <summary>
    ''' Clone
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function Clone() As Object
        Dim TheCopy As DataGridViewCalendarColumnStyle = DirectCast(MyBase.Clone(), DataGridViewCalendarColumnStyle)
        With TheCopy
            .Format = Me.Format
        End With
        Return TheCopy
    End Function
End Class

Public Class CalendarCell
    Inherits DataGridViewTextBoxCell
    Public Sub New()
    End Sub
    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)
        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        Dim TheControl As CalendarEditingControl = CType(DataGridView.EditingControl, CalendarEditingControl)

        Dim MyOwner As DataGridViewCalendarColumnStyle = CType(OwningColumn, DataGridViewCalendarColumnStyle)
        Me.Style.Format = MyOwner.Format
        TheControl.CustomFormat = MyOwner.Format
        If Not Me.Value Is DBNull.Value Then
            TheControl.Value = CType(Me.Value, DateTime)
        Else
            TheControl.CustomFormat = ""
        End If
    End Sub
    Public Overrides ReadOnly Property EditType() As Type
        Get
            ' Return the type of the editing contol that CalendarCell uses.
            Return GetType(CalendarEditingControl)
        End Get
    End Property
    Public Overrides ReadOnly Property ValueType() As Type
        Get
            ' Return the type of the value that CalendarCell contains.
            Return GetType(DateTime)
        End Get
    End Property
    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' Kevininstructor changed from  "Use the current date and time as the default value" to DbNullValue
            Return DBNull.Value
        End Get
    End Property
End Class

''' <summary>
''' Provides Calendar popup within the GridView.
''' </summary>
''' <remarks></remarks>
Class CalendarEditingControl
    Inherits DateTimePicker
    Implements IDataGridViewEditingControl

    Public Sub New()

    End Sub
    Public Property EditingControlRowIndex() As Integer Implements IDataGridViewEditingControl.EditingControlRowIndex
    Public Property EditingControlDataGridView() As DataGridView Implements IDataGridViewEditingControl.EditingControlDataGridView
    Public Property EditingControlValueChanged() As Boolean Implements IDataGridViewEditingControl.EditingControlValueChanged
    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
        ' No preparation needs to be done.
    End Sub
    ''' <summary>
    ''' EditingControlFormattedValue
    ''' </summary>
    ''' <returns></returns>
    Public Property EditingControlFormattedValue() As Object Implements IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            Return Me.Value.ToString(Me.CustomFormat)
        End Get
        Set(ByVal value As Object)
            If TypeOf value Is [String] Then
                Me.Value = DateTime.Parse(CStr(value))
            End If
        End Set
    End Property

    ''' <summary>
    ''' GetEditingControlFormattedValue
    ''' </summary>
    ''' <param name="context"></param>
    ''' <returns></returns>
    Public Function GetEditingControlFormattedValue(ByVal context As DataGridViewDataErrorContexts) As Object _
        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return Me.Value.ToString(Me.CustomFormat)
    End Function

    ''' <summary>
    ''' ApplyCellStyleToEditingControl
    ''' </summary>
    ''' <param name="dataGridViewCellStyle"></param>
    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As DataGridViewCellStyle) Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = dataGridViewCellStyle.Font
        Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
        Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor
    End Sub


    ''' <summary>
    ''' EditingControlWantsInputKey
    ''' </summary>
    ''' <param name="key"></param>
    ''' <param name="dataGridViewWantsInputKey"></param>
    ''' <returns></returns>
    Public Function EditingControlWantsInputKey(ByVal key As Keys, ByVal dataGridViewWantsInputKey As Boolean) As Boolean Implements IDataGridViewEditingControl.EditingControlWantsInputKey
        ' Let the DateTimePicker handle the keys listed.
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                Return True
            Case Else
                Return False
        End Select
    End Function

    ''' <summary>
    ''' RepositionEditingControlOnValueChange
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property RepositionEditingControlOnValueChange() As Boolean Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return False
        End Get
    End Property

    ''' <summary>
    ''' EditingControlCursor
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property EditingControlCursor() As Cursor Implements IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property

    ''' <summary>
    ''' OnValueChanged
    ''' </summary>
    ''' <param name="eventargs"></param>
    Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)
        ' Notify the DataGridView that the contents of the cell have changed.
        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
        MyBase.OnValueChanged(eventargs)
    End Sub
End Class