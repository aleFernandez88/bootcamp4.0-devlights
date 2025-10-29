// Crear una variable para guardar los nombres de elementos para una “lista de
// supermercado”. Solicitar al usuario que ingrese el nombre de un elemento que va a
// comprar en el super y verificar que el elemento esté en la lista. Si no está, agregarlo
// e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba. Al
// finalizar mostrar por pantalla los elementos que no compró y los que compró, pero
// no estaban en la lista. Si se quiere, mostrar también todos los elementos que el
// usuario compró. Para salir el usuario debe ingresar “fin”.

namespace Eje04Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listaSupermercado = { "leche", "pan", "huevos", "queso", "frutas", "verduras" };
            List<string> elementosNoComprados = new List<string>(listaSupermercado);
            List<string> elementosCompradosNoLista = new List<string>();
            List<string> elementosComprados = new List<string>();

            bool bandera = true;
            do
            {
                Console.WriteLine("Ingrese el nombre del elemento que va a comprar (o 'fin' para terminar):");
                string input = Console.ReadLine().ToLower();

                if (input == "fin")
                {
                    bandera = false;
                }

                if (elementosNoComprados.Contains(input))
                {
                    elementosNoComprados.Remove(input);
                    elementosComprados.Add(input);
                    Console.WriteLine($"El elemento '{input}' estaba en la lista y ha sido comprado.");
                }
                else
                {
                    elementosCompradosNoLista.Add(input);
                    elementosComprados.Add(input);
                    Console.WriteLine($"El elemento '{input}' no estaba en la lista y ha sido agregado a los comprados.");
                }
            } while (bandera);


            Console.WriteLine("\nElementos que no compró:");
            foreach (var item in elementosNoComprados)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nElementos que compró pero no estaban en la lista:");
            foreach (var item in elementosCompradosNoLista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTodos los elementos que compró:");
            foreach (var item in elementosComprados)
            {
                Console.WriteLine(item);
            }
        }
    }
}