Imports System

Module Program
    Sub Main()
        Dim length As Double
        Dim breadth As Double
        Dim height As Double
        Dim result As Double

        Console.Write("Enter the Length number: ")
        length = Convert.ToDouble(Console.ReadLine())

        Console.Write("Enter the breadth number: ")
        breadth = Convert.ToDouble(Console.ReadLine())

        Console.Write("Enter the height number: ")
        height = Convert.ToDouble(Console.ReadLine())

        result = length * height * breadth * 1000

        Console.WriteLine("The Capacity of  Tank is : {0}", result)

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
