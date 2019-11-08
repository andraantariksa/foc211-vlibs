Public Class RegistrationForm
    Private _loginForm As Form
    Private gender As Char = "M"c

    Public Property LoginForm As Object
        Get
            Return LoginForm
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
End Class