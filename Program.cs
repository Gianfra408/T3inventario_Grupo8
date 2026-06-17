using System;

class Program
{
    static int MAX = 100;
    static int opcion;
    static string[] codigos = new string[MAX];
    static string[] nombres = new string[MAX];
    static double[] precios = new double[MAX];
    static int[] stocks = new int[MAX];

    static int cantidad = 0;

    static void Main()
    {
        

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
    Console.Clear();
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

PresioneParaContinuar();


}

//DANIEL GUTIERREZ - MOSTRANDO LOS PRODUCTOS REGISTRADOS
    static void Mostrar()
    {
        
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("                 MUESTRA DE PRODUCTOS:");
            Console.WriteLine("----------------------------------------------------------------------------");
        if (cantidad == 0)
            {
                Console.WriteLine("\nNo hay productos registrados");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("[" + i + "] Código: " + codigos[i] +
                                 " | Nombre: " + nombres[i] +
                                 " | Precio: S/" + precios[i].ToString("F2") +
                                 " | Stock: " + stocks[i]);
            }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
   
    }

    static void Buscar()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("No hay productos registrados.");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        string codigo;
        do
        {
            Console.Write("Código a buscar: ");
            codigo = Console.ReadLine() ?? "";
            codigo = codigo.Trim();

            if (codigo == "")
            {
                Console.WriteLine("El código no puede estar vacío.");
            }

        } while (codigo == "");

        int posicion = -1;

        for (int i = 0; i < cantidad; i++)
        {
            if (string.Equals(codigos[i], codigo, StringComparison.OrdinalIgnoreCase))
            {
                posicion = i;
                break;
            }
        }

        if (posicion == -1)
        {
            Console.WriteLine("Producto no encontrado.");
        }
        else
        {
            Console.WriteLine("\nProducto encontrado:");
            Console.WriteLine("Código: " + codigos[posicion]);
            Console.WriteLine("Nombre: " + nombres[posicion]);
            Console.WriteLine("Precio: " + precios[posicion]);
            Console.WriteLine("Stock: " + stocks[posicion]);
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        PresioneParaContinuar();
    }

    static void Modificar()
    {
    Console.Write("Ingrese el código del producto a modificar: ");
    string codigoBuscado = Console.ReadLine();

    for (int i = 0; i < cantidad; i++)
    {
        if (codigos[i] == codigoBuscado)
        {
            Console.Write("Nuevo nombre: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Nuevo precio: ");
            precios[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nuevo stock: ");
            stocks[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Producto modificado correctamente");
            return;
        }
    }
    
        Console.WriteLine("Producto no encontrado");
        if (cantidad == 0)
        {
            Console.WriteLine("No hay productos registrados.");
            Console.WriteLine("\nPresione una tecla para continuar...");
            PresioneParaContinuar();
            return;
        }
        string codigo;

        do
        {
            Console.Write("Código del producto a modificar: ");
            codigo = Console.ReadLine();

            if (codigo == "")
            {
                Console.WriteLine("El código no puede estar vacío.");
            }

        } while (codigo == "");
        int posicion = -1;

        for (int i = 0; i < cantidad; i++)
        {
            if (codigos[i] == codigo)
            {
                posicion = i;
                break;
            }
        }

        if (posicion == -1)
        {
            Console.WriteLine("Producto no encontrado.");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        Console.WriteLine("\nProducto actual:");
        Console.WriteLine("Código: " + codigos[posicion]);
        Console.WriteLine("Nombre: " + nombres[posicion]);
        Console.WriteLine("Precio: " + precios[posicion]);
        Console.WriteLine("Stock: " + stocks[posicion]);

        string nuevoNombre;

        do
        {
            Console.Write("Nuevo nombre: ");
            nuevoNombre = Console.ReadLine();

            if (nuevoNombre == "")
            {
                Console.WriteLine("El nombre no puede estar vacío.");
            }

        } while (nuevoNombre == "");

        Console.Write("Nuevo precio: ");
        string textoPrecio = Console.ReadLine();

        double nuevoPrecio;

        if (textoPrecio == "")
        {
            nuevoPrecio = 0;
            Console.WriteLine("Precio vacío. Se asignó 0.");
        }
        else
        {
            nuevoPrecio = double.Parse(textoPrecio);

            while (nuevoPrecio < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
                Console.Write("Nuevo precio: ");
                nuevoPrecio = double.Parse(Console.ReadLine());
            }
        }

        Console.Write("Nuevo stock: ");
        string textoStock = Console.ReadLine();

        int nuevoStock;

        if (textoStock == "")
        {
            nuevoStock = 0;
            Console.WriteLine("Stock vacío. Se asignó 0.");
        }
        else
        {
            nuevoStock = int.Parse(textoStock);

            while (nuevoStock < 0)
            {
                Console.WriteLine("El stock no puede ser negativo.");
                Console.Write("Nuevo stock: ");
                nuevoStock = int.Parse(Console.ReadLine());
            }
        }

        nombres[posicion] = nuevoNombre;
        precios[posicion] = nuevoPrecio;
        stocks[posicion] = nuevoStock;

        Console.WriteLine("Producto modificado correctamente.");

        Console.WriteLine("\nPresione una tecla para continuar...");
        PresioneParaContinuar();

    }

    static void Insertar()
    {
        if (cantidad >= MAX)
        {
            Console.WriteLine("Capacidad máxima alcanzada.");
            return;
        }

        Console.Write("Posición: ");
        int posicion = Convert.ToInt32(Console.ReadLine());

        if (posicion < 0 || posicion > cantidad)
        {
            Console.WriteLine("Posición inválida.");
            return;
        }

        for (int i = cantidad; i > posicion; i--)
        {
            codigos[i] = codigos[i - 1];
            nombres[i] = nombres[i - 1];
            precios[i] = precios[i - 1];
            stocks[i] = stocks[i - 1];
        }

        Console.Write("Código: ");
        codigos[posicion] = Console.ReadLine();

        Console.Write("Nombre: ");
        nombres[posicion] = Console.ReadLine();

        Console.Write("Precio: ");
        precios[posicion] = Double.Parse(Console.ReadLine());

        Console.Write("Stock: ");
        stocks[posicion] = int.Parse(Console.ReadLine());

        cantidad++;

        Console.WriteLine("Producto insertado correctamente.");
        PresioneParaContinuar();
    }

   static void Eliminar()
{
    Console.Write("Ingrese el código del producto a eliminar: ");
    string codigoBuscado = Console.ReadLine();

    int indice = ObtenerIndice(codigoBuscado);
    if (indice == -1)
    {
        Console.WriteLine("Producto no encontrado");
        return;
    }

    for (int i = indice; i < cantidad - 1; i++)
    {
        codigos[i] = codigos[i + 1];
        nombres[i] = nombres[i + 1];
        precios[i] = precios[i + 1];
        stocks[i] = stocks[i + 1];
    }

    cantidad--;

    Console.WriteLine("Producto eliminado correctamente");
    PresioneParaContinuar();
}
    //DANIEL GUTIERREZ - INSERTANDO EL PARAMETRO PARA ORDENAMIENTO DE BURBUJA
    static void OrdenarBurbuja()
    {
        for (int i = 0; i < cantidad - 1; i++)
        {
            for (int j = 0; j < cantidad - i - 1; j++)
            {
                if (precios[j] > precios[j + 1])
                {
                double auxPrecio = precios[j];
                precios[j] = precios[j + 1];
                precios[j + 1] = auxPrecio;

                string auxCodigo = codigos[j];
                codigos[j] = codigos[j + 1];
                codigos[j + 1] = auxCodigo;

                string auxNombre = nombres[j];
                nombres[j] = nombres[j + 1];
                nombres[j + 1] = auxNombre;

                int auxStock = stocks[j];
                stocks[j] = stocks[j + 1];
                stocks[j + 1] = auxStock;
                
                }
            }
        }
        Console.WriteLine("Productos ordenados correctamente.");
        PresioneParaContinuar();
    }
    static void Resumen()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("No hay productos registrados.");
             return;
        }

        double suma = 0;
        int indiceMayor = 0;
        int indiceMenor = 0;

        for (int i = 0; i < cantidad; i++)
        {
            suma += precios[i];

            if (precios[i] > precios[indiceMayor])
                indiceMayor = i;

            if (precios[i] < precios[indiceMenor])
                indiceMenor = i;
        }

        Console.WriteLine("Total de productos: " + cantidad);
        Console.WriteLine("Producto con mayor precio: " + nombres[indiceMayor]);
        Console.WriteLine("Producto con menor precio: " + nombres[indiceMenor]);
        Console.WriteLine("Suma total de precios: " + suma);
        PresioneParaContinuar();
    }
    static int ObtenerIndice(string codigoBuscado)
{
    for (int i = 0; i < cantidad; i++)
    {
        if (codigos[i] == codigoBuscado)
        {
            return i;
        }
    }

    return -1;
}
//Daniel gutierrez - metodo para presionar una tecla y continuar
static void PresioneParaContinuar()
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}