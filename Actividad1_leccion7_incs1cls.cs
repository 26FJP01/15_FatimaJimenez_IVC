internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==BUZON DE VOZ==");
        //DECLARACION DE VARIABLES
        int opcion;
        //ENTRADA DE DATOS
        Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1. Ventas");
        Console.WriteLine("2. Soporte tecnico");
        Console.WriteLine("3. Facturacion");
        Console.WriteLine("4. Dejar mensaje");
        opcion = Convert.ToInt32(Console.ReadLine());

        //PROCESO Y SALIDA
        if (opcion == 1)
            Console.WriteLine("Ha seleccionado Ventas");
        else
            if (opcion == 2)
                Console.WriteLine("Ha seleccionado Soporte tecnico");
            else
                if (opcion == 3)
                    Console.WriteLine("Ha seleccionado Facturacion");
                else
                    if (opcion == 4)
                        Console.WriteLine("Por favor deje su mensaje despues del tono...");
                    else
                        Console.WriteLine("Opcion no valida");
    }
}
