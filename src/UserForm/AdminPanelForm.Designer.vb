<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPanelForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPanelForm))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BooksToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BorrowedToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UsersToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TimeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.LogoutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UsernameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BooksToolStripButton, Me.BorrowedToolStripButton, Me.UsersToolStripButton, Me.ToolStripSeparator1, Me.TimeToolStripLabel, Me.LogoutToolStripButton, Me.UsernameToolStripLabel})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(328, 25)
        Me.ToolStrip.TabIndex = 12
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'BooksToolStripButton
        '
        Me.BooksToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BooksToolStripButton.Image = CType(resources.GetObject("BooksToolStripButton.Image"), System.Drawing.Image)
        Me.BooksToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BooksToolStripButton.Name = "BooksToolStripButton"
        Me.BooksToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BooksToolStripButton.Text = "Add"
        '
        'BorrowedToolStripButton
        '
        Me.BorrowedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BorrowedToolStripButton.Image = CType(resources.GetObject("BorrowedToolStripButton.Image"), System.Drawing.Image)
        Me.BorrowedToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BorrowedToolStripButton.Name = "BorrowedToolStripButton"
        Me.BorrowedToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BorrowedToolStripButton.Text = "Borrowed Books"
        '
        'UsersToolStripButton
        '
        Me.UsersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersToolStripButton.Image = CType(resources.GetObject("UsersToolStripButton.Image"), System.Drawing.Image)
        Me.UsersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UsersToolStripButton.Name = "UsersToolStripButton"
        Me.UsersToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.UsersToolStripButton.Text = "Manage Users"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TimeToolStripLabel
        '
        Me.TimeToolStripLabel.Name = "TimeToolStripLabel"
        Me.TimeToolStripLabel.Size = New System.Drawing.Size(33, 22)
        Me.TimeToolStripLabel.Text = "Time"
        '
        'LogoutToolStripButton
        '
        Me.LogoutToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LogoutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LogoutToolStripButton.Image = CType(resources.GetObject("LogoutToolStripButton.Image"), System.Drawing.Image)
        Me.LogoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LogoutToolStripButton.Name = "LogoutToolStripButton"
        Me.LogoutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.LogoutToolStripButton.Text = "Logout"
        '
        'UsernameToolStripLabel
        '
        Me.UsernameToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.UsernameToolStripLabel.Name = "UsernameToolStripLabel"
        Me.UsernameToolStripLabel.Size = New System.Drawing.Size(60, 22)
        Me.UsernameToolStripLabel.Text = "Username"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'AdminPanelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 224)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminPanelForm"
        Me.Text = "Admin Panel"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents BooksToolStripButton As ToolStripButton
    Friend WithEvents UsersToolStripButton As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimeToolStripLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents UsernameToolStripLabel As ToolStripLabel
    Friend WithEvents BorrowedToolStripButton As ToolStripButton
    Friend WithEvents LogoutToolStripButton As ToolStripButton
End Class
