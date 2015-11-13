Option Explicit On
Option Strict On

Imports System.IO

Public Class Form1
    Private currentExcuse As New Excuse()
    Private selectedFolder As String = Application.StartupPath
    Private random As New Random()
    Private formChanged As Boolean = False

    Private Const STRING_FILTER As String = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadControls()
        currentExcuse.LastUsed = lastUsed.Value
    End Sub

    Private Sub LoadControls()
        save.Enabled = False
        open.Enabled = False
        randomExcuse.Enabled = False
    End Sub

    Private Sub EnableControls()
        save.Enabled = True
        open.Enabled = True
        randomExcuse.Enabled = True
    End Sub

    Private Sub UpdateForm(ByVal changed As Boolean)
        Text = "Excuse Manager"

        If Not changed Then
            description.Text = currentExcuse.Description
            results.Text = currentExcuse.Results
            lastUsed.Value = currentExcuse.LastUsed

            If (Not String.IsNullOrEmpty(currentExcuse.ExcusePath)) Then
                fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString()
            End If
        Else
            Text &= "*"
        End If
        formChanged = changed
    End Sub

    Private Function ContinueWithExcuse() As Boolean
        If formChanged Then
            Dim result As DialogResult = MessageBox.Show("The current excuse has not been saved. Continue?", "Warning",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then Return False
        End If

        Return True
    End Function

    Private Function FileName() As String
        Return currentExcuse.Description & ".txt"
    End Function


    Private Sub folder_Click(sender As Object, e As EventArgs) Handles folder.Click
        Dim folderBrowser As New FolderBrowserDialog()
        With folderBrowser
            .Description = "Browse for Folder"
            .SelectedPath = selectedFolder
        End With

        If folderBrowser.ShowDialog = DialogResult.OK Then
            selectedFolder = folderBrowser.SelectedPath
            EnableControls()
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If (String.IsNullOrEmpty(description.Text) OrElse String.IsNullOrEmpty(results.Text)) Then
            MessageBox.Show("Please specify an excuse and a result", "Unable to save",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim saveDialog As New SaveFileDialog()
            With saveDialog
                .InitialDirectory = selectedFolder
                .FileName = FileName()
                .Filter = STRING_FILTER
            End With

            If saveDialog.ShowDialog = DialogResult.OK Then
                currentExcuse.Save(saveDialog.FileName)
                UpdateForm(False)
                MessageBox.Show("Excuse Written")
            End If
        End If
    End Sub

    Private Sub open_Click(sender As Object, e As EventArgs) Handles open.Click
        If Not ContinueWithExcuse() Then Exit Sub

        Dim openDialog = New OpenFileDialog
        With openDialog
            .InitialDirectory = selectedFolder
            .FileName = FileName()
            .Filter = STRING_FILTER
        End With

        If openDialog.ShowDialog = DialogResult.OK Then
            currentExcuse = New Excuse(openDialog.FileName)
            currentExcuse.OpenFile(openDialog.FileName)
            UpdateForm(False)
        End If
    End Sub

    Private Sub randomExcuse_Click(sender As Object, e As EventArgs) Handles randomExcuse.Click
        If Not ContinueWithExcuse() Then Exit Sub

        currentExcuse = New Excuse(selectedFolder, random)
        currentExcuse.OpenFile(currentExcuse.ExcusePath)
        UpdateForm(False)
    End Sub


    Private Sub description_TextChanged(sender As Object, e As EventArgs) Handles description.TextChanged
        currentExcuse.Description = description.Text
        UpdateForm(True)
    End Sub

    Private Sub results_TextChanged(sender As Object, e As EventArgs) Handles results.TextChanged
        currentExcuse.Results = results.Text
        UpdateForm(True)
    End Sub

    Private Sub lastUsed_ValueChanged(sender As Object, e As EventArgs) Handles lastUsed.ValueChanged
        currentExcuse.LastUsed = lastUsed.Value
        UpdateForm(True)
    End Sub


End Class
