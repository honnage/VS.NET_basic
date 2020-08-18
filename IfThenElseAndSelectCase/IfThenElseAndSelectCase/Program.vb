Imports System

Module Program
    Enum MemberType As Byte
        Gold = 1
        Silver = 2
        Blue = 3
    End Enum

    Enum MyDay As Byte
        Sunday = 0
        Monday = 1
        Tuesday = 2
        Wednesday = 3
        Thursday = 4
        Friday = 5
        Saturday = 6
    End Enum

    Sub Main(args As String())
        Console.WriteLine("If...Then...Else And Select Case")
        Console.WriteLine()

        Console.WriteLine("Example 1")
        Console.WriteLine()

        Dim value As MemberType = MemberType.Blue
        Dim IsAdmin As Boolean = True

        If (IsAdmin = True) Then
            If (value = MemberType.Gold) Then
                Console.WriteLine("Member type: " & value & " : " & value.ToString)
            ElseIf (value = MemberType.Silver) Then
                Console.WriteLine("Member type: " & value & " : " & value.ToString)
            ElseIf (value = MemberType.Blue) Then
                Console.WriteLine("Member type: " & value & " : " & value.ToString)
            Else
                Console.WriteLine("unknow member type.")
            End If
        Else
            Console.WriteLine("Access denied! File is not accessible.")
        End If

        Console.WriteLine()
        Console.WriteLine("Example 2")
        Console.WriteLine()

        Dim WorkDay As MyDay = MyDay.Sunday



        Select Case WorkDay
            Case MyDay.Monday
                Console.WriteLine("Today is a good day.")
            Case MyDay.Tuesday
                Console.WriteLine("Today is a beautiful day.")
            Case MyDay.Friday
                Console.WriteLine("Today is a my birthday.")
            Case Else
                Console.WriteLine("Invalid")
        End Select




        Console.ReadKey()

    End Sub
End Module
