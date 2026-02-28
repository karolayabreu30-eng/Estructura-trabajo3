using System;

class Program
{
    static void Main()
    {
        var frutas = ("Manzana", "Pera", "Uva");
        var verduras = ("Zanahoria", "Lechuga", "Tomate");

        var todo = (frutas.Item1, frutas.Item2, frutas.Item3,
                    verduras.Item1, verduras.Item2, verduras.Item3);

        Console.WriteLine(todo);
    }
}
