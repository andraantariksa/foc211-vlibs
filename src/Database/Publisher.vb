Public Class Publisher
    Private _id As Integer
    Private _name As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Shared Function ReadResult(reader As Npgsql.NpgsqlDataReader) As List(Of Publisher)
        Dim publishersResult As List(Of Publisher) = New List(Of Publisher)
        While reader.Read()
            Dim publisherTemp = New Publisher()
            For i = 0 To reader.FieldCount - 1
                Select Case reader.GetName(i)
                    Case "id"
                        publisherTemp.Id = reader.GetInt64(i)
                    Case "name"
                        publisherTemp.Name = reader.GetString(i)
                End Select
            Next
            publishersResult.Add(publisherTemp)
        End While
        Return publishersResult
    End Function

    Public Shared Function ListAll() As List(Of Publisher)
        Dim con = Connection.GetInstance()

        con.Open()
        Dim res = New Npgsql.NpgsqlCommand("SELECT * FROM ""publisher""", con)
        Dim read = res.ExecuteReader()
        Dim publishersResult = ReadResult(read)
        con.Close()
        Return publishersResult
    End Function

    Public Sub Create()
        Dim con = Connection.GetInstance()
        con.Open()

        Dim res = New Npgsql.NpgsqlCommand("INSERT INTO ""publisher""(""name"") VALUES(@name)", con)
        res.Parameters.Add(New Npgsql.NpgsqlParameter("name", Me.Name))
        Try
            Dim read = res.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            con.Close()
        End Try
    End Sub
End Class
