using System;

class Program
{
    // Función por referencia
    static void CalcularDatos(int[] notas, ref double promedio, ref int maxima, ref int minima)
    {
        int suma = 0;

        maxima = notas[0];
        minima = notas[0];

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];

            if (notas[i] > maxima)
            {
                maxima = notas[i];
            }

            if (notas[i] < minima)
            {
                minima = notas[i];
            }
        }

        promedio = (double)suma / notas.Length;
    }

    // Función por valor
    static int CalcularAprobados(int[] notas)
    {
        int aprobados = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= 12)
            {
                aprobados++;
            }
        }

        return aprobados;
    }

    static void Main()
    {
        Console.Write("¿Cuántas notas deseas ingresar?: ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] notas = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            int nota;

            do
            {
                Console.Write($"Ingresa la nota {i + 1}: ");
                nota = int.Parse(Console.ReadLine());

                if (nota < 0 || nota > 20)
                {
                    Console.WriteLine("Nota inválida, ingresa entre 0 y 20.");
                }

            } while (nota < 0 || nota > 20);

            notas[i] = nota;
        }

        double promedio = 0;
        int maxima = 0;
        int minima = 0;

        CalcularDatos(notas, ref promedio, ref maxima, ref minima);

        int aprobados = CalcularAprobados(notas);
        int desaprobados = cantidad - aprobados;

        double porcentajeAprobados = (double)aprobados * 100 / cantidad;
        double porcentajeDesaprobados = (double)desaprobados * 100 / cantidad;

        Console.WriteLine("\n--- Reporte del Salón ---");

        Console.Write("\nNotas ingresadas: ");

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write(notas[i] + " ");
        }

        Console.WriteLine($"\n\nPromedio       : {promedio:F2}");
        Console.WriteLine($"Nota máxima    : {maxima}");
        Console.WriteLine($"Nota mínima    : {minima}");

        Console.WriteLine($"\nAprobados      : {aprobados} ({porcentajeAprobados:F2}%)");
        Console.WriteLine($"Desaprobados   : {desaprobados} ({porcentajeDesaprobados:F2}%)");

        if (porcentajeDesaprobados > 75)
        {
            Console.WriteLine("\nALERTA: Más del 75% del salón ha desaprobado.");
        }
    }
}