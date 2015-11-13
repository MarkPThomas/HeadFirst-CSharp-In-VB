Option Explicit On
Option Strict On

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable>
Public Class Excuse
    Public Const EXCUSE_FILE_EXTENSION As String = ".excuse"
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
        Dim files() As String = Directory.GetFiles(directoryExcuses, "*" & EXCUSE_FILE_EXTENSION, SearchOption.TopDirectoryOnly)
        ExcusePath = files(random.Next(files.Length))
    End Sub

    Public Sub OpenFile(ByVal path As String)
        ExcusePath = path

        Dim fileExcuse As Excuse
        Dim bf As New BinaryFormatter()
        Using input As Stream = File.OpenRead(path)
            fileExcuse = DirectCast(bf.Deserialize(input), Excuse)
        End Using

        Description = fileExcuse.Description
        Results = fileExcuse.Results
        LastUsed = fileExcuse.LastUsed
    End Sub

    Public Sub Save(ByVal path As String)
        Dim bf As New BinaryFormatter()
        Using output As Stream = File.Create(path)
            bf.Serialize(output, Me)
        End Using
    End Sub
End Class
