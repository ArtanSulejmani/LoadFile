Imports System.IO
Public Class Form1
    Private Sub LoadFile_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        OFDReader.ShowDialog()

    End Sub

    Private Sub OFDReader_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OFDReader.FileOk
        If OFDReader.FileName <> "" Then
            Dim Sr As New StreamReader(OFDReader.FileName)

            Do Until Sr.EndOfStream
            txtOutput.Text = txtOutput.Text & Sr.ReadLine & vbCrLf

        Loop

        SR.Close()
        End If
    End Sub
End Class
