// Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares
// pares. Imprimir la matriz por pantalla

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matriz = new char[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        matriz[i, j] = 'P';
                    }
                    else
                    {
                        matriz[i, j] = 'I';
                    }
                }

            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}