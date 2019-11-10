<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyBorrowedBook
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
        Me.BorrowedBookListbox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BorrowedBookListbox
        '
        Me.BorrowedBookListbox.FormattingEnabled = True
        Me.BorrowedBookListbox.Location = New System.Drawing.Point(12, 12)
        Me.BorrowedBookListbox.Name = "BorrowedBookListbox"
        Me.BorrowedBookListbox.Size = New System.Drawing.Size(340, 329)
        Me.BorrowedBookListbox.TabIndex = 1
        '
        'MyBorrowedBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 357)
        Me.Controls.Add(Me.BorrowedBookListbox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MyBorrowedBook"
        Me.Text = "My Borrowed Books"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BorrowedBookListbox As ListBox
End Class
