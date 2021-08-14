using lib.weather_monitor.Observers;

namespace lib.weather_monitor
{
    class WeatherData : ISubject
    {
        public void NotifyObserver()
        {
            throw new System.NotImplementedException();
        }
        public void RegisterObserver(IObserver o)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveObserver(IObserver o)
        {
            throw new System.NotImplementedException();
        }
        public void GetTemperature()
        {

        }
        public void GetHumidity()
        {

        }
        public void GetPressure()
        {

        }
        public void MeasurementsChanged()
        {

        }


    }
}