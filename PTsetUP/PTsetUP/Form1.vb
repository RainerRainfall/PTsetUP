Imports System.IO
Imports System.Reflection

Public Class Form1
    Private Sub ElegantThemeButton5_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        If Directory.Exists(tbPTPath.Text) Then
            lblStatus.Text = "Lese PAIRS.properties..."
        Else
            lblStatus.Text = "ProfitTailer-verzeichnis existiert nicht. Bitte in den Settings anpassen..."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbPTPath.Text = My.Settings.PTpath
        If Directory.Exists(tbPTPath.Text) Then
            lblStatus.Text = "Ready..."
        Else
            lblStatus.Text = "ProfitTailer-verzeichnis existiert nicht. Bitte in den Settings anpassen..."
        End If
    End Sub

    Private Sub ElegantThemeButton1_Click(sender As Object, e As EventArgs) Handles ElegantThemeButton1.Click
        Dim DirectoryBrowser As System.Windows.Forms.FolderBrowserDialog
        DirectoryBrowser = New System.Windows.Forms.FolderBrowserDialog
        DirectoryBrowser.Description = "Bitte Profittrailer Hauptverzeichnis angeben..."
        If (DirectoryBrowser.ShowDialog() = DialogResult.OK) Then
            tbPTPath.Text = DirectoryBrowser.SelectedPath
            My.Settings.PTpath = DirectoryBrowser.SelectedPath
            My.Settings.Save()
        End If
    End Sub

End Class