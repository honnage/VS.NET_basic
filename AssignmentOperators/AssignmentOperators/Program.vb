Option Explicit On
Option Strict On
Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Assignment Operators : iBasskung Tutorial")
        Console.WriteLine()

        Dim firsNum As Double = 10
        Dim secondNum As Integer = 3
        Console.WriteLine("Number is " & firsNum)
        Console.WriteLine("Number is " & secondNum)
        Console.WriteLine()

        firsNum += secondNum '-- 13

        Console.WriteLine(vbTab + $"+= Operator : value of firstNum = {firsNum}")
        Console.WriteLine()

        firsNum -= secondNum '-- 10

        Console.WriteLine(vbTab + $"-= Operator : value of firstNum = {firsNum}")
        Console.WriteLine()

        firsNum *= secondNum '-- 30

        Console.WriteLine(vbTab + $"*= Operator : value of firstNum = {firsNum}")
        Console.WriteLine()


        firsNum /= secondNum '-- 10

        Console.WriteLine(vbTab + $"/= Operator : value of firstNum = {firsNum}")
        Console.WriteLine()

        firsNum ^= secondNum '-- 1000

        Console.WriteLine(vbTab + $"^= Operator : value of firstNum = {firsNum}")
        Console.WriteLine()

        Dim firstString As String = CType(firsNum, String)
        Dim secondString As String = CType(secondNum, String)
        '--Dim secondString As String = secondNum.ToString

        firstString &= secondString
        Console.WriteLine(vbTab + $"&= Operator : value of firstString = {firstString}")
        Console.WriteLine()

        Dim UnitInStock = 111
        Console.WriteLine("Stock in: " & UnitInStock & Environment.NewLine)
        UnitInStock += 11

        Console.WriteLine("Avaiable inventory: " & UnitInStock)
        Console.WriteLine()

        Console.WriteLine("Stock out: " & UnitInStock & Environment.NewLine)
        UnitInStock -= 11

        Console.WriteLine("Avaiable inventory: " & UnitInStock)
        Console.WriteLine()

        Console.WriteLine("Press and key to continus")
        Console.ReadKey()


    End Sub

End Module
