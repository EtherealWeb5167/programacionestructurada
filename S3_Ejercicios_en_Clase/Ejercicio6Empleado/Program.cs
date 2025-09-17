//Identificar subproblemas en el cálculo de nómina de empleados
//(entrada de datos, horas trabajadas, cálculo de salario bruto, deducciones, salario neto).

namespace Tarea_Ejercicion_S3__1
{
    internal class Program
    {
        // Entrada de datos 
        static (string, double, double, double) Entrada_datos()
        {
            string nombre = "";
            double horas_trabajadas = 0, pago_hora = 0, deduccion = 0;

            Console.Write("Ingrese el nombre del empleado: ");
            try
            {
                nombre = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return ("", 0, 0, 0);
            }
            Console.Clear();

            Console.Write("Ingrese el Total de horas trabajadas: ");
            try
            {
                horas_trabajadas = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida. Por favor, ingrese un número.");
                return ("", 0, 0, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return ("", 0, 0, 0);
            }
            Console.Clear();

            Console.Write("Ingrese el pago por hora: ");
            try
            {
                pago_hora = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida. Por favor, ingrese un número.");
                return ("", 0, 0, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return ("", 0, 0, 0);
            }
            Console.Clear();

            Console.Write("Ingrese la deducción a aplicar: ");
            try
            {
                deduccion = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no válida. Por favor, ingrese un número.");
                return ("", 0, 0, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return ("", 0, 0, 0);
            }
            Console.Clear();

            return (nombre, horas_trabajadas, pago_hora, deduccion);
        }

        // Cálculo de salario bruto
        static double Calculo_salario_bruto(double horasTrabajadas, double pagoPorHora)
        {
            return horasTrabajadas * pagoPorHora;
        }

        // Cálculo de salario neto
        static double Calculo_salario_neto(double salarioBruto, double deduccion)
        {
            return salarioBruto - deduccion;
        }

        // Print de la nómina
        static void Impresion_nomina(string nombre, double horasTrabajadas, double pagoPorHora, double salarioBruto, double deduccion, double salarioNeto)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nNómina de '{nombre}':");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");
            Console.WriteLine($"Pago por hora: {pagoPorHora}");
            Console.WriteLine($"Salario bruto: {salarioBruto}");
            Console.WriteLine($"Deducción: {deduccion}");
            Console.WriteLine($"Salario neto: {salarioNeto}");
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            var (nombre, horasTrabajadas, pagoPorHora, deduccion) = Entrada_datos();
            double salarioBruto = Calculo_salario_bruto(horasTrabajadas, pagoPorHora);
            double salarioNeto = Calculo_salario_neto(salarioBruto, deduccion);
            Impresion_nomina(nombre, horasTrabajadas, pagoPorHora, salarioBruto, deduccion, salarioNeto);
        }
    }
}
