using _180209_Practica5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180209_Practica5.Classes
{
    public class Customer : IObserver
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public void update(Observable observable, object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
