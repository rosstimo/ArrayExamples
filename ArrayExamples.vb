Module ArrayExamples

    Sub Main()
        'SimpleArray()
        'IterateSimpleArray()
        'LessSimple()
        'Multidimensional()
        DisplayArray()
        Console.Read()
    End Sub

    Sub SimpleArray()
        Dim names(5) As String

        names(0) = "Bob"
        names(3) = "Jimmy"

        Console.WriteLine("Hello " & names(3))

    End Sub

    Sub IterateSimpleArray()
        Dim names(5) As String

        names(0) = "joe"
        names(3) = "Jimmy"

        For i = 0 To 5
            If names(i) <> "" Then : Console.WriteLine("Hello " & names(i)) : End If
        Next

        'For i = LBound(names) To UBound(names)
        '    Console.WriteLine("Hello " & names(i))
        'Next

        If names.Contains("Bob") Then
            Console.WriteLine("Bob is home")
        Else
            Console.WriteLine("Bob has gone fishing")
        End If

    End Sub

    Sub LessSimple()
        Dim animals() = New String() {"dog", "cat", "bird", "liger"}

        For i = LBound(animals) To UBound(animals)
            Console.WriteLine("Hello " & animals(i))
        Next

    End Sub

    Sub Multidimensional()
        Dim dataArray(3, 5) As Integer

        dataArray(0, 0) = 5I
        dataArray(1, 0) = 7I
        dataArray(2, 0) = 15I
        dataArray(3, 0) = 6I
        dataArray(2, 3) = 22I


        'nested loop
        For column = 0 To 5
            For row = 0 To 3
                Console.Write(dataArray(row, column) & " ")
            Next
            Console.WriteLine()
        Next

        'iterate
        For Each thingy In dataArray
            Console.Write(thingy)
        Next

    End Sub

    Sub DisplayArray() 'TODO pass in array, maybe column row headers
        Dim row As Integer = 12
        Dim column As Integer = 3
        Dim formattedString As String
        Dim currentArray(row, column) As Boolean

        For i = 0 To row
            For j = 0 To column
                formattedString = $" {i},{j} "
                Console.Write(formattedString.PadLeft(8))
            Next
            Console.WriteLine()
        Next

    End Sub

End Module
