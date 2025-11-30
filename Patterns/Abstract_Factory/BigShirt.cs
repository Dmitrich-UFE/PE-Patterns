using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class BigShirt: Shirt
    {
        private int _size;
        int Shirt.Size { get { return _size;  } }

        void Shirt.Wear() { Console.WriteLine("Большая рубашка наделась"); }

        internal BigShirt() { _size = 64; }
    }
}
