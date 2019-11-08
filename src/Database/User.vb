Public Class User
    Private _username As String
    Private _password As String
    Private _name As String
    Private _address As String
    Private _email As String
    Private _gender? As Char
    Private _birthDate? As Date
    Private _isAdmin? As Boolean

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Gender As Char?
        Get
            Return _gender
        End Get
        Set(value As Char?)
            _gender = value
        End Set
    End Property

    Public Property BirthDate As Date?
        Get
            Return _birthDate
        End Get
        Set(value As Date?)
            _birthDate = value
        End Set
    End Property

    Public Property IsAdmin As Boolean?
        Get
            Return _isAdmin
        End Get
        Set(value As Boolean?)
            _isAdmin = value
        End Set
    End Property

    Public Function FindByUsername(username As String) As User
        Dim con = Connection.GetInstance()

        con.Open()
        Dim res = New Npgsql.NpgsqlCommand("SELECT * FROM ""users"" WHERE username = @username", con)
        res.Parameters.Add(New Npgsql.NpgsqlParameter("username", username))
        Dim read = res.ExecuteReader()
        Dim usersResult = ReadResult(read)
        con.Close()
        Return usersResult.ElementAt(0)
    End Function

    Public Shared Function GetByUsername(username As String) As User
        Dim con = Connection.GetInstance()

        con.Open()
        Dim res = New Npgsql.NpgsqlCommand("SELECT * FROM ""users"" WHERE username = @username", con)
        res.Parameters.Add(New Npgsql.NpgsqlParameter("username", username))
        Dim read = res.ExecuteReader()
        Dim booksResult = ReadResult(read)
        con.Close()
        Return booksResult.ElementAt(0)
    End Function

    Public Shared Function GetByUsernamePassword(username As String, password As String) As User
        Dim con = Connection.GetInstance()

        con.Open()
        Dim res = New Npgsql.NpgsqlCommand("SELECT * FROM ""users"" WHERE username = @username AND password = @password", con)
        res.Parameters.Add(New Npgsql.NpgsqlParameter("username", username))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("password", password))
        Dim read = res.ExecuteReader()
        Dim booksResult = ReadResult(read)
        con.Close()
        Return booksResult.ElementAt(0)
    End Function

    Public Shared Function ListAll() As List(Of User)
        Dim con = Connection.GetInstance()

        con.Open()
        Dim res = New Npgsql.NpgsqlCommand("SELECT * FROM ""users""", con)
        Dim read = res.ExecuteReader()
        Dim booksResult = ReadResult(read)
        con.Close()
        Return booksResult
    End Function

    Public Sub Create()
        Dim con = Connection.GetInstance()
        con.Open()

        Dim res = New Npgsql.NpgsqlCommand("INSERT INTO ""users""(""username"", ""password"", ""birthdate"", ""name"", ""address"", ""gender"", ""email"", ""is_admin"") VALUES(@username, @password, @birthdate, @name, @address, @gender, @email, @is_admin)", con)
        res.Parameters.Add(New Npgsql.NpgsqlParameter("username", Me._username))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("password", Me._password))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("birthdate", Me._birthDate))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("name", Me._name))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("email", Me._email))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("address", Me._address))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("gender", Me._gender.ToString))
        res.Parameters.Add(New Npgsql.NpgsqlParameter("is_admin", Me._isAdmin))
        Try
            Dim read = res.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            con.Close()
        End Try
        'Dim booksResult = Me.ReadResult(read)
    End Sub

    Public Sub Update(username As String)
        Dim con = Connection.GetInstance()

        con.Open()

        Dim fieldSetQuery = If(Me.Password IsNot Nothing, """password"" = @password", "")
        fieldSetQuery += If(Me.Username IsNot Nothing, """username"" = @username", "")
        fieldSetQuery += If(Me.Name IsNot Nothing, """name"" = @name", "")
        fieldSetQuery += If(Me.BirthDate IsNot Nothing, """birthdate"" = @birthdate", "")
        fieldSetQuery += If(Me.Email IsNot Nothing, """email"" = @email", "")
        fieldSetQuery += If(Me.Gender IsNot Nothing, """gender"" = @gender", "")
        fieldSetQuery += If(Me.IsAdmin IsNot Nothing, """is_admin"" = @is_admin", "")

        Dim res = New Npgsql.NpgsqlCommand("UPDATE ""users"" SET " & fieldSetQuery & " WHERE username = @w_username", con)
        res.Parameters.Add(New Npgsql.NpgsqlParameter("w_username", username))
        If Me.Username IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("username", Me.Username))
        End If
        If Me.Name IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("name", Me.Name))
        End If
        If Me.Email IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("email", Me.Email))
        End If
        If Me.BirthDate IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("birthdate", Me.BirthDate))
        End If
        If Me.Password IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("password", Me.Password))
        End If
        If Me.Gender IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("gender", Me.Gender))
        End If
        If Me.IsAdmin IsNot Nothing Then
            res.Parameters.Add(New Npgsql.NpgsqlParameter("is_admin", Me.IsAdmin))
        End If
        res.ExecuteReader()
        con.Close()
    End Sub

    Public Shared Function ReadResult(reader As Npgsql.NpgsqlDataReader) As List(Of User)
        Dim usersResult As List(Of User) = New List(Of User)
        While reader.Read()
            Dim userTemp = New User()
            For i = 0 To reader.FieldCount - 1
                Select Case reader.GetName(i)
                    Case "username"
                        userTemp.Username = reader.GetString(i)
                    Case "password"
                        userTemp.Password = reader.GetString(i)
                    Case "name"
                        userTemp.Name = reader.GetString(i)
                    Case "address"
                        userTemp.Address = reader.GetString(i)
                    Case "email"
                        userTemp.Email = reader.GetString(i)
                    Case "birthdate"
                        userTemp.BirthDate = reader.GetDateTime(i)
                    Case "gender"
                        userTemp.Gender = reader.GetChar(i)
                    Case "is_admin"
                        userTemp.IsAdmin = reader.GetBoolean(i)
                End Select
            Next
            usersResult.Add(userTemp)
        End While
        Return usersResult
    End Function
End Class
