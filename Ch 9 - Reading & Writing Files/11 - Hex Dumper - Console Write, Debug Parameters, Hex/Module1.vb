Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text

Module Module1

    Sub Main(ByVal args() As String)
        If Not args.Length = 1 Then
            Console.Error.WriteLine("usage: HexDumper file-to-dump")
            Environment.Exit(1)
        End If
        If Not File.Exists(args(0)) Then
            Console.Error.WriteLine("File does not exist: {0}", args(0))
            Environment.Exit(2)
        End If

        Using input As Stream = File.OpenRead(args(0))
            Dim position As Integer = 0
            Dim bytesPerLine As Integer = 16
            Dim bytesPerSegment As Integer = 8
            Dim buffer(bytesPerLine) As Byte

            ' Line written as
            ' {4-character hex position} {2-character bytes 1-8} -- {2-character bytes 9-16}    {Text representation of the line}
            While position < input.Length
                Dim charactersRead As Integer = input.Read(buffer, 0, buffer.Length)
                If charactersRead > 0 Then
                    ' 0:x4 means to write parameter 0 as a 4-character hex number
                    Console.Write("{0}: ", String.Format("{0:x4}", position))
                    position += charactersRead - 1

                    For i = 0 To bytesPerLine - 1
                        If i < charactersRead Then
                            ' Write parameter as a 2-character hex number
                            Dim hex As String = String.Format("{0:x2}", buffer(i))
                            Console.Write(hex & " ")
                        Else
                            Console.Write("   ")
                        End If

                        ' Write divide between byte segment
                        If i = (bytesPerSegment - 1) Then Console.Write("-- ")

                        ' Characters byte values outside of this range values don't print to text well, so they are blocked out as periods.
                        If (buffer(i) < 32 OrElse 250 < buffer(i)) Then buffer(i) = Convert.ToByte(CChar("."))
                    Next

                    ' Write bytes out as text
                    Dim bufferContents As String = Encoding.UTF8.GetString(buffer)
                    Console.WriteLine("    " & bufferContents)
                End If
            End While
        End Using

        Console.ReadKey()
    End Sub

End Module
