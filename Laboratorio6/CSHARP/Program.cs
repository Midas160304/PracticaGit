using System;

class Program
{
    static void Main()
    {
        string[] productos = new string[6];
        bool registrado = false;
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ DE PRODUCTOS ===");
            Console.WriteLine("1. Registrar productos");
            Console.WriteLine("2. Buscar producto");
            Console.WriteLine("3. Modificar producto");
            Console.WriteLine("4. Mostrar lista completa");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n--- REGISTRAR PRODUCTOS ---");
                    for (int i = 0; i < productos.Length; i++)
                    {
                        Console.Write($"Producto {i + 1}: ");
                        productos[i] = Console.ReadLine();
                    }
                    registrado = true;
                    break;

                case 2:
                    if (!registrado)
                    {
                        Console.WriteLine("\nPrimero debes registrar los productos.");
                        break;
                    }

                    Console.Write("\nIngresa el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    bool encontrado = false;

                    for (int i = 0; i < productos.Length; i++)
                    {
                        if (productos[i].Equals(buscar, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Producto encontrado: {productos[i]} (posición {i})");
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                        Console.WriteLine("Producto no encontrado.");

                    break;

                case 3:
                    if (!registrado)
                    {
                        Console.WriteLine("\nPrimero debes registrar los productos.");
                        break;
                    }

                    Console.Write("\nIngresa el número de producto a modificar (1-6): ");
                    int indice = int.Parse(Console.ReadLine()) - 1;

                    if (indice < 0 || indice >= productos.Length)
                    {
                        Console.WriteLine("Índice fuera de rango.");
                    }
                    else
                    {
                        Console.Write($"Nuevo nombre para {productos[indice]}: ");
                        productos[indice] = Console.ReadLine();
                        Console.WriteLine("Producto modificado correctamente.");
                    }

                    break;

                case 4:
                    if (!registrado)
                    {
                        Console.WriteLine("\nPrimero debes registrar los productos.");
                        break;
                    }

                    Console.WriteLine("\n--- LISTA COMPLETA DE PRODUCTOS ---");
                    for (int i = 0; i < productos.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {productos[i]}");
                    }

                    break;

                case 5:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 5);
    }
}

