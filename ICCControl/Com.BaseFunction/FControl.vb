Public Class FControl

#Region "Public Shared Function changeStrWide：半角文字を全角文字に変換して返す"
    ''' <summary>
    ''' 半角文字を全角文字に変換して返す
    ''' </summary>
    ''' <param name="prmString">文字列</param>
    ''' <returns>変換後文字列</returns>
    ''' <remarks>半角文字を全角文字に変換して返す</remarks>
    Public Shared Function ChangeStrWide(ByVal prmString As String) As String

        ChangeStrWide = StrConv(prmString, VbStrConv.Wide, New System.Globalization.CultureInfo("ja-JP", True).LCID)

        Return ChangeStrWide
    End Function
#End Region

#Region "Public Shared Function changeStrNarrow：全角文字を半角文字に変換して返す"
    ''' <summary>
    ''' 全角文字を半角文字に変換して返す
    ''' </summary>
    ''' <param name="prmString">文字列</param>
    ''' <returns>変換後文字列</returns>
    ''' <remarks>全角文字を半角文字に変換して返す</remarks>
    Public Shared Function ChangeStrNarrow(ByVal prmString As String) As String

        ChangeStrNarrow = StrConv(prmString, VbStrConv.Narrow, New System.Globalization.CultureInfo("ja-JP", True).LCID)

        Return ChangeStrNarrow
    End Function
#End Region

#Region "Shared GetByte：バイト数算出"
    ''' <summary>
    ''' 対象文字列のバイト数を返す
    ''' </summary>
    ''' <param name="prmStrValue">対象文字列 - Object</param>
    ''' <returns>Long</returns>
    ''' <remarks></remarks>
    Public Shared Function GetByte(ByVal prmStrValue As Object) As Long

        Dim prmReturn As Long

        Try
            prmReturn = System.Text.Encoding.GetEncoding("Shift_JIS").GetBytes(prmStrValue.ToString).Length()
            Return prmReturn

        Catch ex As System.Exception
            Throw ex
        Finally
        End Try
    End Function
#End Region

#Region "Shared IsFullWidth"
    ''' <summary>
    ''' CheckFullWidth
    ''' </summary>
    ''' <param name="prmStrValue"></param>
    ''' <returns></returns>
    Public Shared Function IsFullWidth(ByVal prmStrValue As String) As Boolean
        Try
            If GetByte(prmStrValue) - prmStrValue.Length > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Exception
            Throw ex
        Finally
        End Try
    End Function
#End Region

#Region "Shared IsFullWidth"
    ''' <summary>
    ''' CheckFullWidth
    ''' </summary>
    ''' <param name="prmStrValue"></param>
    ''' <returns></returns>
    Public Shared Function IsHaftWidthEng(ByVal prmStrValue As String) As Boolean
        Try
            If String.IsNullOrEmpty(prmStrValue) Then
                Return True
            End If
            If Asc(prmStrValue) >= 0 AndAlso Asc(prmStrValue) <= 177 Then
                Return True
            End If
            Return False
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
#End Region

End Class
