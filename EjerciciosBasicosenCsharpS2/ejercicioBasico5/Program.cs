namespace ejercicioBasico5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, par = 0, impar = 0, conteo;
            for (conteo = 1; conteo <= 10; conteo++)
            {
                Console.Write("Ingresa un numero entero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }Console.WriteLine("De los 10 numeros ingresados, " + par + " son pares y " + impar + " son impares.");
        }
    }
}
