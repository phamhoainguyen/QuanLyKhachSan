Imports System.Text.RegularExpressions
Imports System.Data
Imports System.Data.SqlClient
Namespace NController
    Public Class CUser
        Public controller As Controller = New Controller()
        Private msg As NController.Message = controller.msg
        Private db As Database = controller.db
        Private _userID As String
        Private _userName As String
        Private _level As Integer
        Private _name As String
        Private _email As String
        Private _phoneNumber As String
        Private _position As String
        Private _isLogin As Boolean = False
#Region "Hàm kiểm tra đăng nhập"
        Public Function Login(ByVal username As String, ByVal password As String) As Boolean
            Dim result As Boolean = False
            If (username = "" Or password = "") Then
                If (username = "") Then
                    MsgBox(msg.errorEmptyUsername, MsgBoxStyle.Exclamation, msg.errorLoginTitle)
                ElseIf (password = "") Then
                    MsgBox(msg.errorEmptyPassword, MsgBoxStyle.Exclamation, msg.errorLoginTitle)
                End If
            Else
                Try
                    Dim params(0 To 1) As SqlParameter
                    params(0) = New SqlParameter("@username", SqlDbType.VarChar, 50)
                    params(0).Value = username
                    params(1) = New SqlParameter("@password", SqlDbType.VarChar, 50)
                    params(1).Value = password
                    Dim sqlquery As String
                    sqlquery = "SELECT User_ID, User_Name, UP.Level AS Level, Name, Email, PhoneNumber, UP.Position AS Position FROM [USER] AS U, [USER_POSITION] AS UP"
                    sqlquery &= " WHERE U.User_Name = @username AND U.User_Password = @password AND U.Pos_ID = UP.Pos_ID"
                    Dim dr As IDataReader = db.ExecuteReader(sqlquery, CommandType.Text, params)
                    While dr.Read()
                        _userID = dr("User_ID")
                        _userName = dr("User_Name")
                        _level = Convert.ToInt32(dr("Level"))
                        _name = dr("Name")
                        _email = dr("Email")
                        _phoneNumber = dr("PhoneNumber")
                        _position = dr("Position")
                        result = True
                        Exit While
                    End While
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
                If (result) Then
                    MsgBox(msg.loginSuccess, MsgBoxStyle.Information, msg.msgTitleNotify)
                Else
                    MsgBox(msg.loginFail, MsgBoxStyle.Exclamation, msg.msgTitleNotify)
                End If
            End If
            _isLogin = result
            Return result
        End Function
        Public Sub Logout()
            _isLogin = False
        End Sub
        Property isLogin() As Boolean
            Get
                Return _isLogin
            End Get
            Set(value As Boolean)
                _isLogin = value
            End Set

        End Property
        Property name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property
        Property userID() As String
            Get
                Return _userID
            End Get
            Set(ByVal value As String)
                _userID = value
            End Set
        End Property
        Property userName() As String
            Get
                Return _userName
            End Get
            Set(ByVal value As String)
                _userName = value
            End Set
        End Property
        Property level() As Integer
            Get
                Return _level
            End Get
            Set(ByVal value As Integer)
                _level = value
            End Set
        End Property
        Property position() As String
            Get
                Return _position
            End Get
            Set(ByVal value As String)
                _position = value
            End Set
        End Property
        Property email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                _email = value
            End Set
        End Property
        Property phoneNumber() As String
            Get
                Return _phoneNumber
            End Get
            Set(ByVal value As String)
                _phoneNumber = value
            End Set
        End Property
#End Region
    End Class
    Public Class Controller
        Public db As Database = New Database()
        Public msg As New NController.Message
#Region "Hàm hiển thị dấu , giá trị tiền tệ"
        Public Function MoneyToString(ByVal money As Double) As String
            Dim res As String = money.ToString()
            Dim i As Integer
            If (res.Length > 3) Then
                Dim count As Integer = 0
                For i = res.Length - 1 To 1 Step -1
                    count += 1
                    If (count = 3) Then
                        res = res.Insert(i, ",")
                        count = 0
                    End If
                Next
            End If
            Return res
        End Function
#End Region
#Region "Hàm tạo ID tự động"
        Public Function createAutoID(ByVal s As String, ByVal charString As String) As String
            Dim NoMaPhong As Int32 = Convert.ToInt32(s.Substring(charString.Length, 3)) 'Number Of MaPhong (Lấy phần số của mã phòng)
            Dim result As String = charString + "000"
            If (NoMaPhong + 1 < 10) Then
                result = charString + "00" + (NoMaPhong + 1).ToString()
            ElseIf (NoMaPhong + 1 < 100) Then
                result = charString + "0" + (NoMaPhong + 1).ToString()
            End If
            Return result
        End Function
#End Region
    End Class
    Public Class Message
#Region "Danh sách các thông báo"

        Private _msgNotPermission As String = "Bạn không có quền sử dụng chức năng này!"
        Private _msgExitWarning As String = "Bạn có chắc muốn thoát?"
        Private _msgLoginSuccess As String = "Đăng nhập thành công!"
        Private _msgLoginFail As String = "Đăng nhập thất bại!" + vbNewLine + "Sai tài khoản hoặc mật khẩu."
        Private _msgTitleNotify As String = "Thông báo"
        Private _msgErrorLoginTitle As String = "Lỗi đăng nhập"
        Private _msgEmptyUsername As String = "Tài khoản không được để trống!"
        Private _msgEmptyPassword As String = "Mật khẩu không được để trống!"
        Private _msgAddRoomSuccess As String = "Lập danh mục phòng thành công!"
        Private _msgAddRoomFail As String = "Lập danh mục phòng thất bại!"
        Private _msgEditRoomSuccess As String = "Sửa thông tin phòng thành công!"
        Private _msgEditRoomFail As String = "Sửa thông tin phòng thất bại!"
        Private _msgDeleteRoomSuccess As String = "Xóa phòng thành công!"
        Private _msgDeleteRoomFail As String = "Xóa phòng thất bại!"
        Private _msgTitleWarning As String = "Cảnh báo"
        Private _msgDeleteWarning As String = "Bạn có chắc muốn xóa"
        Private _msgAddRoomType As String = "Thêm loại phòng"
        Private _msgAddRoom As String = "Lập danh mục phòng"
        Private _txtRoomID As String = "Mã phòng"
        Private _txtRoomName As String = "Tên phòng"
        Private _txtRoomTypeName As String = "Loại phòng"
        Private _txtRoomTypeID As String = "Mã loại phòng"
        Private _txtPriceUnit As String = "Đơn giá"
        Private _txtNote As String = "Ghi chú"
        Private _txtCMND As String = "CMND"
        Private _txtAddress As String = "Địa chỉ"
        Private _txtStartDate As String = "Ngày bắt đầu"
        Private _txtEndDate As String = "Ngày kết thúc"
        Private _txtCustomerID As String = "Mã khách hàng"
        Private _txtCustomerName As String = "Tên khách hàng"
        Private _txtCustomerTypeID As String = "Mã loại khách hàng"
        Private _txtCustomerTypeName As String = "Tên loại khách hàng"
#End Region
#Region "Danh sách các property để thay đổi các thông báo nếu muốn"
        Public Property cmnd As String
            Get
                Return _txtCMND
            End Get
            Set(value As String)
                _txtCMND = value
            End Set
        End Property
        Public Property address As String
            Get
                Return _txtAddress
            End Get
            Set(value As String)
                _txtAddress = value
            End Set
        End Property
        Public Property startDate As String
            Get
                Return _txtStartDate
            End Get
            Set(value As String)
                _txtStartDate = value
            End Set
        End Property
        Public Property endDate As String
            Get
                Return _txtEndDate
            End Get
            Set(value As String)
                _txtEndDate = value
            End Set
        End Property
        Public Property customerID As String
            Get
                Return _txtCustomerID
            End Get
            Set(value As String)
                _txtCustomerID = value
            End Set
        End Property
        Public Property customerName As String
            Get
                Return _txtCustomerName
            End Get
            Set(value As String)
                _txtCustomerName = value
            End Set
        End Property
        Public Property customerTypeID As String
            Get
                Return _txtCustomerTypeID
            End Get
            Set(value As String)
                _txtCustomerTypeID = value
            End Set
        End Property
        Public Property customerTypeName As String
            Get
                Return _txtCustomerTypeName
            End Get
            Set(value As String)
                _txtCustomerTypeName = value
            End Set
        End Property
        Public Property notPermission As String
            Get
                Return _msgNotPermission
            End Get
            Set(value As String)
                _msgNotPermission = value
            End Set
        End Property
        Public Property exitWarning As String
            Get
                Return _msgExitWarning
            End Get
            Set(value As String)
                _msgExitWarning = value
            End Set
        End Property
        Public Property priceUnit As String
            Get
                Return _txtPriceUnit
            End Get
            Set(value As String)
                _txtPriceUnit = value
            End Set
        End Property
        Public Property note As String
            Get
                Return _txtNote
            End Get
            Set(value As String)
                _txtNote = value
            End Set
        End Property
        Public Property roomTypeName As String
            Get
                Return _txtRoomTypeName
            End Get
            Set(value As String)
                _txtRoomTypeName = value
            End Set
        End Property
        Public Property roomTypeID As String
            Get
                Return _txtRoomTypeID
            End Get
            Set(value As String)
                _txtRoomTypeID = value
            End Set
        End Property
        Public Property roomName As String
            Get
                Return _txtRoomName
            End Get
            Set(value As String)
                _txtRoomName = value
            End Set
        End Property
        Public Property roomID As String
            Get
                Return _txtRoomID
            End Get
            Set(value As String)
                _txtRoomID = value
            End Set
        End Property

        Public Property addRoom As String
            Get
                Return _msgAddRoom
            End Get
            Set(value As String)
                _msgAddRoom = value
            End Set
        End Property
        Public Property addRoomType As String
            Get
                Return _msgAddRoomType
            End Get
            Set(value As String)
                _msgAddRoomType = value
            End Set
        End Property
        Public Property deleteWarning As String
            Get
                Return _msgDeleteWarning
            End Get
            Set(value As String)
                _msgDeleteWarning = value
            End Set
        End Property
        Public Property msgTitleWarning As String
            Get
                Return _msgTitleWarning
            End Get
            Set(value As String)
                _msgTitleWarning = value
            End Set
        End Property

        Public Property deleteRoomSuccess As String
            Get
                Return _msgDeleteRoomSuccess
            End Get
            Set(value As String)
                _msgDeleteRoomSuccess = value
            End Set
        End Property
        Public Property deleteRoomFail As String
            Get
                Return _msgDeleteRoomFail
            End Get
            Set(value As String)
                _msgDeleteRoomFail = value
            End Set
        End Property
        Public Property editRoomSuccess() As String
            Get
                Return _msgEditRoomSuccess
            End Get
            Set(value As String)
                _msgEditRoomSuccess = value
            End Set
        End Property
        Public Property editRoomFail() As String
            Get
                Return _msgEditRoomFail
            End Get
            Set(value As String)
                _msgEditRoomFail = value
            End Set
        End Property
        Public Property addRoomSuccess() As String
            Get
                Return _msgAddRoomSuccess
            End Get
            Set(value As String)
                _msgAddRoomSuccess = value
            End Set
        End Property
        Public Property addRoomFail() As String
            Get
                Return _msgAddRoomFail
            End Get
            Set(value As String)
                _msgAddRoomFail = value
            End Set
        End Property

        Public Property loginSuccess() As String
            Get
                Return _msgLoginSuccess
            End Get
            Set(value As String)
                _msgLoginSuccess = value
            End Set
        End Property
        Public Property loginFail() As String
            Get
                Return _msgLoginFail
            End Get
            Set(value As String)
                _msgLoginFail = value
            End Set
        End Property
        Public Property errorLoginTitle() As String
            Get
                Return _msgErrorLoginTitle
            End Get
            Set(value As String)
                _msgErrorLoginTitle = value
            End Set
        End Property
        Public Property errorEmptyUsername() As String
            Get
                Return _msgEmptyUsername
            End Get
            Set(value As String)
                _msgEmptyUsername = value
            End Set
        End Property
        Public Property errorEmptyPassword() As String
            Get
                Return _msgEmptyPassword
            End Get
            Set(value As String)
                _msgEmptyPassword = value
            End Set
        End Property
        Public Property msgTitleNotify() As String
            Get
                Return _msgTitleNotify
            End Get
            Set(value As String)
                _msgTitleNotify = value
            End Set
        End Property
#End Region

    End Class
    Public Class SqlDatabaseException
        Inherits Exception
#Region " Constructor "
        Public Sub New()
        End Sub
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
        Public Sub New(ByVal message As String, ByVal innerException As Exception)
            MyBase.New(message, innerException)
        End Sub
#End Region
    End Class
End Namespace

