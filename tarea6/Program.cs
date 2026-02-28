using System;

class Program
{
    static double Convertir(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static void Main()
    {
        Console.Write("Ingrese grados Celsius: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("En Fahrenheit: " + Convertir(c));
    }
}