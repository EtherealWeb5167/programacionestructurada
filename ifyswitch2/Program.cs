int dia = 0;

Console.Write("Ingresa un numero ");
dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1: Console.Write("Lunes"); break;
    case 2: Console.Write("Martes"); break;
    case 3: Console.Write("Miercoles"); break;
    case 4: Console.Write("Jueves"); break;
    case 5: Console.Write("Viernes"); break;
    case 6: Console.Write("Sabado"); break;
    case 7: Console.Write("Domingo"); break;
    default:
        {
            Console.Write("El numero tiene que estar entre 1 y 7"); break;
    }
}