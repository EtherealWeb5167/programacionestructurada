int costo;
int participantes;
int costoporparticipante;

Console.Write("Ingrese el costo total ");
costo = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de participantes ");
participantes = int.Parse(Console.ReadLine());

try
{
    costoporparticipante = costo / participantes;
    Console.WriteLine("El costo por participante es: " + costoporparticipante);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: La cantidad de participantes no puede ser cero.");
}
