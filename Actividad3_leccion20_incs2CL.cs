internal class Program
{
    private static void Main(string[] args)
    {
        int calificacion;
        Console.Write("Ingrese nota: ");
        calificacion = int.Parse(Console.ReadLine());
        if (calificacion >= 70)
            Console.WriteLine("Aprobado");
        else
            Console.WriteLine("Reprobado");
    }
}