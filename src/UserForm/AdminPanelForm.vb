Public Class AdminPanelForm
    Private _loginForm As Form
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

    Private Sub UsersToolStripButton_Click(sender As Object, e As EventArgs) Handles UsersToolStripButton.Click
        Dim usersForm As Form = New Users()
        usersForm.MdiParent = Me.MdiParent
        usersForm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeToolStripLabel.Text = TimeOfDay()
    End Sub

    Private Sub AdminPanelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameToolStripLabel.Text = Me.username
        TimeToolStripLabel.Text = TimeOfDay()
    End Sub

    Private Sub BooksToolStripButton_Click(sender As Object, e As EventArgs) Handles BooksToolStripButton.Click
        Dim addForm As Form = New Add()
        addForm.MdiParent = Me.MdiParent
        addForm.Show()
    End Sub

    Private Sub BorrowedToolStripButton_Click(sender As Object, e As EventArgs) Handles BorrowedToolStripButton.Click
        Dim borrowForm As Form = New BorrowedBook()
        borrowForm.MdiParent = Me.MdiParent
        borrowForm.Show()
    End Sub

    Private Sub LogoutToolStripButton_Click(sender As Object, e As EventArgs) Handles LogoutToolStripButton.Click
        loginForm.Show()
        Me.Dispose()
    End Sub
End Class