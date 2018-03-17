using _180316_Command_01.Receivers;
using _180316_Command_01.RoofLightCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleInvoker SimpleInvoker = new SimpleInvoker();
            RoofLight RoofLight = new RoofLight();
            RoofLightOn RoofLightOn = new RoofLightOn();
            RoofLightOn.roofLight = RoofLight;
            SimpleInvoker.SetCommand(RoofLightOn);
            SimpleInvoker.PressButton();
        }
    }
}
