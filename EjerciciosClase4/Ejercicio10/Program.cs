// Simulador de atención en ventanilla: Usar una cola (Queue) para simular la atención
// de clientes en una ventanilla bancaria.
// a. Encolar nombres de clientes.
// b. Atender (desencolar) uno por uno hasta que no queden.
// c. Mostrar en pantalla quién está siendo atendido y cuántos quedan en la fila.
// d. Hint: usar Enqueue(), Dequeue() y Count.

using System;
using System.Collections.Generic;

namespace Eje10Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> colaClientes = new Queue<string>();

            colaClientes.Enqueue("Ana");
            colaClientes.Enqueue("Bruno");
            colaClientes.Enqueue("Carla");
            colaClientes.Enqueue("Diego");
            colaClientes.Enqueue("Elena");

            Console.WriteLine("Bienvenido al banco Verzet!");
            Console.WriteLine($"Clientes en espera: {colaClientes.Count}\n");


            while (colaClientes.Count > 0)
            {

                string clienteAtendido = colaClientes.Dequeue();

                Console.WriteLine($"Atendiendo a: {clienteAtendido}");
                Console.WriteLine($"Quedan {colaClientes.Count} cliente(s) en la fila.\n");


                System.Threading.Thread.Sleep(800);
            }

            Console.WriteLine("Todos los clientes fueron atendidos. Fin de la jornada.");
        }
    }
}
