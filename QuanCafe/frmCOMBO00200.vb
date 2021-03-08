Public Class frmCOMBO00200
    Private Sub frmCOMBO00200_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr As String() = {"部分一致", "前方一致", "後方一致", "完全一致"}
        CC_Combobox1.Items.AddRange(arr)
        CC_Combobox2.Items.AddRange(arr)
        CC_Combobox2.SelectedIndex = 0
        CC_Combobox1.SelectedIndex = 0
    End Sub

    Function getDataM_IRYOKIKAN() As List(Of M_IRYOKIKAN)
        Return New QuanCafeEntities().M_IRYOKIKAN.ToList()
    End Function
    Function searchM_IRYOKIKAN(ByVal key As Decimal, ByVal IRYO_NAME_KJ As String, ByVal kjvalue As Integer, ByVal IRYO_NAME_KN As String, ByVal knvalue As Integer) As List(Of M_IRYOKIKAN)
        Dim listmodel = getDataM_IRYOKIKAN()
        If key > 0 Then
            listmodel = listmodel.Where(Function(e) e.IRYO_KIKAN_CD >= key).ToList()
        End If

        If Not String.IsNullOrEmpty(IRYO_NAME_KJ) Then
            Select Case kjvalue
                Case 0
                    listmodel = listmodel.Where(Function(x) x.IRYO_NAME_KJ.Contains(IRYO_NAME_KJ)).ToList()
                Case 1
                    listmodel = listmodel.Where(Function(x) x.IRYO_NAME_KJ.StartsWith(IRYO_NAME_KJ)).ToList()
                Case 2
                    listmodel = listmodel.Where(Function(x) x.IRYO_NAME_KJ.EndsWith(IRYO_NAME_KJ)).ToList()
                Case 3
                    listmodel = listmodel.Where(Function(x) x.IRYO_NAME_KJ = IRYO_NAME_KJ).ToList()
            End Select
        End If
        If Not String.IsNullOrEmpty(IRYO_NAME_KN) Then
            Select Case knvalue
                Case 0
                    listmodel = listmodel.Where(Function(x) x.IRYO_NAME_KN.Contains(IRYO_NAME_KN)).ToList()
                Case 1
                    listmodel = listmodel.Where(Function(x) x.IRYO_NAME_KN.StartsWith(IRYO_NAME_KN)).ToList()
                Case 2
                    listmodel = listmodel.Where(Function(x) x.IRYO_NAME_KN.EndsWith(IRYO_NAME_KN)).ToList()
                Case 3
                    listmodel = listmodel.Where(Function(x) x.IRYO_NAME_KN = IRYO_NAME_KN).ToList()
            End Select
        End If
        Return listmodel
    End Function
    Sub fillDataInDatagridview(ByVal listmodel As List(Of M_IRYOKIKAN))
        If listmodel.Count > 0 Then
            dtgvIRYOKIKAN.Rows.Clear()
            Dim irow As Integer = 0
            For Each model In listmodel
                Dim i = dtgvIRYOKIKAN.Rows.Add()
                dtgvIRYOKIKAN.Rows(i).Cells(clm1.Index).Value = model.IRYO_KIKAN_CD
                dtgvIRYOKIKAN.Rows(i).Cells(clm2.Index).Value = model.IRYO_NAME_KJ
                dtgvIRYOKIKAN.Rows(i).Cells(clm3.Index).Value = model.IRYO_NAME_KN
                dtgvIRYOKIKAN.Rows(i).Cells(clm4.Index).Value = model.HAISI_DATE
                irow += 1
            Next
            dtgvIRYOKIKAN.Rows(0).Selected = True
        End If
    End Sub

    Private Sub btnF5_Click(sender As Object, e As EventArgs) Handles btnF5.Click
        Dim key = CDec(Val(txb_IRYO_KIKAN_CD.Text))
        Dim irynamekj = txb_IRYO_NAME_KJ.Text
        Dim irynamekn = txb_IRYO_NAME_KN.Text
        Dim listmodel = searchM_IRYOKIKAN(key, irynamekj, CC_Combobox2.SelectedIndex, irynamekn, CC_Combobox1.SelectedIndex)
        If listmodel.Count = 0 Then
            txb_IRYO_KIKAN_CD.BackColor = Color.MistyRose
        Else
            txb_IRYO_KIKAN_CD.BackColor = Color.White
            txb_IRYO_NAME_KN.Enabled = False
            txb_IRYO_NAME_KJ.Enabled = False
            txb_IRYO_KIKAN_CD.Enabled = False
            fillDataInDatagridview(listmodel)
            btnF5.Enabled = False
        End If

    End Sub

    Private Sub btnESC_Click(sender As Object, e As EventArgs) Handles btnESC.Click
        If dtgvIRYOKIKAN.Rows.Count = 0 Then
            txb_IRYO_NAME_KJ.Clear()
            txb_IRYO_NAME_KN.Clear()
        End If
        dtgvIRYOKIKAN.Rows.Clear()
        txb_IRYO_KIKAN_CD.Clear()
        txb_IRYO_NAME_KN.Enabled = True
        txb_IRYO_NAME_KJ.Enabled = True
        txb_IRYO_KIKAN_CD.Enabled = True
        txb_IRYO_KIKAN_CD.BackColor = Color.White
        btnF5.Enabled = True
    End Sub

    Private Sub dtgvIRYOKIKAN_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvIRYOKIKAN.CellClick
        Dim i = e.RowIndex
        dtgvIRYOKIKAN.Rows(i).Selected = True
    End Sub

    Private Sub btnF6_Click(sender As Object, e As EventArgs) Handles btnF6.Click
        Dim key = dtgvIRYOKIKAN.SelectedRows(0).Cells(clm1.Index).Value
        Dim frm = New frmM_IRYOKIKAN()
        frm.txb_IRYO_KIKAN_CD.Text = key
        frm.btnESC.Enabled = True
        frm.Show()
        Me.Close()
    End Sub

    Private Sub txb_IRYO_KIKAN_CD_TextChanged(sender As Object, e As EventArgs) Handles txb_IRYO_KIKAN_CD.TextChanged
        txb_IRYO_KIKAN_CD.BackColor = Color.White
    End Sub

    Private Sub txb_IRYO_KIKAN_CD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_IRYO_KIKAN_CD.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 OrElse Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If txb_IRYO_KIKAN_CD.TextLength >= 7 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class