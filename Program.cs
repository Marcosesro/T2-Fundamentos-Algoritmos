using System;

class Program
{
    // Función por referencia
    static void CalcularDatos(int[] notas, ref double promedio, ref int maxima, ref int minima)
    {

    }

    // Función por valor
    static int CalcularAprobados(int[] notas)
    {
        return 0;
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
    }
}