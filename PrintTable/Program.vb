Imports System

Module Program
    Sub Main()
        Dim table As Integer

        Console.Write("Enter the Number you want Table :- ")
        table = Console.ReadLine()

        For index As Integer = 1 To 10
            Console.WriteLine("{0} X {1} = {2}", table, index, table * index)
        Next

        Console.Write("Press any key for exit...")
        Console.ReadLine()
    End Sub
End Module
