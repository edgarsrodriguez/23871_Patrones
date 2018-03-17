using _180316_Command_01.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01.RoofLightCommands
{
    public class RoofLightOn : Command
    {
        public RoofLight roofLight { get; set; }
        public void execute()
        {
            roofLight.On();
        }

        public void undo()
        {
            throw new NotImplementedException();
        }
    }
}
