using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ DE EJERCICIOS ===");
                Console.WriteLine("10. Día de la semana");
                Console.WriteLine("11. Operaciones básicas");
                Console.WriteLine("12. Contador de pares");
                Console.WriteLine("13. Suma de números impares");
                Console.WriteLine("14. Contador de letras");
                Console.WriteLine("15. Tabla de multiplicar");
                Console.WriteLine("16. Promedio de notas");
                Console.WriteLine("17. Contador hasta cero");
                Console.WriteLine("18. Suma acumulada hasta 100");
                Console.WriteLine("19. Contador de dígitos");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");

                opcion = int.Parse(Console.ReadLine() ?? "0");
                Console.Clear();

                switch (opcion)
                {
                    case 10:
                        DiaDeLaSemana();
                        break;
                    case 11:
                        MenuOperaciones();
                        break;
                    case 12:
                        ContadorPares();
                        break;
                    case 13:
                        SumaImpares();
                        break;
                    case 14:
                        ContadorLetras();
                        break;
                    case 15:
                        TablaMultiplicar();
                        break;
                    case 16:
                        PromedioNotas();
                        break;
                    case 17:
                        ContarHastaCero();
                        break;
                    case 18:
                        SumaHastaCien();
                        break;
                    case 19:
                        ContarDigitos();
                        break;
                    case 0:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        // 10. Día de la semana
        static void DiaDeLaSemana()
        {
            Console.Write("Ingresa un número del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine() ?? "0");

            string nombreDia = dia switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Número inválido"
            };

            Console.WriteLine($"Día correspondiente: {nombreDia}");
        }

        // 11. Menú con operaciones
        static void MenuOperaciones()
        {
            Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir");
            Console.Write("Elige una operación: ");
            int opcion = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingresa el primer número: ");
            double num1 = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingresa el segundo número: ");
            double num2 = double.Parse(Console.ReadLine() ?? "0");

            double resultado = opcion switch
            {
                1 => num1 + num2,
                2 => num1 - num2,
                3 => num1 * num2,
                4 => num2 != 0 ? num1 / num2 : double.NaN,
                _ => double.NaN
            };

            if (double.IsNaN(resultado))
                Console.WriteLine("Operación inválida o división por cero.");
            else
                Console.WriteLine($"Resultado: {resultado}");
        }

        // 12. Contador de pares
        static void ContadorPares()
        {
            Console.Write("Ingresa un número N: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int contador = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0) contador++;
            }

            Console.WriteLine($"Hay {contador} números pares entre 1 y {n}.");
        }

        // 13. Suma de impares
        static void SumaImpares()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de los números impares del 1 al 100 es: {suma}");
        }

        // 14. Contador de letras
        static void ContadorLetras()
        {
            Console.Write("Ingresa una palabra: ");
            string palabra = Console.ReadLine() ?? "";
            Console.WriteLine($"La palabra '{palabra}' tiene {palabra.Length} letras.");
        }

        // 15. Tabla de multiplicar
        static void TablaMultiplicar()
        {
            Console.Write("Ingresa un número: ");
            int num = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Tabla de multiplicar del {num}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        // 16. Promedio de notas
        static void PromedioNotas()
        {
            double suma = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingresa la nota {i}: ");
                suma += double.Parse(Console.ReadLine() ?? "0");
            }

            double promedio = suma / 5;
            string resultado = promedio >= 6 ? "Aprobado" : "Reprobado";
            Console.WriteLine($"Promedio: {promedio:F2} - {resultado}");
        }

        // 17. Contador hasta cero
        static void ContarHastaCero()
        {
            int contador = 0, num;
            do
            {
                Console.Write("Ingresa un número (0 para salir): ");
                num = int.Parse(Console.ReadLine() ?? "0");
                if (num != 0) contador++;
            } while (num != 0);

            Console.WriteLine($"Ingresaste {contador} números en total.");
        }

        // 18. Suma acumulada hasta 100
        static void SumaHastaCien()
        {
            int suma = 0, contador = 0;
            while (suma <= 100)
            {
                Console.Write("Ingresa un número: ");
                suma += int.Parse(Console.ReadLine() ?? "0");
                contador++;
            }
            Console.WriteLine($"La suma superó 100 luego de ingresar {contador} números.");
        }

        // 19. Contador de dígitos
        static void ContarDigitos()
        {
            Console.Write("Ingresa un número entero: ");
            string numero = Console.ReadLine() ?? "";
            Console.WriteLine($"El número tiene {numero.Length} dígitos.");
        }
    }
}
