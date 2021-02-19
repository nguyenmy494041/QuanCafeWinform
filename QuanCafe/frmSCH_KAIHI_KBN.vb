Public Class frmSCH_KAIHI_KBN
    Private rowdata As Integer
    Private Sub frmSCH_KAIHI_KBN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDatagridview()
    End Sub

    Function getCD_NAME() As List(Of M_CODE)
        Dim context = New QuanCafeEntities()
        Return context.M_CODE.Where(Function(x) x.CD_SYU = "GAKKOKAI").ToList()
    End Function

    Function getSCHKAIHIKBN() As List(Of M_SCH_KAIHI)
        Dim context = New QuanCafeEntities()
        Return context.M_SCH_KAIHI.ToList()
    End Function
    Sub loadDatagridview()
        Dim cdname = getCD_NAME()
        Dim kaihikbn = getSCHKAIHIKBN()
        DataGridView1.Rows.Clear()
        For Each row In kaihikbn
            Dim index = DataGridView1.Rows.Add()
            DataGridView1.Rows(index).Cells(1).Value = row.SCH_KAIHI_KBN
            Dim comb = New DataGridViewComboBoxCell()
            For Each item In cdname
                comb.Items.Add(item.CD_NAME)
            Next
            comb.Value = cdname.Where(Function(x) x.CD_NO = row.SCH_KAIHI_KBN).FirstOrDefault().CD_NAME
            DataGridView1.Rows(index).Cells(2) = comb
            DataGridView1.Rows(index).Cells(3).Value = row.KAIHI
            DataGridView1.Rows(index).Cells(4).Value = row.UPD_DATE
            DataGridView1.Rows(index).Cells(5).Value = row.UPD_TANTO
        Next
        DataGridView1.Columns(1).ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

        If DataGridView1.IsCurrentCellDirty Then
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            Dim col = e.ColumnIndex
            Dim row = e.RowIndex
            If col = 1 And row = DataGridView1.Rows.Count - 2 Then
                Dim check = False
                Dim cdname = getCD_NAME()
                Dim SCH = getSCHKAIHIKBN()
                Dim keySCH = DataGridView1.Rows(row).Cells(col).Value
                Dim exitSCH = cdname.Where(Function(x) x.CD_NO = keySCH).FirstOrDefault()
                For Each rowa As DataGridViewRow In DataGridView1.Rows
                    If rowa.Cells(1).Value = DataGridView1.Rows(row).Cells(1).Value AndAlso rowa.Index <> row Then
                        check = True
                    End If
                Next
                If Not IsNothing(exitSCH) Then
                    If Not check Then
                        DataGridView1.Rows(row).Cells(1).Style.BackColor = Color.White
                        If DataGridView1.Rows(row).IsNewRow Then
                            DataGridView1.Rows(row).Cells(2).Value = cdname.Where(Function(x) x.CD_NO = keySCH).FirstOrDefault().CD_NAME
                        Else
                            Dim comb = New DataGridViewComboBoxCell()
                            For Each item In cdname
                                comb.Items.Add(item.CD_NAME)
                            Next
                            comb.Value = cdname.Where(Function(x) x.CD_NO = keySCH).FirstOrDefault().CD_NAME
                            DataGridView1.Rows(row).Cells(2) = comb
                        End If
                    Else
                        DataGridView1.Rows(row).Cells(1).Style.BackColor = Color.MistyRose
                        'MsgBox("SCH_KAIHI_KBN used")
                    End If
                Else
                    DataGridView1.Rows(row).Cells(1).Style.BackColor = Color.MistyRose
                    MsgBox("not found on M_CODE")
                End If
            ElseIf col = 3 Or col = 5 Then
                Dim str = DataGridView1.Rows(row).Cells(col).Value
                If IsNothing(str) OrElse str.Length = 0 Then
                    DataGridView1.Rows(row).Cells(col).Style.BackColor = Color.MistyRose
                    btnf5.Enabled = False
                Else
                    DataGridView1.Rows(row).Cells(col).Style.BackColor = Color.White
                    btnf5.Enabled = True
                End If
            End If
        End If

    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        rowdata = DataGridView1.CurrentCell.RowIndex
        If DataGridView1.CurrentCell.ColumnIndex = 2 Then
            Dim combo = New ComboBox()
            combo = CType(e.Control, ComboBox)
            RemoveHandler combo.SelectedIndexChanged, AddressOf combo_SelectedIndexChanged
            AddHandler combo.SelectedIndexChanged, AddressOf combo_SelectedIndexChanged
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 3 Then
            Dim textbo = New TextBox()
            textbo = CType(e.Control, TextBox)
            RemoveHandler textbo.KeyPress, AddressOf text_TextChanged
            RemoveHandler textbo.KeyPress, AddressOf text_KeyPress
            AddHandler textbo.KeyPress, AddressOf text_KeyPress
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 5 Then
            Dim textbo = New TextBox()
            textbo = CType(e.Control, TextBox)
            RemoveHandler textbo.KeyPress, AddressOf text_KeyPress
            RemoveHandler textbo.KeyPress, AddressOf text_TextChanged
            AddHandler textbo.KeyPress, AddressOf text_TextChanged

        End If

    End Sub
    Sub text_TextChanged(sender As Object, e As KeyPressEventArgs)
        Dim text = New TextBox()
        text = CType(sender, TextBox)
        If Asc(e.KeyChar) <> 8 Then
            If text.TextLength >= 12 Then
                e.Handled = True
                MsgBox("UPD_TANGO no more than 12 characters")
            End If
        End If

    End Sub
    Sub text_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim text = New TextBox()
        text = CType(sender, TextBox)
        If Asc(e.KeyChar) <> 8 Then
            Dim a = text.Text.Length
            If Asc(e.KeyChar) < 48 OrElse Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If a >= 6 Then
                e.Handled = True
                MsgBox("KAIHI no more than 6 digits")
            End If
        End If
    End Sub

    Sub combo_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim combo = New ComboBox()
        rowdata = DataGridView1.CurrentCell.RowIndex
        Dim cdname = getCD_NAME()
        Dim check = False
        combo = CType(sender, ComboBox)
        DataGridView1.Rows(rowdata).Cells(1).Value = cdname.Where(Function(x) x.CD_NAME = combo.Text).FirstOrDefault().CD_NO
        Dim SCH = getSCHKAIHIKBN()
        Dim exitdatagridview = SCH.Where(Function(x) x.SCH_KAIHI_KBN = DataGridView1.Rows(rowdata).Cells(1).Value).FirstOrDefault()
        For Each rowa As DataGridViewRow In DataGridView1.Rows
            If rowa.Cells(1).Value = DataGridView1.Rows(rowdata).Cells(1).Value AndAlso rowa.Index <> rowdata Then
                check = True
            End If
        Next
        If check Then
            DataGridView1.Rows(rowdata).Cells(1).Style.BackColor = Color.MistyRose
            MsgBox("SCH_KAIHI_KBN vvvvv vvvvv used")
            btnf5.Enabled = False
        Else
            DataGridView1.Rows(rowdata).Cells(1).Style.BackColor = Color.White
            btnf5.Enabled = True
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i = e.RowIndex
        If DataGridView1.Rows(i).IsNewRow Then
            Dim txb = New TextBox()
            DataGridView1.Rows(i).Cells(1).ReadOnly = False
            Dim cdname = getCD_NAME()
            Dim comb = New DataGridViewComboBoxCell()
            For Each item In cdname
                comb.Items.Add(item.CD_NAME)
            Next
            ' comb.Value = cdname.Where(Function(x) x.CD_NO = row.SCH_KAIHI_KBN).FirstOrDefault().CD_NAME
            DataGridView1.Rows(i).Cells(2) = comb
        End If
    End Sub
    Sub hasValueColumn(ByVal i As Integer)
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim str = row.Cells(i).Value.ToString
                If str.Length = 0 Then
                    row.Cells(i).Style.BackColor = Color.MistyRose
                Else
                    row.Cells(i).Style.BackColor = Color.White
                End If
            End If
        Next
    End Sub

    Private Sub btnf5_Click(sender As Object, e As EventArgs) Handles btnf5.Click
        If hasValue() Then
            'If validation() Then
            Dim keycode As String = ""
                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim key1 = row.Cells(1).Value
                    If Not IsNothing(key1) Then
                        Dim key = CType(key1, Decimal)
                        If row.Cells(0).Value Then
                            Dim context = New QuanCafeEntities()
                            Dim delete = context.M_SCH_KAIHI.Where(Function(x) x.SCH_KAIHI_KBN = key).FirstOrDefault()
                            If Not IsNothing(delete) Then
                                context.M_SCH_KAIHI.Remove(delete)
                                context.SaveChanges()
                            End If
                        Else
                            Dim context = New QuanCafeEntities()
                            Dim check_keycode = getCD_NAME()
                            Dim exit_Code = False
                            For Each item In check_keycode
                                If item.CD_NO = key Then
                                    exit_Code = True
                                End If
                            Next
                            If exit_Code Then
                                Dim sch_new = context.M_SCH_KAIHI.Where(Function(x) x.SCH_KAIHI_KBN = key).FirstOrDefault()
                                Dim kaihi = CType(row.Cells(3).Value, Decimal)
                                Dim upd_date = row.Cells(4).Value
                                Dim dat = CDate(upd_date).ToString("dd/MM/yyyy")
                                Dim upd_date2 = CType(dat, Date)
                                Dim tango = row.Cells(5).Value
                                Dim upd_time = Date.Now.ToString("HH:mm:ss")
                                If IsNothing(sch_new) Then
                                    Dim new_sch = New M_SCH_KAIHI()
                                    new_sch.SCH_KAIHI_KBN = key
                                    new_sch.KAIHI = kaihi
                                    new_sch.UPD_DATE = upd_date2
                                    new_sch.UPD_TIME = upd_time
                                    new_sch.UPD_TANTO = tango.ToString()
                                    context.M_SCH_KAIHI.Add(new_sch)
                                    context.SaveChanges()
                                Else
                                    sch_new.KAIHI = kaihi
                                    sch_new.UPD_DATE = upd_date2
                                    sch_new.UPD_TANTO = tango
                                    sch_new.UPD_TIME = upd_time
                                    context.SaveChanges()
                                End If
                            Else
                                keycode &= key & " "
                            End If
                        End If
                    End If
                Next
            If keycode <> "" Then
                keycode &= "notfound M_CODE"
            End If
            validation()
            MsgBox("ok" & vbCrLf & keycode)
            loadDatagridview()
        Else
            MsgBox("Chưa nhập")
        End If
    End Sub

    Private Sub btnesc_Click(sender As Object, e As EventArgs) Handles btnesc.Click
        loadDatagridview()
    End Sub
    Sub validation()

        Dim context = New QuanCafeEntities()
        Dim keyvalue = context.M_SCH_KAIHI.ToList()
        For Each key As M_SCH_KAIHI In keyvalue
            Dim check = True
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim a = CType(row.Cells(1).Value, Decimal)
                    If key.SCH_KAIHI_KBN = a Then
                        check = False
                    End If
                End If
            Next
            If check Then
                context.M_SCH_KAIHI.Remove(key)
                context.SaveChanges()
            End If
        Next
    End Sub
    Function hasValue() As Boolean
        Dim check = True
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                For i As Integer = 1 To row.Cells.Count - 1
                    If i <> 2 Then
                        If IsNothing(row.Cells(i).Value) OrElse row.Cells(i).Value.ToString = "" Then
                            check = False
                            row.Cells(i).Style.BackColor = Color.MistyRose
                        Else
                            row.Cells(i).Style.BackColor = Color.White
                        End If
                    End If
                Next
            End If
        Next
        Return check
    End Function
End Class