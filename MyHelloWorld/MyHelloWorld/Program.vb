Imports System

Module Program
    Sub Main()
        Console.WriteLine("Hello World!")

        Dim hello As String
        hello = "Hello World this is my first program in "

        Dim currentYear As Integer
        currentYear = 2020

        Console.WriteLine(hello + CStr(currentYear))
        Console.Write(hello & currentYear)

        Console.Write(" VS.NET")


        Console.Read()


    End Sub
End Module
