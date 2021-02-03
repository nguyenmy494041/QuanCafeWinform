Public Class CM_Util

#Region "Shared GetByte：バイト数算出"
    ''' <summary>
    ''' 対象文字列のバイト数を返す
    ''' </summary>
    ''' <param name="prmStrValue">対象文字列 - Object</param>
    ''' <returns>Long</returns>
    ''' <remarks></remarks>
    Public Shared Function GetByte(ByVal prmStrValue As Object) As Long

        Dim prmReturn As Long
        prmReturn = 0 '初期化

        Try
            prmReturn = System.Text.Encoding.GetEncoding("Shift_JIS").GetBytes(prmStrValue.ToString).Length()
            Return prmReturn

        Catch ex As System.Exception
            Throw ex
        Finally
        End Try
    End Function
#End Region

    ''' <summary>
    ''' 桁数チェックと必須入力チェックを同時に行う
    ''' </summary>
    ''' <param name="objTarget"></param>
    ''' <param name="intChkLen"></param>
    ''' <param name="flgReq"></param>
    ''' <returns></returns>
    Shared Function CheckLenAndReq(ByRef strtargetName As String, ByVal objTarget As Object, ByRef intChkLen As Integer, ByRef flgReq As Boolean) As CM_ValidateReturn
        Dim bRet As CM_ValidateReturn = New CM_ValidateReturn(True, "")
        If objTarget Is DBNull.Value Then
            objTarget = Nothing
        End If
        If IsNothing(strtargetName) Then
            strtargetName = ""
        End If

        Try
            ' 必須入力チェック
            If flgReq And Not CheckRequired(objTarget) Then
                bRet = New CM_ValidateReturn(False, CM_Message.MESS_ERROR_NODATA.Replace("{0}", strtargetName))
                Return bRet
            End If

            ' 桁数チェック（数値の場合は小数点を含むので注意）
            If intChkLen > 0 Then
                If Not CheckFig(CStr(objTarget), intChkLen) Then
                    bRet = New CM_ValidateReturn(False, CM_Message.MESS_ERROR_LENGTH.Replace("{0}", CStr(strtargetName & ":" & intChkLen)))
                    Return bRet
                End If
            End If

        Catch ex As Exception

            bRet = New CM_ValidateReturn(False, ex.Message)
            Return bRet
        End Try

        Return bRet

    End Function
    ''' <summary>
    ''' 必須項目入力チェック
    ''' </summary>
    ''' <param name="prmObjValue">チェック対象値</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Shared Function CheckRequired(ByVal prmObjValue As Object) As Boolean
        Try
            If prmObjValue Is DBNull.Value Then
                prmObjValue = Nothing
            End If
            If IsNullToString(prmObjValue).Length <= 0 Then
                Return False
            End If
            Return True
        Catch ex As System.Exception
            Return False
        Finally
        End Try
    End Function
#Region "Shared CheckFig：桁チェック "
    ''' <summary>
    ''' 対象文字列の桁数が指定桁数以下であるか評価する
    ''' </summary>
    ''' <param name="prmStrValue">評価対象文字列 - String</param>
    ''' <param name="prmIntFigure">評価用指定桁数 - Long</param>
    ''' <returns>Boolean（True:指定と同一/False:指定と異なる）</returns>
    ''' <remarks></remarks>
    Public Shared Function CheckFig(ByVal prmStrValue As String, ByVal prmIntFigure As Long) As Boolean
        If prmStrValue <> Nothing Then

            Try
                If prmStrValue Is DBNull.Value Then
                    prmStrValue = Nothing
                End If

                ' 評価対象文字列がNullの場合は処理しない
                If Not prmStrValue.Length > 0 Then
                    Return True
                End If

                '規定桁数以内か
                If Len(StrConv(prmStrValue, VbStrConv.Uppercase)) > prmIntFigure Then
                    Return False
                End If

                Return True

            Catch ex As System.Exception
                Return False
            Finally
            End Try
        End If
        Return True
    End Function
#End Region

#Region "Shared IsNullToString：文字型(String)変換 "
    ''' <summary>
    ''' 変換対象値を文字型(String)に変換する
    ''' </summary>
    ''' <param name="prmObjValue">変換対象値 - Object</param>
    ''' <param name="prmTrimFlg">[Optional]Default:Trim  False:NoTrim</param>
    ''' <param name="prmNull">[Optional]Default:Trim  False:NoTrim</param>
    ''' <returns>String</returns>
    ''' <remarks>変換できない場合は""または"Null"を返す</remarks>
    Public Shared Function IsNullToString(ByVal prmObjValue As Object, Optional ByVal prmTrimFlg As Boolean = True,
                                              Optional ByVal prmNull As Boolean = False) As String

        Dim prmReturn As String
        prmReturn = ""

        Try
            ' Date型の場合は文字列に再変換
            If TypeOf prmObjValue Is Date Then
                prmObjValue = prmObjValue.ToString()
            End If

            '値がある場合
            If IsNothing(prmObjValue) = False Then
                If Not (prmObjValue Is DBNull.Value) Then
                    Dim strValue As String = ""
                    If prmTrimFlg = True Then
                        strValue = Trim(DirectCast(prmObjValue, String))
                    Else
                        strValue = DirectCast(prmObjValue, String)
                    End If

                    '変換して返す
                    prmReturn = CStr(strValue)
                End If
            End If

            If prmNull Then
                prmReturn = "NULL"
            End If

            Return prmReturn

        Catch ex As System.Exception
            Throw ex
        Finally
        End Try

    End Function
#End Region

End Class
