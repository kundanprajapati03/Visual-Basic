Imports System

Module Program
    Sub Main()
        Dim a As Integer

        Console.WriteLine("1. While Loop")
        Console.WriteLine("2. Do While Loop")

        Console.Write("Enter Choise :- ")
        a = Console.ReadLine()

        Dim i As Integer = 1

        Select Case a
            Case 1
                While i <= 10
                    console.writeline(i)
                    i = i + 1
                End While
            Case 2
                Do
                    console.writeline(i)
                    i = i + 1
                Loop While i <= 10
            Case Else
                console.writeline("You choese a wrong number")
        End Select

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
