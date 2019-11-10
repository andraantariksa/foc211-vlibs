Imports Library_Information_System.Models

Public Class UserBorrowedBook
    Private _id As Integer
    Private _userUsername As String
    Private _bookID As String
    Private _dateStart As Date?
    Private _dateReturn As Date?
    Private _dateLimit As Date?

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property UserUsername As String
        Get
            Return _userUsername
        End Get
        Set(value As String)
            _userUsername = value
        End Set
    End Property

    Public Property BookID As String
        Get
            Return _bookID
        End Get
        Set(value As String)
            _bookID = value
        End Set
    End Property

    Public Property DateStart As Date?
        Get
            Return _dateStart
        End Get
        Set(value As Date?)
            _dateStart = value
        End Set
    End Property

    Public Property DateLimit As Date?
        Get
            Return _dateLimit
        End Get
        Set(value As Date?)
            _dateLimit = value
        End Set
    End Property

    Public Property DateReturn As Date?
        Get
            Return _dateReturn
        End Get
        Set(value As Date?)
            _dateReturn = value
        End Set
    End Property

    Public Shared Sub Borrow(username As String, bookId As Integer, Optional borrowStart As Date? = Nothing, Optional borrowLimit As Date? = Nothing)
        If borrowStart Is Nothing Then
            borrowStart = Date.Now()
        End If

        If borrowLimit Is Nothing Then
            borrowLimit = Now.AddDays(7)
        End If

        Dim con = Connection.GetInstance()
        con.Open()

        Dim res = New Npgsql.NpgsqlCommand("INSERT INTO ""user_borrowed_book""(""users_username"", ""book_id"", ""date_start"", ""date_return"", ""date_limit"") VALUES(@users_username, @book_id, @date_start, NULL, @date_limit)", con)
        res.Parameters.Add(New Npgsql.NpgsqlParameter("users_username", username))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("book_id", bookId))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("date_start", borrowStart))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("date_limit", borrowLimit))
        Try
            Dim read = res.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            con.Close()
        End Try
    End Sub

    Public Shared Function ListBorrowedBy(username As String) As List(Of (UserBorrowedBook, Book))
        Dim con = Connection.GetInstance()
        con.Open()

        Dim res = New Npgsql.NpgsqlCommand("SELECT * FROM ""user_borrowed_book"" WHERE ""users_username"" = @user_username AND ""date_return"" IS NULL", con)
        res.Parameters.Add(New Npgsql.NpgsqlParameter("user_username", username))
        Dim borrowResult As List(Of UserBorrowedBook)
        Try
            Dim read = res.ExecuteReader()
            borrowResult = ReadResult(read)
        Catch ex As Exception
            Throw ex
        Finally
            con.Close()
        End Try
        Dim booksBorrowList As List(Of (UserBorrowedBook, Book)) = New List(Of (UserBorrowedBook, Book))
        For Each _borrow In borrowResult
            booksBorrowList.Add((_borrow, Book.FindById(_borrow.BookID)))
        Next
        Return booksBorrowList
    End Function

    Public Shared Function IsBorrowed(bookId As Integer) As Boolean
        Dim con = Connection.GetInstance()
        con.Open()

        Dim res = New Npgsql.NpgsqlCommand("SELECT COUNT(*) FROM ""user_borrowed_book"" WHERE ""book_id"" = @book_id AND date_return IS NULL", con)
        res.Parameters.Add(New Npgsql.NpgsqlParameter("book_id", bookId))
        Try
            Dim read = res.ExecuteReader()
            read.Read()
            Return read.GetInt64(0) > 0
        Catch ex As Exception
            Throw ex
        Finally
            con.Close()
        End Try
    End Function

    Public Sub Update()
        Dim con = Connection.GetInstance()

        con.Open()

        Dim fieldSetQuery = If(Me.DateStart IsNot Nothing, """date_start"" = @date_start", "")
        fieldSetQuery += If(Me.DateReturn IsNot Nothing, """date_return"" = @date_return", "")
        fieldSetQuery += If(Me.DateLimit IsNot Nothing, """date_limit"" = @date_limit", "")
        fieldSetQuery += If(Me.UserUsername IsNot Nothing, """users_username"" = @users_username", "")
        fieldSetQuery += If(Me.BookID IsNot Nothing, """book_id"" = @book_id", "")

        Dim res = New Npgsql.NpgsqlCommand("UPDATE ""user_borrowed_book"" SET " & fieldSetQuery & " WHERE id = @id", con)
        res.Parameters.Add(New Npgsql.NpgsqlParameter("id", Me.Id))
        If Me.BookID IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("users_username", Me.UserUsername))
        End If
        If Me.UserUsername IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("book_id", Me.BookID))
        End If
        If Me.DateLimit IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("date_limit", Me.DateLimit))
        End If
        If Me.DateReturn IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("date_return", Me.DateReturn))
        End If
        If Me.DateStart IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("date_start", Me.DateStart))
        End If
        res.ExecuteReader()
        con.Close()
    End Sub

    Public Shared Function ReadResult(reader As Npgsql.NpgsqlDataReader) As List(Of UserBorrowedBook)
        Dim userBorrowedBookResult As List(Of UserBorrowedBook) = New List(Of UserBorrowedBook)
        While reader.Read()
            Dim userBorrowedBookResultTemp = New UserBorrowedBook()
            For i = 0 To reader.FieldCount - 1
                Select Case reader.GetName(i)
                    Case "id"
                        userBorrowedBookResultTemp.Id = reader.GetInt64(i)
                    Case "users_username"
                        userBorrowedBookResultTemp.UserUsername = reader.GetString(i)
                    Case "book_id"
                        userBorrowedBookResultTemp.BookID = reader.GetInt64(i)
                    Case "date_start"
                        userBorrowedBookResultTemp.DateStart = reader.GetDate(i)
                    Case "date_limit"
                        userBorrowedBookResultTemp.DateLimit = reader.GetDate(i)
                    Case "date_return"
                        userBorrowedBookResultTemp.DateReturn = If(reader.IsDBNull(i), Nothing, reader.GetDate(i))
                End Select
            Next
            userBorrowedBookResult.Add(userBorrowedBookResultTemp)
        End While
        Return userBorrowedBookResult
    End Function
End Class
