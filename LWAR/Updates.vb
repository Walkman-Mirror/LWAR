'DogeCoin-Live is a simple DogeCoin read-only wallet with other features too.
'   Copyright (C) 2014  DeavmiOSS

'   This program is free software: you can redistribute it and/or modify
'   it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.

'   This program is distributed in the hope that it will be useful,
'   but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.

'   You should have received a copy of the GNU General Public License
'   along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
'   Contact the DeavmiOSS orginization by electronic mail: mailto:tristankildaire@gmail.com or mailto:walkman100@gmail.com
'   Contact the DeavmiOSS orginization by paper mail: <no info>

Public Class Updates

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Done_button.Click
        Me.Close()
    End Sub

    Private Sub Start()
        WebBrowser1.Navigate("https://CampusTools.github.io/LWAR/current_version.txt")
    End Sub
    Private Sub Updates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        your_version_text.Text = "Your version: v" & My.Application.Info.Version.ToString
        Start()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'This is probably bad
        WebBrowser1.Refresh(WebBrowserRefreshOption.Completely)
        ReadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CheckForUpdates_button.Click
        If CheckForUpdates_button.Text = "&Check for updates" Then
            Start()
        Else
            Downloader.RunWorkerAsync()
        End If
    End Sub

    Public updatestatus As String = "False"

    Private Sub ReadData()
        your_version_text.Text = "Your version: v" & My.Application.Info.Version.ToString
        online_version_text.Text = "Online version: v" & WebBrowser1.Document.Body.InnerText.ToString
        If WebBrowser1.Document.Body.InnerText.ToString > My.Application.Info.Version.ToString Then
            MsgBox("Update available!", MsgBoxStyle.Information)
            CheckForUpdates_button.Text = "&Install updates"
            updatestatus = "True"
        Else
            MsgBox("No updates available!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Downloader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Downloader.DoWork
        My.Computer.Network.DownloadFile("https://CampusTools.github.io/LWAR/LWAR-Updater.exe", "LWAR-Updater.exe", False, False, False, connectionTimeout:=My.Settings.LWAR_ENVIRONMENT_Updates_DownloadUpdaterConnectionTimeout, overwrite:=True)
    End Sub

    Private Sub Downloader_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Downloader.RunWorkerCompleted
        MsgBox("Click Ok to download and install the updates.")
        Process.Start("LWAR-Updater.exe")
        Application.Exit()
    End Sub
End Class