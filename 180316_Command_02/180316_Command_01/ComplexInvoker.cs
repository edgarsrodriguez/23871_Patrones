using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01
{
    public class ComplexInvoker
    {
        Stack<Command> Stack = new Stack<Command>();
        List<Command> Slots = new List<Command>(7) { new BlankCommand(), new BlankCommand(), new BlankCommand(), new BlankCommand(), new BlankCommand(), new BlankCommand(), new BlankCommand(), new BlankCommand() };

        public void SetCommand(Command command, int index)
        {
            Slots.Insert(index, command);
        }

        public void PressButton(int index)
        {
            Stack.Push(Slots[index]);
            Slots[index].execute();
        }

        public void Undo()
        {
            if (Stack.Count() > 0)
            {
                Stack.Pop().undo();
            }
            else
            {
                Console.WriteLine("No se arma compa");
                Console.ReadLine();
            }
        }
    }
}
