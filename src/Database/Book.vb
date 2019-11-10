Namespace Models

    Public Class Book
        Private _id As Integer
        Private _title As String
        Private _author As String
        Private _thumbnailURL As String
        Private _description As String
        Private _isbn As String
        Private _publisherId As Integer
        Private _quantity As Integer

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property Title As String
            Get
                Return _title
            End Get
            Set(value As String)
                _title = value
            End Set
        End Property

        Public Property Description As String
            Get
                Return _description
            End Get
            Set(value As String)
                _description = value
            End Set
        End Property

        Public Property Isbn As String
            Get
                Return _isbn
            End Get
            Set(value As String)
                _isbn = value
            End Set
        End Property

        Public Property Author As String
            Get
                Return _author
            End Get
            Set(value As String)
                _author = value
            End Set
        End Property

        Public Property ThumbnailURL As String
            Get
                Return _thumbnailURL
            End Get
            Set(value As String)
                _thumbnailURL = value
            End Set
        End Property

        Public Property PublisherId As Integer
            Get
                Return _publisherId
            End Get
            Set(value As Integer)
                _publisherId = value
            End Set
        End Property

        Public Property Quantity As Integer
            Get
                Return _quantity
            End Get
            Set(value As Integer)
                _quantity = value
            End Set
        End Property

        Public Shared Function FindById(id As Integer) As Book
            Dim con = Connection.GetInstance()

            con.Open()
            Dim res = New Npgsql.NpgsqlCommand("SELECT * FROM ""books"" WHERE id = @id", con)
            res.Parameters.Add(New Npgsql.NpgsqlParameter("id", id))
            Dim read = res.ExecuteReader()
            Dim booksResult = ReadResult(read)
            con.Close()
            Return booksResult.ElementAt(0)
        End Function

        Public Shared Function ListAll() As List(Of Book)
            Dim con = Connection.GetInstance()

            con.Open()
            Dim res = New Npgsql.NpgsqlCommand("SELECT * FROM ""books""", con)
            Dim read = res.ExecuteReader()
            Dim booksResult = ReadResult(read)
            con.Close()
            Return booksResult
        End Function

        Public Shared Function ListAll(sortBy As String, order As String) As List(Of Book)
            Dim dontClose As Boolean
            Dim con = Connection.GetInstance()

            If con.State = ConnectionState.Closed Then
                con.Open()
            Else
                dontClose = True
            End If
            Dim res = New Npgsql.NpgsqlCommand("SELECT * FROM ""books"" ORDER BY """ & sortBy & """ " & order, con)
            Dim read = res.ExecuteReader()
            Dim booksResult = ReadResult(read)
            If Not dontClose Then
                con.Close()
            End If
            Return booksResult
        End Function

        Public Sub Create()
            Dim con = Connection.GetInstance()
            con.Open()

            Dim res = New Npgsql.NpgsqlCommand("INSERT INTO ""books""(""title"", ""isbn"", ""author"", ""publisher_id"", ""thumbnail_url"", ""description"", ""quantity"") VALUES(@title, @isbn, @author, @publisher_id, @thumbnail_url, @description, @quantity)", con)
            res.Parameters.Add(New Npgsql.NpgsqlParameter("title", Me._title))
            res.Parameters.Add(New Npgsql.NpgsqlParameter("isbn", Me._isbn))
            res.Parameters.Add(New Npgsql.NpgsqlParameter("author", Me._author))
            res.Parameters.Add(New Npgsql.NpgsqlParameter("publisher_id", Me._publisherId))
            res.Parameters.Add(New Npgsql.NpgsqlParameter("thumbnail_url", Me._thumbnailURL))
            res.Parameters.Add(New Npgsql.NpgsqlParameter("description", Me._description))
            res.Parameters.Add(New Npgsql.NpgsqlParameter("quantity", Me._quantity))
            Try
                Dim read = res.ExecuteReader()
            Catch ex As Exception
                Throw ex
            Finally
                con.Close()
            End Try
        End Sub

        Public Shared Function ReadResult(reader As Npgsql.NpgsqlDataReader) As List(Of Book)
            Dim booksResult As List(Of Book) = New List(Of Book)
            While reader.Read()
                Dim bookTemp = New Book()
                For i = 0 To reader.FieldCount - 1
                    Select Case reader.GetName(i)
                        Case "id"
                            bookTemp.Id = reader.GetInt64(i)
                        Case "title"
                            bookTemp.Title = reader.GetString(i)
                        Case "isbn"
                            bookTemp.Isbn = reader.GetString(i)
                        Case "description"
                            bookTemp.Description = reader.GetString(i)
                        Case "author"
                            bookTemp.Author = reader.GetString(i)
                        Case "thumbnail_url"
                            bookTemp.ThumbnailURL = reader.GetString(i)
                        Case "quantity"
                            bookTemp.Quantity = reader.GetInt64(i)
                        Case "publisher_id"
                            bookTemp.PublisherId = reader.GetInt64(i)
                    End Select
                Next
                booksResult.Add(bookTemp)
            End While
            Return booksResult
        End Function
    End Class

End Namespace