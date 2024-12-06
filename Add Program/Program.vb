Imports System

Module Program
    Sub Main()
        Dim num1 As Double
        Dim num2 As Double
        Dim result As Double

        ' Prompt the user to enter the first number
        Console.Write("Enter the first number: ")
        num1 = Convert.ToDouble(Console.ReadLine())

        ' Prompt the user to enter the second number
        Console.Write("Enter the second number: ")
        num2 = Convert.ToDouble(Console.ReadLine())

        ' Perform the addition
        result = num1 + num2

        ' Display the result
        Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, result)

        ' Wait for the user to press a key before closing
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub
End Module
