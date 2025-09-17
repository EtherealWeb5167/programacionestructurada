// Diseñar subproblemas para un sistema de parqueo (entrada de vehículo, asignación de espacio, cobro por horas, salida).
using System;
using System.Collections.Generic;
public class Program
{
    // Diccionario para almacenar la hora de entrada y el espacio de cada vehículo
    private static Dictionary<string, (DateTime HoraEntrada, int EspacioAsignado)> vehiculos = new Dictionary<string, (DateTime, int)>();
    private static bool[] espacios = new bool[10]; // 10 espacios de parqueo
    private const double TARIFA_POR_HORA = 3.00;

    public static void Main(string[] args)
    {
        Console.WriteLine("--- Bienvenido al Parqueo ---");

        RegistrarEntrada("ABC-123");
        RegistrarEntrada("XYZ-456");

        System.Threading.Thread.Sleep(3600); // Pausa para simular el tiempo

        RegistrarSalida("ABC-123");
        RegistrarSalida("GHI-789"); // Vehículo no encontrado
    }

    // Subproblema: Entrada de vehículo y asignación de espacio
    public static void RegistrarEntrada(string placa)
    {
        if (vehiculos.ContainsKey(placa))
        {
            Console.WriteLine($"Error: {placa} ya está en el parqueo.");
            return;
        }

        int espacioDisponible = Array.IndexOf(espacios, false);

        if (espacioDisponible != -1)
        {
            espacios[espacioDisponible] = true;
            vehiculos.Add(placa, (DateTime.Now, espacioDisponible));
            Console.WriteLine($"Placa {placa} ha entrado. Espacio #{espacioDisponible + 1}.");
        }
        else
        {
            Console.WriteLine("Parqueo lleno, lo siento.");
        }
    }

    // Subproblema: Salida de vehículo y cobro
    public static void RegistrarSalida(string placa)
    {
        if (!vehiculos.ContainsKey(placa))
        {
            Console.WriteLine($"Error: {placa} no se encuentra en el parqueo.");
            return;
        }

        var vehiculoInfo = vehiculos[placa];

        TimeSpan duracion = DateTime.Now - vehiculoInfo.HoraEntrada;
        double costo = Math.Ceiling(duracion.TotalHours) * TARIFA_POR_HORA;

        // Liberar espacio y remover vehículo
        espacios[vehiculoInfo.EspacioAsignado] = false;
        vehiculos.Remove(placa);

        Console.WriteLine($"\nPlaca {placa} ha salido.");
        Console.WriteLine($"Duración: {duracion.TotalMinutes:F2} minutos.");
        Console.WriteLine($"Costo total: ${costo:F2}.");
    }
}