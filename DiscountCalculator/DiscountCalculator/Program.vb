Imports System

Module Program
    Sub Main(args As String())
        Dim CurrentDate As String = String.Format("{0:g}", Now)
        Console.WriteLine()
        Console.WriteLine("Date: " & CurrentDate)
        Console.WriteLine()

        Dim AppTitle As String = "$ Discound Calculator $"
        Dim Line As String = StrDup(Len(AppTitle), "-")

        Console.WriteLine(Line)
        Console.WriteLine(AppTitle)
        Console.WriteLine(Line)

        Dim ProductPrice As Double = 11000
        Dim Discount As Double = 15 / 100

        Console.WriteLine(String.Format("{0,-14} {1,8}", "Product Price", "Discount"))
        Console.WriteLine()

        Console.WriteLine(String.Format("{0,-14:C2} {1,0:P}", ProductPrice, Discount))
        Console.WriteLine()

        Console.WriteLine(Line)
        Console.WriteLine()

        Dim YouSave As Double = ProductPrice * Discount
        Console.WriteLine(String.Format("YouSave: {0:C2}", YouSave))
        Console.WriteLine()

        Dim FinalPrice As Double = ProductPrice - YouSave
        Console.WriteLine(String.Format("Final price: {0:c2}", FinalPrice))
        Console.WriteLine()


        Console.WriteLine("Press Enter to continue...")
        Console.Read()
    End Sub

End Module
