// using System:

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de productos: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el costo de cada proudcto: ");
        double costoUnitario = double.Parse(Console.ReadLine());

        double costoTotal = cantidad * costoUnitario;
        double descuento = 0;

        if (cantidad >= 10 && cantidad <= 20)
        {
            descuento = 5;
        }
        else if (cantidad > 20)
        {
            descuento = 10;
        }

        double costoFinal = costoTotal - (costoTotal * descuento / 100);
        Console.WriteLine("\nCosto total del pedido: " + costoFinal);
    }
}
