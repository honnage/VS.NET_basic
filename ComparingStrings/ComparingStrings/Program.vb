Imports System

Module Program
    Sub Main(args As String())
        Dim a As String = "Mr. A"
        Dim b As String = "Mr. B"
        Dim c As String = "Mr. A"
        Console.WriteLine("Comparing Strings :Case-Sensitive")
        Console.WriteLine()
        '-- Example 1
        Dim result1 As Boolean = (a <> b)
        Console.WriteLine(String.Format("{0} <> {1} returns: {2}", a, b, result1))
        Console.WriteLine()

        '-- Example 2
        Dim result2 As Boolean = String.Equals(a, c)
        Console.WriteLine(String.Format("{0} = {1}  {2}", a, c, result2))
        Console.WriteLine()

        '-- Example 3
        Dim str1 As String = "abc"
        Dim str2 As String = "ABC"
        Dim result3 As Integer = String.CompareOrdinal(str1, str2)
        Dim MyString As String

        If (result3 < 0) Then
            MyString = str1 & " is iess then " & str2
        ElseIf (result3 = 0) Then
            MyString = str1 & " is equal to " & str2
        Else
            MyString = str1 & " is greater then " & str2
        End If
        Console.WriteLine(String.Format("Returns: {0} => {1}", result3, MyString))
        Console.WriteLine()

        Console.WriteLine("Press enter to continus...")
        Console.ReadKey()

    End Sub
End Module
