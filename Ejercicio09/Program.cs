namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su ingreso anual para calcular el impuesto: ");
            double ingreso = double.Parse(Console.ReadLine());
            double impuesto;
            if (ingreso >= 50000)
            {
                impuesto = ingreso * 0.20;
                Console.Write($"El impuesto anual en base a su ingreso es de 20%.Y debera pagar la suma de {impuesto}");
            }
            else if (ingreso >= 10000)
            {
                impuesto = ingreso * 0.10;
                Console.Write($"El impuesto anual en base a su ingreso es de 10%.Y debera pagar la suma de {impuesto}");
            }
            else
            {
                impuesto = ingreso * 0.0;
                Console.Write($"El impuesto anual en base a su ingreso es de 0%.Y debera pagar la suma de {impuesto}");
            }
        }
    }
}