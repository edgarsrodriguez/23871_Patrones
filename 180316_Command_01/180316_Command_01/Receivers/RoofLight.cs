using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01.Receivers
{
    public class RoofLight
    {
        public void On()
        {
            Console.WriteLine("Encendiendo luces del techo");
            Console.ReadLine();
        }

        public void Off()
        {
            Console.WriteLine("Apagando luces del techo");
            Console.ReadLine();
        }

        public void Dim()
        {
            Console.WriteLine("Bajando luces del techo");
            Console.ReadLine();
        }
    }
}
