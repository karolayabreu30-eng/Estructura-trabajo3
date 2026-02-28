class Libro
{
    public string titulo;

    public void MostrarTitulo()
    {
        Console.WriteLine("El título del libro es: " + titulo);
    }
}

class Program
{
    static void Main()
    {
        Libro libro1 = new Libro();
        libro1.titulo = "Cien años de soledad";
        libro1.MostrarTitulo();
    }
}
