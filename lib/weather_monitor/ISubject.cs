using lib.weather_monitor.Observers;

namespace lib.weather_monitor
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}