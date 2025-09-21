using System;


namespace SistemaDeMonitoreo
{
    internal class SistemaDeMonitoreo
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor = null;
            AlertSystem alert = new AlertSystem();
            bool activo = true;
            while (activo)
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ DE MONITOREO DE TEMPERATURA ===");
                Console.WriteLine("1. Iniciar sensor");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        if (sensor == null)
                        {
                            sensor = new TemperatureSensor();
                            sensor.HighTemperatureReached += (sender, e) => alert.OnHighTemperature(sender, e);
                            sensor.LowTemperatureReached += (sender, e) => alert.OnLowTemperature(sender, e);
                            Console.WriteLine("Sensor iniciado. Presiona Enter para continuar...");
                        }
                        else
                        {
                            Console.WriteLine("El sensor ya está en funcionamiento.");
                        }
                        Console.ReadLine();
                        break;
                    case "2":
                        activo = false;
                        if (sensor != null) sensor.timer.Stop(); // Detener el timer al salir
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
    