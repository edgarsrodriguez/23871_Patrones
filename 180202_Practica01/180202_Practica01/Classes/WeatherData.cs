using _180202_Practica01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180202_Practica01.Classes
{
    public class WeatherData : ISubject
    {
        public WeatherData()
        {
             observerList = new List<IObserver>();
        }

        double Temperature { get; set; }
        double Pressure { get; set; }
        double Humidity { get; set; }
        List<IObserver> observerList;
        public double getTemp()
        {
            return Temperature;
        }

        public double getPressure()
        {
            return Pressure;
        }

        public double getHumidity()
        {
            return Humidity;
        }

        public void measurementChanged()
        {
            notify();
        }

        public void add(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void remove(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void notify()
        {
            foreach (IObserver observer in observerList)
            {
                observer.update(Temperature,Pressure,Humidity);
            }
        }
    }
}
