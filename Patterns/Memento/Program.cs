using static Memento.Editor;

namespace Memento
{
    internal class Program
    {
        //Отмена действий в графическом редакторе
        static Stack<EditorMemento> _states = new Stack<EditorMemento>();


        static void Main(string[] args)
        {
            Editor _editor = new Editor();
            AddToHistory(_editor.Save());

            _editor.AddShape(new Shape(new Transform(3, 4)));
            _editor.AddShape(new Shape(new Transform(5, 8)));
            AddToHistory(_editor.Save());


            _editor.AddShape(new Shape(new Transform(6, -4)));
            _editor.AddShape(new Shape(new Transform(11, -8)));
            AddToHistory(_editor.Save());

            Console.WriteLine($"Сейчас в редакторе сохранено {_editor.Count()} фигур");

            _editor.Restore(Undo());
            Console.WriteLine($"Сейчас в редакторе сохранено {_editor.Count()} фигур");


            _editor.Restore(Undo());
            Console.WriteLine($"Сейчас в редакторе сохранено {_editor.Count()} фигур");

            _editor.Restore(Undo());
            Console.WriteLine($"Сейчас в редакторе сохранено {_editor.Count()} фигур");

        }

        static EditorMemento Undo() 
        {
            if (_states.Count() > 0) 
            {
                Console.WriteLine("Откат редактора...");
                return _states.Pop();
            }
            return null;
        }

        static void AddToHistory(EditorMemento eM) 
        {
            _states.Push(eM);
            Console.WriteLine("Состояние добавляется...");
        }
    }
}
