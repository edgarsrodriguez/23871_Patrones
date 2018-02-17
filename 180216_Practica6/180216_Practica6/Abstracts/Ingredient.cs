using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180216_Practica6.Classes
{
    public abstract class Ingredient : Beverage
    {
        public abstract override string Description { get; set; }
        public abstract override double Cost { get; set; }

        public abstract override string getDescription();

        public abstract override double getCost();
    }
}
