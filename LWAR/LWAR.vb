Public Class LWAR
    Dim MeVisibility As Boolean = True
    Private Sub QuitLWAR(sender As Object, e As EventArgs) Handles QuitLWARToolStripMenuItem.Click, btnCancel.Click, NotificationContextQuit.Click
        Application.Exit()
    End Sub

    Private Sub ShowOrHideLWAR(sender As Object, e As EventArgs) Handles btnHide.Click, NotificationContextShowHide.Click
        If MeVisibility = True Then
            Me.Hide()
            NotifyIcon.Visible = True
            NotificationContextShowHide.Text = "Show LWAR"
            'NotificationContextShowHide.Image = "LWAR.My.Resources.Resources.eye_shown" 'Can't seem to get this to work, not important tho
            MeVisibility = False
        Else
            Me.Show()
            'NotifyIcon.Visible = False  'Uncomment this to make the systray icon hide when showing LWAR
            NotificationContextShowHide.Text = "Hide LWAR"
            'NotificationContextShowHide.Image = "LWAR.My.Resources.Resources.eye_hidden"
            MeVisibility = True
        End If
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

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialogBrowse.ShowDialog()
        txtFile.Text = OpenFileDialogBrowse.FileName.ToString()
    End Sub

    Private Sub StartLWAR(sender As Object, e As EventArgs) Handles btnStart.Click
        'start program
    End Sub

    Private Sub ShowAboutLWAR(sender As Object, e As EventArgs) Handles AboutLWARToolStripMenuItem.Click
        'Show about window
    End Sub

    Private Sub OpenPreferences(sender As Object, e As EventArgs) Handles NotificationContextPreferences.Click, PreferencesToolStripMenuItem.Click
        MsgBox("Preferences window is a WIP at the moment.", MsgBoxStyle.Information, "Preferences Window [WIP]") 'Show preferences window
    End Sub

End Class
