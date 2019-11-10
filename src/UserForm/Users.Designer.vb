<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DetailTabPage = New System.Windows.Forms.TabPage()
        Me.DateOfBirthLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActionTabPage = New System.Windows.Forms.TabPage()
        Me.AdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResetPasswordButton = New System.Windows.Forms.Button()
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.DetailTabPage.SuspendLayout()
        Me.ActionTabPage.SuspendLayout()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DetailTabPage)
        Me.TabControl1.Controls.Add(Me.ActionTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(329, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(202, 395)
        Me.TabControl1.TabIndex = 13
        '
        'DetailTabPage
        '
        Me.DetailTabPage.Controls.Add(Me.DateOfBirthLabel)
        Me.DetailTabPage.Controls.Add(Me.Label4)
        Me.DetailTabPage.Controls.Add(Me.NameLabel)
        Me.DetailTabPage.Controls.Add(Me.UsernameLabel)
        Me.DetailTabPage.Controls.Add(Me.Label2)
        Me.DetailTabPage.Controls.Add(Me.Label1)
        Me.DetailTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DetailTabPage.Name = "DetailTabPage"
        Me.DetailTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DetailTabPage.Size = New System.Drawing.Size(194, 369)
        Me.DetailTabPage.TabIndex = 0
        Me.DetailTabPage.Text = "Detail"
        Me.DetailTabPage.UseVisualStyleBackColor = True
        '
        'DateOfBirthLabel
        '
        Me.DateOfBirthLabel.AutoSize = True
        Me.DateOfBirthLabel.Location = New System.Drawing.Point(81, 38)
        Me.DateOfBirthLabel.Name = "DateOfBirthLabel"
        Me.DateOfBirthLabel.Size = New System.Drawing.Size(10, 13)
        Me.DateOfBirthLabel.TabIndex = 15
        Me.DateOfBirthLabel.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Date of Birth:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(81, 20)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(10, 13)
        Me.NameLabel.TabIndex = 12
        Me.NameLabel.Text = "-"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(81, 3)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(10, 13)
        Me.UsernameLabel.TabIndex = 11
        Me.UsernameLabel.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Username:"
        '
        'ActionTabPage
        '
        Me.ActionTabPage.Controls.Add(Me.AdminCheckBox)
        Me.ActionTabPage.Controls.Add(Me.ResetPasswordButton)
        Me.ActionTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ActionTabPage.Name = "ActionTabPage"
        Me.ActionTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ActionTabPage.Size = New System.Drawing.Size(194, 369)
        Me.ActionTabPage.TabIndex = 1
        Me.ActionTabPage.Text = "Action"
        Me.ActionTabPage.UseVisualStyleBackColor = True
        '
        'AdminCheckBox
        '
        Me.AdminCheckBox.AutoSize = True
        Me.AdminCheckBox.Enabled = False
        Me.AdminCheckBox.Location = New System.Drawing.Point(6, 6)
        Me.AdminCheckBox.Name = "AdminCheckBox"
        Me.AdminCheckBox.Size = New System.Drawing.Size(93, 17)
        Me.AdminCheckBox.TabIndex = 18
        Me.AdminCheckBox.Text = "Admin Access"
        Me.AdminCheckBox.UseVisualStyleBackColor = True
        '
        'ResetPasswordButton
        '
        Me.ResetPasswordButton.Enabled = False
        Me.ResetPasswordButton.Location = New System.Drawing.Point(6, 29)
        Me.ResetPasswordButton.Name = "ResetPasswordButton"
        Me.ResetPasswordButton.Size = New System.Drawing.Size(75, 36)
        Me.ResetPasswordButton.TabIndex = 17
        Me.ResetPasswordButton.Text = "Reset Password"
        Me.ResetPasswordButton.UseVisualStyleBackColor = True
        '
        'UserDataGridView
        '
        Me.UserDataGridView.AllowUserToAddRows = False
        Me.UserDataGridView.AllowUserToDeleteRows = False
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewColumn, Me.NameDataGridViewColumn})
        Me.UserDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.ReadOnly = True
        Me.UserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserDataGridView.Size = New System.Drawing.Size(311, 395)
        Me.UserDataGridView.TabIndex = 12
        '
        'UsernameDataGridViewColumn
        '
        Me.UsernameDataGridViewColumn.HeaderText = "Username"
        Me.UsernameDataGridViewColumn.Name = "UsernameDataGridViewColumn"
        Me.UsernameDataGridViewColumn.ReadOnly = True
        '
        'NameDataGridViewColumn
        '
        Me.NameDataGridViewColumn.HeaderText = "Name"
        Me.NameDataGridViewColumn.Name = "NameDataGridViewColumn"
        Me.NameDataGridViewColumn.ReadOnly = True
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 423)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.UserDataGridView)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Users"
        Me.Text = "Users"
        Me.TabControl1.ResumeLayout(False)
        Me.DetailTabPage.ResumeLayout(False)
        Me.DetailTabPage.PerformLayout()
        Me.ActionTabPage.ResumeLayout(False)
        Me.ActionTabPage.PerformLayout()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DetailTabPage As TabPage
    Friend WithEvents DateOfBirthLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ActionTabPage As TabPage
    Friend WithEvents AdminCheckBox As CheckBox
    Friend WithEvents ResetPasswordButton As Button
    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents UsernameDataGridViewColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewColumn As DataGridViewTextBoxColumn
End Class
