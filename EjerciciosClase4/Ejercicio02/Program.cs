// Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla
// cuántos son mayores de edad y cuántos no.
namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edades = { 15, 22, 18, 14, 30, 25, 17, 19, 16, 21,
                          13, 29, 20, 12, 24, 27, 11, 23, 28, 10 };

            int mayoresDeEdad = 0;
            int menoresDeEdad = 0;

            foreach (int edad in edades)
            {
                if (edad >= 18)
                {
                    mayoresDeEdad++;
                }
                else
                {
                    menoresDeEdad++;
                }
            }

            Console.WriteLine($"Mayores de edad: {mayoresDeEdad}");
            Console.WriteLine($"Menores de edad: {menoresDeEdad}");
        }
    }
}