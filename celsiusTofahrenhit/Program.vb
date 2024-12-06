Imports System

Module Program
    Sub Main()
        Dim celsuis As Double
        Dim fahrenhit As Double

        Console.Write("Enter the value of Celsius:-")
        celsuis = Convert.ToDouble(Console.ReadLine())

        fahrenhit = (celsuis * 9 / 5) + 32

        Console.Write(fahrenhit)
        Console.WriteLine(" F°")
        Console.Write("Press any key for Exit...")
        Console.ReadLine()

    End Sub
End Module
