Imports System.IO
Imports System.Reflection

Public Class Form1
    Private Sub ElegantThemeButton5_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        If Directory.Exists(ElegantThemeTextBox1.Text) Then

        Else
            lblStatus.Text = "ProfitTailer-verzeichnis existiert nicht. Bitte in den Settings anpassen..."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblStatus.Text = My.Settings.PTpath
    End Sub
End Class