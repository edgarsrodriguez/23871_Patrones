using _180316_Command_01.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01.RoofLightCommands
{
    public class RoofLightOff : Command
    {
        public RoofLight RoofLight { get; set; }
        public void execute()
        {
            RoofLight.Off();
        }

        public void undo()
        {
            RoofLight.On();
        }
    }
}
