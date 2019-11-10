Public Class RegistrationForm
    Private _loginForm As Form
    Private gender As Char

    ' Validation
    Private emailFieldValid As Boolean
    Private usernameFieldValid As Boolean
    Private passwordFieldValid As Boolean
    Private nameFieldValid As Boolean
    Private addressFieldValid As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.gender = "M"c
    End Sub

    Public Property LoginForm As Object
        Get
            Return _loginForm
        End Get
        Set(value As Object)
            _loginForm = value
        End Set
    End Property

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim userObj = New User()
        userObj.Username = TextBoxUsername.Text
        userObj.Password = TextBoxPassword.Text
        userObj.Name = TextBoxName.Text
        userObj.Password = TextBoxPassword.Text
        userObj.Address = TextBoxAddress.Text
        userObj.Email = TextBoxEmail.Text
        userObj.BirthDate = DateTimePickerBirthDate.Value.Date
        userObj.IsAdmin = False
        userObj.Gender = Me.gender
        Try
            userObj.Create()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
            Return
        End Try

        MsgBox("Registration completed!")

        Me._loginForm.Show()
        Me.Dispose()
    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me._loginForm.Hide()
    End Sub

    Private Sub RegistrationForm_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Me._loginForm.Show()
    End Sub

    Private Sub RadioButtonMale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMale.CheckedChanged
        Me.gender = "M"
    End Sub

    Private Sub RadioButtonFemale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFemale.CheckedChanged
        Me.gender = "F"
    End Sub

    Private Sub TextBoxEmail_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmail.TextChanged
        Me.emailFieldValid = ValidatorHelper.IsEmail(TextBoxEmail.Text)
        ReloadProgress()
    End Sub

    Private Sub ReloadProgress()
        Dim totalProgress As Integer = 0
        If Me.emailFieldValid Then
            totalProgress += 20
        End If
        If Me.usernameFieldValid Then
            totalProgress += 25
        End If
        If Me.passwordFieldValid Then
            totalProgress += 25
        End If
        If Me.nameFieldValid Then
            totalProgress += 15
        End If
        If Me.addressFieldValid Then
            totalProgress += 15
        End If
        FieldCompletedProgressBar.Value = totalProgress
        ButtonRegister.Enabled = totalProgress = 100
    End Sub

    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged
        Me.usernameFieldValid = ValidatorHelper.IsUsername(TextBoxUsername.Text)
        ReloadProgress()
    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged
        Me.passwordFieldValid = ValidatorHelper.IsPassword(TextBoxPassword.Text)
        ReloadProgress()
    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged
        Me.nameFieldValid = TextBoxName.Text <> ""
        ReloadProgress()
    End Sub

    Private Sub TextBoxAddress_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAddress.TextChanged
        Me.addressFieldValid = TextBoxAddress.Text <> ""
        ReloadProgress()
    End Sub
End Class