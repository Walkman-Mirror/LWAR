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
        Me.Hide()
        If LWAR.Visible = True Then If My.Settings.IconHideOnShowLWAR = True Then LWAR.NotifyIcon.Visible = False Else LWAR.NotifyIcon.Visible = True
    End Sub

    Private Sub CancelPreferences(sender As Object, e As EventArgs) Handles btnPrefCancel.Click
        If My.Settings.IconOnStartup = True Then chkBoxIconShowOnStartup.Checked = True Else chkBoxIconShowOnStartup.Checked = False
        If My.Settings.IconHideOnShowLWAR = True Then chkBoxHideIconWhenShowLWAR.Checked = True Else chkBoxHideIconWhenShowLWAR.Checked = False
        If My.Settings.RememberStartContents = True Then chkBoxRememberStartContents.Checked = True Else chkBoxRememberStartContents.Checked = False
        Me.Hide()
    End Sub

End Class