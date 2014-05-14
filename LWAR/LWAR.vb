Public Class LWAR

    Private Sub QuitLWAR(sender As Object, e As EventArgs) Handles QuitLWARToolStripMenuItem.Click, btnCancel.Click
        End
    End Sub

    Private Sub HideLWAR(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()   'How do you show it again?
    End Sub

    Private Sub StartLWAR(sender As Object, e As EventArgs) Handles btnStart.Click
        'start program
    End Sub

    Private Sub ShowDocumentation(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        'Show Documentation, URl??
    End Sub
    Private Sub OpenLWARProjectSite(sender As Object, e As EventArgs) Handles ProjectsiteToolStripMenuItem.Click
        Process.Start("http://campustools.github.io/LWAR")
    End Sub

    Private Sub OpenSourceCode(sender As Object, e As EventArgs) Handles SourcecodeToolStripMenuItem.Click
        Process.Start("http://www.github.com/CampusTools/LWAR")
    End Sub

    Private Sub CheckForUpdates(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Process.Start("http://www.github.com/CampusTools/LWAR/releases")
    End Sub

    Private Sub ShowAboutLWAR(sender As Object, e As EventArgs) Handles AboutLWARToolStripMenuItem.Click
        'Show about window
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        txtFile.Text = MsgBox("Select File: ", MsgBoxStyle.Question, "Browse for a file...")

    End Sub
End Class
