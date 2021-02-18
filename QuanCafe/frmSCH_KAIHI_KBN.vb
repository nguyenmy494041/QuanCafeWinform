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

    'Function saveKaihi(ByVal key As Integer, ByVal kaihi As String, ByVal dat As Date, ByVal tango As String) As Integer

    'End Function



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
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

        If DataGridView1.IsCurrentCellDirty Then
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            Dim col = e.ColumnIndex
            Dim row = e.RowIndex
            Dim cdname = getCD_NAME()
            If col = 1 Then
                Dim keySCH = DataGridView1.Rows(row).Cells(col).Value
                Dim exitSCH = cdname.Where(Function(x) x.CD_NO = keySCH).FirstOrDefault()
                If Not IsNothing(exitSCH) Then
                    DataGridView1.Rows(row).Cells(1).Style.BackColor = Color.White
                    If DataGridView1.Rows(row).IsNewRow Then
                        DataGridView1.Rows(row).Cells(col + 1).Value = cdname.Where(Function(x) x.CD_NO = keySCH).FirstOrDefault().CD_NAME
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
                    MsgBox("not found!")
                    DataGridView1.Rows(row).Cells(1).Value = ""
                End If
            ElseIf col = 3 Then


            End If
        End If

    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        rowdata = DataGridView1.CurrentCell.RowIndex

        If DataGridView1.CurrentCell.ColumnIndex = 2 Then
            Dim combo = New ComboBox()
            combo = CType(e.Control, ComboBox)
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
        If text.TextLength >= 12 Then
            e.Handled = True
            MsgBox("UPD_TANGO no more than 12 characters")
        End If
        'RemoveHandler text.KeyPress, AddressOf text_TextChanged
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
        ' RemoveHandler text.KeyPress, AddressOf text_KeyPress
    End Sub

    Sub combo_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim combo = New ComboBox()
        Dim cdname = getCD_NAME()
        combo = CType(sender, ComboBox)
        MsgBox(combo.Text)
        DataGridView1.Rows(rowdata).Cells(1).Value = cdname.Where(Function(x) x.CD_NAME = combo.Text).FirstOrDefault().CD_NO
        RemoveHandler combo.SelectedIndexChanged, AddressOf combo_SelectedIndexChanged
    End Sub



    'Private Sub DataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellLeave
    '    Dim i = e.RowIndex
    '    If DataGridView1.CurrentCell.ColumnIndex = 2 Then
    '        MsgBox(DataGridView1.Rows(i).Cells(2).Value)
    '    End If
    'End Sub




End Class