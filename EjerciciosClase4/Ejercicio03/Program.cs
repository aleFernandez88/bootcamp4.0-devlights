// Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que
// tenga menos letras de todos.

namespace Eje03Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes = { "Ana", "Bernardo", "Cecilia", "David", "Elena", "Fernando" };

            string estudianteMasLargo = estudiantes[0];
            string estudianteMasCorto = estudiantes[0];

            foreach (string estudiante in estudiantes)
            {
                if (estudianteMasCorto.Length < estudiante.Length)
                {
                    estudianteMasLargo = estudiante;
                }
                if (estudianteMasCorto.Length > estudiante.Length)
                {
                    estudianteMasCorto = estudiante;
                }
            }
            Console.WriteLine("Estudiante con más letras: " + estudianteMasLargo);
            Console.WriteLine("Estudiante con menos letras: " + estudianteMasCorto);
        }
    }
}