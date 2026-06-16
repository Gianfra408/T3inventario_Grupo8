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
            Console.WriteLine("3. Buscar por c贸digo");
            Console.WriteLine("4. Modificar producto");
            Console.WriteLine("5. Insertar en posici贸n");
            Console.WriteLine("6. Eliminar producto");
            Console.WriteLine("7. Ordenar por burbuja");
            Console.WriteLine("8. Resumen");
            Console.WriteLine("9. Salir");

            Console.Write("Opci贸n: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Registrar();
                    break;
                case 2:
                    Mostrar();
                    break;
                case 3:
                    Buscar();
                    break;
                case 4:
                    Modificar();
                    break;
                case 5:
                    Insertar();
                    break;
                case 6:
                    Eliminar();
                    break;
                case 7:
                    OrdenarBurbuja();
                    break;
                case 8:
                    Resumen();
                    break;
                case 9:
                    Console.WriteLine("Fin del programa");
                    break;
                default:
                    Console.WriteLine("Opci贸n incorrecta");
                    break;
            }

        } while (opcion != 9);
    }

    static void Registrar()
    {

    }

    static void Mostrar()
    {

    }

    static void Buscar()
    {

    }

    static void Modificar()
    {

    }

    static void Insertar()
    {

    }

    static void Eliminar()
    {

    }

    static void OrdenarBurbuja()
    {

    }

    static void Resumen()
    {

    }
}