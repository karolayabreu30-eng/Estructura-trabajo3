using System;

class Program
{
    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }

    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        if (EsPar(num))
            Console.WriteLine("Es par");
        else
            Console.WriteLine("Es impar");
    }
}
