using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class AddTriangleShape : Command
    {
        internal override bool Execute() 
        {
            BackupState();
            GEditor.AddShape(new Triangle());
            Console.WriteLine("Added Triangle");
            return true;
        }

        public AddTriangleShape(Editor _GEditor, App _App) : base(_GEditor, _App)
        {
        }
    }

    internal class AddCircleShape : Command
    {
        internal override bool Execute()
        {
            BackupState();
            GEditor.AddShape(new Circle());
            Console.WriteLine("Added Circle");
            return true;
        }

        public AddCircleShape(Editor _GEditor, App _App) : base(_GEditor, _App)
        {
        }
    }

    internal class AddSquareShape : Command
    {
        internal override bool Execute()
        {
            BackupState();
            GEditor.AddShape(new Square());
            Console.WriteLine("Added Square");
            return true;
        }

        public AddSquareShape(Editor _GEditor, App _App) : base(_GEditor, _App)
        {
        }
    }

    internal class Undo: Command 
    {
        public Undo(Editor _GEditor, App _App) : base(_GEditor, _App)
        {
        }

        internal override bool Execute() 
        {
            App.Undo();
            Console.WriteLine("Undo");
            return false;
        }


    }
}
