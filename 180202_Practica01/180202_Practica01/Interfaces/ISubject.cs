using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180202_Practica01.Interfaces
{
    public interface ISubject
    {
        void add(IObserver observer);
        void remove(IObserver observer);
        void notify();
    }
}
