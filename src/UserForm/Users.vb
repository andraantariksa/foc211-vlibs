Public Class Users
    Dim selectedUserUsername As String = Nothing

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserToUserDataGridView()
    End Sub

    Private Sub LoadUserToUserDataGridView()
        Dim userList As List(Of User) = User.ListAll()
        For Each userDetail As User In userList
            UserDataGridView.Rows.Add(New String(1) {userDetail.Username, userDetail.Name})
        Next
    End Sub

    Private Sub UserDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellClick
        AdminCheckBox.Enabled = True
        ResetPasswordButton.Enabled = True

        Dim selectedRowCells As DataGridViewCellCollection = UserDataGridView.SelectedRows.Item(0).Cells
        Dim userUsername As String = selectedRowCells("UsernameDataGridViewColumn").Value

        Dim userObj As User = User.GetByUsername(userUsername)

        Me.selectedUserUsername = userObj.Username
        UsernameLabel.Text = userObj.Username
        NameLabel.Text = userObj.Name
        DateOfBirthLabel.Text = userObj.BirthDate
        AdminCheckBox.Checked = userObj.IsAdmin
    End Sub

    Private Sub ResetPasswordButton_Click(sender As Object, e As EventArgs) Handles ResetPasswordButton.Click
        Dim randPassword As String = Rand.RandomString(6)

        Dim tempUser As User = New User()
        tempUser.Password = randPassword
        tempUser.Update(Me.selectedUserUsername)

        MsgBox(Me.selectedUserUsername & "'s password has been reseted" & vbNewLine & "New password: " & randPassword, Title:="Password Reset")
    End Sub

    Private Sub AdminCheckBox_Click(sender As Object, e As EventArgs) Handles AdminCheckBox.Click
        AdminCheckBox.Checked = Not AdminCheckBox.Checked
        Select Case MsgBox("Are you sure you want to add/remove admin access from " & selectedUserUsername & "'s account?", MsgBoxStyle.YesNo, "Warning")
            Case MsgBoxResult.Yes
                AdminCheckBox.Checked = Not AdminCheckBox.Checked
                Dim tempUser As User = New User()
                tempUser.IsAdmin = AdminCheckBox.Checked
                tempUser.Update(Me.selectedUserUsername)
        End Select
    End Sub
End Class