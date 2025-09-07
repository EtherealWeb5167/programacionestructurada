namespace ejercicioBasico8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contrasena = "123456789", intento = "";
            while (intento != contrasena)
            {
                Console.Write("Ingresa la contrasena: ");
                intento = Console.ReadLine();
                if (intento != contrasena)
                {
                    Console.WriteLine("Contrasena incorrecta, intenta nuevamente");
                }
                
            }
            Console.WriteLine("Bienvenido");
            

        }
    }
}
