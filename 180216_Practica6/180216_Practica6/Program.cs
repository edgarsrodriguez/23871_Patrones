using _180216_Practica6.Beverages;
using _180216_Practica6.Classes;
using _180216_Practica6.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180216_Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage bebida = new PayuEspresso(1);
            Console.WriteLine(bebida.getDescription() + " $" + bebida.getCost());
            bebida = new SoyMilk(bebida);
            Console.WriteLine(bebida.getDescription() + " $" + bebida.getCost());
            bebida = new Sugar(bebida);
            Console.WriteLine(bebida.getDescription() + " $" + bebida.getCost());
            bebida = new EspressoShot(bebida);
            Console.WriteLine(bebida.getDescription() + " $" + bebida.getCost());

            Console.ReadKey();
        }
    }
}
