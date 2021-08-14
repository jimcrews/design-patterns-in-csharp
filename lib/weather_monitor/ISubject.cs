using lib.weather_monitor.Observers;

namespace lib.weather_monitor
{
    interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObserver();
    }
}