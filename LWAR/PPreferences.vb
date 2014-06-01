Public Class PPreferences

    Private Sub PPreferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Reset()
        MsgBox("LWAR will now restart! Please click Ok.")
        Application.Restart()
    End Sub
End Class