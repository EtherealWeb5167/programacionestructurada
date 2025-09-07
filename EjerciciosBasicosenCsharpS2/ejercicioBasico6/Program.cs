namespace ejercicioBasico6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un numero entero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 0)
            {
                Console.WriteLine("El numero es 0");
            }
            else if (numero > 0)
            {
                Console.WriteLine("Ese numero es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Ese numero es negativo");
            }
        }
    }
}
