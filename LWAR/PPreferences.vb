Public Class PPreferences

    Private Sub PPreferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Reset()
        MsgBox("LWAR will now restart! Please click Ok.")
        Application.Restart()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.IconOnStartup = chkBoxIconShowOnStartup.Checked
        My.Settings.IconHideOnShowLWAR = chkBoxHideIconWhenShowLWAR.Checked
        My.Settings.RememberStartContents = chkBoxRememberStartContents.Checked
        My.Settings.AutoAssignUsername = chkAutoAssignUserName.Checked
        My.Settings.Save()
        If LWAR.Visible = True Then If My.Settings.IconHideOnShowLWAR = True Then LWAR.NotifyIcon.Visible = False Else LWAR.NotifyIcon.Visible = True
        Me.Close()
    End Sub
End Class