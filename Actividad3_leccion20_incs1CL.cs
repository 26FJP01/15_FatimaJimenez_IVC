internal class Program
{
    private static void Main(string[] args)
    {
        // VARIABLES
        int dia;
        // ENTRADA DE DATOS
        Console.Write("Ingrese el número del día de la semana (1-7): ");
        dia = Convert.ToInt32(Console.ReadLine());
        // PROCESO Y VALIDACIÓN
        if (dia >= 1 || dia <= 7)
        {
            Console.WriteLine("Fin de semana");
        }
        else if (dia >= 2 && dia <= 6)
        {
            Console.WriteLine("Entre semana");
        }
        else
        {
            Console.WriteLine("Número inválido. Debe ser un número del 1 al 7.");
        }
    }
}