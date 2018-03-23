Imports System.IO
Imports System.Reflection

Public Class Form1
    Private Sub ElegantThemeButton5_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        If Directory.Exists(tbPTPath.Text) Then
            lblStatus.Text = ""
        Else
            lblStatus.Text = "ProfitTailer-verzeichnis existiert nicht. Bitte in den Settings anpassen..."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbPTPath.Text = My.Settings.PTpath
        tbPTbackup.Text = My.Settings.PTbackup
        tbLogtotxt.Text = My.Settings.LogToTXT
    End Sub
End Class