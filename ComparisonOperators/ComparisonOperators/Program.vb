Imports System

Module Program
    Sub Main(args As String())
        '-- = เท่ากับ
        '-- <> ไม่เท่ากัย
        '-- < น้อยกว่า
        '-- > มากกว่า
        '-- <= น้อยกว่าหรือเท่ากับ
        '-- >= มากกว่าหรือเท่ากับ
        Console.WriteLine("Comparison Operators")
        Console.WriteLine("Comparing Numeric Values." & vbNewLine)

        Dim numberA As Integer = 10
        Dim numberB As Integer = 11
        Console.WriteLine("Result: " & (numberA <= numberB))

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub
End Module
