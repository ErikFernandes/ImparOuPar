Imports System

Module Program

    Dim num As Object
    Dim rest As Decimal

    Sub Main()

        Console.WriteLine("Digite um número;")

        num = Console.ReadLine()

        Do
            Try

                rest = num Mod 2

                If rest = 0 Then

                    Console.WriteLine($"O número {num} é par")
                    Console.WriteLine("Pressione qualquer tecla...")
                    Console.ReadKey(True)
                    End
                ElseIf rest <> 0 Then

                    Console.WriteLine($"O número {num} é impar")
                    Console.WriteLine("Pressione qualquer tecla...")
                    Console.ReadKey(True)
                    End

                End If

            Catch

                Console.WriteLine("Digite apenas números")
                num = Console.ReadLine()

            End Try

        Loop


    End Sub
End Module
