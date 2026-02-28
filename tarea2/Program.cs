using System;

class Program
{
    static double CalcularArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    static void Main()
    {
        Console.Write("Ingrese el radio: ");
        double radio = double.Parse(Console.ReadLine());

        double area = CalcularArea(radio);
        Console.WriteLine("El área es: " + area);
    }
}