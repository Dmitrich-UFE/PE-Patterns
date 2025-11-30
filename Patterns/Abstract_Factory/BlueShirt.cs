using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class BlueShirt: Shirt
    {
        private int _size;
        int Shirt.Size { get { return _size; } }

        void Shirt.Wear() { Console.WriteLine("Голубая рубашка наделась"); }

        internal BlueShirt() { _size = 46; }
    }
}
