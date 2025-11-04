using System;
using System.Linq;

namespace Eje08Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            char[,] matriz = new char[10, 10];
            int[] posicionesX = new int[20];
            int pasadas = 0;
            int posPasada = 0;
            int aux;
            int fila;
            int columna;
            int aciertos = 0;
            Random random = new Random();

            // Generar posiciones únicas
            for (int i = 0; i < posicionesX.Length; i++)
            {
                aux = random.Next(0, 100);
                while (posicionesX.Contains(aux))
                {
                    aux = random.Next(0, 100);
                }
                posicionesX[i] = aux;
            }

            Array.Sort(posicionesX);

            // Llenar la matriz con X en las posiciones elegidas
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (posPasada < posicionesX.Length && pasadas == posicionesX[posPasada])
                    {
                        matriz[i, j] = 'X'; // esconder X
                        posPasada++;
                    }
                    else
                    {
                        matriz[i, j] = '*'; // vacío
                    }

                    pasadas++;
                    // Debug visual opcional
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Juego
            do
            {
                Console.Write("Ingrese la fila donde cree que hay una X (0-9): ");
                fila = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la columna donde cree que hay una X (0-9): ");
                columna = int.Parse(Console.ReadLine());

                if (matriz[fila, columna] == 'X')
                {
                    Console.WriteLine("¡Acertaste!");
                    matriz[fila, columna] = '#'; // marcar acierto
                    aciertos++;

                    if (aciertos == posicionesX.Length)
                    {
                        Console.WriteLine("¡Felicidades! Has encontrado todas las X.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Fallaste. Te quedan {2 - intentos} intentos.");
                    intentos++;
                }

            } while (intentos < 3);

            Console.WriteLine("\nEstado final de la matriz:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
