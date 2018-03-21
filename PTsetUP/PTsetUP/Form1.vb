Imports System.IO

Public Class Form1
    Private Sub ElegantThemeButton5_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        If Directory.Exists(ElegantThemeTextBox1.Text) Then
        Else
            lblStatus.Text = "ProfitTailer-verzeichnis existiert nicht. Bitte in den Settings anpassen..."
        End If
    End Sub
End Class