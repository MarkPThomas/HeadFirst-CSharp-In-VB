Option Strict On
Option Explicit On

Imports System.IO

Public Class Form1
    Private Const EUREKA_FILENAME As String = "eureka.txt"
    Private Const SHALOM_FILENAME As String = "shalom.txt"
    Private Const EUREKA_SHALOM_FILENAME As String = "eureka-shalom.txt"

    Private Sub writeEureka_Click(sender As Object, e As EventArgs) Handles writeEureka.Click
        File.WriteAllText(EUREKA_FILENAME, "Eureka!")
        Dim eurekaBytes() As Byte = File.ReadAllBytes(EUREKA_FILENAME)
        For Each b As Byte In eurekaBytes
            ' Write to console in bytes
            Console.WriteLine("{0}", b)
        Next
        Console.WriteLine()
    End Sub

    Private Sub bytesAsHexNumbers_Click(sender As Object, e As EventArgs) Handles bytesAsHexNumbers.Click
        File.WriteAllText(EUREKA_FILENAME, "Eureka!")
        Dim eurekaBytes() As Byte = File.ReadAllBytes(EUREKA_FILENAME)
        For Each b As Byte In eurekaBytes
            ' Write to console in Hex
            Console.WriteLine("{0:x2}", b)
        Next
        Console.WriteLine()
    End Sub

    Private Sub writeInHebrew_Click(sender As Object, e As EventArgs) Handles writeInHebrew.Click
        File.WriteAllText(SHALOM_FILENAME, "לשלום!")
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        File.WriteAllText(EUREKA_FILENAME, "Eureka!")
        Dim eurekaBytes() As Byte = File.ReadAllBytes(EUREKA_FILENAME)

        File.WriteAllText(SHALOM_FILENAME, "לשלום!")
        Dim shalomBytes() As Byte = File.ReadAllBytes(SHALOM_FILENAME)

        Using writer As New StreamWriter(EUREKA_SHALOM_FILENAME)
            With writer
                .WriteLine("Eureka!")
                .WriteLine()
                .WriteLine("In bytes:")
            End With
            For Each b As Byte In eurekaBytes
                ' Write to console in bytes
                writer.WriteLine("{0}", b)
            Next
            With writer
                .WriteLine()
                .WriteLine("In Hex:")
            End With
            For Each b As Byte In eurekaBytes
                ' Write to console in Hex
                writer.WriteLine("{0:x2}", b)
            Next
            writer.WriteLine()

            With writer
                .WriteLine("לשלום! (Shalom!)")
                .WriteLine()
                .WriteLine("In bytes:")
            End With
            For Each b As Byte In shalomBytes
                ' Write to console in bytes
                writer.WriteLine("{0}", b)
            Next
            With writer
                .WriteLine()
                .WriteLine("In Hex:")
            End With
            For Each b As Byte In shalomBytes
                ' Write to console in Hex
                writer.WriteLine("{0:x2}", b)
            Next
        End Using
    End Sub
End Class
