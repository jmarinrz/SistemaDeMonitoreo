using System;

namespace SistemaDeMonitoreo
{
    public class TemperatureEventArgs : EventArgs
    {
        public double Temperature { get; }

        public TemperatureEventArgs(double temperature)
        {
            Temperature = temperature;
        }
    }
}