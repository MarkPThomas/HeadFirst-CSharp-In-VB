Option Strict On
Option Explicit On

Public Class Queen
    Inherits Bee

    Private workers As Worker()
    Private shiftNumber As Integer = 0


    Public Sub New(ByVal workers As Worker(),
                   ByVal weightMG As Double)
        MyBase.New(weightMG)

        Me.workers = workers
    End Sub

    Public Function AssignWork(ByVal job As String,
                               ByVal numberOfShifts As Integer) As Boolean
        For i = 0 To workers.Length - 1
            If workers(i).DoThisJob(job, numberOfShifts) Then Return True
        Next

        Return False
    End Function

    Public Function WorkTheNextShift() As String
        Dim honeyConsumed As Double = HoneyConsumptionRate()

        shiftNumber += 1
        Dim report As String = "Report for shift #" & shiftNumber & vbCrLf
        For i = 0 To workers.Length - 1
            If workers(i).DidYouFinish() Then report &= "Worker #" & (i + 1) & " finished the job" & vbCrLf
            If String.IsNullOrEmpty(workers(i).CurrentJob) Then
                report &= "Worker #" & (i + 1) & " is not working" & vbCrLf
            Else
                If workers(i).ShiftsLeft > 0 Then
                    report &= "Worker #" & (i + 1) & " is doing `" & workers(i).CurrentJob &
                    "` for " & workers(i).ShiftsLeft & " more shifts" & vbCrLf
                Else
                    report &= "Worker #" & (i + 1) & " will be done with `" & workers(i).CurrentJob &
                    "` after this shift" & vbCrLf
                End If
            End If
            honeyConsumed += workers(i).HoneyConsumptionRate
        Next
        report &= "Total honey consumed for the shift: " & honeyConsumed & " units" & vbCrLf

        Return report
    End Function
End Class
