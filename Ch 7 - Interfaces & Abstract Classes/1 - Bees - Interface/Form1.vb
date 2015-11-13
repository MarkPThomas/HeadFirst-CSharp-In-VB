Option Strict On
Option Explicit On

Public Class Form1
    Private queen As Queen

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        workerBeeJob.SelectedIndex = 0
        Dim workers(3) As Worker
        workers(0) = New Worker(New String() {"Nectar Collector", "Honey Manufacturing"}, 175)
        workers(1) = New Worker(New String() {"Egg Care", "Baby Bee Tutoring"}, 114)
        workers(2) = New Worker(New String() {"Hive Maintenance", "Sting Patrol"}, 149)
        workers(3) = New Worker(New String() {"Nectar Collector", "Honey Manufacturing",
                                                "Egg Care", "Baby Bee Tutoring",
                                                "Hive Maintenance", "Sting Patrol"}, 155)

        queen = New Queen(workers, 275)
    End Sub

    Private Sub assignJob_Click(sender As Object, e As EventArgs) Handles assignJob.Click
        If Not queen.AssignWork(workerBeeJob.Text, CInt(shifts.Value)) Then
            MessageBox.Show("No workers are available to do the job `" &
                            workerBeeJob.Text & "`", "The queen bee says ...")
        Else
            MessageBox.Show("The job `" & workerBeeJob.Text & "` will be done in " &
                            shifts.Value & " shifts", "The queen bee says ...")
        End If
    End Sub

    Private Sub nextShift_Click(sender As Object, e As EventArgs) Handles nextShift.Click
        report.Text = queen.WorkTheNextShift()
    End Sub
End Class
