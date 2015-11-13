Option Explicit On
Option Strict On

Imports System.IO

Module Module1
    Private Const FILE_BINARY As String = "binarydata.dat"

    Sub Main()
        Dim intValue As Integer = 48769414
        Dim stringValue As String = "Hello!"
        Dim byteArray() As Byte = {47, 129, 0, 116}
        Dim floatValue As Single = 491.695F
        Dim charValue As Char = CChar("E")

        ' Write data out with BinaryWriter
        Using output As FileStream = File.Create(FILE_BINARY),
                writer As New BinaryWriter(output)
            With writer
                .Write(intValue)
                .Write(stringValue)
                .Write(byteArray)
                .Write(floatValue)
                .Write(charValue)
            End With
        End Using

        ' Read data from file to console as Hex
        Dim dataWritten() As Byte = File.ReadAllBytes(FILE_BINARY)
        For Each b As Byte In dataWritten
            Console.WriteLine("{0:x2}", b)
        Next
        Console.WriteLine(" - {0} bytes", dataWritten.Length)

        Console.ReadKey()

        ' Read data back in with BinaryReader
        Using input As FileStream = File.OpenRead(FILE_BINARY),
                reader As New BinaryReader(input)
            With reader
                Dim intRead As Integer = .ReadInt32()
                Dim stringRead As String = .ReadString()
                Dim byteArrayRead() As Byte = .ReadBytes(4)
                Dim floatRead As Single = .ReadSingle()
                Dim charRead As Char = .ReadChar()

                Console.WriteLine("int: {0} string: {1} bytes: ", intRead, stringRead)
                For Each b As Byte In byteArrayRead
                    Console.WriteLine("{0}", b)
                Next
                Console.WriteLine(" float: {0} char: {1} ", floatRead, charRead)
            End With
        End Using
        Console.ReadKey()
    End Sub

End Module
