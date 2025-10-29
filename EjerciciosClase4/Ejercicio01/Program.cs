// Dado que se tiene almacenado en una lista, los resultados de los últimos 10
// exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas de
// los exámenes y el promedio resultante.
namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notasAlumnoA = { 7.5, 8.0, 6.5, 9.0, 5.5, 8.5, 7.0, 6.0, 9.5, 8.0 };
            double sumaNotas = 0;
            for (int i = 0; i < notasAlumnoA.Length; i++)
            {
                sumaNotas += notasAlumnoA[i];
                Console.WriteLine("Nota del examen " + (i + 1) + ": " + notasAlumnoA[i]);
            }
            double promedio = sumaNotas / notasAlumnoA.Length;

            Console.WriteLine("El promedio de las notas del alumno A es: " + promedio);
        }
    }
}