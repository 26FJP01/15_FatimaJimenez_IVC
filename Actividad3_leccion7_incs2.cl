internal class Program
{
    private static void Main(string[] args)
        {
            // VARIABLES
            int AG1, AG2, AG3;
            // ENTRADA DE DATOS
            Console.WriteLine("TIPO DE TRIÁNGULO SEGÚN SUS ÁNGULOS");
            Console.Write("Ingrese el primer ángulo: ");
            AG1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo ángulo: ");
            AG2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tercer ángulo: ");
            AG3 = Convert.ToInt32(Console.ReadLine());
            // Verificar que la suma de los ángulos sea 180 grados
            if (AG1 + AG2 + AG3 == 180)
            {
                // Determinar el tipo de triángulo
                if (AG1 == AG2 && AG2== AG3)
                {
                    Console.WriteLine("El triángulo es Equilátero.");
                }
                else if (AG1 == AG2 || AG2 == AG3 || AG1 == AG3)
                {
                    Console.WriteLine("El triángulo es Isósceles.");
                }
                else
                {
                    Console.WriteLine("El triángulo es Escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Los ángulos no forman un triángulo válido.");
            }
        }
    }