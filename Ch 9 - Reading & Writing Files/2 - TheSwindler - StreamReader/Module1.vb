Option Explicit On
Option Strict On

Imports System.IO


Module Module1

    Sub Main()
        Dim programDirectory As String = Reflection.Assembly.GetExecutingAssembly().Location
        programDirectory = Path.GetDirectoryName(programDirectory)

        SwindlerAction(programDirectory)
        SwindlerLeaked(programDirectory)
    End Sub

    Private Sub SwindlerAction(ByVal programDirectory As String)
        Dim sw As New StreamWriter(programDirectory & "\secret_plan.txt")
        With sw
            .WriteLine("How I'll defeat Captain Amazing")
            .WriteLine("Another genius secret plan by The Swindler")
            .Write("I'll create an army of clones and ")
            .WriteLine("unleash them upon the citizens of Objectville.")
        End With

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

    Private Sub SwindlerLeaked(ByVal programDirectory As String)
        ' Dim folder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim folder As String = programDirectory
        Dim reader As New StreamReader(folder & "\secret_plan.txt")
        Dim writer As New StreamWriter(folder & "\emailToCaptainAmazing.txt")

        With writer
            .WriteLine("To: CaptainAmazing@objectville.net")
            .WriteLine("From: Commissioner@objectville.net")
            .WriteLine("Subject: Can you save the day ... again?")
            .WriteLine()
            .WriteLine("We've discovered the Swindler's plan:")
        End With

        While Not reader.EndOfStream
            Dim lineFromThePlan As String = reader.ReadLine
            writer.WriteLine("The plan -> " & lineFromThePlan)
        End While

        With writer
            .WriteLine()
            .WriteLine("Can you help us?")
        End With

        writer.Close()
        reader.Close()
    End Sub
End Module
