
#Region "Validate Return Struture"

#End Region
#Region "ValidateCellInfo"
Imports ICCControl
''' <summary>
''' ValidateCellInfo: using for setting GridView Validate
''' </summary>
<System.Serializable()> Public Class ValidateCellInfo
    Private _columnIndex As Integer = 0
    Private _rowIndex As Integer = -1
    Private _dataMaxLength As Integer = 0
    Private _decimalLength As Integer = 0
    Private _dataNotNull As Boolean = False
    Private _isMinute As Boolean = False

    Private _ColIndex As Integer = 0
    Private _IsPostalCode As Boolean = False
    Private _AutoFormat As Boolean = False

    Private _IsColKey As Boolean
    Private _DataMaxLenth As Integer
    Private _IsJPEra As Boolean
    Private _ColumnCoboboxIndex As Integer
    Private _ColumnGetValueCombobox As Integer
    Private _IsShowMess As Boolean
    Private _ImeMode As ImeMode
    Private _IsValidFieldReadOnly As Boolean
    Private _IsYearMonth As Boolean
    Private _VbStrConv As VbStrConv
    Private _IsHandleChange As Boolean
    Private _IsOnlyHatWidthEng As Boolean
    Private _EventStrConv As CM_Enum.CC_EVENT
    Public Sub New()
    End Sub

    ''' <summary>
    ''' New ValidateCellInfo 
    ''' </summary>
    ''' <param name="columnIndex">specify column index, must be >0</param>
    ''' <param name="rowIndex">specify row index, set -1 if valid for all rows</param>
    ''' <param name="dataMaxLength">must be set</param>
    ''' <param name="decimalLength">just setting if decimal value</param>
    ''' <param name="dataNotNull">default is false</param>
    Public Sub New(columnIndex As Integer, rowIndex As Integer, dataMaxLength As Integer, decimalLength As Integer, dataNotNull As Boolean, Optional ByVal isMinute As Boolean = False)
        _columnIndex = columnIndex
        _rowIndex = rowIndex
        _dataMaxLength = dataMaxLength
        _decimalLength = decimalLength
        _dataNotNull = dataNotNull
        _isMinute = isMinute
    End Sub
    Public Sub New(ColIndex As Integer, IsPostalCode As Boolean, AutoFormat As String)
        _ColIndex = ColIndex
        _IsPostalCode = IsPostalCode
        _AutoFormat = AutoFormat
    End Sub
    Public Property DataMaxLength As Integer
        Get
            Return _dataMaxLength
        End Get
        Set(value As Integer)
            _dataMaxLength = value
        End Set
    End Property

    Public Property DecimalLength As Integer
        Get
            Return _decimalLength
        End Get
        Set(value As Integer)
            _decimalLength = value
        End Set
    End Property

    Public Property DataNotNull As Boolean
        Get
            Return _dataNotNull
        End Get
        Set(value As Boolean)
            _dataNotNull = value
        End Set
    End Property

    Public Property RowIndex As Integer
        Get
            Return _rowIndex
        End Get
        Set(value As Integer)
            _rowIndex = value
        End Set
    End Property

    Public Property ColumnIndex As Integer
        Get
            Return _columnIndex
        End Get
        Set(value As Integer)
            _columnIndex = value
        End Set
    End Property

    Public Property ColIndex As Integer
        Get
            Return _ColIndex
        End Get
        Set(value As Integer)
            _ColIndex = value
        End Set
    End Property

    Public Property IsPostalCode As Boolean
        Get
            Return _IsPostalCode
        End Get
        Set(value As Boolean)
            _IsPostalCode = value
        End Set
    End Property

    Public Property AutoFormat As Boolean
        Get
            Return _AutoFormat
        End Get
        Set(value As Boolean)
            _AutoFormat = value
        End Set
    End Property

    Public Property IsColKey As Boolean
        Get
            Return _IsColKey
        End Get
        Set(value As Boolean)
            _IsColKey = value
        End Set
    End Property

    Public Property DataMaxLenth As Integer
        Get
            Return _DataMaxLenth
        End Get
        Set(value As Integer)
            _DataMaxLenth = value
        End Set
    End Property

    Public Property ColumnCoboboxIndex As Integer
        Get
            Return _ColumnCoboboxIndex
        End Get
        Set(value As Integer)
            _ColumnCoboboxIndex = value
        End Set
    End Property

    Public Property ColumnGetValueCombobox As Integer
        Get
            Return _ColumnGetValueCombobox
        End Get
        Set(value As Integer)
            _ColumnGetValueCombobox = value
        End Set
    End Property

    Public Property IsJPEra As Boolean
        Get
            Return _IsJPEra
        End Get
        Set(value As Boolean)
            _IsJPEra = value
        End Set
    End Property

    Public Property IsShowMess As Boolean
        Get
            Return _IsShowMess
        End Get
        Set(value As Boolean)
            _IsShowMess = value
        End Set
    End Property

    Public Property ImeMode As ImeMode
        Get
            Return _ImeMode
        End Get
        Set(value As ImeMode)
            _ImeMode = value
        End Set
    End Property

    Public Property IsValidFieldReadOnly As Boolean
        Get
            Return _IsValidFieldReadOnly
        End Get
        Set(value As Boolean)
            _IsValidFieldReadOnly = value
        End Set
    End Property

    Public Property IsYearMonth As Boolean
        Get
            Return _IsYearMonth
        End Get
        Set(value As Boolean)
            _IsYearMonth = value
        End Set
    End Property

    Public Property VbStrConv As VbStrConv
        Get
            Return _VbStrConv
        End Get
        Set(value As VbStrConv)
            _VbStrConv = value
        End Set
    End Property

    Public Property IsHandleChange As Boolean
        Get
            Return _IsHandleChange
        End Get
        Set(value As Boolean)
            _IsHandleChange = value
        End Set
    End Property

    Public Property IsOnlyHatWidthEng As Boolean
        Get
            Return _IsOnlyHatWidthEng
        End Get
        Set(value As Boolean)
            _IsOnlyHatWidthEng = value
        End Set
    End Property

    Public Property EventStrConv As CM_Enum.CC_EVENT
        Get
            Return _EventStrConv
        End Get
        Set(value As CM_Enum.CC_EVENT)
            _EventStrConv = value
        End Set
    End Property
End Class
#End Region
