namespace ejerciciosBasicos10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias, semanas, residuo;
            Console.Write("Ingresa una cantidad de dias: ");
            dias = Convert.ToInt32(Console.ReadLine());
            residuo = dias % 7;
            semanas = dias / 7;
            Console.WriteLine($"{dias} Dias son {semanas} Semanas y {residuo} Dias");

        }
    }
}
