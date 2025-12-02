using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Editor
    {
        private List<Shape> _shapes;

        internal Editor() 
        {
            _shapes = new List<Shape>(); 
        }

        internal void AddShape(Shape shape) { _shapes.Add(shape); }

        internal EditorMemento Save() 
        {
            Console.WriteLine("Состояние редактора сохранено");
            return new EditorMemento(_shapes); 
        }
        internal void Restore(EditorMemento state) 
        {
            _shapes = new List<Shape>(state.GetState());
            Console.WriteLine("Состояние редактора восстановлено");
        }

        internal int Count() {  return _shapes.Count; }


        //класс для создания снимков 
        internal class EditorMemento 
        {
            private List<Shape> em_shapes;

            internal EditorMemento(List<Shape> shapes) 
            {
                em_shapes = new List<Shape>(shapes);
            }

            internal List<Shape> GetState() 
            {
                return em_shapes;
            }
        
        }


    }
}
