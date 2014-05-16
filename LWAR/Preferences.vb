Public Class Preferences

    Private Sub LoadPreferences(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.IconOnStartup = True Then chkBoxIconShowOnStartup.Checked = True Else chkBoxIconShowOnStartup.Checked = False
        If My.Settings.IconHideOnShowLWAR = True Then chkBoxHideIconWhenShowLWAR.Checked = True Else chkBoxHideIconWhenShowLWAR.Checked = False
        If My.Settings.RememberStartContents = True Then chkBoxRememberStartContents.Checked = True Else chkBoxRememberStartContents.Checked = False
    End Sub

    Private Sub SavePreferences(sender As Object, e As EventArgs) Handles btnPrefSave.Click
        My.Settings.IconOnStartup = chkBoxIconShowOnStartup.Checked
        My.Settings.IconHideOnShowLWAR = chkBoxHideIconWhenShowLWAR.Checked
        My.Settings.RememberStartContents = chkBoxRememberStartContents.Checked
        My.Settings.Save()
        'Isn't there meant to be an "End If" after this (ABSOLUTE MINDFUCK, NIGGA HOW YOU GOT THIS CORRECT, DAMN  I DON'T KNOW, LOL ;P)
        If LWAR.Visible = True Then If My.Settings.IconHideOnShowLWAR = True Then LWAR.NotifyIcon.Visible = False Else LWAR.NotifyIcon.Visible = True
        Me.Close()
    End Sub

    Private Sub CancelPreferences(sender As Object, e As EventArgs) Handles btnPrefCancel.Click
        If My.Settings.IconOnStartup = True Then chkBoxIconShowOnStartup.Checked = True Else chkBoxIconShowOnStartup.Checked = False
        If My.Settings.IconHideOnShowLWAR = True Then chkBoxHideIconWhenShowLWAR.Checked = True Else chkBoxHideIconWhenShowLWAR.Checked = False
        If My.Settings.RememberStartContents = True Then chkBoxRememberStartContents.Checked = True Else chkBoxRememberStartContents.Checked = False
    End Sub

    Private Sub btnPrefReset_Click(sender As Object, e As EventArgs) Handles btnPrefReset.Click
        My.Settings.Reset()
    End Sub
End Class