Imports System.IO
Public Class LWAR
    Dim strSecurePass As System.Security.SecureString = Nothing     'See Sub LoadSecureString()
    'window control

    Private Sub QuitLWAR(sender As Object, e As EventArgs) Handles btnCancel.Click, NotificationContextQuit.Click, ToolStripMenuItemFileQuit.Click
        Application.Exit()
    End Sub

    Private Sub ShowOrHideLWAR(sender As Object, e As EventArgs) Handles btnHide.Click, NotificationContextShowHide.Click, NotifyIcon.MouseDoubleClick
        If Me.Visible = True Then
            Me.Hide()
            NotifyIcon.Visible = True
            NotificationContextShowHide.Text = "&Show LWAR"
            NotificationContextShowHide.Image = My.Resources.eye_shown 'HA! got it to work, after fiddling around for ~30 mins. go follow me on https://twitter.com/Walkman100
            Me.Visible = False
        Else
            Me.Show()
            If My.Settings.IconHideOnShowLWAR = True Then NotifyIcon.Visible = False
            NotificationContextShowHide.Text = "&Hide LWAR"
            NotificationContextShowHide.Image = My.Resources.eye_hidden
            Me.Visible = True
        End If
    End Sub

    'show windows

    Private Sub ShowAboutLWAR(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelpAbout.Click, AboutLWARToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

    Private Sub ShowDocumentation(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click, ToolStripMenuItemHelpDocumentation.Click
        Documentation.Show()
    End Sub

    Private Sub OpenPreferences(sender As Object, e As EventArgs) Handles NotificationContextPreferences.Click, ToolStripMenuItemToolsPreferences.Click, PreferencesToolStripMenuItem.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub CheckForUpdates(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click, ToolStripMenuItemHelpCheckForUpdates.Click
        Updates.ShowDialog()
    End Sub

    Private Sub BrowseForFile(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialogBrowse.ShowDialog()
    End Sub

    Private Sub BrowseForFile_Ok(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialogBrowse.FileOk
        txtFile.Text = OpenFileDialogBrowse.FileName
    End Sub

    'open webpages

    Private Sub OpenLWARProjectSite(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelpProjectsSite.Click
        Process.Start("http://campustools.github.io/LWAR")
    End Sub

    Private Sub OpenSourceCode(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelpSourceCode.Click
        Process.Start("https://github.com/CampusTools/LWAR")
    End Sub

    Private Sub SubmitFeedback(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelpSubmitFeedback.Click
        Process.Start("https://github.com/CampusTools/LWAR/issues/new")
    End Sub

    'run process

    Private Sub StartFromNotificationContext(sender As Object, e As EventArgs) Handles NotificationContextStart.Click
        If txtFile.Text = "" Then
            OpenFileDialogBrowse.ShowDialog()
            Me.Show()
        ElseIf txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please fill in the text fields!", MsgBoxStyle.Critical)
            Me.Show()
        Else
            StartProcess()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartProcess()
    End Sub

    Private Sub StartProcess()
        If My.Settings.RememberStartContents = True Then
            My.Settings.Username = txtUsername.Text
            My.Settings.Password = txtPassword.Text
            My.Settings.Domain = txtDomain.Text
            My.Settings.File = txtFile.Text
        End If
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtFile.Text = "" Then
            MsgBox("Please fill in the text fields!", MsgBoxStyle.Critical)
        ElseIf txtDomain.Text = "" Then
            NotifyIcon.ShowBalloonTip(6000, "LWAR", "Starting '" & txtFile.Text & "' as '" & txtUsername.Text & "' ...", ToolTipIcon.Info)
            Try
                LoadSecureString(txtPassword.Text)
                Process.Start(txtFile.Text, txtUsername.Text, strSecurePass, Nothing)
            Catch ex As Exception
                MsgBox("There was a problem with starting the program!" & vbNewLine & "ERROR: " & ex.ToString, MsgBoxStyle.Exclamation)
            End Try
        Else
            NotifyIcon.ShowBalloonTip(6000, "LWAR", "Starting '" & txtFile.Text & "' as '" & txtUsername.Text & "' on domain '" & txtDomain.Text & "' ...", ToolTipIcon.Info)
            Try
                LoadSecureString(txtPassword.Text)
                Process.Start(txtFile.Text, txtUsername.Text, strSecurePass, txtDomain.Text)
            Catch ex As Exception
                MsgBox("There was a problem with starting the program!" & vbNewLine & "ERROR: " & ex.ToString, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    'adapted from http://bytes.com/topic/visual-basic-net/answers/609857-how-set-value-securestring
    ' - also (but not much) http://msdn.microsoft.com/en-us/library/system.security.securestring(v=vs.110).aspx?cs-save-lang=1&cs-lang=vb#code-snippet-1
    Public Shared Function LoadSecureString(ByVal input As String) As System.Security.SecureString()
        'LoadSecureString = Nothing                                 'original line
        'Dim strSecurePass As System.Security.SecureString = Nothing 'line from @Walkman's brain
        '     --  COMMENTED OUT BECAUSE IT HAS TO BE AT THE BEGINNING OF THE PROGRAM  --

        If Not String.IsNullOrEmpty(input) Then
            'LoadSecureString = New System.Security.SecureString    'original line
            LWAR.strSecurePass = New System.Security.SecureString   'line from @Walkman's brain

            For Each character As Char In input.ToCharArray
                'LoadSecureString.AppendChar(character)             'original line
                LWAR.strSecurePass.AppendChar(character)            'line from @Walkman's brain

            Next
            'LoadSecureString.MakeReadOnly()                        'original line
            LWAR.strSecurePass.MakeReadOnly()                       'line from @Walkman's brain
        End If
    End Function

    'field management & settings

    Private Sub LoadLWAR(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Shown
        If My.Settings.IconOnStartup = True Then NotifyIcon.Visible = True
        If My.Settings.RememberStartContents = True Then
            txtUsername.Text = My.Settings.Username
            txtPassword.Text = My.Settings.Password
            txtDomain.Text = My.Settings.Domain
            txtFile.Text = My.Settings.File
        End If
        If My.Settings.AutoAssignUsername = True Then txtUsername.Text = My.User.Name
        If My.Settings.ShowPassword = True Then txtPassword.PasswordChar = "" Else txtPassword.PasswordChar = "●"
        If My.Settings.Logging = True Then
            'Thank to DotNetPerls for this below code. Page reference: <"http://www.dotnetperls.com/streamwriter-vbnet">
            Using logger As StreamWriter = New StreamWriter(My.Settings.LogTextFile)
                logger.writeline("[" & DateTime.Today & "]" & "LWAR has started!")
            End Using
        End If
    End Sub

    Private Sub ClearFields(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtDomain.Text = ""
        txtFile.Text = ""
    End Sub

    Private Sub UsernameChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If My.Settings.RememberStartContents = True Then
            My.Settings.Username = txtUsername.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub PasswordChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If My.Settings.RememberStartContents = True Then
            My.Settings.Password = txtPassword.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub DomainChanged(sender As Object, e As EventArgs) Handles txtDomain.TextChanged
        If My.Settings.RememberStartContents = True Then
            My.Settings.Domain = txtDomain.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub FileChanged(sender As Object, e As EventArgs) Handles txtFile.TextChanged
        If My.Settings.RememberStartContents = True Then
            My.Settings.File = txtFile.Text
            My.Settings.Save()
        End If
    End Sub

End Class