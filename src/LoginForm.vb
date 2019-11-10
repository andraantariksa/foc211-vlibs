Public Class LoginForm
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username = UsernameTextBox.Text
        Dim password = PasswordTextBox.Text
        Dim userResult As User = Nothing
        Try
            userResult = User.GetByUsernamePassword(username, password)
        Catch ex As ArgumentOutOfRangeException
            MsgBox("User not found")
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
        End Try

        If userResult IsNot Nothing Then
            Dim panelForm = Nothing
            If userResult.IsAdmin Then
                panelForm = New AdminPanelForm(userResult.Username)
            Else
                panelForm = New UserPanelForm(userResult.Username)
            End If
            panelForm.LoginForm = Me
            Me.Hide()
            panelForm.MdiParent = Me.MdiParent
            panelForm.StartPosition = FormStartPosition.CenterScreen
            panelForm.Show()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dim registrationFormObj = New RegistrationForm()
        registrationFormObj.LoginForm = Me
        registrationFormObj.MdiParent = Me.MdiParent
        registrationFormObj.StartPosition = FormStartPosition.CenterScreen
        registrationFormObj.Show()
    End Sub
End Class
