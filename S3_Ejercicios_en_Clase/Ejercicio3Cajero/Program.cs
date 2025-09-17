namespace Ejercicio3Cajero
{
    internal class Program
    {
        static string user = "usuario";
        static string password = "12345";
        static decimal saldo = 8473m;
        static bool sesionIniciada = false;

        static bool IniciarSesion()
        {
            Console.Write("Ingresa nombre de usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Ingresa la contrasena: ");
            string contrasena = Console.ReadLine();

            if (usuario == user && contrasena == password)
            {
                Console.WriteLine("Sesion iniciada correctamente.");
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Saldo()
        {
            Console.WriteLine($"Su saldo es de {saldo}");
        }

        static void Retirar()
        {
            Console.Write("Ingresa la cantidad a retirar: ");
            decimal retiro = Convert.ToDecimal(Console.ReadLine());
            if (retiro > 0 && retiro <= saldo)
            {
                saldo-= retiro;
                Console.WriteLine($"El retiro fue realizado con exito. Nuevo saldo: {saldo}");
            }
            else
            {
                Console.WriteLine("Cantidad invalida o fondos insuficientes");
            }
        }

        static void Depositar()
        {
            Console.Write("Ingresa la cantidad que vas a depositar: ");
            decimal deposito = Convert.ToDecimal(Console.ReadLine());
            if (deposito > 0)
            {
                saldo += deposito;
                Console.WriteLine($"Deposito realizado con exito. Nuevo saldo: {saldo}");
            }
            else
            {
                Console.WriteLine("deposito invalido");
            }
        }

        static void CerrarSesion()
        {
            Console.WriteLine("Cerrando sesion....");
            sesionIniciada = false;
        }
        static void Main(string[] args)
        {
            if (IniciarSesion())
            {
                sesionIniciada = true;
                while (sesionIniciada)
                {
                    Console.WriteLine("\nSelecciona una opcion");
                    Console.WriteLine("1. Consultar saldo");
                    Console.WriteLine("2. Retirar dinero");
                    Console.WriteLine("3. Depositar dinero");
                    Console.WriteLine("4. Cerrar sesion");
                    Console.Write("opcion: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1": Saldo(); break;
                        case "2": Retirar(); break;
                        case "3": Depositar(); break;
                        case "4": CerrarSesion(); break;
                        default: Console.WriteLine("Opcion Invalida"); break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Inicio de sesion fallido");
            }
        }
    }
}
