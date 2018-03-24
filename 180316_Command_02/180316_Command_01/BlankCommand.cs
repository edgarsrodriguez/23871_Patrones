using _180316_Command_01.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01
{
    public class BlankCommand : Command
    {
        public BlankReceiver BlankReceiver = new BlankReceiver();
        public void execute()
        {
            BlankReceiver.Execute();
        }

        public void undo()
        {
            throw new NotImplementedException();
        }
    }
}
