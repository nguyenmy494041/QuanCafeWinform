Public Class CC_DataGridViewMergeHeader
#Region "Merge Column"
    ''' <summary>
    ''' Structure to define Merge Column Info
    ''' </summary>
    Public Class CC_MergeColumnInfo
        Public Sub New()

        End Sub
        Public ColumnFrom As Byte
        Public ColumnCount As Byte
        Public ColumnText As String
        ''' <summary>
        ''' New Structure to define Merge Column Info
        ''' </summary>
        ''' <param name="columnFrom">columnFrom</param>
        ''' <param name="columnCount">columnCount</param>
        ''' <param name="columnText">columnText</param>
        Public Sub New(columnFrom As Byte, columnCount As Byte, columnText As String)
            Me.ColumnFrom = columnFrom
            Me.ColumnCount = columnCount
            Me.ColumnText = columnText
        End Sub
    End Class
    ''' <summary>
    ''' MergeColumnInfo
    ''' </summary>
    Public MergeColumnInfo As List(Of CC_MergeColumnInfo) = New List(Of CC_MergeColumnInfo)
    ''' <summary>
    ''' getColumnWidth
    ''' </summary>
    ''' <param name="columnFrom"></param>
    ''' <param name="columnCount"></param>
    ''' <returns></returns>
    Private Function getColumnWidth(columnFrom As Byte, columnCount As Byte) As Integer
        Dim iRtn = 0
        Try
            For i = (columnFrom + 1) To (columnFrom + columnCount - 1)
                iRtn += Me.GetCellDisplayRectangle(i, -1, True).Width
            Next
        Catch ex As Exception

        End Try
        Return iRtn
    End Function
#End Region
#Region "Merge Row"
    ''' <summary>
    ''' Structure to define Merge Row Info
    ''' </summary>
    Public Class CC_MergeRowInfo
        Public Sub New()
        End Sub
        Public RowFrom As Byte
        Public RowTo As Byte
        Public ColumnIndex As Int32 = -1
        ''' <summary>
        ''' New Structure to define Merge Row Info
        ''' </summary>
        ''' <param name="rowFrom">rowFrom</param>
        ''' <param name="rowTo">rowTo</param>
        ''' <param name="columnIndex">columnIndex</param>
        Public Sub New(rowFrom As Byte, rowTo As Byte, columnIndex As Integer)
            Me.RowFrom = rowFrom
            Me.RowTo = rowTo
            Me.ColumnIndex = columnIndex
        End Sub
    End Class
    ''' <summary>
    ''' MergeRowInfo
    ''' </summary>
    Public MergeRowInfo As List(Of CC_MergeRowInfo) = New List(Of CC_MergeRowInfo)
    ''' <summary>
    ''' getRowHeight
    ''' </summary>
    ''' <param name="rowFrom"></param>
    ''' <param name="rowTo"></param>
    ''' <returns></returns>
    Private Function getRowHeight(rowFrom As Byte, rowTo As Byte) As Integer
        Dim iRtn = 0
        Try
            For i = (rowFrom + 1) To (rowTo)
                iRtn += Me.GetCellDisplayRectangle(-1, i, True).Height
            Next
        Catch ex As Exception

        End Try
        Return iRtn
    End Function
    ''' <summary>
    ''' getRowText
    ''' </summary>
    ''' <param name="rowFrom"></param>
    ''' <param name="rowTo"></param>
    ''' <returns></returns>
    Private Function getRowText(columnIndex As Byte, rowFrom As Byte, rowTo As Byte) As String
        Dim strRtn = Me.GetCellValue(rowFrom, columnIndex).ToString
        Try
            For i = (rowFrom + 1) To (rowTo)
                strRtn = strRtn & "\r\n" & Me.GetCellValue(i, columnIndex).ToString

            Next
        Catch ex As Exception

        End Try
        Return strRtn
    End Function

#End Region

    ''' <summary>
    ''' OnCreateControl
    ''' </summary>
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()

        Me.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ColumnHeadersHeight = Me.ColumnHeadersHeight * 2
        Me.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

    End Sub

    Private Sub DataGridView1_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Me.CellPainting
        'Merge Column Header
        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
            Dim r2 As Rectangle = e.CellBounds
            r2.Y += e.CellBounds.Height / 2
            r2.Height = e.CellBounds.Height / 2
            e.PaintBackground(r2, True)
            e.PaintContent(r2)
            e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' DataGridView1_ColumnWidthChanged
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView1_ColumnWidthChanged(sender As Object, e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles Me.ColumnWidthChanged
        Dim rtHeader As Rectangle = Me.DisplayRectangle
        rtHeader.Height = Me.ColumnHeadersHeight / 2
        Me.Invalidate(rtHeader)
    End Sub
    Private Sub DataGridView1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Merge Column Header
        Try
            For Each _mergeColumnInfo As CC_MergeColumnInfo In MergeColumnInfo
                Try
                    ' Get Column From rectangle
                    Dim r1 As Rectangle = Me.GetCellDisplayRectangle(_mergeColumnInfo.ColumnFrom, -1, True)
                    ' Get column with
                    Dim w2 = getColumnWidth(_mergeColumnInfo.ColumnFrom, _mergeColumnInfo.ColumnCount)
                    ' Add 1 to XY
                    r1.X += 1
                    r1.Y += 1
                    ' Add Total Height and Width
                    r1.Width = r1.Width + w2 - 2
                    r1.Height = r1.Height / 2 - 2
                    e.Graphics.FillRectangle(New SolidBrush(Me.ColumnHeadersDefaultCellStyle.BackColor), r1)
                    Dim format As New StringFormat()
                    format.Alignment = StringAlignment.Center
                    format.LineAlignment = StringAlignment.Center
                    e.Graphics.DrawString(_mergeColumnInfo.ColumnText, Me.ColumnHeadersDefaultCellStyle.Font, New SolidBrush(Me.ColumnHeadersDefaultCellStyle.ForeColor), r1, format)
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try
        'Merge Row Header
        Try
            For Each _mergeRowInfo As CC_MergeRowInfo In MergeRowInfo
                Try
                    ' Get Column From rectangle
                    Dim r1 As Rectangle = Me.GetCellDisplayRectangle(_mergeRowInfo.ColumnIndex, _mergeRowInfo.RowFrom, True)
                    ' Get column with
                    Dim w2 = getRowHeight(_mergeRowInfo.RowFrom, _mergeRowInfo.RowTo)
                    Dim text As String = getRowText(_mergeRowInfo.ColumnIndex, _mergeRowInfo.RowFrom, _mergeRowInfo.RowTo)
                    ' Add 1 to XY
                    r1.X += 1
                    r1.Y += 1
                    ' Add Total Height and Width
                    r1.Width = r1.Width - 2
                    r1.Height = r1.Height + w2 - 2
                    e.Graphics.FillRectangle(New SolidBrush(Me.ColumnHeadersDefaultCellStyle.BackColor), r1)
                    Dim format As New StringFormat()
                    format.Alignment = StringAlignment.Center
                    format.LineAlignment = StringAlignment.Center
                    e.Graphics.DrawString(text, Me.RowsDefaultCellStyle.Font, New SolidBrush(Me.ColumnHeadersDefaultCellStyle.ForeColor), r1)
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' DataGridView1_Scroll
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView1_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles Me.Scroll
        Dim rtHeader As Rectangle = Me.DisplayRectangle
        rtHeader.Height = Me.ColumnHeadersHeight / 2
        Me.Invalidate(rtHeader)
    End Sub


End Class
