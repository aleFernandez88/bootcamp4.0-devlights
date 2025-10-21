// Ejercicio 1
// Número positivo o negativo: Pedir un número y mostrar si es positivo, negativo o cero.

Console.Write("Ingrese un numero: ");
int numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.Write("El numero es positivo.");
}
else if (numero < 0)
{
    Console.Write("El numero es negativo.");
}
else
{
    Console.Write("El numero es cero.");
}
