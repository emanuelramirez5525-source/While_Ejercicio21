// Sumar números ingresados hasta que el total supere 100

int numero;
int total = 0;

while (total <= 100)
{
    Console.WriteLine("Ingrese número positivos (presione 0 para salir)");
    numero = int.Parse(Console.ReadLine());

    total += numero;

}
Console.WriteLine("El total supero los 100");
Console.WriteLine("El total final es = " + total);