using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01
{
    public class SimpleInvoker
    {
        Command slot1;

        public void SetCommand(Command command)
        {
            slot1 = command;
        }

        public void PressButton()
        {
            slot1.execute();
        }
    }
}
