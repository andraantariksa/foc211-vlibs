Public Class MyBorrowedBook
    Private username As String

    Public Sub New(username As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.username = username
    End Sub

    Private Sub MyBorrowedBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each _borrowedBook As (UserBorrowedBook, Models.Book) In UserBorrowedBook.ListBorrowedBy(Me.username)
            BorrowedBookListbox.Items.Add(_borrowedBook.Item2.Title)
        Next
    End Sub
End Class