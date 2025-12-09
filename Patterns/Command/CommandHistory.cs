using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class CommandHistory
    {
        Stack<Command> history;

        internal CommandHistory() 
        {
            history = new Stack<Command>();
        }

        internal void AddToHistory(Command command) 
        {
            history.Push(command);
        }

        internal Command DeleteFromHistory()
        {
            return history.Pop();
        }

    }
}
