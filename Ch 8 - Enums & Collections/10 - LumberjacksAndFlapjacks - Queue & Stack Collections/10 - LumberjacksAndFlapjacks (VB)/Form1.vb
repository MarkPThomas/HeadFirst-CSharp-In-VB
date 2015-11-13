Option Strict On
Option Explicit On

Public Class Form1
    Private breakfastLine As New Queue(Of Lumberjack)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RedrawList()
    End Sub

    Private Sub addLumberjack_Click(sender As Object, e As EventArgs) Handles addLumberjack.Click
        If String.IsNullOrEmpty(customerName.Text) Then Exit Sub

        breakfastLine.Enqueue(New Lumberjack(customerName.Text))
        customerName.Text = ""
        RedrawList()
    End Sub

    Private Sub addFlapjacks_Click(sender As Object, e As EventArgs) Handles addFlapjacks.Click
        If breakfastLine.Count = 0 Then Exit Sub
        Dim food As Flapjack

        If crispy.Checked Then
            food = Flapjack.Crispy
        ElseIf soggy.Checked Then
            food = Flapjack.Soggy
        ElseIf browned.Checked Then
            food = Flapjack.Browned
        Else
            food = Flapjack.Banana
        End If

        Dim currentLumberjack As Lumberjack = breakfastLine.Peek()
        currentLumberjack.TakeFlapJacks(food, CType(howMany.Value, Integer))

        RedrawList()
    End Sub

    Private Sub nextLumberjack_Click(sender As Object, e As EventArgs) Handles nextLumberjack.Click
        If breakfastLine.Count = 0 Then Exit Sub
        Dim nextLumberjack As Lumberjack = breakfastLine.Dequeue()

        nextLumberjack.EatFlapjacks()
        nextInLine.Text = ""
        RedrawList()
    End Sub

    Private Sub RedrawList()
        Dim queueNumber As Integer = 1
        line.Items.Clear()

        For Each customer As Lumberjack In breakfastLine
            line.Items.Add(queueNumber & ". " & customer.Name)
        Next

        If breakfastLine.Count = 0 Then
            groupBox1.Enabled = False
            nextInLine.Text = ""
        Else
            groupBox1.Enabled = True
            Dim currentLumberjack As Lumberjack = breakfastLine.Peek()
            nextInLine.Text = currentLumberjack.Name & " has " & currentLumberjack.FlapjackCount & " flapjacks."
        End If

    End Sub
End Class
