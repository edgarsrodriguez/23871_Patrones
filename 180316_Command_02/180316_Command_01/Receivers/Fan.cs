using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01.Receivers
{
    public class Fan
    {
        public void High()
        {
            Console.WriteLine("Ventilador en velocidad alta");
            Console.ReadLine();
        }

        public void Medium()
        {
            Console.WriteLine("Ventilador en velocidad media");
            Console.ReadLine();
        }

        public void Low()
        {
            Console.WriteLine("Ventilador en velocidad baja");
            Console.ReadLine();
        }

        public void Off()
        {
            Console.WriteLine("Ventilador apagado");
            Console.ReadLine();
        }
    }
}
