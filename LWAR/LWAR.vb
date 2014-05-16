Public Class LWAR
    Dim MeVisibility As Boolean = True
    Private Sub LoadLWAR(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Shown
        If My.Settings.IconOnStartup = True Then NotifyIcon.Visible = True
        If My.Settings.RememberStartContents = True Then
            txtUsername.Text = My.Settings.Username
            txtPassword.Text = My.Settings.Password
            txtDomain.Text = My.Settings.Domain
            txtFile.Text = My.Settings.File
        Else
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtDomain.Text = ""
            txtFile.Text = ""
        End If
    End Sub

    Private Sub QuitLWAR(sender As Object, e As EventArgs) Handles btnCancel.Click, NotificationContextQuit.Click
        Application.Exit()
    End Sub

    Private Sub ShowOrHideLWAR(sender As Object, e As EventArgs) Handles btnHide.Click, NotificationContextShowHide.Click
        If MeVisibility = True Then
            Me.Hide()
            NotifyIcon.Visible = True
            NotificationContextShowHide.Text = "Show LWAR"
            NotificationContextShowHide.Image = My.Resources.eye_shown 'HA! got it to work, after fiddling around for ~30 mins. go follow me on http://twitter.com/Walkman100
            MeVisibility = False
        Else
            Me.Show()
            If My.Settings.IconHideOnShowLWAR = True Then NotifyIcon.Visible = False
            NotificationContextShowHide.Text = "Hide LWAR"
            NotificationContextShowHide.Image = My.Resources.eye_hidden
            MeVisibility = True
        End If
    End Sub

    Private Sub ShowDocumentation(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        'Show Documentation, URl??
    End Sub
    Private Sub OpenLWARProjectSite(sender As Object, e As EventArgs)
        Process.Start("http://campustools.github.io/LWAR")
    End Sub

    Private Sub OpenSourceCode(sender As Object, e As EventArgs)
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
        If My.Settings.RememberStartContents = True Then
            My.Settings.Username = txtUsername.Text
            My.Settings.Password = txtPassword.Text
            My.Settings.Domain = txtDomain.Text
            My.Settings.File = txtFile.Text
        End If

        'start program
    End Sub

    Private Sub ShowAboutLWAR(sender As Object, e As EventArgs)
        'Show about window
    End Sub

    Private Sub OpenPreferences(sender As Object, e As EventArgs) Handles NotificationContextPreferences.Click, PreferencesToolStripMenuItem.Click
        Preferences.Show()
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtDomain.Text = ""
        txtFile.Text = ""
    End Sub
End Class
