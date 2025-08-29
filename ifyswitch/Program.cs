int numero = 0;

Console.Write("Ingresa un numero ");
numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.Write("El numero " + numero + " es mayor que 0");
}
else if (numero < 0)
{
    Console.Write("El numero " + numero + " es menor que 0");
}
else
{
    Console.Write("Ese numero es 0");
}


