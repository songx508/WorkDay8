Module Module1

    Sub Main()
        Dim i As Integer
        Dim j As Integer

        For i = 65 To 70
            Console.WriteLine("Appendix " & Chr(i))
            'Exit For: quit loop any time w/out waiting for end of interation
            'Continue For: continually jump back 

            For j = 1 To 5
                Console.WriteLine("Section " & CStr(j))
            Next
        Next

    End Sub

End Module
