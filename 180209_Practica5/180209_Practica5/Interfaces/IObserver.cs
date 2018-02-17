using _180209_Practica5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180209_Practica5.Interfaces
{
    public interface IObserver
    {
        void update(Observable observable, object obj);
    }
}
