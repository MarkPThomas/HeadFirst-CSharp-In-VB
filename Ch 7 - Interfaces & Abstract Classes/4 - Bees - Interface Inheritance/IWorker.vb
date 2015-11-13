Option Strict On
Option Explicit On

Public Interface IWorker
    ReadOnly Property Job As String
    ReadOnly Property ShiftsLeft As Integer
    Sub DoThisJob(ByVal job As String, ByVal shifts As Integer)
    Sub WorkOneShift()
End Interface
