Imports System.Windows.Forms

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub trackBar1_Scroll(sender As Object, e As EventArgs)





    End Sub
End Class
