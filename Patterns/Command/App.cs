using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class App
    {
        Editor GEditor {  get; set; }
        CommandHistory History { get; set; }

        internal App(CommandHistory history, Editor editor) 
        {
            GEditor = editor;
            History = history;
        }


        internal void ExecuteCommand(Command command) 
        {
            if (command.Execute())
                History.AddToHistory(command);
        }

        internal void Undo() 
        {
            try 
            {
                Command _command = History.DeleteFromHistory();
                if (_command != null)
                    _command.ApplyState();
            }
            catch (InvalidOperationException) 
            {
                Console.WriteLine("History is Empty");
            }
        }

    }
}
