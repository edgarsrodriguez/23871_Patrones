using _180209_Practica4A.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180209_Practica4A.Clases
{
    public class WeatherData : Observable
    {
        public WeatherData()
        {
            
        }

        double Temperature { get; set; }
        double Pressure { get; set; }
        double Humidity { get; set; }

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

        public void measurementChanged(object obj)
        {
            setChanged();
            notify(obj);
        }
    }
}
