Option Strict On
Option Explicit On
Imports System

Module Program
    Sub Main(args As String())
        Dim firstNumber As Double
        Dim secondNumber As Double
        Dim result As Double

        firstNumber = 1001
        secondNumber = 2
        '-- + - * / ^ \
        '-- result = firstNumber - secondNumber
        '-- result = System.Math.Pow(firstNumber, secondNumber)
        result = firstNumber Mod secondNumber

        Console.WriteLine("result: " & result)
        Console.WriteLine()

        Dim number As Double
        number = 2
        Console.WriteLine(number & "is an " & IIf(number Mod 2 <> 0, "odd number", "even number").ToString)

        Console.WriteLine("Press any key to continus...")
        Console.ReadKey()



    End Sub
End Module
