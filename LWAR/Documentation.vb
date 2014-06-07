Public Class Documentation

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemFileClose.Click
        Me.Close()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click, ToolStripMenuItemNavBack.Click
        WebBrowser.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem.Click, ToolStripMenuItemNavForward.Click
        WebBrowser.GoForward()
    End Sub

    Private Sub Documentation_Load(sender As Object, e As EventArgs) Handles MyBase.Load, FrontPgaeToolStripMenuItem.Click, ToolStripMenuItemNavHome.Click
        StatusText_timer.Start()
        WebBrowser.Navigate("https://github.com/CampusTools/LWAR/wiki")
    End Sub

    Private Sub FrontPgaeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrontPgaeToolStripMenuItem.Click, ToolStripButtonHome.Click
        WebBrowser.Navigate("https://github.com/CampusTools/LWAR/wiki")
    End Sub

    Private Sub StatusText_timer_Tick(sender As Object, e As EventArgs) Handles StatusText_timer.Tick
        StatusText_label.Text = WebBrowser.StatusText
    End Sub

    Private Sub PagesIndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagesIndexToolStripMenuItem.Click, ToolStripMenuItemNavPagesIndex.Click
        WebBrowser.Navigate("https://github.com/CampusTools/LWAR/wiki/Pages-index")
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser.Navigating
        ToolStripProgressBar1.Visible = True
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser.DocumentCompleted
        ToolStripTxtURL.Text = WebBrowser.Url.ToString
        PageTitle.Text = WebBrowser.DocumentTitle
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click, ToolStripButtonRefresh.Click
        WebBrowser.Refresh(WebBrowserRefreshOption.Completely)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButtonStop.Click
        WebBrowser.Stop()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        WebBrowser.Navigate(ToolStripTxtURL.Text)
    End Sub
End Class