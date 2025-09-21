using System;

namespace SistemaDeMonitoreo
{
    public class AlertSystem
    {
        // Método que se ejecuta cuando se detecta una temperatura alta
        public void OnHighTemperature(object sender, TemperatureEventArgs e)
        {
            Console.WriteLine("ALERTA: Temperatura alta detectada: 82°C");
        }

        // Método que se ejecuta cuando se detecta una temperatura baja
        public void OnLowTemperature(object sender, TemperatureEventArgs e)
        {
            Console.WriteLine("ADVERTENCIA: Temperatura baja detectada: 28°C");
        }
    }
