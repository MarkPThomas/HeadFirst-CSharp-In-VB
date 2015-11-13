Option Strict On
Option Explicit On

Public Class TalkerTester
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim len As Integer = Talker.BlahBlahBlah(textBox1.Text, CType(numericUpDown1.Value, Integer))
        MessageBox.Show("The message length is " & len)
    End Sub
End Class
