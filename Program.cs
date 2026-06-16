using System;

class Program
{
    static int MAX = 100;

    static string[] codigos = new string[MAX];
    static string[] nombres = new string[MAX];
    static double[] precios = new double[MAX];
    static int[] stocks = new int[MAX];

    static int cantidad = 0;

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Mostrar productos");
            Console.WriteLine("3. Buscar por código");
            Console.WriteLine("4. Modificar producto");
            Console.WriteLine("5. Insertar en posición");
            Console.WriteLine("6. Eliminar producto");
            Console.WriteLine("7. Ordenar por burbuja");
            Console.WriteLine("8. Resumen");
            Console.WriteLine("9. Salir");

            Console.Write("Opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

        } while (opcion != 9);
    }
}