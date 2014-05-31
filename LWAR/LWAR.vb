Public Class LWAR
    Dim strSecurePass As System.Security.SecureString = Nothing     'See Sub LoadSecureString()

    'window control

    Private Sub QuitLWAR(sender As Object, e As EventArgs) Handles btnCancel.Click, NotificationContextQuit.Click, QuitLWARToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ShowOrHideLWAR(sender As Object, e As EventArgs) Handles btnHide.Click, NotificationContextShowHide.Click, NotifyIcon.MouseDoubleClick
        If Me.Visible = True Then
            Me.Hide()
            NotifyIcon.Visible = True
            NotificationContextShowHide.Text = "&Show LWAR"
            NotificationContextShowHide.Image = My.Resources.eye_shown 'HA! got it to work, after fiddling around for ~30 mins. go follow me on http://twitter.com/Walkman100
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

    Private Sub ShowAboutLWAR(sender As Object, e As EventArgs) Handles AboutLWARToolStripMenuItem.Click, AboutLWARToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

    Private Sub ShowDocumentation(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click, DocumentationToolStripMenuItemCurrent.Click
        Documentation.Show()
    End Sub

    Private Sub OpenPreferences(sender As Object, e As EventArgs) Handles NotificationContextPreferences.Click, PreferencesToolStripMenuItemCurrent.Click, PreferencesToolStripMenuItem.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub CheckForUpdates(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click, CheckForUpdatesToolStripMenuItemCurrent.Click
        Updates.ShowDialog()
    End Sub

    Private Sub BrowseForFile(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialogBrowse.ShowDialog()
    End Sub

    Private Sub BrowseForFile_Ok(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialogBrowse.FileOk
        txtFile.Text = OpenFileDialogBrowse.FileName
    End Sub

    'open webpages

    Private Sub OpenLWARProjectSite(sender As Object, e As EventArgs) Handles ProjectsSiteToolStripMenuItem.Click
        Process.Start("https://campustools.github.io/LWAR")
    End Sub

    Private Sub OpenSourceCode(sender As Object, e As EventArgs) Handles SourceCodeToolStripMenuItem.Click
        Process.Start("https://github.com/CampusTools/LWAR")
    End Sub

    Private Sub SubmitFeedback(sender As Object, e As EventArgs) Handles SubmitFeedbackToolStripMenuItem.Click
        Process.Start("https://github.com/CampusTools/LWAR/issues/new")
    End Sub

    'run process

    Private Sub StartFromNotificationContext(sender As Object, e As EventArgs) Handles NotificationContextStart.Click
        OpenFileDialogBrowse.ShowDialog() 'can i ask wtf this does? how does it run the program? matthew REPLY: It is a quick way to choose the file when LWAR is hidden and then fill in the user credentials.
        Me.Show()
    End Sub

    Private Sub StartProcess(sender As Object, e As EventArgs) Handles btnStart.Click
        If My.Settings.RememberStartContents = True Then
            My.Settings.Username = txtUsername.Text
            My.Settings.Password = txtPassword.Text
            My.Settings.Domain = txtDomain.Text
            My.Settings.File = txtFile.Text
        End If
        'Starts user-specified program (Still working on this (Uncomment the code to allow it to be executed at run time.))
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtFile.Text = "" Then
            MsgBox("Please fill in the text fields!", MsgBoxStyle.Critical)
        Else
            If txtDomain.Text = "" Then
                NotifyIcon.ShowBalloonTip(6000, "LWAR", "Starting '" & txtFile.Text & "' as '" & txtUsername.Text & "' ...", ToolTipIcon.Info)
                Try
                    LoadSecureString(txtPassword.Text)
                    Process.Start(txtFile.Text, txtUsername.Text, strSecurePass, Nothing)
                Catch ex As Exception
                    MsgBox("There was a problem with starting the program!" & vbNewLine & "ERROR: " & ex.ToString, MsgBoxStyle.Exclamation)
                End Try
            Else
                NotifyIcon.ShowBalloonTip(6000, "LWAR", "Starting '" & txtFile.Text & "' as '" & txtUsername.Text & "' on domain '" & txtDomain.Text & "' ...", ToolTipIcon.Info)
                'Dim strSecurePass As System.Security.SecureString
                'strSecurePass = txtPassword.Text
                Try
                    LoadSecureString(txtPassword.Text)
                    Process.Start(txtFile.Text, txtUsername.Text, strSecurePass, txtDomain.Text)
                Catch ex As Exception
                    MsgBox("There was a problem with starting the program!" & vbNewLine & "ERROR: " & ex.ToString, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub

    'credits for this function to http://bytes.com/topic/visual-basic-net/answers/609857-how-set-value-securestring
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

    'field management

    Private Sub LoadLWAR(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Shown
        If My.Settings.IconOnStartup = True Then NotifyIcon.Visible = True
        If My.Settings.RememberStartContents = True Then
            txtUsername.Text = My.Settings.Username
            txtPassword.Text = My.Settings.Password
            txtDomain.Text = My.Settings.Domain
            txtFile.Text = My.Settings.File
        End If
        If My.Settings.AutoAssignUsername = True Then txtUsername.Text = My.User.Name
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
