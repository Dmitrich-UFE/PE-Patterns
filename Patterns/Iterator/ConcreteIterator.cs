using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class ConcreteIterator: Iterator
    {
        IterableCollection _collection;
        int currentPosition;


        internal ConcreteIterator(IterableCollection collection)
        {
            _collection = collection;
            currentPosition = 0;

        }

        double Iterator.getNext() 
        {
            if (((Iterator)this).HasMore()) 
            {
                ++currentPosition;
            }

            return _collection[currentPosition];
        }

        bool Iterator.HasMore() 
        {
            return currentPosition < _collection.Count();
        }

    }
}
