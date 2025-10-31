// Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera fila y la primera columna se debe guardar los números (de 0 a 9), estando el cero en la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3, etc. usando las posiciones del array o arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla
namespace Eje07Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[10, 10];


            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    matriz[i, j] = i * j;
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
