using System;
using System.Globalization; // para que funcione el cultureinfo

Console.WriteLine("Ingrese la fecha de entrega, estrictamente en formato dd/MM/yyyy");
string fecha = Console.ReadLine();

try
{
    DateTime formato = DateTime.ParseExact(fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
    Console.WriteLine($"Fecha Registrada: {formato:dd/MM/yyyy}"); // formato para que solo salga la fecha y no 00.00.00
}
catch (FormatException)
{
    Console.WriteLine("Error: Formato de fecha invalido. utilice dd/MM/yyyy (ej. 05/09/2025)");
}