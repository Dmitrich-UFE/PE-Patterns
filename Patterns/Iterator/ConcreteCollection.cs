using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class ConcreteCollection : IterableCollection
    {
        List<double> doubles;

        Iterator IterableCollection.CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        internal ConcreteCollection() 
        {
            doubles = new List<double>();
        }

        double IterableCollection.this[int index] 
        {
            get => doubles[index];
            set => doubles[index] = value;
        }

        int IterableCollection.Count() { return doubles.Count; }

        void IterableCollection.Add(double d) { doubles.Add(d); }
        double IterableCollection.RemoveLast() { double last = doubles.Last(); doubles.Remove(doubles.Last()); return last; }
        void IterableCollection.Clear() { doubles.Clear(); }
    }
}
