int nota = 0;

Console.Write("Ingresa tu calificacion ");
nota = int.Parse(Console.ReadLine());

if (nota >= 70)
{
    Console.Write("Aprobado");
}
else if (nota < 50)
{
    Console.Write("Reprobado");
}
else
{
    Console.Write("Recuperacion");
}