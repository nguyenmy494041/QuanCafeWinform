'Imports System.Drawing.Printing
Imports System.Data.Entity.ModelConfiguration.Configuration
Imports System.Drawing.Printing
Imports System.IO
Imports System.Reflection

Public Class frmcombobox

    Dim WithEvents mPrintDocument As New PrintDocument
    Dim mPrintBitMap As Bitmap

    Private Sub frmcombobox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim context = New QuanCafeEntities()
        Dim schname = context.M_SCH_KAIHI.ToList()
        Dim cdname = context.M_CODE.Where(Function(x) x.CD_SYU = "GAKKOKAI").ToList()
        dtgv.Rows.Clear()
        For Each row In schname
            Dim index = dtgv.Rows.Add()
            dtgv.Rows(index).Cells(1).Value = row.SCH_KAIHI_KBN
            Dim comb = New DataGridViewComboBoxCell()
            For Each item In cdname
                comb.Items.Add(item.CD_NAME)
            Next
            comb.Value = cdname.Where(Function(x) x.CD_NO = row.SCH_KAIHI_KBN).FirstOrDefault().CD_NAME
            dtgv.Rows(index).Cells(2) = comb
            dtgv.Rows(index).Cells(3).Value = row.KAIHI
            dtgv.Rows(index).Cells(4).Value = row.UPD_DATE
            dtgv.Rows(index).Cells(5).Value = row.UPD_TANTO
        Next
        dtgv.Columns(1).ReadOnly = True
    End Sub

    'Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    Dim lWidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mPrintBitMap.Width) / 2
    '    Dim lHeight As Integer = e.MarginBounds.Y + (e.MarginBounds.Height - mPrintBitMap.Height) / 2
    '    e.Graphics.DrawImage(mPrintBitMap, 0, 0)

    '    e.HasMorePages = False
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    mPrintBitMap = New Bitmap(Me.Width, Me.Height)
    '    Dim lRect, ki As System.Drawing.Rectangle
    '    lRect.Width = Me.Width
    '    lRect.Height = Me.Height
    '    ki.Width = 500
    '    ki.Height = 300
    '    Me.DrawToBitmap(mPrintBitMap, lRect)
    '    PrintPreviewDialog1.ShowDialog()
    '    'mPrintDocument = New PrintDocument
    '    'mPrintDocument.Print()
    'End Sub

    ' dùng formprint
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
    '    PrintForm1.Print()
    'End Sub



    ''Copy màn hình


    'Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    e.Graphics.DrawImage(mPrintBitMap, 0, 0)
    'End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim g = Me.CreateGraphics()
    '    mPrintBitMap = New Bitmap(Me.Size.Width, Me.Size.Height, g)
    '    Dim gm = Graphics.FromImage(mPrintBitMap)

    '    gm.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, Me.Size)

    '    PrintPreviewDialog1.ShowDialog()
    'End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.Filter = "CSV File (*.csv) | *.csv"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            Using sw As StreamWriter = File.CreateText(SaveFileDialog1.FileName)
                Dim dgvcolumnname As List(Of String) = dtgv.Columns.Cast(Of DataGridViewColumn).ToList().Select(Function(x) x.Name).ToList()
                sw.WriteLine(String.Join(",", dgvcolumnname))
                For Each row As DataGridViewRow In dtgv.Rows
                    If Not row.IsNewRow Then
                        Dim rowdata = New List(Of String)
                        rowdata.Add(CType("", String))
                        For Each column As DataGridViewColumn In dtgv.Columns
                            If column.Index <> 0 Then
                                Dim a = row.Cells(column.Name).Value
                                rowdata.Add(CType(a, String))
                            End If
                        Next
                        sw.WriteLine(String.Join(",", rowdata))
                    End If

                Next
                Process.Start(SaveFileDialog1.FileName)
            End Using
        End If
    End Sub

    'Dim AllText, LineOfText As String
    'Public strArr() As List(Of String)    
    Private Sub btnopoen_Click(sender As Object, e As EventArgs) Handles btnopoen.Click
        OpenFileDialog1.Filter = "CSV File (*.csv) | *.csv"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            Try
                Dim listresult = New List(Of List(Of String))
                FileClose()
                FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
                Do Until EOF(1)
                    Dim LineOfText = LineInput(1)
                    Dim arr = LineOfText.Split(",")
                    Dim liststr = New List(Of String)
                    For Each item In arr
                        liststr.Add(item)
                    Next
                    listresult.Add(liststr)
                Loop
                FileClose()
                Dim a = listresult
                Dim context = New QuanCafeEntities()
                If listresult.Count > 1 Then
                    Dim dta = context.M_SCH_KAIHI.ToList()
                    For Each item In dta
                        context.M_SCH_KAIHI.Remove(item)
                    Next
                    For i As Integer = 1 To listresult.Count - 1
                        Dim check = False
                        For Each item In listresult(i)

                            If String.IsNullOrEmpty(item) OrElse item.Length = 0 Then
                                check = True
                            End If
                        Next
                        If Not check Then
                            Dim newSCH = New M_SCH_KAIHI()
                            newSCH.SCH_KAIHI_KBN = CType(listresult(i)(0), Decimal)
                            newSCH.KAIHI = CType(listresult(i)(1), Decimal)
                            newSCH.UPD_DATE = CType(listresult(i)(2), Date)
                            newSCH.UPD_TIME = CType(listresult(i)(3), String)
                            newSCH.UPD_TANTO = CType(listresult(i)(4), String)
                            context.M_SCH_KAIHI.Add(newSCH)
                        End If
                    Next
                    context.SaveChanges()

                End If
                'btnupdate_Click(Nothing, Nothing)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSCHKAIHI_Click(sender As Object, e As EventArgs) Handles btnSCHKAIHI.Click
        Dim context = New QuanCafeEntities()
        Dim dataSCH = context.M_SCH_KAIHI.ToList()
        Dim properti = dataSCH.ToArray()(0).GetType.GetProperties()
        Dim dgvcolumnname As New List(Of String)
        For Each item In properti
            dgvcolumnname.Add(item.Name)
        Next
        SaveFileDialog1.Filter = "CSV File (*.csv) | *.csv"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            Using sw As StreamWriter = File.CreateText(SaveFileDialog1.FileName)
                context = New QuanCafeEntities()
                sw.WriteLine(String.Join(",", dgvcolumnname))
                For Each row In dataSCH
                    Dim rowdata = New List(Of String)
                    rowdata.Add(row.SCH_KAIHI_KBN)
                    rowdata.Add(row.KAIHI)
                    rowdata.Add(row.UPD_DATE)
                    rowdata.Add(row.UPD_TIME)
                    rowdata.Add(row.UPD_TANTO)
                    sw.WriteLine(String.Join(",", rowdata))
                Next
                Process.Start(SaveFileDialog1.FileName)
            End Using
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim context = New QuanCafeEntities()
        Dim schname = context.M_SCH_KAIHI.ToList()
        Dim cdname = context.M_CODE.Where(Function(x) x.CD_SYU = "GAKKOKAI").ToList()
        dtgv.Rows.Clear()
        For Each row In schname
            Dim index = dtgv.Rows.Add()
            dtgv.Rows(index).Cells(1).Value = row.SCH_KAIHI_KBN
            Dim comb = New DataGridViewComboBoxCell()
            For Each item In cdname
                comb.Items.Add(item.CD_NAME)
            Next
            comb.Value = cdname.Where(Function(x) x.CD_NO = row.SCH_KAIHI_KBN).FirstOrDefault().CD_NAME
            dtgv.Rows(index).Cells(2) = comb
            dtgv.Rows(index).Cells(3).Value = row.KAIHI
            dtgv.Rows(index).Cells(4).Value = row.UPD_DATE
            dtgv.Rows(index).Cells(5).Value = row.UPD_TANTO
        Next
        dtgv.Columns(1).ReadOnly = True
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        mPrintBitMap = New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(mPrintBitMap, New Rectangle(0, 0, Me.Width, Me.Height))
        Dim ratio As Single = CSng(mPrintBitMap.Width / mPrintBitMap.Height)
        If ratio > e.MarginBounds.Width / e.MarginBounds.Height Then
            Dim xxx = CInt(e.MarginBounds.Top + (e.MarginBounds.Height / 2) - ((e.MarginBounds.Width / ratio) / 2))
            Dim yyy = CInt(e.MarginBounds.Width / ratio)
            e.Graphics.DrawImage(mPrintBitMap, 0, 0, e.MarginBounds.Width, yyy)
        Else
            Dim xxx = CInt(e.MarginBounds.Left + (e.MarginBounds.Width / 2) - (e.MarginBounds.Height * ratio / 2))
            Dim yyy = CInt(e.MarginBounds.Height * ratio)
            e.Graphics.DrawImage(mPrintBitMap, 0, 0, yyy, e.MarginBounds.Height)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        Try
            PageSetupDialog1.Document = PrintDocument1
            PageSetupDialog1.PageSettings = New PageSettings()
            Dim a = PageSetupDialog1.ShowDialog()
            If a = DialogResult.OK Then
                PrintPreviewDialog1.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CC_Button1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class