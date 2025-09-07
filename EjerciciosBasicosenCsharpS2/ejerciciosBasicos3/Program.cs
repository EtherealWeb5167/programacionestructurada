namespace ejerciciosBasicos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seleccion;
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Mostrar fecha actual");
            Console.WriteLine("3. Salir");
            seleccion = Convert.ToInt32(Console.ReadLine());
            switch (seleccion)
            {
                case 1: Console.WriteLine("Bienvenido"); break;
                case 2: Console.WriteLine("Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy")); break;
                case 3: Console.WriteLine("Saliendo del programa"); break;
                default: Console.WriteLine("Opción no valida"); break;
            }
        }
    }
}
