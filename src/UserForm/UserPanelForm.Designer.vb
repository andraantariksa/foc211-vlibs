<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserPanelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserPanelForm))
        Me.BooksListView = New System.Windows.Forms.ListView()
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ISBN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BooksImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BorrowButton = New System.Windows.Forms.Button()
        Me.DescriptionPanel = New System.Windows.Forms.Panel()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.BookPublisherLabel = New System.Windows.Forms.Label()
        Me.BookISBNLabel = New System.Windows.Forms.Label()
        Me.BookTitleLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SortByComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OrderComboBox = New System.Windows.Forms.ComboBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.BooksToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TimeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.LogoutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UsernameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1.SuspendLayout()
        Me.DescriptionPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BooksListView
        '
        Me.BooksListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Title, Me.ID, Me.ISBN, Me.Description})
        Me.BooksListView.HideSelection = False
        Me.BooksListView.LargeImageList = Me.BooksImageList
        Me.BooksListView.Location = New System.Drawing.Point(9, 59)
        Me.BooksListView.MultiSelect = False
        Me.BooksListView.Name = "BooksListView"
        Me.BooksListView.Size = New System.Drawing.Size(390, 275)
        Me.BooksListView.TabIndex = 0
        Me.BooksListView.UseCompatibleStateImageBehavior = False
        '
        'ID
        '
        Me.ID.DisplayIndex = 3
        '
        'ISBN
        '
        Me.ISBN.DisplayIndex = 1
        '
        'Description
        '
        Me.Description.DisplayIndex = 2
        '
        'BooksImageList
        '
        Me.BooksImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.BooksImageList.ImageSize = New System.Drawing.Size(64, 96)
        Me.BooksImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BorrowButton)
        Me.GroupBox1.Controls.Add(Me.DescriptionPanel)
        Me.GroupBox1.Controls.Add(Me.BookPublisherLabel)
        Me.GroupBox1.Controls.Add(Me.BookISBNLabel)
        Me.GroupBox1.Controls.Add(Me.BookTitleLabel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 340)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'BorrowButton
        '
        Me.BorrowButton.Enabled = False
        Me.BorrowButton.Location = New System.Drawing.Point(6, 311)
        Me.BorrowButton.Name = "BorrowButton"
        Me.BorrowButton.Size = New System.Drawing.Size(75, 23)
        Me.BorrowButton.TabIndex = 2
        Me.BorrowButton.Text = "Borrow"
        Me.BorrowButton.UseVisualStyleBackColor = True
        '
        'DescriptionPanel
        '
        Me.DescriptionPanel.AutoScroll = True
        Me.DescriptionPanel.Controls.Add(Me.DescriptionLabel)
        Me.DescriptionPanel.Location = New System.Drawing.Point(6, 85)
        Me.DescriptionPanel.Name = "DescriptionPanel"
        Me.DescriptionPanel.Size = New System.Drawing.Size(281, 220)
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
        Me.BookPublisherLabel.Location = New System.Drawing.Point(66, 53)
        Me.BookPublisherLabel.Name = "BookPublisherLabel"
        Me.BookPublisherLabel.Size = New System.Drawing.Size(10, 13)
        Me.BookPublisherLabel.TabIndex = 6
        Me.BookPublisherLabel.Text = "-"
        '
        'BookISBNLabel
        '
        Me.BookISBNLabel.AutoSize = True
        Me.BookISBNLabel.Location = New System.Drawing.Point(50, 37)
        Me.BookISBNLabel.Name = "BookISBNLabel"
        Me.BookISBNLabel.Size = New System.Drawing.Size(10, 13)
        Me.BookISBNLabel.TabIndex = 5
        Me.BookISBNLabel.Text = "-"
        '
        'BookTitleLabel
        '
        Me.BookTitleLabel.AutoSize = True
        Me.BookTitleLabel.Location = New System.Drawing.Point(40, 20)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.SortByComboBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.OrderComboBox)
        Me.GroupBox2.Controls.Add(Me.BooksListView)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 340)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book List"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Search"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(303, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Order"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 20)
        Me.TextBox1.TabIndex = 6
        '
        'SortByComboBox
        '
        Me.SortByComboBox.FormattingEnabled = True
        Me.SortByComboBox.Items.AddRange(New Object() {"ID", "Title", "ISBN"})
        Me.SortByComboBox.Location = New System.Drawing.Point(197, 32)
        Me.SortByComboBox.Name = "SortByComboBox"
        Me.SortByComboBox.Size = New System.Drawing.Size(103, 21)
        Me.SortByComboBox.TabIndex = 5
        Me.SortByComboBox.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sort By"
        '
        'OrderComboBox
        '
        Me.OrderComboBox.FormattingEnabled = True
        Me.OrderComboBox.Items.AddRange(New Object() {"Ascending", "Descending"})
        Me.OrderComboBox.Location = New System.Drawing.Point(306, 32)
        Me.OrderComboBox.Name = "OrderComboBox"
        Me.OrderComboBox.Size = New System.Drawing.Size(93, 21)
        Me.OrderComboBox.TabIndex = 3
        Me.OrderComboBox.Text = "Ascending"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BooksToolStripButton, Me.ToolStripSeparator1, Me.TimeToolStripLabel, Me.LogoutToolStripButton, Me.UsernameToolStripLabel})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(749, 25)
        Me.ToolStrip.TabIndex = 13
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'BooksToolStripButton
        '
        Me.BooksToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BooksToolStripButton.Image = CType(resources.GetObject("BooksToolStripButton.Image"), System.Drawing.Image)
        Me.BooksToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BooksToolStripButton.Name = "BooksToolStripButton"
        Me.BooksToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BooksToolStripButton.Text = "My Borrowed Books"
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
        Me.LogoutToolStripButton.Text = "LogoutToolStripButton"
        '
        'UsernameToolStripLabel
        '
        Me.UsernameToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.UsernameToolStripLabel.Name = "UsernameToolStripLabel"
        Me.UsernameToolStripLabel.Size = New System.Drawing.Size(60, 22)
        Me.UsernameToolStripLabel.Text = "Username"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(728, 351)
        Me.SplitContainer1.SplitterDistance = 418
        Me.SplitContainer1.TabIndex = 15
        '
        'UserPanelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserPanelForm"
        Me.Text = "User Panel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.DescriptionPanel.ResumeLayout(False)
        Me.DescriptionPanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BooksListView As ListView
    Friend WithEvents Title As ColumnHeader
    Friend WithEvents ISBN As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents BooksImageList As ImageList
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BookTitleLabel As Label
    Friend WithEvents BookPublisherLabel As Label
    Friend WithEvents BookISBNLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DescriptionPanel As Panel
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SortByComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents OrderComboBox As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents BooksToolStripButton As ToolStripButton
    Friend WithEvents Timer As Timer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BorrowButton As Button
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TimeToolStripLabel As ToolStripLabel
    Friend WithEvents LogoutToolStripButton As ToolStripButton
    Friend WithEvents UsernameToolStripLabel As ToolStripLabel
End Class
