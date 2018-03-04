Module Module1

    Sub Main()
        Dim sfinal As String
        Dim uip As String
        Dim ipa(100) As String
        Dim opa() As String = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim ptr As Integer = 0
        Dim flow As Integer = 0
        Dim sl As Integer
        Dim el As Integer
        Dim i As Integer = 0
        Dim flag As Boolean = True
        Dim count As Integer = 0
        Dim uip1 As String
        Dim uip2 As String


        Console.WriteLine("enter our program")
        uip1 = Console.ReadLine()
        uip2 = Console.ReadLine()
        uip = uip1 + uip2

        For i = 0 To uip.Length - 1
            ipa(i) = uip(i)
        Next
        While (flag)
            i = flow
            If (i = uip.Length - 1) Then
                flag = False

            End If

            If (ipa(i) = "+") Then
                opa(ptr) = opa(ptr) + 1
                flow = flow + 1

            End If
            If (ipa(i) = "-") Then
                opa(ptr) = opa(ptr) - 1
                flow = flow + 1

            End If
            If (ipa(i) = ">") Then
                ptr = ptr + 1
                flow = flow + 1

            End If
            If (ipa(i) = "<") Then
                ptr = ptr - 1
                flow = flow + 1

            End If
            If (ipa(i) = ".") Then

                flow = flow + 1

            End If
            If (ipa(i) = ",") Then
                Console.WriteLine("your input")

                opa(i) = Console.ReadLine()
                flow = flow + 1
            End If

            If (ipa(i) = "[") Then
                sl = i
                If (opa(ptr) <> 0) Then
                    flow = flow + 1
                Else
                    flow = el + 1
                End If
            End If
            If (ipa(i) = "]") Then
                el = i
                If (opa(ptr) <> 0) Then
                    flow = sl + 1
                Else
                    flow = el + 1
                End If
            End If
        End While
        For i = 0 To uip.Length - 1
            If (opa(i) = "1") Then
                opa(i) = "a"
            End If
            If (opa(i) = "2") Then
                opa(i) = "b"
            End If
            If (opa(i) = "3") Then
                opa(i) = "c"
            End If
            If (opa(i) = "4") Then
                opa(i) = "d"
            End If
            If (opa(i) = "5") Then
                opa(i) = "e"
            End If
            If (opa(i) = "6") Then
                opa(i) = "f"
            End If
            If (opa(i) = "7") Then
                opa(i) = "g"
            End If
            If (opa(i) = "8") Then
                opa(i) = "h"
            End If
            If (opa(i) = "9") Then
                opa(i) = "i"
            End If
            If (opa(i) = "10") Then
                opa(i) = "j"
            End If
            If (opa(i) = "11") Then
                opa(i) = "k"
            End If
            If (opa(i) = "12") Then
                opa(i) = "l"
            End If
            If (opa(i) = "13") Then
                opa(i) = "m"

            End If
            If (opa(i) = "14") Then
                opa(i) = "n"

            End If
            If (opa(i) = "15") Then
                opa(i) = "o"
            End If
            If (opa(i) = "16") Then
                opa(i) = "p"
            End If
            If (opa(i) = "17") Then
                opa(i) = "q"
            End If
            If (opa(i) = "18") Then
                opa(i) = "r"
            End If
            If (opa(i) = "19") Then
                opa(i) = "s"
            End If
            If (opa(i) = "20") Then
                opa(i) = "t"
            End If
            If (opa(i) = "21") Then
                opa(i) = "u"
            End If
            If (opa(i) = "22") Then
                opa(i) = "v"
            End If
            If (opa(i) = "23") Then
                opa(i) = "w"
            End If
            If (opa(i) = "24") Then
                opa(i) = "x"
            End If
            If (opa(i) = "25") Then
                opa(i) = "y"
            End If
            If (opa(i) = "26") Then
                opa(i) = "z"
            End If

        Next


        For i = 0 To opa.Length - 1
            If (opa(i) = "0") Then
                If (i > 0) And i <> opa.Length - 1 Then
                    opa(i) = opa(i + 1)
                End If
            End If
        Next

        For i = 0 To opa.Length - 1
            If (opa(i) <> "0") Then
                count = count + 1
            End If
        Next

        For i = 1 To count - 1
            Console.Write(opa(i))
        Next

        Console.ReadLine()

    End Sub

End Module

