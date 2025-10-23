using System.Data;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            bool paridad = (num % 2 == 0) ? true : false;

            Console.Write((paridad) ? "El numero ingresado es par." : "El numero ingresado es impar");
        }
    }
}