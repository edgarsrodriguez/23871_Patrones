using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180309_Factory_01
{
    public abstract class PizzaFactory : Pizza
    {
        public PizzaFactory()
        {

        }

        public Pizza getPizza(string name)
        {
            Pizza pizza = new PepperonniPizza();
            switch (name)
            {
                case "Pepperonni":
                    pizza = new PepperonniPizza();
                    break;
                case "Cheese":
                    pizza = new CheesePizza();
                    break;
                case "Vegetarian":
                    pizza = new VegetarianPizza();
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
