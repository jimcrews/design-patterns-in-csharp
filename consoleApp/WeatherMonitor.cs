using System;
using lib.weather_monitor;
using lib.weather_monitor.Observers;

namespace consoleApp
{
    class WeatherMonitor
    {
        public static void Run()
        {
            WeatherData weatherData = new WeatherData();
            IObserver currentDisplay = new CurrentConditionsDisplay(weatherData); // register observer in constructor
            weatherData.SetMeasurements(50, 55, 3f);
            weatherData.SetMeasurements(80, 65, 4f);

            weatherData.RemoveObserver(currentDisplay);

            weatherData.SetMeasurements(90, 75, 5f); // observer 'Current Conditions doesnt get this one'

            weatherData.RegisterObserver(currentDisplay); // register 'Current Conditions' again
            weatherData.SetMeasurements(95, 78, 9f);

        }
    }
}
