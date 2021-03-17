
Imports System.ComponentModel
Imports ICCControl.CM_Enum

Public Class CC_DataGridView
    Public Sub New()
        InitializeComponent()
        Me.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.EditMode = DataGridViewEditMode.EditOnEnter
        Me.AllowUserToDeleteRows = False
        Me.MultiSelect = False

    End Sub
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        SaveColumnRead()
    End Sub
#Region "MaxRow"
    Private _MaxRow As Integer = -1
    <CategoryAttribute("MaxRow"),
    DefaultValueAttribute(-1)>
    Public Property MaxRow As Integer
        Get
            Return _MaxRow
        End Get
        Set(value As Integer)
            _MaxRow = value
        End Set
    End Property
#End Region

#Region "Show Row InDex Flag"
    Private _showRowIndexFlag As Boolean = True
    <CategoryAttribute("IsShowRowIndexFlag"),
    DefaultValueAttribute(True)>
    Public Property IsShowRowIndexFlag As Boolean
        Get
            Return _showRowIndexFlag
        End Get
        Set(value As Boolean)
            _showRowIndexFlag = value
        End Set
    End Property
#End Region

#Region "Delete 2020/04/25"
    '''' <summary>
    '''' List Validate CellInfo
    '''' </summary>
    'Private _ValidateCellInfoList As List(Of ValidateCellInfo) = New List(Of ValidateCellInfo)
    '''' <summary>
    '''' Use for add ValidateCellInfo to List
    '''' </summary>
    '''' <param name="info">ValidateCellInfo</param>
    'Public Sub AddValidateCellInfo(ByVal info As ValidateCellInfo)
    '    Try
    '        _ValidateCellInfoList.Add(info)
    '    Catch ex As Exception

    '    End Try
    'End Sub
    '''' <summary>
    '''' Reset _ValidateCellInfoList before change Datasource
    '''' </summary>
    'Public Sub ResetValidateCellInfo()
    '    Try
    '        _ValidateCellInfoList = New List(Of ValidateCellInfo)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    '''' <summary>
    '''' GetValidateCellInfoList
    '''' </summary>
    '''' <returns></returns>
    'Public Function GetValidateCellInfoList() As List(Of ValidateCellInfo)
    '    Return _ValidateCellInfoList
    'End Function
#End Region

#Region "DataPropetites"
    ''' <summary>
    ''' List(Of KeyValuePair(Of String, Object)) for Col Mapping
    ''' </summary>
    Private _listColMapping As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))
    ''' <summary>
    ''' List(Of KeyValuePair(Of String, Object))
    ''' </summary>
    ''' <returns></returns>
    Public Property ListColMapping As List(Of KeyValuePair(Of String, String))
        Get
            Return _listColMapping
        End Get
        Set(value As List(Of KeyValuePair(Of String, String)))
            If IsNothing(value) Then
                _listColMapping = New List(Of KeyValuePair(Of String, String))
            Else
                _listColMapping = value
            End If
        End Set
    End Property

#End Region

#Region "ResetMode"
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
#End Region

#Region "BindDataTable"
    Public Sub ShowRowIndex()
        Try
            For i = 0 To Me.RowCount - 1
                Me.Rows(i).HeaderCell.Value = CStr(i + 1).PadLeft(3, "0")
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private IsDataBinding = False
    ''' <summary>
    ''' Bind a DataTable to Gridview
    ''' </summary>
    ''' <param name="dtData">DataTable</param>
    Public Sub BindDataToGrid(ByVal dtData As DataTable, Optional ByVal SetCaptionFlag As Boolean = False)
        ListNumber = New List(Of ValidateCellInfo)
        ListInfoColumn = New List(Of ValidateCellInfo)
        ListColumnComboboxInfo = New List(Of ValidateCellInfo)
        Try
            Me.SuspendLayout()
            IsDataBinding = True
            Me.DataSource = dtData
            If IsShowRowIndexFlag Then
                ShowRowIndex()
            End If
            If SetCaptionFlag And Not IsNothing(dtData) Then
                For i = 0 To dtData.Columns.Count - 1
                    Me.Columns(i).HeaderText = dtData.Columns(i).Caption
                Next
            End If
        Catch ex As Exception
        Finally
            Me.ResumeLayout()
            IsDataBinding = False
            Me.rowSelectIndex = 0
            Me.columnSelectIndex = 0
        End Try

    End Sub

#Region "Delete 2020/04/25"
    '''' <summary>
    '''' Bind a DBModel to Gridview
    '''' </summary>
    '''' <param name="objectModel"></param>
    'Public Sub BindDataToGrid(ByVal objectModel As Object)

    '    Try
    '        Me.SuspendLayout()
    '        IsDataBinding = True
    '        ' Delete Row if not swt ListColMapping
    '        If Me.ListColMapping.Count = 0 Then
    '            Me.Rows.Clear()
    '            Return
    '        End If
    '        'Reset Value if model is Nothing
    '        If IsNothing(objectModel) Then
    '            Me.ResetValue()
    '            Return
    '        End If
    '        'SetData
    '        Dim dt As New DataTable()
    '        Dim dr As DataRow = Nothing
    '        dt.Columns.Add(New DataColumn("clmDisplay", GetType(String)))
    '        dt.Columns.Add(New DataColumn("clmContent", GetType(String)))

    '        For Each colMapping In Me.ListColMapping
    '            dr = dt.NewRow()
    '            dr("clmDisplay") = colMapping.Key
    '            If String.IsNullOrEmpty(colMapping.Value) Then
    '                dr("clmContent") = Nothing
    '            Else
    '                Dim fieldNameList = colMapping.Value.Split("&")
    '                Dim valueCol As String = ""
    '                Dim bPadLeft As Boolean = fieldNameList.Length = 3

    '                For Each filedName In fieldNameList
    '                    If IsNothing(objectModel.GetType.GetProperty(filedName)) Or String.IsNullOrEmpty(objectModel.GetType.GetProperty(filedName).GetValue(objectModel)) Then
    '                        Continue For
    '                    Else
    '                        If bPadLeft Then
    '                            valueCol += objectModel.GetType.GetProperty(filedName).GetValue(objectModel).ToString().PadLeft(2, "0")
    '                        Else
    '                            valueCol += objectModel.GetType.GetProperty(filedName).GetValue(objectModel).ToString()
    '                        End If
    '                    End If
    '                Next
    '                dr("clmContent") = valueCol
    '            End If

    '            dt.Rows.Add(dr)

    '        Next
    '        Me.BindDataToGrid(dt)

    '    Catch ex As Exception

    '    Finally
    '        IsDataBinding = False
    '        Me.ResumeLayout()
    '    End Try
    'End Sub
    '''' <summary>
    '''' BindDataToGrid
    '''' </summary>
    '''' <param name="objectList">List(Of ObjectModel)</param>
    'Public Sub BindDataToGrid(ByVal objectList As List(Of Object))

    '    Try
    '        Me.SuspendLayout()
    '        ' Delete Row if not swt ListColMapping
    '        If Me.ListColMapping.Count = 0 Then
    '            Me.Rows.Clear()
    '            Return
    '        End If
    '        'Reset Value if model is Nothing
    '        If IsNothing(objectList) Then
    '            Me.ResetValue()
    '            Return
    '        End If
    '        'SetData
    '        Dim dt As New DataTable()
    '        Dim dr As DataRow = Nothing
    '        dt.Columns.Add(New DataColumn("clmDisplay", GetType(String)))
    '        dt.Columns.Add(New DataColumn("clmContent", GetType(String)))

    '        For Each colMapping In Me.ListColMapping
    '            dr = dt.NewRow()
    '            dr("clmDisplay") = colMapping.Key
    '            If String.IsNullOrEmpty(colMapping.Value) Then
    '                dr("clmContent") = Nothing
    '            Else
    '                dr("clmContent") = getValueColumn(colMapping.Value, objectList)

    '            End If

    '            dt.Rows.Add(dr)

    '        Next
    '        Me.BindDataToGrid(dt)

    '    Catch ex As Exception

    '    Finally
    '        Me.ResumeLayout()
    '    End Try
    'End Sub
    '''' <summary>
    '''' getValueColumn
    '''' </summary>
    '''' <param name="colMappingValue"></param>
    '''' <param name="objectList"></param>
    '''' <returns></returns>
    'Private Function getValueColumn(colMappingValue As String, objectList As List(Of Object)) As String
    '    Dim fieldNameList = colMappingValue.Split("&")
    '    Dim valueCol As String = ""
    '    Dim bPadLeft As Boolean = fieldNameList.Length = 3
    '    Try
    '        For Each fieldName In fieldNameList
    '            For Each obj In objectList
    '                ' Check Nothing fieldName
    '                If IsNothing(obj.GetType.GetProperty(fieldName)) Then
    '                    Continue For
    '                End If
    '                'Check Value is nothing
    '                If String.IsNullOrEmpty(obj.GetType.GetProperty(fieldName).GetValue(obj)) Then
    '                    Continue For
    '                End If
    '                ' Get value
    '                If bPadLeft Then
    '                    valueCol += obj.GetType.GetProperty(fieldName).GetValue(obj).ToString().PadLeft(2, "0")
    '                    Exit For
    '                Else
    '                    valueCol += obj.GetType.GetProperty(fieldName).GetValue(obj).ToString()
    '                    Exit For
    '                End If
    '            Next

    '        Next
    '        Return valueCol
    '    Catch ex As Exception
    '        Return ""
    '    End Try

    'End Function
#End Region

#End Region

#Region "get Set value for cell"
    ''' <summary>
    ''' setCellValue
    ''' </summary>
    ''' <param name="rowIndex">rowIndex</param>
    ''' <param name="colIndex">colIndex</param>
    ''' <param name="value">Object</param>
    Public Sub SetCellValue(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal value As Object)
        Try
            If IsNothing(value) Then
                Me.Rows(rowIndex).Cells(colIndex).Value = ""
            Else
                Me.Rows(rowIndex).Cells(colIndex).Value = value
            End If

        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' getCellValue
    ''' </summary>
    ''' <param name="rowIndex"></param>
    ''' <param name="colIndex"></param>
    ''' <returns></returns>
    Public Function GetCellValue(ByVal rowIndex As Integer, ByVal colIndex As Integer) As Object
        Try
            Dim _value = Me.Rows(rowIndex).Cells(colIndex).Value
            Return _value
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Protected Overrides Sub OnDataError(displayErrorDialogIfNoHandler As Boolean, e As DataGridViewDataErrorEventArgs)
        Try
            displayErrorDialogIfNoHandler = False
            e.ThrowException = False
        Catch ex As Exception

        End Try
    End Sub

    Public Sub RefeshCoulnmsDisplayIndex()
        Try
            For Each col As DataGridViewColumn In Me.Columns
                col.DisplayIndex = col.Index
            Next
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Set Readonly"
    ''' <summary>
    ''' setCellValue
    ''' </summary>
    ''' <param name="rowIndex">rowIndex</param>
    ''' <param name="colIndex">colIndex</param>
    ''' <param name="bReadOnnly">Boolean</param>
    Public Sub SetCellReadonly(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal bReadOnnly As Boolean)
        Try
            Me.Rows(rowIndex).Cells(colIndex).ReadOnly = bReadOnnly
        Catch ex As Exception

        End Try
    End Sub
#Region "Delete 2020/04/25"
    '''' <summary>
    '''' ResetValue and set readonly = false
    '''' </summary>
    'Public Sub ResetValue()
    '    Try
    '        For Each info As ValidateCellInfo In _ValidateCellInfoList
    '            Me.SetCellValue(info.RowIndex, info.ColumnIndex, "")
    '            Me.SetCellReadonly(info.RowIndex, info.ColumnIndex, False)
    '        Next
    '    Catch ex As Exception

    '    End Try
    'End Sub
    '''' <summary>
    '''' SetReadOnly
    '''' </summary>
    '''' <param name="bReadOnly">Boolean</param>
    'Public Sub SetReadOnly(ByVal bReadOnly As Boolean)
    '    For Each info As ValidateCellInfo In _ValidateCellInfoList
    '        Me.SetCellReadonly(info.RowIndex, info.ColumnIndex, bReadOnly)
    '    Next
    'End Sub
#End Region

#End Region

#Region "OnCellEnter"

    ''' <summary>
    ''' OnCellEnter
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnCellEnter(e As DataGridViewCellEventArgs)
        MyBase.OnCellEnter(e)
        Try
            If IsDataBinding Then
                Return
            End If
#Region "Delete 2020/04/25"
            'If Not Me.Item(e.ColumnIndex, e.RowIndex).ReadOnly Then
            '    Me.CurrentCell = Me.Item(e.ColumnIndex, e.RowIndex)
            '    If TypeOf (Me.CurrentCell) Is DataGridViewComboBoxCell Then
            '        Me.BeginEdit(True)
            '    End If
            'End If
#End Region

            If Not IsNothing(CurrentCell) AndAlso Not CurrentCell.ReadOnly Then
                Me.BeginEdit(True)
            End If

#Region "Delete 2020/04/25"
            'Dim Value = Me.Rows(rowSelectIndex).Cells(columnSelectIndex).Value
            'If Not Value Is DBNull.Value Then
            '    If Not String.IsNullOrEmpty(Value) Then
            '        If ListNumber.Any(Function(x) x.ColIndex = columnSelectIndex AndAlso x.IsPostalCode = True) Then
            '            Me.Rows(rowSelectIndex).Cells(columnSelectIndex).Value = Value.ToString.PadRight(7, "0").Insert(3, "-")
            '        ElseIf ListNumber.Any(Function(x) x.ColIndex = columnSelectIndex AndAlso x.AutoFormat = True) Then
            '            Me.Rows(rowSelectIndex).Cells(columnSelectIndex).Value = FormatNumber(Value, 0,,, TriState.True)
            '        ElseIf ListNumber.Any(Function(x) x.ColIndex = columnSelectIndex AndAlso x.IsJPEra = True) Then
            '            Me.Rows(rowSelectIndex).Cells(columnSelectIndex).Value = JapaneseEra(Value)
            '        End If
            '    End If
            'End If
#End Region

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Enter like Tab"
    ''' <summary>
    ''' ProcessDataGridViewKey
    ''' </summary>
    ''' <param name="e"></param>
    ''' <returns></returns>
    Protected Overrides Function ProcessDataGridViewKey(e As KeyEventArgs) As Boolean
        Try
            If e.KeyData = Keys.Enter Then
                Return MyBase.ProcessTabKey(Keys.Tab)
            ElseIf e.KeyData = 65549 Then
                Return MyBase.ProcessTabKey(65545)
            End If
            If e.KeyData = Keys.Escape Then
                Return False
            End If
        Catch ex As Exception
        End Try
        Return MyBase.ProcessDataGridViewKey(e)
    End Function
    Private strPre As String = ""
    ''' <summary>
    ''' ProcessDialogKey
    ''' </summary>
    ''' <param name="keyData"></param>
    ''' <returns></returns>
    Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
        Try
            If keyData = Keys.Enter AndAlso keyData <> 65549 Then
                Return MyBase.ProcessTabKey(Keys.Tab)
            ElseIf keyData = 65549 Then 'Shift + Enter
                Return MyBase.ProcessTabKey(65545)
            Else
                If Not keyData = Keys.Tab AndAlso Not keyData = 65545 Then
                    If Not (keyData = Keys.Escape OrElse (keyData >= Keys.F1 AndAlso keyData <= Keys.F12)) Then
                        If Not keyData = 131137 AndAlso Not keyData = 46 AndAlso Not ((keyData >= 48 AndAlso keyData <= 57) OrElse (keyData >= 96 AndAlso keyData <= 105)) Then
                            If ListNumber.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex) Then
                                Return True
                            End If
                        End If
                    End If
                End If
            End If
            If keyData = Keys.Delete Then
                Me.OnUserDeletingRow(Nothing)
            End If
        Catch ex As Exception
        End Try
        Return MyBase.ProcessDialogKey(keyData)
    End Function
#End Region

#Region "FomatingNumber"
#Region "Delete 2020/04/25"
    'Public ListColumnNumber As List(Of ValidateCellInfo) = New List(Of ValidateCellInfo)
    'Public Sub AddColumnNumberlInfo(ByVal info As ValidateCellInfo)
    '    Try
    '        ListColumnNumber.Add(info)
    '    Catch ex As Exception

    '    End Try
    'End Sub
#End Region

    Public ListNumber As List(Of ValidateCellInfo) = New List(Of ValidateCellInfo)
    Public Sub AddColumnNumberlInfo(ByVal ColumnIndex As Integer, Optional IsPostalCode As Boolean = False, Optional AutoFormat As Boolean = False, Optional IsJPEra As Boolean = False, Optional IsYearMonth As Boolean = False, Optional IsHandleChange As Boolean = False, Optional DataNotNull As Boolean = False)
        Try
            Dim info = New ValidateCellInfo With {
            .ColIndex = ColumnIndex,
            .IsPostalCode = IsPostalCode,
            .AutoFormat = AutoFormat,
            .IsJPEra = IsJPEra,
            .IsYearMonth = IsYearMonth,
            .IsHandleChange = IsHandleChange,
            .DataNotNull = DataNotNull
                }
            ListNumber.Add(info)
        Catch ex As Exception

        End Try
    End Sub

#Region "Delete 2020/04/25"
    'Protected Overrides Sub OnCellFormatting(e As DataGridViewCellFormattingEventArgs)
    '    If e.RowIndex <> Me.NewRowIndex AndAlso Not IsNothing(ListColumnNumber) Then
    '        Dim _fomat As ValidateCellInfo = ListColumnNumber.Find(Function(x) (x.ColumnIndex = e.ColumnIndex) AndAlso (x.RowIndex = e.RowIndex Or x.RowIndex = -1))
    '        If Not IsNothing(_fomat) Then
    '            Try
    '                e.Value = FormatNumber(e.Value, _fomat.DecimalLength,,, TriState.True)
    '                e.FormattingApplied = True
    '                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    '            Catch ex As Exception
    '            End Try
    '        End If

    '    End If
    'End Sub
#End Region

#End Region

#Region "Set Value Form To Grid"
    ''' <summary>
    ''' SetValueFormToGrid
    ''' </summary>
    ''' <param name="frm"></param>
    ''' <returns></returns>
    Public Function SetValueFormToGrid(ByRef frm As Form) As Boolean
        Try
            If frm.ShowDialog() = DialogResult.OK Then
                If Me.Rows(Me.CurrentRow.Index).IsNewRow Then
                    Me.NotifyCurrentCellDirty(True)
                    Me.NotifyCurrentCellDirty(False)
                    'dtData.Rows.Add(dtData.NewRow())
                    'dtData.Rows.RemoveAt(dtData.Rows.Count - 1)
                End If
                Return True
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Delete 2020/04/25"
    '''' <summary>
    '''' Insert Row
    '''' </summary>
    '''' <param name="dtData"></param>
    'Public Sub InsertRow(ByRef dtData As DataTable)
    '    Try
    '        If _MaxRow >= 0 Then
    '            If Me.Rows.Count >= _MaxRow Then
    '                Throw New Exception(String.Format(MESS_ERROR_GRIDMAXROW, _MaxRow))
    '            End If
    '        End If
    '        If rowSelectIndex >= 0 Then
    '            dtData.Rows.InsertAt(dtData.NewRow, rowSelectIndex)
    '            'Me.CurrentCell = Me.Rows(rowSelectIndex + 1).Cells(columnSelectIndex)
    '            'Me.CurrentCell.Selected = True
    '            Me.Select()
    '        End If
    '        Me.AllowUserToAddRows = IIf(Me.AllowUserToAddRows, Me.RowCount - 1, Me.RowCount) < _MaxRow
    '        If IsShowRowIndexFlag Then
    '            For i = 0 To Me.RowCount - 1
    '                Me.Rows(i).HeaderCell.Value = CStr(i + 1).PadLeft(3, "0")
    '            Next
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
    ''' <summary>
    ''' Check maxrow when user add
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnUserAddedRow(e As DataGridViewRowEventArgs)
        MyBase.OnUserAddedRow(e)
        Try
            'MyBase.OnUserAddedRow(e)
            'If _MaxRow > 0 Then

            '    Me.AllowUserToAddRows = IIf(Me.AllowUserToAddRows, Me.RowCount - 1, Me.RowCount) < _MaxRow
            '    If Me.Rows.Count - 1 > _MaxRow Then
            '        Do
            '            Me.Rows.RemoveAt(_MaxRow)
            '        Loop Until Me.Rows.Count = _MaxRow


            '        Throw New Exception(String.Format(MESS_ERROR_GRIDMAXROW, _MaxRow))
            '    End If
            'End If
            'If IsShowRowIndexFlag Then
            '    For i = 0 To Me.RowCount - 1
            '        Me.Rows(i).HeaderCell.Value = CStr(i + 1).PadLeft(3, "0")
            '    Next
            'End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    '''' <summary>
    '''' Check maxrow when user delete
    '''' </summary>
    '''' <param name="e"></param>
    'Protected Overrides Sub OnUserDeletedRow(e As DataGridViewRowEventArgs)
    '    MyBase.OnUserDeletedRow(e)
    '    Try
    '        MyBase.OnUserDeletedRow(e)
    '        If _MaxRow >= 0 Then
    '            Me.AllowUserToAddRows = IIf(Me.AllowUserToAddRows, Me.RowCount - 1, Me.RowCount) < _MaxRow
    '        End If
    '        If IsShowRowIndexFlag Then
    '            For i = 0 To Me.RowCount - 1
    '                Me.Rows(i).HeaderCell.Value = CStr(i + 1).PadLeft(3, "0")
    '            Next
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
#End Region

#Region "Delete 2020/04/25"
    '''' <summary>
    '''' Remove Row
    '''' </summary>
    '''' <param name="dtData"></param>
    'Public Sub RemoveRow(ByRef dtData As DataTable)
    '    Try

    '        If Me.Rows.Count > 0 Then
    '            For iRow As Integer = IIf(Me.AllowUserToAddRows, Me.RowCount - 2, Me.RowCount - 1) To 0 Step -1
    '                If Me.Rows(iRow).Cells(columnSelectIndex).Selected Then
    '                    Me.Rows.RemoveAt(iRow)
    '                    Exit For
    '                End If
    '            Next
    '            Me.AllowUserToAddRows = IIf(Me.AllowUserToAddRows, Me.RowCount - 1, Me.RowCount) < _MaxRow
    '            Me.ClearSelection()
    '            If IIf(Me.AllowUserToAddRows, Me.RowCount - 1, Me.RowCount) > 0 Then
    '                If rowSelectIndex > 0 Then
    '                    Me.CurrentCell = Me.Rows(rowSelectIndex - 1).Cells(columnSelectIndex)
    '                Else
    '                    Me.CurrentCell = Me.Rows(0).Cells(columnSelectIndex)
    '                End If
    '                Me.CurrentCell.Selected = True
    '            End If

    '            Me.Select()
    '        End If

    '        If IsShowRowIndexFlag Then
    '            For i = 0 To Me.RowCount - 1
    '                Me.Rows(i).HeaderCell.Value = CStr(i + 1).PadLeft(3, "0")
    '            Next
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
#End Region

#Region "Leave"
    ''' <summary>
    ''' last rowSelectIndex
    ''' </summary>
    Public rowSelectIndex As Integer = Nothing
    Public columnSelectIndex As Integer = Nothing
    ''' <summary>
    ''' rowSelectIndex = e.RowIndex
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnCellLeave(e As DataGridViewCellEventArgs)
        MyBase.OnCellLeave(e)
        Try
            rowSelectIndex = e.RowIndex
            columnSelectIndex = e.ColumnIndex
            'If Me.Focused Then
            '    If ListColumnComboboxInfo.Any(Function(x) x.ColumnGetValueCombobox = columnSelectIndex) Then
            '        Dim ColIndex = ListColumnComboboxInfo.FirstOrDefault(Function(x) x.ColumnGetValueCombobox = columnSelectIndex).ColumnCoboboxIndex
            '        Dim value = Me.Rows(rowSelectIndex).Cells(ColIndex).FormattedValue
            '        If String.IsNullOrEmpty(value) Then
            '            Me.SetCellValue(rowSelectIndex, columnSelectIndex, "")
            '        End If
            '    End If
            'End If

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "OnCurrentCellChanged"

#Region "Delete 2020/04/25"
    '''' <summary>
    '''' OnGotFocus
    '''' </summary>
    '''' <param name="e"></param>
    'Protected Overrides Sub OnCurrentCellChanged(e As EventArgs)
    '    MyBase.OnCurrentCellChanged(e)
    '    Try
    '        If Not IsNothing(CurrentCell) AndAlso Not CurrentCell.ReadOnly Then
    '            Me.BeginEdit(True)
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
#End Region

    Protected Overrides Sub OnCellBeginEdit(e As DataGridViewCellCancelEventArgs)
        MyBase.OnCellBeginEdit(e)
        Try
            If Not IsNothing(CurrentCell) AndAlso Not IsDBNull(CurrentCell.Value) Then
                If Not String.IsNullOrEmpty(Me.CurrentCell.Value) Then
                    If ListNumber.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex AndAlso x.IsPostalCode = True) Then
                        Me.CurrentCell.Value = Me.CurrentCell.Value.ToString().Replace("-", "")
                    ElseIf ListNumber.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex AndAlso x.AutoFormat = True) Then
                        Me.CurrentCell.Value = Me.CurrentCell.Value.ToString().Replace(",", "")
                    ElseIf ListNumber.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex AndAlso x.IsJPEra = True) Then
                        Me.CurrentCell.Value = ConvertJapaneseEra(Me.CurrentCell.Value)
                    ElseIf ListNumber.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex AndAlso x.IsYearMonth = True) Then
                        Me.CurrentCell.Value = IsYearMonthToInteger(Me.CurrentCell.Value)
                    End If
                End If
            End If
            'AddColumnInfo
            If ListInfoColumn.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex) Then
                Dim _ImeMode = ListInfoColumn.FirstOrDefault(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex).ImeMode
                Me.ImeMode = _ImeMode
            End If
        Catch ex As Exception
        End Try
    End Sub
    ''' <summary>
    ''' OnCellEndEdit
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnCellEndEdit(e As DataGridViewCellEventArgs)
        MyBase.OnCellEndEdit(e)
        Try
            If Not IsNothing(CurrentCell) AndAlso Not IsDBNull(CurrentCell.Value) Then
                If Not String.IsNullOrEmpty(CurrentCell.Value) Then
                    If ListNumber.Any(Function(x) x.ColIndex = CurrentCell.ColumnIndex AndAlso x.IsPostalCode = True) Then
                        Me.CurrentCell.Value = CurrentCell.Value.ToString.PadRight(7, "0").Insert(3, "-")
                    ElseIf ListNumber.Any(Function(x) x.ColIndex = CurrentCell.ColumnIndex AndAlso x.AutoFormat = True) Then
                        Me.CurrentCell.Value = FormatNumber(CurrentCell.Value, 0,,, TriState.True)
                    ElseIf ListNumber.Any(Function(x) x.ColIndex = CurrentCell.ColumnIndex AndAlso x.IsJPEra = True) Then
                        Me.CurrentCell.Value = JapaneseEra(CurrentCell.Value)
                    ElseIf ListNumber.Any(Function(x) x.ColIndex = CurrentCell.ColumnIndex AndAlso x.IsYearMonth = True) Then
                        Me.CurrentCell.Value = IsNumberToYearMonth(CurrentCell.Value)
                    End If
                End If
            End If
            If ListInfoColumn.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex AndAlso x.VbStrConv <> VbStrConv.None) Then
                Dim TypeStr = ListInfoColumn.FirstOrDefault(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex).VbStrConv
                Me.CurrentCell.Value = StrConv(Me.CurrentCell.FormattedValue, TypeStr, New System.Globalization.CultureInfo("ja-JP", True).LCID)
            End If
            If ListNumber.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex AndAlso x.DataNotNull = True) Then
                If String.IsNullOrEmpty(Me.CurrentCell.FormattedValue) Then
                    Me.CurrentCell.Value = "0"
                End If
            End If

            If Me.Focused Then
                If ListColumnComboboxInfo.Any(Function(x) x.ColumnGetValueCombobox = columnSelectIndex) Then
                    Dim ColIndex = ListColumnComboboxInfo.FirstOrDefault(Function(x) x.ColumnGetValueCombobox = columnSelectIndex).ColumnCoboboxIndex
                    Dim value = Me.Rows(rowSelectIndex).Cells(ColIndex).FormattedValue
                    If String.IsNullOrEmpty(value) Then
                        Me.SetCellValue(rowSelectIndex, columnSelectIndex, "")
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Validate"
    Public ListInfoColumn As List(Of ValidateCellInfo) = New List(Of ValidateCellInfo)
    ''' <summary>
    ''' AddColumnInfo
    ''' </summary>
    ''' <param name="ColumnIndex"></param>
    ''' <param name="IsColKey"></param>
    ''' <param name="DataMaxlength"></param>
    Public Sub AddColumnInfo(ByVal ColumnIndex As Integer, Optional IsColKey As Boolean = False, Optional DataMaxlength As Integer = -1, Optional IsShowMess As Boolean = True, Optional ImeMode As ImeMode = ImeMode.Disable, Optional IsValidFieldReadOnly As Boolean = False, Optional VbStrConv As VbStrConv = VbStrConv.None, Optional IsOnlyHatWidthEng As Boolean = False, Optional EventStrConv As CC_EVENT = CC_EVENT.None)
        Try
            Dim info = New ValidateCellInfo With {
            .ColIndex = ColumnIndex,
            .IsColKey = IsColKey,
            .DataMaxLength = DataMaxlength,
            .IsShowMess = IsShowMess,
            .ImeMode = ImeMode,
            .IsValidFieldReadOnly = IsValidFieldReadOnly,
            .VbStrConv = VbStrConv,
            .IsOnlyHatWidthEng = IsOnlyHatWidthEng,
            .EventStrConv = EventStrConv}
            ListInfoColumn.Add(info)
        Catch ex As Exception

        End Try
    End Sub

    Public ListColumnComboboxInfo As List(Of ValidateCellInfo) = New List(Of ValidateCellInfo)
    ''' <summary>
    ''' AddColumnComboboxInfo
    ''' </summary>
    Public Sub AddColumnComboboxInfo(ByVal ColumnGetValueCombobox As Integer, ByVal ColumnCoboboxIndex As Integer)
        Try
            Dim info = New ValidateCellInfo With {
            .ColumnCoboboxIndex = ColumnCoboboxIndex,
            .ColumnGetValueCombobox = ColumnGetValueCombobox
                }
            ListColumnComboboxInfo.Add(info)
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "OnCurrentCellDirtyStateChanged"
    ''' <summary>
    ''' OnCellValueChanged
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnCurrentCellDirtyStateChanged(e As EventArgs)
        MyBase.OnCurrentCellDirtyStateChanged(e)
        Try
            If Me.IsCurrentCellDirty Then
                If ListColumnComboboxInfo.Any(Function(x) x.ColumnCoboboxIndex = CurrentCell.ColumnIndex Or x.ColumnGetValueCombobox = CurrentCell.ColumnIndex) Or
                    ListNumber.Any(Function(x) x.ColIndex = CurrentCell.ColumnIndex AndAlso x.IsHandleChange = True) OrElse
                    ListInfoColumn.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex And (x.IsOnlyHatWidthEng = True OrElse x.EventStrConv = CC_EVENT.TextChange)) Then
                    Me.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    DirectCast(Me.EditingControl, TextBox).SelectionStart = Me.CurrentCell.FormattedValue.ToString.Length
                    If ListColumnComboboxInfo.Any(Function(x) x.ColumnCoboboxIndex = CurrentCell.ColumnIndex Or x.ColumnGetValueCombobox = CurrentCell.ColumnIndex) Then
                        DirectCast(Me.EditingControl, TextBox).Text = Me.CurrentCell.FormattedValue.ToString.ToUpper
                    End If
                    strPre = Me.CurrentCell.FormattedValue
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' OnCellValueChanged
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnCellValueChanged(e As DataGridViewCellEventArgs)
        MyBase.OnCellValueChanged(e)
        Try
            If Not IsNothing(CurrentCell) AndAlso Not IsDBNull(CurrentCell.Value) Then
                'If Not String.IsNullOrEmpty(CurrentCell.Value) Then
                If ListColumnComboboxInfo.Any(Function(x) x.ColumnCoboboxIndex = CurrentCell.ColumnIndex) Then
                    Dim colIndex = ListColumnComboboxInfo.FirstOrDefault(Function(x) x.ColumnCoboboxIndex = CurrentCell.ColumnIndex).ColumnGetValueCombobox
                    Me.SetCellValue(CurrentCell.RowIndex, colIndex, CurrentCell.Value)
                ElseIf ListColumnComboboxInfo.Any(Function(x) x.ColumnGetValueCombobox = CurrentCell.ColumnIndex) Then
                    Dim colIndex = ListColumnComboboxInfo.FirstOrDefault(Function(x) x.ColumnGetValueCombobox = CurrentCell.ColumnIndex).ColumnCoboboxIndex
                    Me.SetCellValue(CurrentCell.RowIndex, colIndex, CurrentCell.FormattedValue)
                End If
                'End If

                If ListInfoColumn.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex And x.IsOnlyHatWidthEng = True) Then
                    If (String.IsNullOrEmpty(strPre) AndAlso Not FControl.IsHaftWidthEng(Me.CurrentCell.FormattedValue)) OrElse (Not String.IsNullOrEmpty(strPre) AndAlso Not FControl.IsHaftWidthEng(Me.CurrentCell.FormattedValue.ToString.Replace(strPre, ""))) Then
                        Me.CurrentCell.Value = strPre
                    End If
                ElseIf ListInfoColumn.Any(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex And x.EventStrConv = CC_EVENT.TextChange) Then
                    Dim TypeStr = ListInfoColumn.FirstOrDefault(Function(x) x.ColIndex = Me.CurrentCell.ColumnIndex).VbStrConv
                    Me.CurrentCell.Value = StrConv(Me.CurrentCell.FormattedValue, TypeStr, New System.Globalization.CultureInfo("ja-JP", True).LCID)
                End If
            Else
                If ListColumnComboboxInfo.Any(Function(x) x.ColumnGetValueCombobox = CurrentCell.ColumnIndex) Then
                    Dim colIndex = ListColumnComboboxInfo.FirstOrDefault(Function(x) x.ColumnGetValueCombobox = CurrentCell.ColumnIndex).ColumnCoboboxIndex
                    Me.SetCellValue(CurrentCell.RowIndex, colIndex, Nothing)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "JPEra"
    ''' <summary>
    ''' JapaneseEraName
    ''' </summary>
    ''' <returns></returns>
    Private Function JapaneseEra(ByVal pDate As Integer) As String
        Try
            'Reiwa(令和) :  01/05/2019 – Now
            'Heisei(平成) :  1989 – <=2019
            'Showa(昭和) :  1926–1989
            'Taisho(大正) :  1912–1926
            'Meiji(明治) :  1868–1912
            Dim strDate As String = ""
            Dim dtDateTime As System.DateTime
            Try
                dtDateTime = DateTime.ParseExact(pDate, "yyyyMMdd", New System.Globalization.CultureInfo("ja-JP"))
            Catch
                Return ""
            End Try
            Select Case True
                Case pDate > 18681101 And pDate <= 19120729
                    strDate = "M " & ((pDate - 18680000 + 10000).ToString().PadLeft(6, "0").Insert(2, "/").Insert(5, "/"))
                Case pDate > 19120729 And pDate <= 19261224
                    strDate = "T " & ((pDate - 19120000 + 10000).ToString().PadLeft(6, "0").Insert(2, "/").Insert(5, "/"))
                Case pDate > 19261224 And pDate <= 19890107
                    strDate = "S " & ((pDate - 19260000 + 10000).ToString().PadLeft(6, "0").Insert(2, "/").Insert(5, "/"))
                Case pDate > 19890107 And pDate < 20190501
                    strDate = "H " & ((pDate - 19890000 + 10000).ToString().PadLeft(6, "0").Insert(2, "/").Insert(5, "/"))
                Case pDate >= 20190501
                    strDate = "R " & ((pDate - 20190000 + 10000).ToString().PadLeft(6, "0").Insert(2, "/").Insert(5, "/"))
                Case Else
                    Return ""
            End Select
            Return strDate
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' JapaneseEraName
    ''' </summary>
    ''' <returns></returns>
    Private Function ConvertJapaneseEra(ByVal JEraName As String) As String
        Try
            Select Case True
                Case JEraName.Contains("M")
                    JEraName = CInt(JEraName.Replace("M ", "").Replace("/", "")) + 18680000 - 10000
                Case JEraName.Contains("T")
                    JEraName = CInt(JEraName.Replace("T ", "").Replace("/", "")) + 19120000 - 10000
                Case JEraName.Contains("S")
                    JEraName = CInt(JEraName.Replace("S ", "").Replace("/", "")) + 19260000 - 10000
                Case JEraName.Contains("H")
                    JEraName = CInt(JEraName.Replace("H ", "").Replace("/", "")) + 19890000 - 10000
                Case JEraName.Contains("R")
                    JEraName = CInt(JEraName.Replace("R ", "").Replace("/", "")) + 20190000 - 10000
                Case Else
                    Return ""
            End Select
            Return JEraName
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "IsYearMonthToInteger"
    ''' <summary>
    ''' IsNumberToYearMonth
    ''' </summary>
    Private Function IsNumberToYearMonth(YearMonth As String) As String
        Try
            Dim strDate As String = ""
            Dim dtDateTime As System.DateTime
            Try
                dtDateTime = DateTime.ParseExact(YearMonth, "yyyyMM", New System.Globalization.CultureInfo("ja-JP"))
            Catch
                Return ""
            End Try
            strDate = dtDateTime.ToString("yyyy/MM")
            Return strDate
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' IsYearMonthToInteger
    ''' </summary>
    Private Function IsYearMonthToInteger(YearMonth As String) As String
        Try
            Return YearMonth.Replace("/", "")
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "SetColorError"
    ''' <summary>
    ''' ColorCellError
    ''' </summary>
    Public Sub ColorCellError(RowIndex As Integer, ColumnIndex As Integer)
        Try
            Me.Rows(RowIndex).Cells(ColumnIndex).Style.BackColor = Color.FromArgb(255, 192, 203)
        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' ColorCell
    ''' </summary>
    Public Sub ColorCellDefault(RowIndex As Integer, ColumnIndex As Integer)
        Try
            Me.Rows(RowIndex).Cells(ColumnIndex).Style.BackColor = Color.White
        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' ColorCell
    ''' </summary>
    Public Sub SetColorGridDefault()
        Try
            For Each row As DataGridViewRow In Me.Rows
                For Each col As DataGridViewColumn In Me.Columns
                    Me.Rows(row.Index).Cells(col.Index).Style.BackColor = Color.White
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' ColorCell
    ''' </summary>
    Public Function IsNotColorError(Optional IsBeginEdit As Boolean = False) As Boolean
        Try
            For Each row As DataGridViewRow In Me.Rows
                For Each col As DataGridViewColumn In Me.Columns
                    If Me.Rows(row.Index).Cells(col.Index).Style.BackColor.Name = "ffffc0cb" Then
                        If IsBeginEdit Then
                            Me.BeginEdit(True)
                        End If
                        Return False
                    End If
                Next
            Next
        Catch ex As Exception
        End Try
        Return True
    End Function
#End Region

#Region "Clear Row"
    ''' <summary>
    ''' ClearRow
    ''' </summary>
    Public Sub ClearRow()
        Try
            Me.Rows.Clear()
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "SetReadOnlyGrv"
    ''' <summary>
    ''' SetReadOnlyGrv
    ''' </summary>
    Public Sub SetReadOnlyGrv(IsReadOnly As Boolean)
        Try
            If Not IsReadOnly Then
                Dim i = 0
                For Each Flag As Boolean In ListColumnRead
                    Me.Columns(i).ReadOnly = Flag
                    i += 1
                Next
            Else
                Me.ReadOnly = IsReadOnly
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private ListColumnRead As List(Of Boolean)
    ''' <summary>
    ''' SaveColumnRead
    ''' </summary>
    Public Sub SaveColumnRead()
        Try
            ListColumnRead = New List(Of Boolean)
            For Each col As DataGridViewColumn In Me.Columns
                ListColumnRead.Add(col.ReadOnly)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
