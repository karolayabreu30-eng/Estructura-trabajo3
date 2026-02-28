using System;

class Program
{
    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = Sumar(num1, num2);
        Console.WriteLine("La suma es: " + resultado);
    }
}