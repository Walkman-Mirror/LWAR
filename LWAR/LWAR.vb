﻿Public Class LWAR

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
        txtFile.Text = OpenFileDialogBrowse.FileName.ToString()
    End Sub

    'open webpages

    Private Sub OpenLWARProjectSite(sender As Object, e As EventArgs) Handles ProjectsSiteToolStripMenuItem.Click
        Process.Start("http://campustools.github.io/LWAR")
    End Sub

    Private Sub OpenSourceCode(sender As Object, e As EventArgs) Handles SourceCodeToolStripMenuItem.Click
        Process.Start("https://github.com/CampusTools/LWAR")
    End Sub

    Private Sub SubmitFeedback(sender As Object, e As EventArgs) Handles SubmitFeedbackToolStripMenuItem.Click
        Process.Start("https://github.com/CampusTools/LWAR/issues/new")
    End Sub

    'run process

    Private Sub StartFromNotificationContext(sender As Object, e As EventArgs) Handles NotificationContextStart.Click
        OpenFileDialogBrowse.ShowDialog() 'can i ask wtf this does? how does it run the program? matthew
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
                NotifyIcon.ShowBalloonTip(10000, "LWAR", "Starting '" & txtFile.Text.ToString & "' as '" & txtUsername.Text.ToString & "' ...", ToolTipIcon.Info)
                Try
                    'Process.Start(txtFile.Text.ToString, userName:=txtUsername.Text.ToString, password:=txtPassword.Text.ToString)
                Catch ex As Exception
                    MsgBox("There was a problem with starting the program!", MsgBoxStyle.Exclamation)
                End Try
            Else
                NotifyIcon.ShowBalloonTip(10000, "LWAR", "Starting '" & txtFile.Text.ToString & "' as '" & txtUsername.Text.ToString & "' on domain '" & txtDomain.Text.ToString & "' ...", ToolTipIcon.Info)
                Try
                    ' Process.Start(txtFile.Text.ToString, txtUsername.Text.ToString, txtPassword.Text.ToString, txtDomain.Text.ToString)
                Catch ex As Exception
                    MsgBox("There was a problem with starting the program!", MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub

    'field management

    Private Sub LoadLWAR(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Shown
        If My.Settings.IconOnStartup = True Then NotifyIcon.Visible = True
        If My.Settings.RememberStartContents = True Then
            txtUsername.Text = My.Settings.Username.ToString 'wtf is ToString
            txtPassword.Text = My.Settings.Password.ToString
            txtDomain.Text = My.Settings.Domain.ToString
            txtFile.Text = My.Settings.File.ToString
        End If
        If My.Settings.AutoAssignUsername = True Then txtUsername.Text = My.User.Name.ToString
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
