Option Strict On
Option Explicit On


Module ArrayExamples

    Sub Main()
        ' SimpleArray()
        'IterateSimpleArray()
        'LessSimple()
        Multidimensionsole()
        Console.Read()

    End Sub

    Sub SimpleArray()
        Dim names(5) As String

        names(0) = "Bob"
        names(3) = "Jimmy"

        Console.WriteLine("Hello " & names(3))
        Console.Read()

    End Sub

    Sub IterateSimpleArray()
        Dim names(5) As String

        names(0) = "Bob"
        names(3) = "Jimmy"

        'For i = 0 To 5
        '    Console.WriteLine("Hello " & names(i))
        'Next

        For i = LBound(names) To UBound(names)
            Console.WriteLine("Hello " & names(i))
        Next

        Console.Read()
    End Sub

    Sub LessSimple()
        Dim animals() = New String() {"dog", "cat", "bird", "liger"}

        For i = LBound(animals) To UBound(animals)
            Console.WriteLine("Hello " & animals(i))
        Next

    End Sub

    Sub Multidimensionsole()
        Dim dataArry(3, 5) As Integer

        dataArry(0, 0) = 5I
        dataArry(1, 0) = 7I
        dataArry(2, 0) = 15I
        dataArry(3, 0) = 6I
        dataArry(2, 3) = 22I

        'neasted loop 
        For column = 0 To 5
            For row = 0 To 3
                Console.WriteLine(dataArry(row, column) & " ")
            Next
            Console.WriteLine()
        Next

        For Each Thingy In dataArry
            Console.WriteLine(Thingy)
        Next

    End Sub

End Module
