Option Strict On
Option Explicit On

Public Class Worker
    Private jobsICanDo As String()
    Private shiftsToWork As Integer
    Private shiftsWorked As Integer

    Public ReadOnly Property ShiftsLeft As Integer
        Get
            Return shiftsToWork - shiftsWorked
        End Get
    End Property

    Private _currentJob As String = ""
    Public ReadOnly Property CurrentJob As String
        Get
            Return _CurrentJob
        End Get
    End Property


    Public Sub New(ByVal jobsICanDo As String())
        Me.jobsICanDo = jobsICanDo
    End Sub

    Public Function DoThisJob(ByVal job As String,
                              ByVal numberOfShifts As Integer) As Boolean
        If Not String.IsNullOrEmpty(CurrentJob) Then Return False

        For i = 0 To jobsICanDo.Length - 1
            If jobsICanDo(i) = job Then
                _currentJob = job
                Me.shiftsToWork = numberOfShifts
                shiftsWorked = 0
                Return True
            End If
        Next

        Return False
    End Function

    Public Function DidYouFinish() As Boolean
        If String.IsNullOrEmpty(CurrentJob) Then Return False

        shiftsWorked += 1
        If shiftsWorked > shiftsToWork Then
            shiftsWorked = 0
            shiftsToWork = 0
            _currentJob = ""
            Return True
        Else
            Return False
        End If
    End Function
End Class
