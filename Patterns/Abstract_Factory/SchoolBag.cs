using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class SchoolBag: Bag
    {
        private int _weight;

        int Bag.Weight 
        { get { return _weight; }
          set 
            { 
                if (value <= 0) throw new ArgumentOutOfRangeException("value должен быть больше нуля");
                _weight = value;
            } 
        }

        void Bag.Zip() { Console.WriteLine("Школьная сумка застегнулась"); }

        internal SchoolBag(int ex_eight) { ((Bag)this).Weight = ex_eight; }
    }
}
