namespace Ejercicio2Supermercado
{
    internal class Program
    {

        static (List<string>, List<double>, List<int>) Ingreso()
        {
            var productos = new List<string>();
            var precios = new List<double>();
            var cantidades = new List<int>();

            Console.WriteLine("Ingrese sus productos. Para terminar, deje espacio en blanco y presione enter.");

            while (true)
            {
                Console.Write("Nombre del producto: ");
                string nombre = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    break;
                }

                Console.Write("Precio del producto: ");
                double precio = Convert.ToDouble(Console.ReadLine());

                Console.Write("Cantidad de este producto: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                productos.Add(nombre);
                precios.Add(precio);
                cantidades.Add(cantidad);
            }
            return (productos, precios, cantidades);
        }
        static double Subtotal(List<double> precios, List<int> cantidades)
        {
            double subtotal = 0;

            for (int conteo = 0; conteo < precios.Count; conteo++) // cada producto
            {
                subtotal += precios[conteo] * cantidades[conteo]; // esto multiplica el precio de cada producto por su cantidad
            }
            return subtotal;
        }
        static double Impuesto(double subtotal)
        {
            double tax = subtotal * 0.16;
            return tax;
        }

        static void Factura(List<string> productos, List<double> precios, List<int> cantidades, double subtotal, double impuesto)
        {
            Console.WriteLine("Factura:");
            for (int i = 0; i < productos.Count; i++)
            {
                double totalProducto = precios[i] * cantidades[i];
                Console.WriteLine($"Producto: {productos[i]}");
                Console.WriteLine($"Precio: {precios[i]}");
                Console.WriteLine($"Cantidad: {cantidades[i]}");
                Console.WriteLine($"Total de este producto: {totalProducto}");
                Console.WriteLine(); // Espacio entre productos
            }
            Console.WriteLine($"Subtotal: {subtotal}");
            Console.WriteLine($"Impuesto 16%: {impuesto}");
            Console.WriteLine($"Total a pagar: {(subtotal + impuesto)}");
        }
        static void Main(string[] args)
        {
            var (productos, precios, cantidades) = Ingreso();
            double subtotal = Subtotal(precios, cantidades);
            double impuesto = Impuesto(subtotal);
            Factura(productos, precios, cantidades, subtotal, impuesto);
        }
    }
}
