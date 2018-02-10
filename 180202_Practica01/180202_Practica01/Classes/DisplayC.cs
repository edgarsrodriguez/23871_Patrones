using _180202_Practica01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180202_Practica01.Classes
{
    public class DisplayC : IObserver, IDisplay
    {
        double Temperature { get; set; }
        double Pressure { get; set; }
        double Humidity { get; set; }
        public void display()
        {
            Console.WriteLine("Temperature: " + Temperature + "\nPresion: " + Pressure + "\nHumedad: " + Humidity);
        }

        public void update(double temp, double pres, double hum)
        {
            this.Temperature = temp;
            this.Pressure = pres;
            this.Humidity = hum;
        }

        public void display(double param)
        {
            throw new NotImplementedException();
        }
    }
}
