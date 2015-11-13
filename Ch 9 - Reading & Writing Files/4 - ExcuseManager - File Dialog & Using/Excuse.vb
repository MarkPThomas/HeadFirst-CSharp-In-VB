Option Explicit On
Option Strict On

Imports System.IO

Public Class Excuse
    Public Property Description As String
    Public Property Results As String
    Public Property LastUsed As DateTime
    Public Property ExcusePath As String

    Public Sub New()
        ExcusePath = ""
    End Sub
    Public Sub New(ByVal excusePath As String)
        Me.ExcusePath = excusePath
    End Sub

    Public Sub New(ByVal directoryExcuses As String,
                    ByVal random As Random)
        Dim files() As String = Directory.GetFiles(directoryExcuses, "*.txt", SearchOption.TopDirectoryOnly)
        ExcusePath = files(random.Next(files.Length))
    End Sub

    Public Sub OpenFile(ByVal path As String)
        Using sr As New StreamReader(path)
            Description = sr.ReadLine()
            Results = sr.ReadLine()
            LastUsed = Convert.ToDateTime(sr.ReadLine())
        End Using
    End Sub

    Public Sub Save(ByVal path As String)
        Using sw As New StreamWriter(path)
            sw.WriteLine(Description)
            sw.WriteLine(Results)
            sw.WriteLine(LastUsed)
        End Using
    End Sub
End Class
