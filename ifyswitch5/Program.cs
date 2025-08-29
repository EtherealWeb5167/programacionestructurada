int year = 0;

Console.Write("Ingresa un año ");
year = int.Parse(Console.ReadLine());

if ((year % 100 != 0 && year % 4 == 0) || (year % 400 == 0))
{
    Console.Write("El año " + year + " es bisiesto");
}
else
{
    Console.Write("El año " + year + " no es bisiesto");
}