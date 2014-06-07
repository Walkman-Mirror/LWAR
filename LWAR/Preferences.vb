Public Class Preferences

    Private Sub ResetSettings(sender As Object, e As EventArgs)     'what is this for? clicking the cancel button resets everything...
        My.Settings.Reset()
        MsgBox("LWAR will now restart! Please click Ok.")   'why
        Application.Restart()   'that akes no sense. why would you have to restart in order to apply settings? that's counter-intuitive. just set them when you click the save button
    End Sub

    Private Sub SaveSettings(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.IconOnStartup = chkIconShowOnStartup.Checked
        My.Settings.IconHideOnShowLWAR = chkIconHideOnShowLWAR.Checked
        My.Settings.RememberStartContents = chkRememberStartContents.Checked
        My.Settings.AutoAssignUsername = chkAutoAssignUsername.Checked
        My.Settings.BetaUpdateChannel = chkBetaUpdateChannel.Checked
        My.Settings.ShowPassword = chkShowPassword.Checked
        My.Settings.Logging = CheckBox1.Checked
        My.Settings.Save()
        If LWAR.Visible = True Then If My.Settings.IconHideOnShowLWAR = True Then LWAR.NotifyIcon.Visible = False Else LWAR.NotifyIcon.Visible = True
        If My.Settings.ShowPassword = True Then LWAR.txtPassword.PasswordChar = "" Else LWAR.txtPassword.PasswordChar = "●"
        Me.Close()
    End Sub

    Private Sub LoadWindow(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        Reset()
        Me.Close()
    End Sub

    Private Sub Reset()
        If My.Settings.IconOnStartup = True Then chkIconShowOnStartup.Checked = True Else chkIconShowOnStartup.Checked = False
        If My.Settings.IconHideOnShowLWAR = True Then chkIconHideOnShowLWAR.Checked = True Else chkIconHideOnShowLWAR.Checked = False
        If My.Settings.RememberStartContents = True Then chkRememberStartContents.Checked = True Else chkRememberStartContents.Checked = False
        If My.Settings.AutoAssignUsername = True Then chkAutoAssignUsername.Checked = True Else chkAutoAssignUsername.Checked = False
        If My.Settings.BetaUpdateChannel = True Then chkBetaUpdateChannel.Checked = True Else chkBetaUpdateChannel.Checked = False
        If My.Settings.ShowPassword = True Then chkShowPassword.Checked = True Else chkShowPassword.Checked = False
        If My.Settings.Logging = True Then CheckBox1.Checked = True Else CheckBox1.Checked = False
    End Sub
End Class