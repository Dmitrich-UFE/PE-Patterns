using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal abstract class Command
    {
        protected Editor GEditor { get; private set; } 
        protected App App { get; private set; }
        protected List<IShape> BackupShapes { get; private set; }


        internal abstract bool Execute();

        internal Command(Editor _GEditor, App _App) 
        {
            this.GEditor = _GEditor;
            this.App = _App;
        }

        internal void BackupState() 
        {
            BackupShapes = GEditor.GetState();
        }

        internal void ApplyState() 
        {
            GEditor.SaveState(BackupShapes);
        }


    }
}
