Console.Write("Ingresa un numero de 1 a 3 ");

string seleccion = Console.ReadLine();

switch (seleccion)
{
    case "1": Console.Write("Usted estudia medicina"); break;
    case "2": Console.Write("Usted esta estudiando ingenieria en sistemas"); break;
    case "3": Console.Write("Usted no esta estudiando nada"); break;
    default: Console.Write("Ese numero no esta dentro del rango"); break;
}