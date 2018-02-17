using _180216_Practica6.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180216_Practica6.Ingredients
{
    public class EspressoShot : Ingredient
    {
        public EspressoShot(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public Beverage Beverage { get; set; }
        public override string Description { get; set; }
        public override double Cost { get; set; }
        public override int Size { get; set; }

        public override double getCost()
        {
            switch (Beverage.getSize())
            {
                case 1:
                    Cost = 0.25;
                    break;
                case 2:
                    Cost = 0.50;
                    break;
                case 3:
                default:
                    Cost = 0.75;
                    break;
            }
            return Beverage.getCost() + Cost;
        }

        public override string getDescription()
        {
            return Beverage.getDescription() + ", Espresso Shot";
        }

        public override int getSize()
        {
            return Beverage.getSize();
        }
    }
}
