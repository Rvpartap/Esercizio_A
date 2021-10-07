Imports System

Module Program
    Sub Main()
        Console.WriteLine("Inserisci il tuo nome: ")
        Dim MyName As String = Console.ReadLine()
        Console.WriteLine("Inserisci il tuo Cognome: ")
        Dim MySurname As String = Console.ReadLine()
        Console.WriteLine("Inserisci il tuo Email: ")
        Dim MyEmail As String = Console.ReadLine()
        Console.WriteLine("Inserisci il tuo Password: ")
        Dim MyPassword As String = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("Benvenuto nella area riservata " & MyName & " " & MySurname)
        Console.ReadLine()
    End Sub
End Module
