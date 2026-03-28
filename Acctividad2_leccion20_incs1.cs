internal class Program
{
    private static void Main(string[] args)
    {
        // VARIABLES
        string contraseña;
        // ENTRADA DE DATOS
        Console.Write("Por favor ingrese la contraseña: ");
        contraseña = Console.ReadLine();
        // PROCESO Y VALIDACIÓN
        if (contraseña == "Password123")
        {
            Console.WriteLine("Bienvenido");
        }
        else
        {
            Console.WriteLine("Ingreso prohibido");
        }
    }
}