internal class Program
{
    private static void Main(string[] args)
    {
        // DECLARACIÓN DE VARIABLES
        int opcion;
        // ENTRADA DE DATOS
        Console.WriteLine("== BUZÓN DE VOZ ==");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Ventas");
        Console.WriteLine("2. Recepción");
        Console.WriteLine("3. Dirección");
        Console.WriteLine("4. Compras");
        opcion = Convert.ToInt32(Console.ReadLine());
        // PROCESO Y SALIDA
        if (opcion == 1)
        {
            Console.WriteLine("Bienvenido al departamento de Ventas.");
            Console.WriteLine("Responsable:  Diego Gonzalez\"");
            Console.WriteLine("Correo: Diego.Gonzalez@empresa.gt.com");
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Bienvenido al departamento de Recepción.");
            Console.WriteLine("Responsable: Sofia Diaz");
            Console.WriteLine("Correo: Sofia.Diaz@empresa.gt.com");
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Bienvenido al departamento de Dirección.");
            Console.WriteLine("Responsable: Carlos López");
            Console.WriteLine("Correo: carlos.Lopez@empresa.gt.com");
        }
        else if (opcion == 4)
        {
            Console.WriteLine("Bienvenido al departamento de Compras.");
            Console.WriteLine("Responsable: Gabriela Martínez");
            Console.WriteLine("Correo: Gabriela.Martinez@empresa.gt.com");
        }
        else
        {
            Console.WriteLine("Opción no válida. Por favor, elija un número entre 1 y 4.");
        }
    }
}