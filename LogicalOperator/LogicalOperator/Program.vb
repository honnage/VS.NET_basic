Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Logical Operators : iBasskug Tutorial" & vbNewLine)
        '-- and, or, not
        '--Dim result As Boolean = (10 > 50) Or (20 > 50)
        '--Console.WriteLine("result : " & result)
        '--Console.WriteLine("result : " & Not (result))

        '-- andalso ��Ǩ���͹��á ��͹ ����繨�ԧ �֧��Ǩ���͹� ����
        '-- orelse ������͹��á �繨�ԧ ������Ǩ���͹� ����
        If (10 = 100) OrElse (10 = 50) Then
            Console.WriteLine("Reture true")
        Else
            Console.WriteLine("Reture false")
        End If

        Console.WriteLine()
        Console.WriteLine("Press and key to continue...")
        Console.ReadKey()

    End Sub
End Module
