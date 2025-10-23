namespace Ejercicio05
{
    internal class Prgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero decimal: ");
            double deci = double.Parse(Console.ReadLine());
            int num = (int)deci;

            Console.Write($"El numero decimal ingresado es {deci} y convertido a entero es {num}");
        }
    }
}