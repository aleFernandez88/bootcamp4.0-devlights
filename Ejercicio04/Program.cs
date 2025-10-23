namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deme el precio de un producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            if (precio > 1000)
            {
                decimal precioDescuento = precio - precio * 0.1m;
                Console.Write($"El producto tiene un nuevo precio con descuento: {precioDescuento}");
            }
        }
    }
}
