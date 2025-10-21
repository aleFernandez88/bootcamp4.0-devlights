// See https://aka.ms/new-console-template for more information
namespace Ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 30043.43m;
            bool bandera = true;
            do
            {
                Console.Clear();
                Console.WriteLine("========== MENÚ PRINCIPAL ==========");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Retirar saldo");
                Console.WriteLine("3. Depositar saldo");
                Console.WriteLine("4. Salir");
                Console.WriteLine("===================================");
                Console.Write("Selecciona una opción (1-4): ");

                //aca guardo la elección
                string opcion = Console.ReadLine();
                //tiro el switch con los distintos escenarios
                switch (opcion)
                {
                    case "1":
                        ConsultarSaldo(saldo);
                        break;

                    case "2":

                        RetirarDinero(saldo);
                        break;

                    case "3":

                        DepositarDinero(saldo);
                        break;

                    case "4":
                        Console.WriteLine("\n💠 Saliendo del programa...");
                        bandera = true;
                        break;

                    default:
                        Console.WriteLine("\n⚠️ Opción no válida. Intente nuevamente.");
                        break;
                }
                if (bandera)
                {
                    Console.WriteLine("\nPresione alguna tecla para volver al menú...");
                    Console.ReadKey();
                }
            } while (bandera);

        }
        // ------------------------------
        //  FUNCIONES AUXILIARES
        // ------------------------------
        static void ConsultarSaldo(decimal saldo)
        {
            Console.WriteLine($"\n Su saldo actual es: ${saldo}");
        }

        static decimal DepositarDinero(decimal saldo)
        {
            Console.Write("\nIngrese el monto a depositar: ");
            string? entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out decimal monto))
            {
                if (monto <= 0)
                {
                    Console.WriteLine(" El monto debe ser mayor que cero.");
                }
                else
                {
                    saldo += monto;
                    Console.WriteLine($" Depósito exitoso. Nuevo saldo: ${saldo}");
                }
            }
            else
            {
                Console.WriteLine(" Entrada inválida. Debe ingresar un número.");
            }

            return saldo;
        }
        static decimal RetirarDinero(decimal saldo)
        {
            Console.Write("\nIngrese el monto a retirar: ");
            string? entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out decimal monto))
            {
                if (monto <= 0)
                {
                    Console.WriteLine("El monto debe ser mayor que cero.");
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("Saldo insuficiente para realizar el retiro.");
                }
                else
                {
                    saldo -= monto;
                    Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${saldo}");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debe ingresar un número.");
            }

            return saldo;
        }

    }
}
