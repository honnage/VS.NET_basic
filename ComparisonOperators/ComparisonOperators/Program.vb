Imports System

Module Program
    Sub Main(args As String())
        '-- = ��ҡѺ
        '-- <> �����ҡ��
        '-- < ���¡���
        '-- > �ҡ����
        '-- <= ���¡���������ҡѺ
        '-- >= �ҡ����������ҡѺ
        Console.WriteLine("Comparison Operators")
        Console.WriteLine("Comparing Numeric Values." & vbNewLine)

        Dim numberA As Integer = 10
        Dim numberB As Integer = 11
        Console.WriteLine("Result: " & (numberA <= numberB))

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub
End Module
