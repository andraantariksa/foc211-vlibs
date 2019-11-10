Imports Library_Information_System.Models

Public Class Add
    Private publisherList As List(Of Publisher)

    Private Sub BookAddButton_Click(sender As Object, e As EventArgs) Handles BookAddButton.Click
        Dim bookTemp As Book = New Book()
        bookTemp.Title = BookTitleTextBox.Text
        If BookPublisherComboBox.SelectedIndex = -1 Then
            bookTemp.PublisherId = -1
        Else
            bookTemp.PublisherId = Me.publisherList(BookPublisherComboBox.SelectedIndex).Id
        End If
        bookTemp.Author = BookAuthorTextBox.Text
        bookTemp.Description = BookDescriptionTextBox.Text
        bookTemp.Isbn = BookISBNMaskedTextBox.Text
        bookTemp.Quantity = BookQuantityNumericUpDown.Value
        bookTemp.ThumbnailURL = BookThumbnailURLTextBox.Text
        Try
            bookTemp.Create()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
            Return
        End Try
        MsgBox(bookTemp.Title & " has been created")

        BookTitleTextBox.Text = ""
        BookPublisherComboBox.SelectedIndex = -1
        BookAuthorTextBox.Text = ""
        BookDescriptionTextBox.Text = ""
        BookISBNMaskedTextBox.Text = ""
        BookQuantityNumericUpDown.Value = 1
        BookThumbnailURLTextBox.Text = ""
    End Sub

    Private Sub ReloadPublisher()
        Me.publisherList = Publisher.ListAll()
        For Each _publisher As Publisher In Me.publisherList
            BookPublisherComboBox.Items.Add(_publisher.Name)
        Next
    End Sub

    Private Sub PublisherAddButton_Click(sender As Object, e As EventArgs) Handles PublisherAddButton.Click
        Dim publisherTemp As Publisher = New Publisher()
        publisherTemp.Name = PublisherNameTextBox.Text
        publisherTemp.Create()
        MsgBox("Publisher " & PublisherNameTextBox.Text & " has been created")
        PublisherNameTextBox.Text = ""
        ReloadPublisher()
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadPublisher()
    End Sub
End Class