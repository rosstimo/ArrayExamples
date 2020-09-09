Module ArrayExamples

    Sub Main()
        SimpleArray()
    End Sub

    Sub SimpleArray()
        Dim names(5) As String

        names(0) = "Bob"
        names(3) = "Jimmy"

        Console.WriteLine("Hello " & names(3))
        Console.Read()

    End Sub


End Module
