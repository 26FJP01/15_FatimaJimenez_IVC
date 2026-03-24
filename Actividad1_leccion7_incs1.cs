using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==PROMEDIO DE CALIFICACIONES==");
        //DECLARACION DE VARIABLES
        string materia;
        int n1, n2, n3, n4, n5;
        double promedio;
        //ENTRADA DE DATOS
        Console.WriteLine("ingrese el nombre de la materia: ");
        materia=Console.ReadLine();
        Console.WriteLine("ingrese 5 calificaciones:");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());  
        n3 = Convert.ToInt32(Console.ReadLine());
        n4 = Convert.ToInt32(Console.ReadLine());  
        n5 = Convert.ToInt32(Console.ReadLine());
        //proceso
        promedio = (n1 + n2 + n3 + n4 + n5) / 5;
        //evaluar si gano o perdio
        if (promedio >= 70)
            Console.WriteLine("el proedio es " + promedio + " y el estudiante aprobo");
        else
            Console.WriteLine("el promedio es " + promedio + "y el estudiante reprobo");
    }
}