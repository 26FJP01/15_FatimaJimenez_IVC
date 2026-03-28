internal class Program
{
    private static void Main(string[] args)
    {
        int nota;
        Console.Write("Ingrese la nota: ");
        nota = int.Parse(Console.ReadLine());
        if (nota < 0 && nota >= 100)
            Console.WriteLine("Deficiente");
        else if (nota < 70)
            Console.WriteLine("Regular");
        else if (nota < 80)
            Console.WriteLine("Bien");
        else if (nota < 90)
            Console.WriteLine("Muy bien");
        else if (nota <= 100)
            Console.WriteLine("Excelente");
        else
            Console.WriteLine("Nota inválida");
    }
}
