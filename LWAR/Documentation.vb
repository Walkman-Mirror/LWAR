Public Class Documentation

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Documentation_Load(sender As Object, e As EventArgs) Handles MyBase.Load, FrontPgaeToolStripMenuItem.Click
        StatusText_timer.Start()
        WebBrowser1.Navigate("https://github.com/CampusTools/LWAR/wiki")
    End Sub

    Private Sub FrontPgaeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrontPgaeToolStripMenuItem.Click
        WebBrowser1.Navigate("https://github.com/CampusTools/LWAR/wiki")
    End Sub

    Private Sub StatusText_timer_Tick(sender As Object, e As EventArgs) Handles StatusText_timer.Tick
        StatusText_label.Text = WebBrowser1.StatusText.ToString
    End Sub

    Private Sub PagesIndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagesIndexToolStripMenuItem.Click
        WebBrowser1.Navigate("https://github.com/CampusTools/LWAR/wiki/Pages-index")
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        ToolStripProgressBar1.Visible = True
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        PageTitle.Text = WebBrowser1.DocumentTitle.ToString
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub BackToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem1.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub PagesIndexToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PagesIndexToolStripMenuItem1.Click
        WebBrowser1.Navigate("https://github.com/CampusTools/LWAR/wiki/Pages-index")
    End Sub
End Class