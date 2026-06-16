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
            Console.WriteLine("\n<<<<< MENU >>>>>");
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
            opcion = int.Parse(Console.ReadLine());

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
                    Console.WriteLine("Opción incorrecta");
                    break;
            }

        } while (opcion != 9);
    }

    static void Registrar()
{
if (cantidad >= MAX)
{
Console.WriteLine("Capacidad máxima alcanzada");
return;
}

string codigo;

do
{
    Console.Write("Código: ");
    codigo = Console.ReadLine();

    if (codigo == "")
    {
        Console.WriteLine("El código no puede estar vacío.");
    }

} while (codigo == "");

string nombre;

do
{
    Console.Write("Nombre: ");
    nombre = Console.ReadLine();

    if (nombre == "")
    {
        Console.WriteLine("El nombre no puede estar vacío.");
    }

} while (nombre == "");

Console.Write("Precio: ");
string textoPrecio = Console.ReadLine();

double precio;

if (textoPrecio == "")
{
    precio = 0;
    Console.WriteLine("Precio vacío. Se asignó 0.");
}
else
{
    precio = double.Parse(textoPrecio);

    while (precio < 0)
    {
        Console.WriteLine("El precio no puede ser negativo.");
        Console.Write("Precio: ");
        precio = double.Parse(Console.ReadLine());
    }
}

Console.Write("Stock: ");
string textoStock = Console.ReadLine();

int stock;

if (textoStock == "")
{
    stock = 0;
    Console.WriteLine("Stock vacío. Se asignó 0.");
}
else
{
    stock = int.Parse(textoStock);

    while (stock < 0)
    {
        Console.WriteLine("El stock no puede ser negativo.");
        Console.Write("Stock: ");
        stock = int.Parse(Console.ReadLine());
    }
}

codigos[cantidad] = codigo;
nombres[cantidad] = nombre;
precios[cantidad] = precio;
stocks[cantidad] = stock;

cantidad++;

Console.WriteLine("Producto registrado correctamente.");

Console.WriteLine("\nPresione una tecla para continuar...");
Console.ReadKey();
Console.Clear();

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