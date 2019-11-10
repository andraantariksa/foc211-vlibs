Public Class UserPanelForm
    Private _loginForm As Form
    Private selectedBookId As Integer
    Private username As String

    Public Sub New(username As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.username = username

    End Sub

    Public Property LoginForm As Form
        Get
            Return _loginForm
        End Get
        Set(value As Form)
            _loginForm = value
        End Set
    End Property

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

            Dim bookColumnData(4) As String
            bookColumnData(0) = book.Title
            bookColumnData(1) = book.Id
            bookColumnData(2) = book.Isbn
            bookColumnData(3) = book.Description

            Dim bookListViewItem = New ListViewItem(bookColumnData, book.Id)
            bookListViewItem.ImageKey = book.Id
            BooksListView.Items.Add(bookListViewItem)
        Next
    End Sub

    Private Sub UserPanelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadBooks("ID", "Ascending")
        TimeToolStripLabel.Text = TimeOfDay
        DescriptionLabel.MaximumSize = New Size(DescriptionPanel.Width - 30, 0)
        UsernameToolStripLabel.Text = Me.username
    End Sub

    Private Sub BooksListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BooksListView.SelectedIndexChanged
        Dim selectedBookIndex
        Dim selectedBook
        Try
            selectedBookIndex = BooksListView.FocusedItem.Index
            selectedBook = BooksListView.Items(selectedBookIndex).SubItems
        Catch ex As Exception
            Return
        End Try

        BookTitleLabel.Text = selectedBook(0).Text
        Me.selectedBookId = Convert.ToInt64(selectedBook(1).Text)
        BookISBNLabel.Text = selectedBook(2).Text
        DescriptionLabel.Text = selectedBook(3).Text

        If UserBorrowedBook.IsBorrowed(Me.selectedBookId) Then
            BorrowButton.Enabled = False
        Else
            BorrowButton.Enabled = True
        End If
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

    Private Sub BorrowButton_Click(sender As Object, e As EventArgs) Handles BorrowButton.Click
        UserBorrowedBook.Borrow(Me.username, Me.selectedBookId)

        MsgBox("Borrow date: " & Date.Now() & vbNewLine & "Limit return date: " & Now.AddDays(7))
        BorrowButton.Enabled = False
    End Sub

    Private Sub LogoutToolStripButton_Click(sender As Object, e As EventArgs) Handles LogoutToolStripButton.Click
        Me.LoginForm.Show()
        Me.Dispose()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        TimeToolStripLabel.Text = TimeOfDay
    End Sub

    Private Sub BooksToolStripButton_Click(sender As Object, e As EventArgs) Handles BooksToolStripButton.Click
        Dim myBorrowedBook As Form = New MyBorrowedBook(Me.username)
        myBorrowedBook.Show()
    End Sub
End Class