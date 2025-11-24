using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántos estudiantes? ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        double[] notas = new double[n];
        double suma = 0;
        int aprobados = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nota del estudiante {i + 1}: ");
            double nota = double.Parse(Console.ReadLine() ?? "0");
            notas[i] = nota;

            suma += nota;
            if (nota >= 11)
            {
                aprobados++;
            }
        }

        double promedio = n > 0 ? suma / n : 0;

        Console.WriteLine();
        Console.WriteLine($"Promedio de notas: {promedio:F2}");
        Console.WriteLine($"Aprobados: {aprobados}");
        Console.WriteLine($"Desaprobados: {n - aprobados}");
    }
}

