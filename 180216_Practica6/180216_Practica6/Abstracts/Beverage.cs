using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180216_Practica6.Classes
{
    public abstract class Beverage
    {
        public abstract string Description { get; set; }
        public abstract double Cost { get; set; }
        public abstract int Size { get; set; }

        public abstract string getDescription();
        public abstract double getCost();
        public abstract int getSize();
    }
}
