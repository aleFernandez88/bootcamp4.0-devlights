namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 % numero2 == 0)
            {
                Console.Write("El primer numero es multiplo del segundo.");
            }
            else
            {
                Console.Write("El primer numero NO es multiplo del segundo.");
            }
        }
    }
}
