using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal interface Bag
    {
        int Weight { get; set; }
        void Zip();
    }
}
