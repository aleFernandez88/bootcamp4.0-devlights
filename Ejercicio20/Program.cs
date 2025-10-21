
namespace Ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(palabra))
            {
                Console.WriteLine("No ingresó ninguna palabra.");
                return;
            }

            int contadorVocales = CantVocales(palabra);

            Console.WriteLine($"\nLa palabra \"{palabra}\" tiene {contadorVocales} vocales.");
        }

        static int CantVocales(string texto)
        {
            int cont = 0;
            string vocales = "aeiouáéíóúAEIOUÁÉÍÓÚ";

            foreach (char c in texto)
            {
                if (vocales.Contains(c))
                {
                    cont++;
                }
            }

            return cont;
        }
    }
}