Imports System

Module Program
    <Obsolete>
    Sub Main(args As String())
        Console.WriteLine("VB.Net - Comparison Operators : iBasskung Tutorial. ")
        Console.WriteLine("Grade Calculator." & vbNewLine)

        Dim stringScore As String
        Dim intScore As Integer
        Dim Grade As Char

        Do
            Console.Write("Prass input the student's sroce: ")
            stringScore = Console.ReadLine()

            If Not String.IsNullOrEmpty(stringScore) Then

                If (Integer.TryParse(stringScore, intScore)) Then
                    intScore = CInt(stringScore)

                    If (intScore < 0 Or intScore > 100) Then
                        Console.WriteLine()
                        Console.WriteLine("Please enter a valid score between (0 and 100)")
                        Console.WriteLine()
                        Continue Do
                    End If

                    If (intScore >= 80) Then
                        Grade = CChar("A")
                    ElseIf (intScore >= 70) Then
                        Grade = CChar("B")
                    ElseIf (intScore >= 60) Then
                        Grade = CChar("C")
                    ElseIf (intScore >= 50) Then
                        Grade = CChar("D")
                    Else
                        Grade = CChar("F")
                    End If

                    Console.WriteLine()
                    Console.WriteLine("Sroce: {0} >> You letter grade is a {1}", intScore, Grade)
                    Console.WriteLine()
                Else
                    Console.WriteLine()
                    Console.WriteLine("sorry, please input number only.")
                    Console.WriteLine()

                End If

            End If
        Loop

        Console.WriteLine("Press any keey to exit...")
        Console.ReadKey()
    End Sub

End Module
