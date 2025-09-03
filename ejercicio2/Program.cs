int cantidad;
decimal precioUnitario;
decimal subtotal;
decimal iva;



try
{
    Console.WriteLine("Ingrese la cantidad de productos: ");
    cantidad = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el precio unitario: ");
    precioUnitario = decimal.Parse(Console.ReadLine());

    subtotal = cantidad * precioUnitario;
    Console.WriteLine("El subtotal es: " + subtotal);
    iva = subtotal * 0.15m;
    Console.WriteLine("El IVA es: " + iva);
    Console.WriteLine("El total a pagar es: " + (subtotal + iva));
}
catch (OverflowException)
{
    Console.WriteLine("Error: El valor ingresado es demasiado grande.");
}
catch (FormatException)
{
    Console.WriteLine("Error: Formato de entrada no valido. por favor, ingrese un numero entero para la cantidad de productos o un decimal para el precio unitario.");
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

