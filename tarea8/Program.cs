using System;

class Program
{
    static int LongitudCadena(string texto)
    {
        return texto.Length;
    }

    static void Main()
    {
        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        Console.WriteLine("Longitud: " + LongitudCadena(texto));
    }
}
