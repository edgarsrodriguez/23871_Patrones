using _180209_Practica5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180209_Practica5.Classes
{
    public class Observable
    {
        public bool changed = false;
        List<IObserver> observerList = new List<IObserver>();

        public void add(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void remove(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void notify(object obj)
        {
            foreach (IObserver observer in observerList)
            {
                observer.update(this, obj);
            }
        }

        public void setChanged()
        {
            this.changed = true;
        }

        public void clearChanged()
        {
            this.changed = false;
        }
    }
}
