using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal interface IterableCollection
    {

        Iterator CreateIterator();

        internal double this[int index] { get; set; }

        internal int Count();

        internal void Add(double d);
        internal double RemoveLast();
        internal void Clear();

    }
}
