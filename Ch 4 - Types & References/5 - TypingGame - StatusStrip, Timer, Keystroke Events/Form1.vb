Option Strict On
Option Explicit On

Public Class Form1
    Dim random As New Random()
    Dim stats As New Stats()

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Add a random key to the listbox
        listBox1.Items.Add(CType(random.Next(65, 90), Keys))
        If listBox1.Items.Count > 7 Then
            listBox1.Items.Clear()
            listBox1.Items.Add("Game Over")
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, listBox1.KeyDown
        ' If the user pressed a key that's in the ListBox, remove it
        ' And then make the game a little faster
        If listBox1.Items.Contains(e.KeyCode) Then
            listBox1.Items.Remove(e.KeyCode)
            listBox1.Refresh()

            If Timer1.Interval > 400 Then Timer1.Interval -= 10
            If Timer1.Interval > 250 Then Timer1.Interval -= 7
            If Timer1.Interval > 100 Then Timer1.Interval -= 2

            difficultyProgressBar.Value = 800 - Timer1.Interval

            ' The user pressed a correct key, so updates the Stats object
            ' by calling its Update() method with the argument true
            stats.Update(True)
        Else
            ' The user pressed am incorrect key, so update the Stats object
            ' by calling its Update() method with the argument false
            stats.Update(False)
        End If

        ' Update the labels on the StatusStrip
        correctLabel.Text = "Correct: " & stats.Correct
        missedLabel.Text = "Missed: " & stats.Missed
        totalLabel.Text = "Total: " & stats.Total
        accuracyLabel.Text = "Accuracy: " & stats.Accuracy & "%"
    End Sub
End Class
