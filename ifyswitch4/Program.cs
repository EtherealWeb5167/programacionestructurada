int calificacion = 0;

Console.Write("Ingresa tu calificacion ");
calificacion = int.Parse(Console.ReadLine());

switch (calificacion)
{
    case >= 70: Console.Write("Aprobado"); break;
    case < 70 and >= 50: Console.Write("Recuperacion"); break;
    default: Console.Write("Reprobado"); break;
}