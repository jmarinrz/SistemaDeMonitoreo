using System;
using System.Timers;

public class temperatureSensor
{
	private double currentTemperature; //Variable donde se va a almacenar la temperatura actual
    private Random random = new Random();//Variable para generar numeros aleatorios
    private Timer timer;//Variable para controlar el tiempo

    public temperatureSensor()
    {
        timer = new Timer(1000);//Se inicializa el timer para que se ejecute cada segundo
        timer.Elapsed += (s,e) => generateTemperature();//Se llama a la funcion generateTemperature cada vez que se ejecuta el timer
        timer.Start();//Se inicia el timer
    }
    public event EventHandler HighTemperatureReached;
    public event EventHandler LowTemperatureReached;

    public void GenerateTemperature()
        {
        currentTemperature = random.Next(20, 100);//Se genera un numero aleatorio entre 20 y 100
        if(currentTemperature > 75)
        {
            HighTemperatureReached?.Invoke(this, EventArgs.Empty);//Si la temperatura es mayor a 75 se lanza el evento de alta temperatura
        }
        else if(currentTemperature < 30)
        {
            LowTemperatureReached?.Invoke(this, EventArgs.Empty);//Si la temperatura es menor a 30 se lanza el evento de baja temperatura
        }
    }
    
    
}
