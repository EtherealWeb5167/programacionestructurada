namespace ejercicioBasico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un número entero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("Ese numero no es un entero positivo");
            }
            else
            {
                int suma = 0;
                for (int i = 1; i <= numero; i++)
                {
                    suma += i;
                }
                Console.WriteLine("La suma de los números enteros positivos desde 1 hasta " + numero + " es: " + suma);
            }   
            


        }
    }
}
