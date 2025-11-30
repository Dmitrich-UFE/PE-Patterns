using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class BackPack: Bag
    {
        private int _weight;

        int Bag.Weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("value должен быть больше нуля");
                _weight = value;
            }
        }

        void Bag.Zip() { Console.WriteLine("Ранец застегнулся"); }

        public BackPack(int ex_eight) { ((Bag)this).Weight = ex_eight; }
    }
}
