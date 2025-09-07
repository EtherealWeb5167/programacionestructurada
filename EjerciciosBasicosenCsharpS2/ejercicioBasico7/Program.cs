namespace ejercicioBasico7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int conteo = 1, suma = 0;
            decimal promedio;
            Console.Write("Cuantas calificaciones queres ingresar? ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            while (conteo <= cantidad)
            {
                Console.Write("Ingresa la calificacion " + conteo + " ");
                int calificacion = Convert.ToInt32(Console.ReadLine());
                suma += calificacion;
                conteo++;

            }
            promedio = (decimal)suma / cantidad;
            Console.WriteLine($"Tu promedio es de {promedio:f2}");
        }
    }
}
