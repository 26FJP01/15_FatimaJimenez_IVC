internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        Console.WriteLine("Introduzca un número:");
        numero = int.Parse(Console.ReadLine());
        if (numero < 0) { 
            Console.WriteLine("El número es menor a cero");
        }
        else
            Console.WriteLine("El número es igual o mayor a cero");
    }
}
