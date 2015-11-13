Option Strict On
Option Explicit On

Public Class Form1
    Dim lucinda As New Elephant() With {.Name = "Lucinda", .EarSize = 33}
    Dim lloyd As New Elephant() With {.Name = "Lloyd", .EarSize = 40}

    Private Sub btnLloyd_Click(sender As Object, e As EventArgs) Handles btnLloyd.Click
        lloyd.WhoAmI()
    End Sub

    Private Sub btnLucinda_Click(sender As Object, e As EventArgs) Handles btnLucinda.Click
        lucinda.WhoAmI()
    End Sub

    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        Dim swap As Elephant = lloyd
        lloyd = lucinda
        lucinda = swap
        swap = Nothing
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        lloyd.TellMe("Hi", lucinda)
        lloyd.SpeakTo(lucinda, "Hello")

        lloyd = lucinda
        lloyd.EarSize = 4321
        lloyd.WhoAmI()
    End Sub
End Class
