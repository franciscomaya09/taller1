Option Strict On
Module Module1

    Sub Main()
        Dim a, b, c, d, menor As Double
        Console.WriteLine("Inserte el valor de a ")
        a = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Inserte el valor de b")
        b = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Inserte el valor de c")
        c = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Inserte el valor de d")
        d = Convert.ToDouble(Console.ReadLine())
        If a < d Then
            menor = a
        Else
            menor = b
        End If
        If a < c Then

            menor = a
        Else
            menor = c
        End If
        If b < c Then
            menor = b
        Else
            menor = c

        End If

        If a < d Then
            Console.WriteLine(" El menor es" & a)

        End If
        If b < d Then
            Console.WriteLine(" El menor es" & b)

        End If
        If c < d Then
            Console.WriteLine(" El menor es" & c)
        Else
            Console.WriteLine(" El menor es" & d)
        End If
        Console.ReadLine()
    End Sub

End Module
