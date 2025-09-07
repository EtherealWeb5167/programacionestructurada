namespace ejercicioBasico9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;
            Console.Write("Ingresa el numero 1: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el numero 2: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el numero 3: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("El numero " + numero1 + " Es el mayor");
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine("El numero " + numero2 + " Es el mayor");
            }
            else if (numero3 > numero2 && numero3 > numero1)
            {
                Console.WriteLine("El numero " + numero3 + " Es el mayor");
            }
            else if (numero1 == numero2 && numero2 == numero3)
            {
                Console.WriteLine("Todos los numeros son iguales");
            }
        }
    }
}
