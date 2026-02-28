using System;

class Program
{
    static int Mayor(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("El mayor es: " + Mayor(num1, num2));
    }
}
