Module Module1

    Sub Main()

        Console.WriteLine("Enter Num one ")

        Dim count As Integer = Console.ReadLine
        Dim array(count - 1) As Integer


        For i As Integer = 0 To count - 1
            array(i) = Console.ReadLine

        Next

        Console.WriteLine()
        For Each result As Integer In symmetric(count, array)
            Console.WriteLine(result)
        Next


        Console.ReadKey()

    End Sub

    Public Function AddTwoNumbers(ByVal numOne As Integer, ByVal numTwo As Integer)

        Dim result As Integer = numOne + numTwo
        Return result

    End Function

    Public Sub DisplaySuccess()
        Console.WriteLine("This is a success")
    End Sub

    Public Function symmetric(ByVal count As Integer, inputArray() As Integer) As Integer()

        Dim result(count - 1) As Integer

        For index As Integer = 0 To inputArray.Count - 1



            Dim oldNumber As Integer = inputArray(index) + 1


            Dim newNumber As Integer = ReverseNumber(oldNumber)

            Do While oldNumber <> newNumber
                oldNumber += 1
                newNumber = ReverseNumber(oldNumber)
                If oldNumber = newNumber Then
                    result(index) = newNumber
                    Exit Do
                End If
            Loop

        Next


        Return result

    End Function

    Public Function ReverseNumber(ByVal input As Integer) As Integer
        Dim newNumberString As New String(input.ToString.ToCharArray.Reverse().ToArray)
        Return Convert.ToInt64(newNumberString)

    End Function
End Module
