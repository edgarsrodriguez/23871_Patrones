using _180209_Practica4A.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180209_Practica4A.Interfaces
{
    public interface IObserver
    {
        void update(Observable observable, object obj);
    }
}
