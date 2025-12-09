using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    
    internal class Editor
    {
        List<IShape> shapes;

        internal Editor() 
        {
            shapes = new List<IShape>();
        }

        internal void AddShape(IShape shape) 
        {
            shapes.Add(shape);
        }

        internal void RemoveLastShape() 
        {
            shapes.RemoveAt(shapes.Count - 1);
        }

        internal void SaveState(List<IShape> shapes) 
        {
            this.shapes = shapes;
        }

        internal List<IShape> GetState()
        {
            return shapes;
        }


    }
}
