using _180216_Practica6.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180216_Practica6.Beverages
{
    public class PayuEspresso : Beverage
    {
        public PayuEspresso(int size)
        {
            this.Description = "PayuEspresso";
            this.Size = size;
        }
        public override string Description { get; set; }
        public override double Cost { get; set; }
        public override int Size { get; set; }

        public override double getCost()
        {
            switch (this.Size)
            {
                case 1:
                    Cost = 1.00;
                    break;
                case 2:
                    Cost = 1.50;
                    break;
                case 3:
                default:
                    Cost = 2.00;
                    break;
            }
            return Cost;
        }

        public override string getDescription()
        {
            return Description;
        }

        public override int getSize()
        {
            return Size;
        }
    }
}
