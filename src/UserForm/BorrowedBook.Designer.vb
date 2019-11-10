<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowedBook
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
        Me.BorrowTreeView = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.DescriptionPanel = New System.Windows.Forms.Panel()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.BookPublisherLabel = New System.Windows.Forms.Label()
        Me.BookISBNLabel = New System.Windows.Forms.Label()
        Me.BookTitleLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BorrowIDLabel = New System.Windows.Forms.Label()
        Me.BorrowStartLabel = New System.Windows.Forms.Label()
        Me.BorrowLimitLabel = New System.Windows.Forms.Label()
        Me.DaysPassedLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.DescriptionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorrowTreeView
        '
        Me.BorrowTreeView.Location = New System.Drawing.Point(7, 12)
        Me.BorrowTreeView.Name = "BorrowTreeView"
        Me.BorrowTreeView.Size = New System.Drawing.Size(318, 334)
        Me.BorrowTreeView.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DaysPassedLabel)
        Me.GroupBox1.Controls.Add(Me.BorrowLimitLabel)
        Me.GroupBox1.Controls.Add(Me.BorrowStartLabel)
        Me.GroupBox1.Controls.Add(Me.BorrowIDLabel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ReturnButton)
        Me.GroupBox1.Controls.Add(Me.DescriptionPanel)
        Me.GroupBox1.Controls.Add(Me.BookPublisherLabel)
        Me.GroupBox1.Controls.Add(Me.BookISBNLabel)
        Me.GroupBox1.Controls.Add(Me.BookTitleLabel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(331, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 340)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'ReturnButton
        '
        Me.ReturnButton.Enabled = False
        Me.ReturnButton.Location = New System.Drawing.Point(6, 311)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(75, 23)
        Me.ReturnButton.TabIndex = 2
        Me.ReturnButton.Text = "Return"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'DescriptionPanel
        '
        Me.DescriptionPanel.AutoScroll = True
        Me.DescriptionPanel.Controls.Add(Me.DescriptionLabel)
        Me.DescriptionPanel.Location = New System.Drawing.Point(6, 85)
        Me.DescriptionPanel.Name = "DescriptionPanel"
        Me.DescriptionPanel.Size = New System.Drawing.Size(281, 150)
        Me.DescriptionPanel.TabIndex = 8
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(3, 9)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(10, 13)
        Me.DescriptionLabel.TabIndex = 9
        Me.DescriptionLabel.Text = "-"
        '
        'BookPublisherLabel
        '
        Me.BookPublisherLabel.AutoSize = True
        Me.BookPublisherLabel.Location = New System.Drawing.Point(93, 53)
        Me.BookPublisherLabel.Name = "BookPublisherLabel"
        Me.BookPublisherLabel.Size = New System.Drawing.Size(10, 13)
        Me.BookPublisherLabel.TabIndex = 6
        Me.BookPublisherLabel.Text = "-"
        '
        'BookISBNLabel
        '
        Me.BookISBNLabel.AutoSize = True
        Me.BookISBNLabel.Location = New System.Drawing.Point(93, 37)
        Me.BookISBNLabel.Name = "BookISBNLabel"
        Me.BookISBNLabel.Size = New System.Drawing.Size(10, 13)
        Me.BookISBNLabel.TabIndex = 5
        Me.BookISBNLabel.Text = "-"
        '
        'BookTitleLabel
        '
        Me.BookTitleLabel.AutoSize = True
        Me.BookTitleLabel.Location = New System.Drawing.Point(93, 20)
        Me.BookTitleLabel.Name = "BookTitleLabel"
        Me.BookTitleLabel.Size = New System.Drawing.Size(10, 13)
        Me.BookTitleLabel.TabIndex = 4
        Me.BookTitleLabel.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Publisher:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ISBN: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Borrow ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Borrow Limit:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Borrow Start:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Days passed:"
        '
        'BorrowIDLabel
        '
        Me.BorrowIDLabel.AutoSize = True
        Me.BorrowIDLabel.Location = New System.Drawing.Point(93, 240)
        Me.BorrowIDLabel.Name = "BorrowIDLabel"
        Me.BorrowIDLabel.Size = New System.Drawing.Size(10, 13)
        Me.BorrowIDLabel.TabIndex = 13
        Me.BorrowIDLabel.Text = "-"
        '
        'BorrowStartLabel
        '
        Me.BorrowStartLabel.AutoSize = True
        Me.BorrowStartLabel.Location = New System.Drawing.Point(93, 253)
        Me.BorrowStartLabel.Name = "BorrowStartLabel"
        Me.BorrowStartLabel.Size = New System.Drawing.Size(10, 13)
        Me.BorrowStartLabel.TabIndex = 14
        Me.BorrowStartLabel.Text = "-"
        '
        'BorrowLimitLabel
        '
        Me.BorrowLimitLabel.AutoSize = True
        Me.BorrowLimitLabel.Location = New System.Drawing.Point(93, 266)
        Me.BorrowLimitLabel.Name = "BorrowLimitLabel"
        Me.BorrowLimitLabel.Size = New System.Drawing.Size(10, 13)
        Me.BorrowLimitLabel.TabIndex = 15
        Me.BorrowLimitLabel.Text = "-"
        '
        'DaysPassedLabel
        '
        Me.DaysPassedLabel.AutoSize = True
        Me.DaysPassedLabel.Location = New System.Drawing.Point(93, 283)
        Me.DaysPassedLabel.Name = "DaysPassedLabel"
        Me.DaysPassedLabel.Size = New System.Drawing.Size(10, 13)
        Me.DaysPassedLabel.TabIndex = 16
        Me.DaysPassedLabel.Text = "-"
        '
        'BorrowedBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 359)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BorrowTreeView)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BorrowedBook"
        Me.Text = "Borrowed Book"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.DescriptionPanel.ResumeLayout(False)
        Me.DescriptionPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BorrowTreeView As TreeView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ReturnButton As Button
    Friend WithEvents DescriptionPanel As Panel
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents BookPublisherLabel As Label
    Friend WithEvents BookISBNLabel As Label
    Friend WithEvents BookTitleLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DaysPassedLabel As Label
    Friend WithEvents BorrowLimitLabel As Label
    Friend WithEvents BorrowStartLabel As Label
    Friend WithEvents BorrowIDLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
