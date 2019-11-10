Public Class BorrowedBook
    Private selectedTreeNodeTag As (UserBorrowedBook, Models.Book)

    Private Sub Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrowTreeView()
    End Sub

    Private Sub LoadBorrowTreeView()
        BorrowTreeView.Nodes.Clear()
        For Each _user As User In User.ListAll()
            Dim userBorrowedNode = BorrowTreeView.Nodes.Add(_user.Username)
            For Each _borrowedBook As (UserBorrowedBook, Models.Book) In UserBorrowedBook.ListBorrowedBy(_user.Username)
                Dim treeTemp As TreeNode = New TreeNode()
                treeTemp.Text = _borrowedBook.Item2.Title
                treeTemp.Tag = _borrowedBook
                userBorrowedNode.Nodes.Add(treeTemp)
            Next
        Next
    End Sub

    Private Sub BorrowTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles BorrowTreeView.AfterSelect
        Dim selectedTreeNodeTagTemp As (UserBorrowedBook, Models.Book)?
        Try
            selectedTreeNodeTagTemp = BorrowTreeView.SelectedNode.Tag
        Catch ex As Exception
            Return
        End Try

        If selectedTreeNodeTagTemp Is Nothing Then
            Return
        End If

        ReturnButton.Enabled = True

        Me.selectedTreeNodeTag = selectedTreeNodeTagTemp
        Dim selectedUserBorrowedBook As UserBorrowedBook = selectedTreeNodeTag.Item1
        Dim selectedBook As Models.Book = selectedTreeNodeTag.Item2

        BookTitleLabel.Text = selectedBook.Title
        BookISBNLabel.Text = selectedBook.Isbn
        DescriptionLabel.Text = selectedBook.Description
        'Publisher.Text = ""

        BorrowIDLabel.Text = selectedUserBorrowedBook.Id
        BorrowStartLabel.Text = selectedUserBorrowedBook.DateStart
        BorrowLimitLabel.Text = selectedUserBorrowedBook.DateLimit

        Dim dateLimit As Date = selectedUserBorrowedBook.DateLimit
        DaysPassedLabel.Text = DateDiff(DateInterval.Day, dateLimit, Date.Now()).ToString
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Dim userBorrowedBookTemp As UserBorrowedBook = New UserBorrowedBook()
        userBorrowedBookTemp.Id = selectedTreeNodeTag.Item1.Id
        userBorrowedBookTemp.DateReturn = Date.Now()
        userBorrowedBookTemp.Update()

        MsgBox("Success!" & vbNewLine & selectedTreeNodeTag.Item2.Title & " has been returned")
        ReturnButton.Enabled = False
        LoadBorrowTreeView()
    End Sub
End Class