using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180309_Factory_01
{
    class Program
    {
        static void Main(string[] args)
        {
            TJFactory factory = new TJFactory("Aguacaliente");
            Pizza pepperonniPizza = factory.getPizza("Pepperoni");
            Console.WriteLine(pepperonniPizza.makePizza());
            Console.WriteLine(pepperonniPizza.bakePizza());
            Console.WriteLine(pepperonniPizza.cutPizza());
            Console.WriteLine(pepperonniPizza.boxPizza());

            Console.ReadLine();
        }
    }
}
