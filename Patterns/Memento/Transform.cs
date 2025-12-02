using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Transform
    {
        internal int x {  get; set; }
        internal int y { get; set; }
        internal Transform(int x, int y) { this.x = x; this.y = y; }
    }
}
