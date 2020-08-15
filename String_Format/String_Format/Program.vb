Imports System

Module Program
    Sub Main(args As String())
        Dim firstName As String = "Passkorn "
        Dim lastName As String = "Phoyai"
        Dim age As Integer = 19

        '-- Example 1
        Console.WriteLine("Example 1")
        Console.WriteLine("First name: " & firstName & " Last name : " & lastName & " Age: " & age)
        Console.WriteLine()

        '-- Example 2
        Console.WriteLine("Example 2")
        Console.WriteLine(String.Format("Firsr name: {0} Last name: {1} Age: {2}", firstName, lastName, age))
        Console.WriteLine()

        '-- Example 3
        Console.WriteLine("Example 3")
        Console.WriteLine($"First name: {firstName} Last name: {lastName} Age: {age}")
        Console.WriteLine()

        '-- Example 4
        Console.WriteLine("Example 4")
        Console.WriteLine(vbTab + $"First name: {firstName & Environment.NewLine & vbTab}Last name: {lastName + vbNewLine + vbTab}age: {age}")
        Console.WriteLine()
        Console.Read()
    End Sub
End Module
