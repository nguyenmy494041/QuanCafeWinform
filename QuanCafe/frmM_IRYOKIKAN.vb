Public Class frmM_IRYOKIKAN

    Private Sub frmM_IRYOKIKAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listCDNAME = get_CD_NAME()
        cbx_HAISI_KBN.Items.Clear()
        For Each item In listCDNAME
            cbx_HAISI_KBN.Items.Add(item.CD_NAME)
        Next
        cbx_HAISI_KBN.Text = ""
        For Each ctrol In Panel3.Controls
            If TypeOf (ctrol) Is Button Then
                Dim btn = CType(ctrol, Button)
                btn.Enabled = False
                'btn.BackColor = Color.FromArgb(227, 227, 227)
            End If
        Next ctrol
        Panel2.Enabled = False
        If txb_IRYO_KIKAN_CD.TextLength > 0 Then
            For Each ctrol In Panel3.Controls
                If TypeOf (ctrol) Is Button Then
                    Dim btn = CType(ctrol, Button)
                    btn.Enabled = True
                    'btn.BackColor = Color.FromArgb(227, 227, 227)
                End If
            Next ctrol
        End If
        dtpk_HAISI_DATE.CustomFormat = " "
        'dtpk_HAISI_DATE.Value = Nothing
    End Sub
    Private Sub CC_Button2_Click(sender As Object, e As EventArgs) Handles CC_Button2.Click
        Dim frmsearch = New frmCOMBO00200()
        frmsearch.txb_IRYO_KIKAN_CD.Text = txb_IRYO_KIKAN_CD.Text
        frmsearch.Show()
        'Me.Hide()
    End Sub

    Sub textLengthMax(sender As Object, e As KeyPressEventArgs, ByVal txb As TextBox, ByVal length As Integer)
        If Asc(e.KeyChar) <> 8 Then
            If txb.TextLength >= length Then
                e.Handled = True
            End If
        End If
    End Sub
    Sub numberLengthMax(sender As Object, e As KeyPressEventArgs, ByVal txb As TextBox, ByVal length As Integer)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 OrElse Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If txb.TextLength >= length Then
                e.Handled = True
            End If
        End If
    End Sub
    Sub numberLengthMaxGuna2(sender As Object, e As KeyPressEventArgs, ByVal txb As Guna.UI2.WinForms.Guna2TextBox, ByVal length As Integer)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 OrElse Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If txb.TextLength >= length Then
                e.Handled = True
            End If
        End If
    End Sub
    Sub telNumber(sender As Object, e As KeyPressEventArgs, ByVal txb As TextBox)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 OrElse Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If txb.TextLength = 3 OrElse txb.TextLength = 7 Then
                txb.Text = txb.Text & "-"
                txb.SelectionStart = txb.Text.Length
            End If
            If txb.TextLength >= 12 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txb_POST_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_POST.KeyPress
        textLengthMax(sender, e, txb_POST, 8)
    End Sub

    Private Sub txb_IRYO_KIKAN_CD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_IRYO_KIKAN_CD.KeyPress
        numberLengthMax(sender, e, txb_IRYO_KIKAN_CD, 7)
    End Sub

    Private Sub txb_IRYO_NAME_KN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_IRYO_NAME_KN.KeyPress
        textLengthMax(sender, e, txb_IRYO_NAME_KN, 32)
    End Sub

    Private Sub tbx_IRYO_NAME_KJ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbx_IRYO_NAME_KJ.KeyPress
        textLengthMax(sender, e, tbx_IRYO_NAME_KJ, 40)
    End Sub

    Private Sub txb_SORT_KN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_SORT_KN.KeyPress
        textLengthMax(sender, e, txb_SORT_KN, 32)
    End Sub

    Private Sub txb_ADDRESS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_ADDRESS1.KeyPress
        textLengthMax(sender, e, txb_ADDRESS1, 40)
    End Sub

    Private Sub txb_ADDRESS2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_ADDRESS2.KeyPress
        textLengthMax(sender, e, txb_ADDRESS2, 40)
    End Sub

    Private Sub txb_TEL1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_TEL1.KeyPress
        telNumber(sender, e, txb_TEL1)
    End Sub
    Private Sub txb_TEL2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_TEL2.KeyPress
        telNumber(sender, e, txb_TEL2)
    End Sub

    Private Sub txb_FAX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_FAX.KeyPress
        telNumber(sender, e, txb_FAX)
    End Sub

    Private Sub txb_HAISI_KBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_HAISI_KBN.KeyPress
        numberLengthMax(sender, e, txb_HAISI_KBN, 1)
    End Sub

    Private Sub txb_IRYO_CARD_40_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_IRYO_CARD_40.KeyPress
        numberLengthMax(sender, e, txb_IRYO_CARD_40, 7)
    End Sub

    Private Sub txb_IRYO_CARD_NIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_IRYO_CARD_NIN.KeyPress
        numberLengthMax(sender, e, txb_IRYO_CARD_NIN, 7)
    End Sub

    Private Sub txb_IRYO_EM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_IRYO_EM.KeyPress
        textLengthMax(sender, e, txb_IRYO_EM, 40)
    End Sub
    Private Sub txb_IRYO_URL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_IRYO_URL.KeyPress
        textLengthMax(sender, e, txb_IRYO_URL, 60)
    End Sub

    Function get_CD_NAME() As List(Of M_CODE)
        Return New QuanCafeEntities().M_CODE.Where(Function(x) x.CD_SYU = "HAISIXXX").ToList()
    End Function

    Private Sub cbx_HAISI_KBN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_HAISI_KBN.SelectedIndexChanged
        txb_HAISI_KBN.Text = get_CD_NAME().Where(Function(x) x.CD_NAME = cbx_HAISI_KBN.Text).FirstOrDefault().CD_NO
    End Sub

    Private Sub txb_HAISI_KBN_TextChanged(sender As Object, e As EventArgs) Handles txb_HAISI_KBN.TextChanged
        Dim key = CDec(Val(txb_HAISI_KBN.Text))
        Dim cdname = get_CD_NAME().Where(Function(x) x.CD_NO = key).FirstOrDefault()
        If IsNothing(cdname) Then
            txb_HAISI_KBN.BackColor = Color.MistyRose
        Else
            txb_HAISI_KBN.BackColor = Color.White
            cbx_HAISI_KBN.SelectedItem = cdname.CD_NAME
        End If
    End Sub

    Private Sub btnESC_Click(sender As Object, e As EventArgs) Handles btnESC.Click
        For Each ctrol In Panel3.Controls
            If TypeOf (ctrol) Is Button Then
                Dim btn = CType(ctrol, Button)
                btn.Enabled = True
                btn.BackColor = Color.FromArgb(227, 227, 227)
            End If
        Next ctrol
        txb_IRYO_KIKAN_CD.Clear()
        txb_IRYO_KIKAN_CD.Enabled = True
        txb_IRYO_KIKAN_CD.BackColor = Color.White
        For Each ctrol In Panel2.Controls
            If TypeOf (ctrol) Is ICCControl.CC_TextBox Then
                Dim a = CType(ctrol, ICCControl.CC_TextBox)
                a.Clear()
            End If
            If TypeOf (ctrol) Is ICCControl.CC_Combobox Then
                Dim a = CType(ctrol, ICCControl.CC_Combobox)
                a.Text = ""
            End If
            If TypeOf (ctrol) Is DateTimePicker Then
                Dim a = CType(ctrol, DateTimePicker)
                a.Value = Date.Now
            End If
        Next ctrol
        cbx_HAISI_KBN.Text = ""
        dtpk_HAISI_DATE.CustomFormat = " "
    End Sub
    Sub btnmistyrose(ByVal btn As Button)
        btn.BackColor = Color.MistyRose
    End Sub
    Sub btnArgb(ByVal btn As Button)
        btn.BackColor = Color.FromArgb(227, 227, 227)
    End Sub
    Private Sub btnF1_Click(sender As Object, e As EventArgs) Handles btnF1.Click
        btnmistyrose(btnF1)
        btnArgb(btnF2)
        btnArgb(btnF3)
        btnArgb(btnF4)
        btnArgb(btnF5)
    End Sub

    Private Sub btnF2_Click(sender As Object, e As EventArgs) Handles btnF2.Click
        btnmistyrose(btnF2)
        btnArgb(btnF1)
        btnArgb(btnF3)
        btnArgb(btnF4)
        btnArgb(btnF5)
    End Sub

    Private Sub btnF3_Click(sender As Object, e As EventArgs) Handles btnF3.Click
        btnmistyrose(btnF3)
        btnArgb(btnF1)
        btnArgb(btnF2)
        btnArgb(btnF4)
        btnArgb(btnF5)
    End Sub

    Private Sub btnF4_Click(sender As Object, e As EventArgs) Handles btnF4.Click
        btnmistyrose(btnF4)
        btnArgb(btnF1)
        btnArgb(btnF3)
        btnArgb(btnF2)
        btnArgb(btnF5)
    End Sub

    Private Sub btnF5_Click(sender As Object, e As EventArgs) Handles btnF5.Click
        If Panel2.Enabled = True AndAlso txb_IRYO_KIKAN_CD.Text <> "" AndAlso txb_IRYO_KIKAN_CD.Enabled = False Then
            Dim model = createModel()
            If btnF1.BackColor = Color.MistyRose Then
                Dim context = New QuanCafeEntities()
                context.M_IRYOKIKAN.Add(model)
                context.SaveChanges()
            End If
            If btnF2.BackColor = Color.MistyRose Then
                Dim context = New QuanCafeEntities()
                Dim exitmodel = context.M_IRYOKIKAN.Where(Function(x) x.IRYO_KIKAN_CD = model.IRYO_KIKAN_CD).FirstOrDefault()
                exitmodel.IRYO_NAME_KJ = model.IRYO_NAME_KJ
                exitmodel.IRYO_NAME_KN = model.IRYO_NAME_KN
                exitmodel.SORT_KN = model.SORT_KN
                exitmodel.POST = model.POST
                exitmodel.ADDRESS1 = model.ADDRESS1
                exitmodel.ADDRESS2 = model.ADDRESS2
                exitmodel.TEL1 = model.TEL1
                exitmodel.TEL2 = model.TEL2
                exitmodel.HAISI_KBN = model.HAISI_KBN
                exitmodel.HAISI_DATE = model.HAISI_DATE
                exitmodel.IRYO_CARD_40 = model.IRYO_CARD_40
                exitmodel.IRYO_CARD_NIN = model.IRYO_CARD_NIN
                exitmodel.IRYO_EM = model.IRYO_EM
                exitmodel.IRYO_URL = model.IRYO_URL
                context.SaveChanges()
            End If
            If btnF3.BackColor = Color.MistyRose Then
                Dim context = New QuanCafeEntities()
                Dim exitmodel = context.M_IRYOKIKAN.Where(Function(x) x.IRYO_KIKAN_CD = model.IRYO_KIKAN_CD).FirstOrDefault()
                context.M_IRYOKIKAN.Remove(exitmodel)
                context.SaveChanges()
            End If
            btnESC_Click(Nothing, Nothing)
            Panel2.Enabled = False
        End If
        btnF5.BackColor = Color.MistyRose
        Dim key = CDec(Val(txb_IRYO_KIKAN_CD.Text))
        If txb_IRYO_KIKAN_CD.Text <> "" AndAlso txb_IRYO_KIKAN_CD.Enabled = True Then
            Dim iryokikan = New QuanCafeEntities().M_IRYOKIKAN.Where(Function(x) x.IRYO_KIKAN_CD = key).FirstOrDefault()
            'insert
            If btnF1.BackColor = Color.MistyRose Then
                If IsNothing(iryokikan) Then
                    Panel2.Enabled = True
                    txb_IRYO_KIKAN_CD.Enabled = False
                    dtpk_HAISI_DATE.CustomFormat = " "
                    showHidepanel2(False, True, True)
                Else
                    txb_IRYO_KIKAN_CD.BackColor = Color.MistyRose
                    Panel2.Enabled = False
                End If
            End If
            'update
            If btnF2.BackColor = Color.MistyRose Then
                If Not IsNothing(iryokikan) Then
                    Panel2.Enabled = True
                    txb_IRYO_KIKAN_CD.Enabled = False
                    showHidepanel2(False, True, True)
                    filldataintextbox(iryokikan)
                Else
                    txb_IRYO_KIKAN_CD.BackColor = Color.MistyRose
                    Panel2.Enabled = False
                End If
            End If

            'delete
            If btnF3.BackColor = Color.MistyRose Then
                If Not IsNothing(iryokikan) Then
                    Panel2.Enabled = True
                    txb_IRYO_KIKAN_CD.Enabled = False
                    showHidepanel2(True, False, False)
                    filldataintextbox(iryokikan)
                Else
                    txb_IRYO_KIKAN_CD.BackColor = Color.MistyRose
                    Panel2.Enabled = False
                End If
            End If
            'search
            If btnF4.BackColor = Color.MistyRose Then
                If Not IsNothing(iryokikan) Then
                    Panel2.Enabled = True
                    txb_IRYO_KIKAN_CD.Enabled = False
                    showHidepanel2(True, False, False)
                    filldataintextbox(iryokikan)
                    btnF5.Enabled = False
                Else
                    txb_IRYO_KIKAN_CD.BackColor = Color.MistyRose
                    Panel2.Enabled = False
                End If
            End If
            btnF1.Enabled = False
            btnF2.Enabled = False
            btnF3.Enabled = False
            btnF4.Enabled = False
        Else
            txb_IRYO_KIKAN_CD.BackColor = Color.MistyRose
        End If
    End Sub

    Private Sub txb_IRYO_KIKAN_CD_TextChanged(sender As Object, e As EventArgs) Handles txb_IRYO_KIKAN_CD.TextChanged
        txb_IRYO_KIKAN_CD.BackColor = Color.White
        If txb_IRYO_KIKAN_CD.TextLength > 0 Then
            For Each ctrol In Panel3.Controls
                If TypeOf (ctrol) Is Button Then
                    Dim btn = CType(ctrol, Button)
                    btn.Enabled = True
                End If
            Next ctrol
        End If
    End Sub
    Function txbIsNull(ByRef txb As ICCControl.CC_TextBox) As String
        If txb.TextLength <> 0 Then
            Return txb.Text
        Else
            Return Nothing
        End If
    End Function
    Function createModel() As M_IRYOKIKAN
        Dim newmodel = New M_IRYOKIKAN()
        Dim datenull = CType("01/01/1753", Date)
        Dim newdate = CDate(dtpk_HAISI_DATE.Value)
        newmodel.IRYO_KIKAN_CD = CDec(Val(txb_IRYO_KIKAN_CD.Text))
        newmodel.IRYO_NAME_KJ = txbIsNull(tbx_IRYO_NAME_KJ)
        newmodel.IRYO_NAME_KN = txbIsNull(txb_IRYO_NAME_KN)
        newmodel.POST = txbIsNull(txb_POST)
        newmodel.ADDRESS1 = txbIsNull(txb_ADDRESS1)
        newmodel.ADDRESS2 = txbIsNull(txb_ADDRESS2)
        newmodel.TEL1 = txbIsNull(txb_TEL1)
        newmodel.TEL2 = txbIsNull(txb_TEL2)
        newmodel.HAISI_KBN = If(CDec(Val(txb_HAISI_KBN.Text)) <> 0, CDec(Val(txb_HAISI_KBN.Text)), Nothing)
        If datenull <> newdate Then
            newmodel.HAISI_DATE = CDate(dtpk_HAISI_DATE.Value)
        End If
        newmodel.UPD_DATE = Date.Now.Date
        newmodel.UPD_TIME = Date.Now.ToString("hh:mm:ss")
        newmodel.SORT_KN = txbIsNull(txb_SORT_KN)
        newmodel.IRYO_EM = txbIsNull(txb_IRYO_EM)
        newmodel.IRYO_URL = txbIsNull(txb_IRYO_URL)
        If CDec(Val(txb_IRYO_CARD_40.Text)) <> 0 Then
            newmodel.IRYO_CARD_40 = CDec(Val(txb_IRYO_CARD_40.Text))
        End If
        If CDec(Val(txb_IRYO_CARD_NIN.Text)) <> 0 Then
            newmodel.IRYO_CARD_NIN = CDec(Val(txb_IRYO_CARD_NIN.Text))
        End If
        newmodel.UPD_TANTO = "1"
        newmodel.FAX = txbIsNull(txb_FAX)
        Return newmodel
    End Function

    Sub filldataintextbox(ByVal model As M_IRYOKIKAN)
        tbx_IRYO_NAME_KJ.Text = model.IRYO_NAME_KJ
        txb_IRYO_NAME_KN.Text = model.IRYO_NAME_KN
        txb_SORT_KN.Text = model.SORT_KN
        txb_POST.Text = model.SORT_KN
        txb_ADDRESS1.Text = model.ADDRESS1
        txb_ADDRESS2.Text = model.ADDRESS2
        txb_TEL1.Text = model.TEL1
        txb_TEL2.Text = model.TEL2
        txb_FAX.Text = model.FAX
        txb_HAISI_KBN.Text = model.HAISI_KBN
        cbx_HAISI_KBN.SelectedItem = get_CD_NAME().Where(Function(x) x.CD_NO = model.HAISI_KBN).FirstOrDefault().CD_NAME
        If Not IsNothing(model.HAISI_DATE) Then
            dtpk_HAISI_DATE.Value = model.HAISI_DATE
            dtpk_HAISI_DATE.CustomFormat = "dd/MM/yyyy"
        Else
            dtpk_HAISI_DATE.Value = CDate("01/01/1753")
            dtpk_HAISI_DATE.CustomFormat = " "
        End If
        txb_IRYO_CARD_40.Text = If(IsNothing(model.IRYO_CARD_40), "", model.IRYO_CARD_40)
        txb_IRYO_CARD_NIN.Text = If(IsNothing(model.IRYO_CARD_NIN), "", model.IRYO_CARD_NIN)
        txb_IRYO_EM.Text = model.IRYO_EM
        txb_IRYO_URL.Text = model.IRYO_URL
    End Sub

    Private Sub dtpk_HAISI_DATE_ValueChanged(sender As Object, e As EventArgs) Handles dtpk_HAISI_DATE.ValueChanged
        dtpk_HAISI_DATE.CustomFormat = "dd/MM/yyyy"
    End Sub
    Sub showHidepanel2(ByRef tebox As Boolean, ByRef cbx As Boolean, ByRef dtpk As Boolean)
        For Each ctrol In Panel2.Controls
            If TypeOf (ctrol) Is ICCControl.CC_TextBox Then
                Dim a = CType(ctrol, ICCControl.CC_TextBox)
                a.ReadOnly = tebox
            End If
            If TypeOf (ctrol) Is ICCControl.CC_Combobox Then
                Dim a = CType(ctrol, ICCControl.CC_Combobox)
                a.Enabled = cbx
            End If
            If TypeOf (ctrol) Is DateTimePicker Then
                Dim a = CType(ctrol, DateTimePicker)
                a.Enabled = dtpk
            End If
        Next ctrol
    End Sub
End Class