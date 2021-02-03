Public Class CM_Message
    ''' <summary>
    ''' 画面初期表示失敗
    ''' </summary>
    ''' <remarks></remarks>
    Public Const MESS_ERROR_INPUT_CHECK As String = "入力チェックに失敗しました"

    Public Const MESS_CONFIRM_INSERT As String = "登録してよろしいですか？"
    Public Const MESS_CONFIRM_UPDATE As String = "データは上書きされます。登録してよろしいですか？"
    Public Const MESS_CONFIRM_DELETE As String = "削除してよろしいですか？"
    Public Const MESS_CONFIRM_DELETE_DUAL As String = "本当に削除してよろしいですか？"
    Public Const MESS_CONFIRM_CANCEL As String = "終了してよろしいですか？？"

    Public Const MESS_QUESTION_INSERT As String = "変更されたデータを反映しますか？"
    Public Const MESS_QUESTION_DELETE As String = "現在選択されている行を削除しますか？"
    Public Const MESS_QUESTION_UPDATE As String = "キーが重複しています" + vbCrLf + "現在の内容で更新してよろしいですか？"
    Public Const MESS_QUESTION_REGIST As String = "登録してよろしいですか?"
    Public Const MESS_ERROR_MUST As String = "必須項目が入力されていません"
    Public Const MESS_ERROR_LENGTH As String = "文字数制限を越えています「{0}」"
    Public Const MESS_ERROR_NODATA As String = "{0}が未入力です"
    Public Const MESS_QUESTION_UPDATE_PRODUCTPLAN As String = "生産分割したデータが削除されますが、登録してよろしいですか？"
    Public Const MESS_ERROR_GOODS As String = "仕入れ品コードが不正です。"
    Public Const MESS_ERROR_GOODS_DATE As String = "仕入れ日は当日以前を入力してください。"
End Class
