using System;

class Program
{
    static bool EstaEnLista(int[] lista, int numero)
    {
        foreach (int n in lista)
        {
            if (n == numero)
                return true;
        }
        return false;
    }

    static void Main()
    {
        int[] numeros = { 5, 10, 15, 20, 25 };

        Console.Write("Ingrese un número a buscar: ");
        int num = int.Parse(Console.ReadLine());

        if (EstaEnLista(numeros, num))
            Console.WriteLine("El número está en la lista");
        else
            Console.WriteLine("No está en la lista");
    }
}