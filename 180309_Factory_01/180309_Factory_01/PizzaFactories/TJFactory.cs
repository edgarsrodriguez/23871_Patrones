using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180309_Factory_01
{
    public class TJFactory : PizzaFactory
    {
        public TJFactory(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
