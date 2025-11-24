//Suma de números pares

using System;

class PC3
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }
        Console.WriteLine("La suma de los números pares entre 1 y 100 es: " + suma);
    }
}
