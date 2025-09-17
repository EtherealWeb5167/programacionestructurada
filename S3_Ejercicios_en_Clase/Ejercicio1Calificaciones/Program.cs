namespace Ejercicio1Calificaciones
{
    internal class Program
    {
        static List<double> IngresarCalificaciones()
        {
            List<double> calificaciones = new List<double>();
            Console.Write("Cuantas calificaciones se van a ingresar? ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int conteo = 0; conteo < cantidad; conteo++)
            {
                Console.Write($"Ingresa la calificacion {conteo + 1} ");
                double calificacion = Convert.ToDouble(Console.ReadLine());
                calificaciones.Add(calificacion);
            }
            return calificaciones;
        }

        static double Promedio(List<double> calificaciones)
        {
            return calificaciones.Average();
        }

        static (int Aprobado, int Reprobado) Clasificacion(List<double> calificaciones)
        {
            int aprobado = 0, reprobado = 0;
            
            foreach (double calificacion in calificaciones)
            {
                if (calificacion >= 70)
                {
                    aprobado++;
                }
                else
                {
                    reprobado++;
                }
            }
            return (aprobado, reprobado);
        }

        static void MostrarResultados(List<double> calificaciones, double promedio, int aprobado, int reprobado)
        {
            Console.WriteLine("Resultados de esta clase: ");
            Console.WriteLine($"El grupo tuvo un promedio de {promedio:F2}");
            Console.WriteLine($"Hubieron {aprobado} Aprobados");
            Console.WriteLine($"Hubieron {reprobado} Reprobados");
        }
        static void Main(string[] args)
        {
            List<double> calificaciones = IngresarCalificaciones();
            double promedio = Promedio(calificaciones);
            var (aprobado, reprobado) = Clasificacion(calificaciones); // tupla, se utilizar var para deducirlo automaticamente
            MostrarResultados(calificaciones, promedio, aprobado, reprobado);
        }
    }
}
