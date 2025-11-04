// Diccionario de calificaciones: Crear un diccionario donde la clave sea el nombre del
// alumno y el valor sea su nota. El programa debe permitir:
// a.Agregar alumnos y sus notas.
// b. Mostrar el promedio general del curso.
// c. Indicar el alumno con mejor nota y el de peor nota.
// d. Hint: usar Dictionary<string, double> y recorrer con foreach

namespace Eje09Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> calificaciones = new Dictionary<string, double>();
            string nombre;
            double nota;
            string continuar;


            do
            {
                Console.Write("Ingrese el nombre del alumno: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese la nota del alumno: ");
                while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
                {
                    Console.Write("Nota inválida. Ingrese un valor entre 0 y 10: ");
                }

                calificaciones[nombre] = nota; // si el nombre ya existe, se actualiza la nota

                Console.Write("¿Desea agregar otro alumno? (s/n): ");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            Console.WriteLine("\n=== RESULTADOS ===");


            if (calificaciones.Count > 0)
            {
                double promedio = calificaciones.Values.Average();
                Console.WriteLine($"Promedio general del curso: {promedio:F2}");


                var mejorAlumno = calificaciones.Aggregate((a, b) => a.Value > b.Value ? a : b);
                var peorAlumno = calificaciones.Aggregate((a, b) => a.Value < b.Value ? a : b);

                Console.WriteLine($"Alumno con mejor nota: {mejorAlumno.Key} ({mejorAlumno.Value})");
                Console.WriteLine($"Alumno con peor nota: {peorAlumno.Key} ({peorAlumno.Value})");

                Console.WriteLine("\nListado completo de alumnos:");
                foreach (var alumno in calificaciones)
                {
                    Console.WriteLine($"{alumno.Key}: {alumno.Value}");
                }
            }
            else
            {
                Console.WriteLine("No se ingresaron alumnos.");
            }
        }
    }
}