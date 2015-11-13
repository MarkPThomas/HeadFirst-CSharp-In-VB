Option Explicit On
Option Strict On

Imports System.IO


Module Module1

    Sub Main()
        Dim programDirectory As String = Reflection.Assembly.GetExecutingAssembly().Location
        programDirectory = Path.GetDirectoryName(programDirectory)

        Dim sw As New StreamWriter(programDirectory & "\secret_plan.txt")
        sw.WriteLine("How I'll defeat Captain Amazing")
        sw.WriteLine("Another genius secret plan by The Swindler")
        sw.Write("I'll create an army of clones and ")
        sw.WriteLine("unleash them upon the citizens of Objectville.")

        Dim location As String = "the mall"
        For number = 0 To 6
            sw.WriteLine("Clone #{0} attacks {1}", number, location)
            If location = "the mall" Then
                location = "downtown"
            Else
                location = "the mall"
            End If
        Next

        sw.Close()
    End Sub

End Module
