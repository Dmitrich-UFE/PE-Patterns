using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Shape
    {
        internal Transform transform { get; set; }

        internal Shape(Transform transform)
        {
            this.transform = transform;
        }
    }
}
