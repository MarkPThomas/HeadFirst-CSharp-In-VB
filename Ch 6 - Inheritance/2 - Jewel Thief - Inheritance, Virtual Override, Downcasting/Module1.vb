Option Explicit On
Option Strict On

Module Module1

    Sub Main()
        Dim owner As New Owner()
        Dim safe As New Safe()
        Dim jewelThief As New JewelThief()

        jewelThief.OpenSafe(safe, owner)

        ' ReadKey waits for the user to press a key. It keeps the program from ending.
        Console.ReadKey()
    End Sub

End Module
