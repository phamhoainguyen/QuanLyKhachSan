Imports System.Data.SqlClient

Public Class Database
#Region "Khai báo các biến cục bộ dùng trong Class DATABASE"
    Private _connection As New SqlConnection
    Private _connectionString As String
    Private DBcommand As New SqlCommand
    Private DBqueryString As String = Nothing
#End Region
#Region "Thuộc tính chuỗi kết nối database (Connection String)"
    Public Property ConnectionString() As String
        Get
            Return _connectionString
        End Get
        Set(ByVal value As String)
            _connectionString = value
        End Set
    End Property
#End Region
#Region "Phương thức khởi tạo (Constructor)"
    Sub New()
        Dim path As String = Application.StartupPath
        _connectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Hoai Nguyen\FinalProject\QLKS\QLKS\Databasedatabase.mdf;Integrated Security=True"
    End Sub
#End Region
#Region "Phương thức gán tham số cho câu lệnh sql được đưa vào ( Sub AssignParameters)"
    'Được chia làm 2 phương thức tùy vào loại tham số được đưa vào
    'Phương thức 1 nếu tham số đưa vào là chuẩn SQLParameters
    Private Sub AssignParameters(ByVal cmd As SqlCommand, ByVal sqlParameters() As SqlParameter)
        If (sqlParameters Is Nothing) Then
            Exit Sub
        End If
        For Each parameter As SqlParameter In sqlParameters
            cmd.Parameters.Add(parameter)
        Next
    End Sub
    'Phương thức 2 nếu tham số là dạng Object (Tức chưa xác định)
    Private Sub AssignParameters(ByVal cmd As SqlCommand, ByVal valueParameter() As Object)
        If (cmd.Parameters.Count - 1 <> valueParameter.Length) Then
            Throw New ApplicationException("Số lượng tham số trong câu lệnh và lượng tham số khi đưa vào không bằng nhau")
        End If
        Dim i As Integer
        For Each parameter As SqlParameter In cmd.Parameters
            If (parameter.Direction <> ParameterDirection.Output) AndAlso (parameter.Direction <> ParameterDirection.ReturnValue) Then
                parameter.Value = valueParameter(i)
                i += 1
            End If
        Next
    End Sub
#End Region
#Region "Hàm xử lý câu lệnh SQL không trả về (Function ExecuteNonQuery)"
    Public Function ExecuteNonQuery(ByVal query As String, ByVal cmdType As CommandType, Optional ByVal parameters() As SqlParameter = Nothing) As Integer
        Dim conn As SqlConnection = Nothing
        Dim trans As SqlTransaction = Nothing 'Dùng để RollBack khi xảy ra vấn đề (Tránh mất dữ liệu)
        Dim cmd As SqlCommand = Nothing
        Dim result As Integer = -1 'Trả về số lượng rows đã được thực thi (num rows effected)
        Try
            conn = New SqlConnection(_connectionString)
            cmd = New SqlCommand(query, conn)
            cmd.CommandType = cmdType
            Me.AssignParameters(cmd, parameters)
            conn.Open()
            trans = conn.BeginTransaction()
            cmd.Transaction = trans
            result = cmd.ExecuteNonQuery()
            trans.Commit()

        Catch ex As Exception
            If Not (trans Is Nothing) Then
                trans.Rollback()
            End If
            Throw New NController.SqlDatabaseException(ex.Message, ex.InnerException)
        Finally
            If Not (conn Is Nothing) AndAlso (conn.State = ConnectionState.Open) Then conn.Close()
            If Not (cmd Is Nothing) Then cmd.Dispose()
            If Not (trans Is Nothing) Then trans.Dispose()
        End Try
        Return result
    End Function
#End Region
#Region "Hàm xử lý câu lệnh SQL mà trả về cột đầu tiên của hàng đầu tiên tìm được (ExecuteScalar)"
    Public Function ExecuteScalar(ByVal query As String, cmdType As CommandType, Optional ByVal parameters() As SqlParameter = Nothing)
        Dim conn As SqlConnection = Nothing
        Dim trans As SqlTransaction = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim res As Object = Nothing
        Try
            conn = New SqlConnection(_connectionString)
            cmd = New SqlCommand(query, conn)
            cmd.CommandType = cmdType
            Me.AssignParameters(cmd, parameters)
            conn.Open()
            trans = conn.BeginTransaction()
            cmd.Transaction = trans
            res = cmd.ExecuteScalar()
            trans.Commit()
        Catch ex As Exception
            If Not (trans Is Nothing) Then
                trans.Rollback()
            End If
            Throw New NController.SqlDatabaseException(ex.Message, ex.InnerException)
        Finally
            If Not (conn Is Nothing) AndAlso (conn.State = ConnectionState.Open) Then conn.Close()
            If Not (cmd Is Nothing) Then cmd.Dispose()
            If Not (trans Is Nothing) Then trans.Dispose()
        End Try
        Return res
    End Function
#End Region
#Region "Hàm xử lý câu lệnh sql trả về một bảng (ExecuteReader)"
    Public Function ExecuteReader(ByVal query As String, ByVal cmdType As CommandType, Optional ByVal parameters() As SqlParameter = Nothing) As IDataReader
        Dim conn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim result As SqlDataReader = Nothing
        Try
            conn = New SqlConnection(_connectionString)
            cmd = New SqlCommand(query, conn)
            cmd.CommandType = cmdType
            Me.AssignParameters(cmd, parameters)
            conn.Open()
            result = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw New NController.SqlDatabaseException(ex.Message, ex.InnerException)
        End Try
        Return CType(result, IDataReader)
    End Function
#End Region
#Region "Hàm xử lý với Dataset (FillDataset)"
    Public Function FillDataset(ByVal cmd As String, ByVal cmdType As CommandType, Optional ByVal parameters() As SqlParameter = Nothing) As DataSet
        Dim conn As SqlConnection = Nothing
        Dim command As SqlCommand = Nothing
        Dim sqlda As SqlDataAdapter = Nothing
        Dim result As New DataSet
        Try
            conn = New SqlConnection(_connectionString)
            command = New SqlCommand(cmd, conn)
            command.CommandType = cmdType
            AssignParameters(command, parameters)
            sqlda = New SqlDataAdapter(command)
            sqlda.Fill(result)
        Catch ex As Exception
            MsgBox("DBE: " + ex.ToString())
            'Throw New NController.SqlDatabaseException(ex.Message, ex.InnerException)
        Finally
            If Not (conn Is Nothing) Then conn.Dispose()
            If Not (command Is Nothing) Then command.Dispose()
            If Not (sqlda Is Nothing) Then sqlda.Dispose()
        End Try
        Return result
    End Function

    Public Function ExecuteDataset(ByVal insertCmd As SqlCommand, ByVal updateCmd As SqlCommand, ByVal deleteCmd As SqlCommand, ByVal ds As DataSet, ByVal srcTable As String) As Integer
        Dim conn As SqlConnection = Nothing
        Dim sqlda As SqlDataAdapter = Nothing
        Dim result As Integer = 0
        MsgBox(insertCmd.CommandText.ToString)
        Try
            conn = New SqlConnection(_connectionString)
            conn.Open()
            sqlda = New SqlDataAdapter

            If Not (insertCmd Is Nothing) Then insertCmd.Connection = conn : sqlda.InsertCommand = insertCmd
            If Not (updateCmd Is Nothing) Then updateCmd.Connection = conn : sqlda.UpdateCommand = updateCmd
            If Not (deleteCmd Is Nothing) Then deleteCmd.Connection = conn : sqlda.DeleteCommand = deleteCmd
            result = sqlda.Update(ds, srcTable)
            MsgBox("DBER: " + result.ToString())

        Catch ex As Exception
            MsgBox("DBE: " + ex.ToString())
            'Throw New NController.SqlDatabaseException(ex.Message, ex.InnerException)
        Finally
            If Not (conn Is Nothing) Then conn.Dispose()
            If Not (insertCmd Is Nothing) Then insertCmd.Dispose()
            If Not (updateCmd Is Nothing) Then updateCmd.Dispose()
            If Not (deleteCmd Is Nothing) Then deleteCmd.Dispose()
            If Not (sqlda Is Nothing) Then sqlda.Dispose()
        End Try
        Return result
    End Function
#End Region
    'CopyRight "NGUYEN CAO CUONG"
End Class

