internal class Program
{
    private static void Main(string[] args)
    {
        // ==MENSAJE DE BIENVENIDA==
        Console.WriteLine("SELECCION DE MES");
        // DECLARACION DE VARIABLES
        int mes;
        // ENTRADA DE DATOS
        Console.WriteLine("Ingrese el número correspondiente al mes (1-12):");
        mes = Convert.ToInt32(Console.ReadLine());
        // PROCESO Y SALIDA
        if (mes == 1)
            Console.WriteLine("Enero");
        else if (mes == 2)
            Console.WriteLine("Febrero");
        else if (mes == 3)
            Console.WriteLine("Marzo");
        else if (mes == 4)
            Console.WriteLine("Abril");
        else if (mes == 5)
            Console.WriteLine("Mayo");
        else if (mes == 6)
            Console.WriteLine("Junio");
        else if (mes == 7)
            Console.WriteLine("Julio");
        else if (mes == 8)
            Console.WriteLine("Agosto");
        else if (mes == 9)
            Console.WriteLine("Septiembre");
        else if (mes == 10)
            Console.WriteLine("Octubre");
        else if (mes == 11)
            Console.WriteLine("Noviembre");
        else if (mes == 12)
            Console.WriteLine("Diciembre");
        else
            Console.WriteLine("Opción no válida, por favor ingrese un número entre 1 y 12.");
    }
}
 