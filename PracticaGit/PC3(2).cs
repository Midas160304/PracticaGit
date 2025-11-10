//Calculadora de Promedio

class Program
{
    static void Main()
    {
        double suma = 0;
        int contador = 0;
        string respuesta;

        do
        {
            Console.Write("Ingrese un número: ");
            double numero = double.Parse(Console.ReadLine() ?? "0");

            suma += numero;
            contador++;

            Console.Write("¿Desea ingresar otro número? (s/n): ");
            respuesta = Console.ReadLine()?.ToLower();

        } while (respuesta == "s");

        if (contador > 0)
        {
            double promedio = suma / contador;
            Console.WriteLine($"\nEl promedio de los números ingresados es: {promedio}");
        }
        else
        {
            Console.WriteLine("\nNo se ingresaron números, no se puede calcular el promedio.");
        }
    }
}