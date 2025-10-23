namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la edad de la persona: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad > 60)
            {
                Console.Write("La persona es un adulto mayor.");
            }
            else if (edad > 18)
            {
                Console.Write("La persona es un adulto.");

            }
            else if (edad > 12)
            {
                Console.Write("La persona es un adolecente.");
            }
            else
            {
                Console.Write("La persona es un niño.");

            }
        }
    }
}