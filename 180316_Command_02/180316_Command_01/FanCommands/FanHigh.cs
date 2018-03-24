using _180316_Command_01.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01.FanCommands
{
    public class FanHigh : Command
    {
        public Fan Fan { get; set; }

        public void execute()
        {
            Fan.High();
        }

        public void undo()
        {
            Fan.Medium();
        }
    }
}
