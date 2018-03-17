using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180309_Factory_01
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public string makePizza()
        {
            return "Making pizza";
        }

        public string bakePizza()
        {
            return "Baking pizza";
        }

        public string cutPizza()
        {
            return "Cutting pizza";
        }

        public string boxPizza()
        {
            return "Boxing pizza";
        }
    }
}
