<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Me.BookAddButton = New System.Windows.Forms.Button()
        Me.BookISBNMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.BookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.BookAuthorTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BookThumbnailURLTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BookQuantityNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BookDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DragLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BookPublisherComboBox = New System.Windows.Forms.ComboBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PublisherAddButton = New System.Windows.Forms.Button()
        Me.PublisherNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.BookQuantityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BookAddButton
        '
        Me.BookAddButton.Location = New System.Drawing.Point(101, 282)
        Me.BookAddButton.Name = "BookAddButton"
        Me.BookAddButton.Size = New System.Drawing.Size(75, 23)
        Me.BookAddButton.TabIndex = 0
        Me.BookAddButton.Text = "Add"
        Me.BookAddButton.UseVisualStyleBackColor = True
        '
        'BookISBNMaskedTextBox
        '
        Me.BookISBNMaskedTextBox.Location = New System.Drawing.Point(101, 45)
        Me.BookISBNMaskedTextBox.Mask = "000-0000000000"
        Me.BookISBNMaskedTextBox.Name = "BookISBNMaskedTextBox"
        Me.BookISBNMaskedTextBox.Size = New System.Drawing.Size(231, 20)
        Me.BookISBNMaskedTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Title"
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(10, 178)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(60, 13)
        Me.DescriptionLabel.TabIndex = 4
        Me.DescriptionLabel.Text = "Description"
        '
        'BookTitleTextBox
        '
        Me.BookTitleTextBox.Location = New System.Drawing.Point(101, 19)
        Me.BookTitleTextBox.Name = "BookTitleTextBox"
        Me.BookTitleTextBox.Size = New System.Drawing.Size(231, 20)
        Me.BookTitleTextBox.TabIndex = 5
        '
        'BookAuthorTextBox
        '
        Me.BookAuthorTextBox.Location = New System.Drawing.Point(101, 71)
        Me.BookAuthorTextBox.Name = "BookAuthorTextBox"
        Me.BookAuthorTextBox.Size = New System.Drawing.Size(231, 20)
        Me.BookAuthorTextBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Author"
        '
        'BookThumbnailURLTextBox
        '
        Me.BookThumbnailURLTextBox.Location = New System.Drawing.Point(101, 97)
        Me.BookThumbnailURLTextBox.Name = "BookThumbnailURLTextBox"
        Me.BookThumbnailURLTextBox.Size = New System.Drawing.Size(231, 20)
        Me.BookThumbnailURLTextBox.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Thumbnail URL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Publisher"
        '
        'BookQuantityNumericUpDown
        '
        Me.BookQuantityNumericUpDown.Location = New System.Drawing.Point(101, 150)
        Me.BookQuantityNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.BookQuantityNumericUpDown.Name = "BookQuantityNumericUpDown"
        Me.BookQuantityNumericUpDown.Size = New System.Drawing.Size(231, 20)
        Me.BookQuantityNumericUpDown.TabIndex = 15
        Me.BookQuantityNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Quantity"
        '
        'BookDescriptionTextBox
        '
        Me.BookDescriptionTextBox.Location = New System.Drawing.Point(101, 175)
        Me.BookDescriptionTextBox.Multiline = True
        Me.BookDescriptionTextBox.Name = "BookDescriptionTextBox"
        Me.BookDescriptionTextBox.Size = New System.Drawing.Size(231, 101)
        Me.BookDescriptionTextBox.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DragLabel)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(427, 347)
        Me.Panel2.TabIndex = 17
        '
        'DragLabel
        '
        Me.DragLabel.AutoSize = True
        Me.DragLabel.Location = New System.Drawing.Point(143, 328)
        Me.DragLabel.Name = "DragLabel"
        Me.DragLabel.Size = New System.Drawing.Size(215, 13)
        Me.DragLabel.TabIndex = 9
        Me.DragLabel.Text = "Drag the splitter on the right to add publisher"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BookAddButton)
        Me.GroupBox2.Controls.Add(Me.BookDescriptionTextBox)
        Me.GroupBox2.Controls.Add(Me.BookPublisherComboBox)
        Me.GroupBox2.Controls.Add(Me.DescriptionLabel)
        Me.GroupBox2.Controls.Add(Me.BookQuantityNumericUpDown)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.BookTitleTextBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BookISBNMaskedTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.BookThumbnailURLTextBox)
        Me.GroupBox2.Controls.Add(Me.BookAuthorTextBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 313)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book"
        '
        'BookPublisherComboBox
        '
        Me.BookPublisherComboBox.FormattingEnabled = True
        Me.BookPublisherComboBox.Location = New System.Drawing.Point(101, 123)
        Me.BookPublisherComboBox.Name = "BookPublisherComboBox"
        Me.BookPublisherComboBox.Size = New System.Drawing.Size(231, 21)
        Me.BookPublisherComboBox.TabIndex = 7
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(427, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 347)
        Me.Splitter1.TabIndex = 18
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(437, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(14, 347)
        Me.Panel1.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PublisherAddButton)
        Me.GroupBox1.Controls.Add(Me.PublisherNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 313)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Publisher"
        '
        'PublisherAddButton
        '
        Me.PublisherAddButton.Location = New System.Drawing.Point(98, 282)
        Me.PublisherAddButton.Name = "PublisherAddButton"
        Me.PublisherAddButton.Size = New System.Drawing.Size(75, 23)
        Me.PublisherAddButton.TabIndex = 20
        Me.PublisherAddButton.Text = "Add"
        Me.PublisherAddButton.UseVisualStyleBackColor = True
        '
        'PublisherNameTextBox
        '
        Me.PublisherNameTextBox.Location = New System.Drawing.Point(98, 19)
        Me.PublisherNameTextBox.Name = "PublisherNameTextBox"
        Me.PublisherNameTextBox.Size = New System.Drawing.Size(231, 20)
        Me.PublisherNameTextBox.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Name"
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 347)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add"
        Me.Text = "Add"
        CType(Me.BookQuantityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BookAddButton As Button
    Friend WithEvents BookISBNMaskedTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents BookTitleTextBox As TextBox
    Friend WithEvents BookAuthorTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BookThumbnailURLTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BookQuantityNumericUpDown As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents BookDescriptionTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PublisherNameTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BookPublisherComboBox As ComboBox
    Friend WithEvents PublisherAddButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DragLabel As Label
End Class
