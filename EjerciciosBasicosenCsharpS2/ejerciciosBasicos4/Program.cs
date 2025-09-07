namespace ejerciciosBasicos4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, conteo = 1;
            Console.Write("Ingrese un número entero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tabla de multiplicar del " + numero);
            do
            {
                Console.WriteLine(numero + " x " + conteo + " = " + (numero * conteo));
                conteo++;
            }while (conteo <= 10);
        }
    }
}
