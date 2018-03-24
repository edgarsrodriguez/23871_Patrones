using _180316_Command_01.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01.FanCommands
{
    public class FanOff : Command
    {
        public Fan Fan { get; set; }
        public void execute()
        {
            Fan.Off();
        }

        public void undo()
        {
            Fan.Low();
        }
    }
}
