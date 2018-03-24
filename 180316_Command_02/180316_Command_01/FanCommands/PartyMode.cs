using _180316_Command_01.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01.FanCommands
{
    public class PartyMode : Command
    {
        public List<Command> CommandList = new List<Command>();

        public void execute()
        {
            foreach (var com in CommandList)
            {
                com.execute();
            }
        }

        public void undo()
        {
            for (int i = CommandList.Count() - 1; i >= 0; i--)
            {
                CommandList[i].undo();
            }
        }
    }
}
