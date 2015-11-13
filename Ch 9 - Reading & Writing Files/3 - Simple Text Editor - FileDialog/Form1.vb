Option Explicit On
Option Strict On

Imports System.IO

Public Class Form1
    Private _name As String

    Private Sub open_Click(sender As Object, e As EventArgs) Handles open.Click
        With openFileDialog1
            .Title = "Open File"
            .InitialDirectory = Application.StartupPath
            .Filter = "Text Files (*.txt)|*.txt"
            .FileName = ""
        End With

        If openFileDialog1.ShowDialog = DialogResult.OK Then
            _name = openFileDialog1.FileName
            textBox1.Clear()
            textBox1.Text = File.ReadAllText(_name)
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        With saveFileDialog1
            .Title = "Save File"
            .InitialDirectory = Application.StartupPath
            .Filter = "Text Files (*.txt)|*.txt"
        End With

        If saveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim saveName As String = saveFileDialog1.FileName

            File.WriteAllText(saveName, textBox1.Text)
        End If
    End Sub
End Class
