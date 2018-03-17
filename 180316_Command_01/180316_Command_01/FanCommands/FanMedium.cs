using _180316_Command_01.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01.FanCommands
{
    public class FanMedium : Command
    {
        private Fan fan { get; set; }

        public void execute()
        {
            fan.Medium();
        }

        public void undo()
        {
            throw new NotImplementedException();
        }
    }
}
