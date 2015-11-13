Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim ducks As New List(Of Duck) From {
            New Duck() With {.Kind = KindsOfDucks.Mallard,
                             .Size = 17},
            New Duck() With {.Kind = KindsOfDucks.Muscovy,
                             .Size = 18},
            New Duck() With {.Kind = KindsOfDucks.Decoy,
                             .Size = 14},
            New Duck() With {.Kind = KindsOfDucks.Mallard,
                             .Size = 11},
            New Duck() With {.Kind = KindsOfDucks.Muscovy,
                             .Size = 14},
            New Duck() With {.Kind = KindsOfDucks.Decoy,
                             .Size = 13}
            }

        Console.WriteLine("Ducks compared within class by size")
        ducks.Sort()
        PrintDucks(ducks)

        Console.WriteLine("Ducks compared with comparer class by size")
        Dim sizeComparer As New DuckComparerBySize()
        ducks.Sort(sizeComparer)
        PrintDucks(ducks)

        Console.WriteLine("Ducks compared with comparer class by kind")
        Dim kindComparer As New DuckComparerByKind()
        ducks.Sort(kindComparer)
        PrintDucks(ducks)

        Dim comparer As New DuckComparer()
        Console.WriteLine("Ducks compared with enum comparer class by kind then size")
        comparer.SortBy = SortCriteria.KindThenSize
        ducks.Sort(comparer)
        PrintDucks(ducks)

        Console.WriteLine("Ducks compared with enum comparer class by size then kind")
        comparer.SortBy = SortCriteria.SizeThenKind
        ducks.Sort(comparer)
        PrintDucks(ducks)

        Console.ReadKey()
    End Sub

    Public Sub PrintDucks(ducks As List(Of Duck))
        For Each bird As Duck In ducks
            Console.WriteLine(bird)
        Next
        Console.WriteLine("End of ducks!" & vbCrLf)
    End Sub


End Module
