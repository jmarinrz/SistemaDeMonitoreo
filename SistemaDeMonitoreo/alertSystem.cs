using System;

public class alertSystem
{
	public void OnHighTempererature(object sender, TemperatureEventArgs e)
	{

		Console.WriteLine($"ALERTA: Temperatura alta detectada: {e.Temperature}°C");

    }
	public void OnLowTemperature(object sender, TemperatureEventArgs e)
	{
		Console.WriteLine($"ALERTA: Temperatura baja detectada: {e.Temperature}°C");

    }

}
