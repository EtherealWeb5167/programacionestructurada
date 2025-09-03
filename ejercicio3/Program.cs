Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.Write("Ingrese su numero de whatsapp: ");
string whatsapp = Console.ReadLine();

if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(whatsapp))
{
    nombre = null;
}
try
{
    string normalizacion = nombre.ToUpper();
    Console.WriteLine("Nombre: " + normalizacion);
    Console.WriteLine("WhatsApp: " + whatsapp);
}
catch (NullReferenceException)
{
    Console.WriteLine("Un dato no fue proporcionado. Imposible normalizar los datos del cliente.");
}