using System;

class Program
{
    static int ContarVocales(string texto)
    {
        int contador = 0;
        texto = texto.ToLower();

        foreach (char letra in texto)
        {
            if ("aeiou".Contains(letra))
                contador++;
        }

        return contador;
    }

    static void Main()
    {
        Console.Write("Ingrese una palabra o frase: ");
        string texto = Console.ReadLine();

        Console.WriteLine("Cantidad de vocales: " + ContarVocales(texto));
    }
};
