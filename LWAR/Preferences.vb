Public Class Preferences

    Private Sub ResetSettings(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Reset()
        MsgBox("LWAR will now restart! Please click Ok.")
        Application.Restart()
    End Sub

    Private Sub Done(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.IconOnStartup = chkBoxIconShowOnStartup.Checked
        My.Settings.IconHideOnShowLWAR = chkBoxHideIconWhenShowLWAR.Checked
        My.Settings.RememberStartContents = chkBoxRememberStartContents.Checked
        My.Settings.AutoAssignUsername = chkAutoAssignUserName.Checked
        My.Settings.BetaUpdateChannel = chkBetaUpdateChannel.checked
        My.Settings.Save()
        If LWAR.Visible = True Then If My.Settings.IconHideOnShowLWAR = True Then LWAR.NotifyIcon.Visible = False Else LWAR.NotifyIcon.Visible = True
        Me.Close()
    End Sub

    Private Sub Apply(sender As Object, e As EventArgs) Handles Button2.Click
        If LWAR.Visible = True Then If My.Settings.IconHideOnShowLWAR = True Then LWAR.NotifyIcon.Visible = False Else LWAR.NotifyIcon.Visible = True
    End Sub
End Class