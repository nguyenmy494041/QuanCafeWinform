Public Class frmKAIHI
    Private listSCHKAIHIKBN As New List(Of M_SCH_KAIHI)
    Private listCDNAME As New List(Of M_CODE)

    Sub SetCellReadOnly(ByVal row As Integer, ByVal col As Integer, ByVal breadonly As Boolean)
        dtgvKAIHI.Rows(row).Cells(col).ReadOnly = breadonly
    End Sub
    Sub fillDataInDataGridView()
        listSCHKAIHIKBN = getDataSCHKAHIKBN()
        dtgvKAIHI.Rows.Clear()
        Dim irow As Integer = 0
        For Each model In listSCHKAIHIKBN
            Dim i = dtgvKAIHI.Rows.Add()
            Dim comb = New DataGridViewComboBoxCell()
            For Each item In getDataCDNAME()
                comb.Items.Add(item.CD_NAME)
            Next
            comb.Value = getCD_NAME_By_SCHKAIHIKBN(model.SCH_KAIHI_KBN).ToString()
            dtgvKAIHI.Rows(i).Cells(clmDelete.Index).Value = False
            dtgvKAIHI.Rows(i).Cells(clmSCHKAIHIKBN.Index).Value = CDec(model.SCH_KAIHI_KBN)
            dtgvKAIHI.Rows(i).Cells(clmName.Index) = comb
            dtgvKAIHI.Rows(i).Cells(clmKAIHI.Index).Value = CDec(model.KAIHI)
            dtgvKAIHI.Rows(i).Cells(clmUPDDATE.Index).Value = CDate(model.UPD_DATE)
            dtgvKAIHI.Rows(i).Cells(clmTANGO.Index).Value = model.UPD_TANTO.ToString()
            SetCellReadOnly(irow, 1, True)
            SetCellReadOnly(irow, 2, True)
            irow += 1
        Next


    End Sub


    Function getDataSCHKAHIKBN() As List(Of M_SCH_KAIHI)
        Return New QuanCafeEntities().M_SCH_KAIHI.ToList()
    End Function
    Function getDataCDNAME() As List(Of M_CODE)
        Return New QuanCafeEntities().M_CODE.Where(Function(e) e.CD_SYU = "GAKKOKAI").ToList()
    End Function
    Function getCD_NAME_By_SCHKAIHIKBN(ByVal key As Decimal) As String
        Return New QuanCafeEntities().M_CODE.Where(Function(e) e.CD_NO = key AndAlso e.CD_SYU = "GAKKOKAI").FirstOrDefault().CD_NAME
    End Function

    Private Sub frmKAIHI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDataInDataGridView()
    End Sub
End Class