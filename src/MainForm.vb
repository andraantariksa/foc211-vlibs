Imports System.Windows.Forms

Public Class MainForm
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim registrationFormObj = New LoginForm()
        registrationFormObj.MdiParent = Me
        registrationFormObj.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutBoxObj = New AboutBox()
        aboutBoxObj.Show()
    End Sub

    Private Sub RepositoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepositoryToolStripMenuItem.Click
        Process.Start("https://github.com/andraantariksa/vlibs")
    End Sub

    Private Sub IssuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssuesToolStripMenuItem.Click
        Process.Start("https://github.com/andraantariksa/vlibs/issues")
    End Sub
End Class
