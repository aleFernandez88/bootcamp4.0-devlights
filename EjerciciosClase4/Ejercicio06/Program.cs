// Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de
// la semana. La estructura es para registrar la temperatura diaria de una cabina de
// pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la matriz de forma
// aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) se
// ubica en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el
// principio del programa, no es necesario pedir los valores al usuario para cada
// posición). Se nos pide hacer lo siguiente:
// a. Obtener la temperatura más alta y baja de la semana y que día se produjo
// (lunes, martes, etc.)
// b. Promedio de temperatura de la semana.
// c. Temperatura más alta del mes y su día.
namespace Eje05Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diasMes = 31;
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            int tempMax;
            int diaTempMax;
            int tempMin;
            int diaTempMin;
            double promTemp;
            int diasConTemp;
            int tempMaxMes = 7;
            int diaTempMaxMes = 0;
            int sumaTemp = 0;
            int[,] matriz = new int[5, 7];
            Random rand = new Random();
            //genero la matriz con temperaturas aleatorias
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (diasMes > 0)
                    {
                        matriz[i, j] = rand.Next(7, 39);
                        Console.Write(matriz[i, j] + " ");
                        diasMes--;
                    }
                    else
                    {
                        matriz[i, j] = 0;
                        continue;
                    }


                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                tempMax = 7;
                diaTempMax = 0;
                tempMin = 38;
                diaTempMin = 0;
                diasConTemp = 0;
                tempMaxMes = 38;
                sumaTemp = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (matriz[i, j] != 0)
                    {
                        sumaTemp += matriz[i, j];
                        diasConTemp++;
                        //Console.Write($"{sumaTemp} - {diasConTemp} | "); //para chequear    
                        if (tempMax < matriz[i, j])
                        {
                            tempMax = matriz[i, j];
                            diaTempMax = j;
                        }
                        if (tempMin > matriz[i, j])
                        {
                            tempMin = matriz[i, j];

                            diaTempMin = j;
                        }
                    }

                    // Console.Write($"{tempMax} - {tempMin} | "); //para chequear
                    if (tempMaxMes < tempMax)
                    {
                        tempMaxMes = tempMax;
                        diaTempMaxMes = j;
                    }
                }
                Console.WriteLine($"\nSemana {i + 1}: la máxima {tempMax}°C el {dias[diaTempMax]} y la mínima {tempMin}°C el {dias[diaTempMin]}");
                Console.WriteLine($"El promedio semanal {((double)sumaTemp / diasConTemp):f2}°C");
            }
            Console.WriteLine($"La maxima del mes {tempMaxMes} °C el {dias[diaTempMaxMes]}");

        }
    }
}