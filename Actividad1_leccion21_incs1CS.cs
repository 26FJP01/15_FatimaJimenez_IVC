internal class Program
{
    private static void Main(string[] args)
    {
        int numeroDia;
        Console.Write("Ingrese un numero del 1 al 7: ");
        numeroDia = int.Parse(Console.ReadLine());
        if (numeroDia == 1)
            Console.WriteLine("Hoy es Lunes");
        else if (numeroDia == 2)
            Console.WriteLine("Hoy es Martes");
        else if (numeroDia == 3)
            Console.WriteLine("Hoy es Miercoles");
        else if (numeroDia == 4)
            Console.WriteLine("Hoy es Jueves");
        else if (numeroDia == 5)
            Console.WriteLine("Hoy es Viernes");
        else if (numeroDia == 6)
            Console.WriteLine("Hoy es Sabado");
        else if (numeroDia == 7)
            Console.WriteLine("Hoy es Domingo");
        else
            Console.WriteLine("Numero invalido");
    }
}