using System;
using System.Timers;

namespace SistemaDeMonitoreo
{
    public class TemperatureSensor
    {
        private double currentTemperature; // Variable donde se va a almacenar la temperatura actual
        private Random random = new Random(); // Variable para generar números aleatorios
        public Timer timer; // Variable que va a controlar el tiempo entre cada generación de temperatura

        public TemperatureSensor()
        {
            timer = new Timer(1000); // Se inicializa el timer para que se ejecute cada segundo
            timer.Elapsed += (s, e) => GenerateTemperature(); // Se llama a la función GenerateTemperature cada vez que se ejecuta el timer
            timer.Start(); // Se inicia el timer
        }

        public event EventHandler<TemperatureEventArgs> HighTemperatureReached;
        public event EventHandler<TemperatureEventArgs> LowTemperatureReached;

        public double GetCurrentTemperature()
        {
            return currentTemperature;
        }

        public void GenerateTemperature()
        {
            currentTemperature = random.Next(20, 101); // Se genera un número aleatorio entre 20 y 100
            if (currentTemperature > 75)
            {
                HighTemperatureReached?.Invoke(this, new TemperatureEventArgs(currentTemperature)); // Se lanza el evento de alta temperatura
            }
            else if (currentTemperature < 30)
            {
                LowTemperatureReached?.Invoke(this, new TemperatureEventArgs(currentTemperature)); // Se lanza el evento de baja temperatura
            }
        }
    }
}
