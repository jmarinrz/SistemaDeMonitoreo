using System;
// Se encarga de recibir las notificaciones de temperatura alta o baja
// y mostrar mensajes al usuario cuando estos eventos ocurren.

public class alertSystem
{
    // Método que se ejecuta cuando el evento de temperatura alta es lanzado
    // 'sender' es el objeto que dispara el evento (en este caso el sensor)
    // 'e' contiene la información de la temperatura actual

    public void OnHighTemperature(object sender, TemperatureEventArgs e)
	{
		console.writeline($"ALERTA: Temperatura alta detectada: {e.Temperature}°C");
    }

    // Método que se ejecuta cuando el evento de temperatura alta es lanzado
    // 'sender' es el objeto que dispara el evento (en este caso el sensor)
    // 'e' contiene la información de la temperatura actual

    public void OnLowTemperature(object sender, TemperatureEventArgs e)
		{
		console.writeline($"ALERTA: Temperatura baja detectada: {e.Temperature}°C");
    }
}
