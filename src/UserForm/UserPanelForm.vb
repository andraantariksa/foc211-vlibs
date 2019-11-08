Public Class UserPanelForm
    Private Sub LoadBooks(sortBy As String, order As String)
        Dim _sortBy As String = ""
        Select Case sortBy
            Case "ID"
                _sortBy = "id"
            Case "Title"
                _sortBy = "title"
            Case "ISBN"
                _sortBy = "isbn"
        End Select

        Dim _order As String = ""
        Select Case order
            Case "Ascending"
                _order = "ASC"
            Case "Descending"
                _order = "DESC"
        End Select

        Dim allBooks = Models.Book.ListAll(_sortBy, _order)

        BooksListView.Items.Clear()
        For Each book In allBooks
            BooksImageList.Images.Add(book.Id, ImageHelper.GetImageBitmapFromURL(book.ThumbnailURL))

            Dim bookColumnData(3) As String
            bookColumnData(0) = book.Title
            bookColumnData(1) = book.Isbn
            bookColumnData(2) = book.Description

            Dim bookListViewItem = New ListViewItem(bookColumnData, book.Id)
            bookListViewItem.ImageKey = book.Id
            BooksListView.Items.Add(bookListViewItem)
        Next
    End Sub

    Private Sub UserPanelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadBooks("ID", "Ascending")
        DescriptionLabel.MaximumSize = New Size(DescriptionPanel.Width - 30, 0)
    End Sub

    Private Sub BooksListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BooksListView.SelectedIndexChanged
        Dim selectedBook = BooksListView.Items(BooksListView.FocusedItem.Index).SubItems

        BookTitleLabel.Text = selectedBook(0).Text
        BookISBNLabel.Text = selectedBook(1).Text
        DescriptionLabel.Text = selectedBook(2).Text
    End Sub

    Private Sub SortByComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SortByComboBox.SelectedIndexChanged
        Dim sortBy = SortByComboBox.Text
        Dim order = OrderComboBox.Text
        LoadBooks(sortBy, order)
    End Sub

    Private Sub OrderComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrderComboBox.SelectedIndexChanged
        Dim sortBy = SortByComboBox.Text
        Dim order = OrderComboBox.Text
        LoadBooks(sortBy, order)
    End Sub
End Class