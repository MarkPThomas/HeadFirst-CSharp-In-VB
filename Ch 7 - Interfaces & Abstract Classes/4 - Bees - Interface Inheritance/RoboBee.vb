Option Explicit On
Option Strict On

Public Class RoboBee
    Inherits Robot
    Implements IWorker

    Private _shiftsToWork As Integer
    Private _shiftsWorked As Integer

    Private _job As String
    Public Property Job As String Implements IWorker.Job
        Get
            Throw New NotImplementedException()
        End Get
        Private Set(value As String)
            _job = value
        End Set
    End Property

    Public ReadOnly Property ShiftsLeft As Integer Implements IWorker.ShiftsLeft
        Get
            Return _shiftsToWork - _shiftsWorked
        End Get
    End Property

    Public Sub DoThisJob(job As String, shifts As Integer) Implements IWorker.DoThisJob
        Throw New NotImplementedException()
    End Sub

    Public Sub WorkOneShift() Implements IWorker.WorkOneShift
        Throw New NotImplementedException()
    End Sub
End Class
