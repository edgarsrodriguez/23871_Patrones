using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01
{
    public interface Command
    {
        void execute();
        void undo();
    }
}
