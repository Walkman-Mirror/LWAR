Public Class Form1

    Private Sub QuitLWARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitLWARToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancel_button.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles hide_button.Click
        Me.Hide()
    End Sub

    Private Sub start_button_Click(sender As Object, e As EventArgs) Handles start_button.Click

    End Sub
End Class
