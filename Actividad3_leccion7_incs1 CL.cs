internal class Program
{
    private static void Main(string[] args)
    {
        // Solicitar el día y el mes
        Console.WriteLine("==ESTACIÓN DEL AÑO==");
        Console.Write("Ingrese el número del día: ");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el número del mes: ");
        int mes = Convert.ToInt32(Console.ReadLine());
        // Determinar la estación del año
        if (mes == 12)
        {
            if (dia >= 21)
            {
                Console.WriteLine("Es Verano");
            }
            else
            {
                Console.WriteLine("Es Primavera");
            }
        }
        else
        {
            if (mes == 1 || mes == 2)
            {
                Console.WriteLine("Es Verano");
            }
            else if (mes == 3)
            {
                if (dia < 21)
                {
                    Console.WriteLine("Es Verano");
                }
                else
                {
                    Console.WriteLine("Es Otoño");
                }
            }
            else if (mes == 4 || mes == 5)
            {
                Console.WriteLine("Es Otoño");
            }
            else if (mes == 6)
            {
                if (dia < 21)
                {
                    Console.WriteLine("Es Otoño");
                }
                else
                {
                    Console.WriteLine("Es Invierno");
                }
            }
            else if (mes == 7 || mes == 8)
            {
                Console.WriteLine("Es Invierno");
            }
            else if (mes == 9)
            {
                if (dia < 21)
                {
                    Console.WriteLine("Es Invierno");
                }
                else
                {
                    Console.WriteLine("Es Primavera");
                }
            }
            else if (mes == 10 || mes == 11)
            {
                Console.WriteLine("Es Primavera");
            }
            else
            {
                Console.WriteLine("Mes no válido.");
            }
        }
    }
}
