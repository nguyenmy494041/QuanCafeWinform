Public Class frmPOST_KANRI
    Sub cleartextbox()
        txbPOST_KANRI.Text = ""
        txbPOST.Text = ""
        txbaddress1.Text = ""
        txbADDRESS.Text = ""
        txbTANTO.Text = ""
    End Sub
    Sub getdata()
        'dtgvPOST_KANRI.s
        dtpkDATE.Value = DateTime.Now()
        dtpkTIME.Value = DateTime.Now()
        btndelete.Enabled = False
        dtgvPOST_KANRI.Rows.Clear()
        Dim context = New QuanCafeEntities()
        Dim data = context.M_POST.ToList()
        For Each row In data
            Dim index = dtgvPOST_KANRI.Rows.Add()
            dtgvPOST_KANRI.Rows(index).Cells(0).Value = row.POST_KANRI
            dtgvPOST_KANRI.Rows(index).Cells(1).Value = row.POST
            dtgvPOST_KANRI.Rows(index).Cells(2).Value = row.ADDRESS1
            dtgvPOST_KANRI.Rows(index).Cells(3).Value = row.ADDRESS_KN
            dtgvPOST_KANRI.Rows(index).Cells(4).Value = row.UPD_DATE

            dtgvPOST_KANRI.Rows(index).Cells(5).Value = row.UPD_TIME
            dtgvPOST_KANRI.Rows(index).Cells(6).Value = row.UPD_TANTO
        Next
        dtgvPOST_KANRI.Rows(0).Selected = False
    End Sub
    Private Sub frmPOST_KANRI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdata()
        btndelete.Enabled = False
    End Sub

    Private Sub dtgvPOST_KANRI_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvPOST_KANRI.CellClick
        Dim index = e.RowIndex()
        dtgvPOST_KANRI.Rows(index).Selected = True
        Dim row = dtgvPOST_KANRI.Rows(index)

        If Not IsNothing(row.Cells(1).Value) Then
            txbPOST_KANRI.Text = row.Cells(0).Value.ToString()
            txbPOST.Text = row.Cells(1).Value.ToString()
            txbaddress1.Text = row.Cells(2).Value.ToString()
            txbADDRESS.Text = row.Cells(3).Value.ToString()
            dtpkDATE.Value = row.Cells(4).Value
            dtpkTIME.Value = DateAdd("yyyy", 1800, TimeValue(row.Cells(5).Value))
            txbTANTO.Text = row.Cells(6).Value.ToString()
            btndelete.Enabled = True
        End If
        If IsNothing(row.Cells(0).Value) Then
            btndelete.Enabled = False
            txbPOST_KANRI.Enabled = True
            cleartextbox()
            txbPOST_KANRI.Text = dtgvPOST_KANRI.Rows(index - 1).Cells(0).Value + 1

        Else
            txbPOST_KANRI.Enabled = False
            btndelete.Enabled = True
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim context = New QuanCafeEntities()
        Dim kanri = context.M_POST.Where(Function(x) x.POST_KANRI = txbPOST_KANRI.Text).FirstOrDefault()
        If MsgBox("Are you sure delete", vbYesNo + vbInformation, "") = vbYes Then
            context.M_POST.Remove(kanri)
            context.SaveChanges()
            getdata()
            cleartextbox()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim context = New QuanCafeEntities()
        Dim index = dtgvPOST_KANRI.SelectedRows(0).Index
        If txbPOST_KANRI.Text <> "" AndAlso Val(txbPOST_KANRI.Text) <> 0 AndAlso txbPOST.Text <> "" AndAlso dtpkDATE.Value <> Nothing AndAlso txbaddress1.Text <> "" AndAlso txbADDRESS.Text <> "" _
           AndAlso dtpkTIME.Value <> Nothing AndAlso txbTANTO.Text <> "" Then
            Dim kanri = context.M_POST.Where(Function(x) x.POST_KANRI = txbPOST_KANRI.Text).FirstOrDefault()
            If Not IsNothing(kanri) Then
                kanri.POST = txbPOST.Text
                kanri.ADDRESS1 = txbaddress1.Text
                kanri.ADDRESS_KN = txbADDRESS.Text
                kanri.UPD_DATE = dtpkDATE.Value
                kanri.UPD_TIME = dtpkTIME.Value.ToString("HH:mm:ss")
                kanri.UPD_TANTO = txbTANTO.Text
                context.SaveChanges()
                MsgBox("Updated")

            Else
                Dim kairi = New M_POST()
                kairi.POST_KANRI = Val(txbPOST_KANRI.Text)
                kairi.POST = txbPOST.Text
                kairi.ADDRESS1 = txbaddress1.Text
                kairi.ADDRESS_KN = txbADDRESS.Text
                kairi.UPD_DATE = CDate(dtpkDATE.Value.ToString("MM/dd/yyyy"))
                kairi.UPD_TIME = dtpkTIME.Value.ToString("HH:mm:ss")
                kairi.UPD_TANTO = txbTANTO.Text
                context.M_POST.Add(kairi)
                context.SaveChanges()
                MsgBox("Added")

            End If
            getdata()
            'cleartextbox()
            dtgvPOST_KANRI.Rows(index).Selected = True
        Else
            MsgBox("du lieu trong")
        End If

    End Sub

    Private Sub txbPOST_KANRI_TextChanged(sender As Object, e As EventArgs) Handles txbPOST_KANRI.TextChanged
        If Not IsNumeric(txbPOST_KANRI.Text) OrElse Val(txbPOST_KANRI.Text) < 0 OrElse txbPOST_KANRI.Text.Length > 8 Then
            txbPOST_KANRI.Clear()
        End If
    End Sub

    Private Sub txbaddress1_TextChanged(sender As Object, e As EventArgs) Handles txbaddress1.TextChanged
        If txbaddress1.Text.Length > 40 Then
            txbaddress1.Clear()
        End If
    End Sub

    Private Sub txbADDRESS_TextChanged(sender As Object, e As EventArgs) Handles txbADDRESS.TextChanged
        If txbADDRESS.Text.Length > 50 Then
            txbADDRESS.Clear()
        End If
    End Sub

    Private Sub txbTANTO_TextChanged(sender As Object, e As EventArgs) Handles txbTANTO.TextChanged
        If txbTANTO.Text.Length > 12 Then
            txbTANTO.Clear()
        End If
    End Sub

    Private Sub txbPOST_TextChanged(sender As Object, e As EventArgs) Handles txbPOST.TextChanged
        If txbPOST.Text.Length > 8 Then
            txbPOST.Clear()
        End If
    End Sub
End Class