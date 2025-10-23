namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero para verificar el rango: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0 && num <= 100)
            {
                Console.Write("El numero esta dentro del rango especificado.");
            }
            else
            {
                Console.Write("El numero esta fuera del rango especificado.");
            }
        }
    }
}