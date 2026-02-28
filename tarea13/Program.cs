using System;

class Program
{
    static void Main()
    {
        var numeros = (1, 2, 3, 4, 5);

        Console.WriteLine("Tercer elemento: " + numeros.Item3);
    }
}