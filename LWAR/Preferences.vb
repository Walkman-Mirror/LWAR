Public Class Preferences

    Private Sub LoadPreferences(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Enviro_IconOnStartup = True Then chkBoxIconShowOnStartup.Checked = True Else chkBoxIconShowOnStartup.Checked = False
        If My.Settings.Enviro_IconHideOnShowLWAR = True Then chkBoxHideIconWhenShowLWAR.Checked = True Else chkBoxHideIconWhenShowLWAR.Checked = False
        If My.Settings.Enviro_RememberStartContents = True Then chkBoxRememberStartContents.Checked = True Else chkBoxRememberStartContents.Checked = False
    End Sub

    Private Sub SavePreferences(sender As Object, e As EventArgs) Handles btnPrefSave.Click
        My.Settings.Enviro_IconOnStartup = chkBoxIconShowOnStartup.Checked
        My.Settings.Enviro_IconHideOnShowLWAR = chkBoxHideIconWhenShowLWAR.Checked
        My.Settings.Enviro_RememberStartContents = chkBoxRememberStartContents.Checked
        My.Settings.Save()
        Apply()
        Me.Close()
    End Sub

    Private Sub CancelPreferences(sender As Object, e As EventArgs) Handles btnPrefCancel.Click
        If My.Settings.Enviro_IconOnStartup = True Then chkBoxIconShowOnStartup.Checked = True Else chkBoxIconShowOnStartup.Checked = False
        If My.Settings.Enviro_IconHideOnShowLWAR = True Then chkBoxHideIconWhenShowLWAR.Checked = True Else chkBoxHideIconWhenShowLWAR.Checked = False
        If My.Settings.Enviro_RememberStartContents = True Then chkBoxRememberStartContents.Checked = True Else chkBoxRememberStartContents.Checked = False
    End Sub

    Private Sub btnPrefReset_Click(sender As Object, e As EventArgs) Handles btnPrefReset.Click
        My.Settings.Reset()
        Apply()
    End Sub

    Private Sub Apply()
        If LWAR.Visible = True Then If My.Settings.Enviro_IconHideOnShowLWAR = True Then LWAR.NotifyIcon.Visible = False Else LWAR.NotifyIcon.Visible = True
    End Sub
End Class