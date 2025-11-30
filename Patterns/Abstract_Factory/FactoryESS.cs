using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class FactoryESS: Factory
    {
        Bag Factory.CreateBag() { return new SchoolBag(10); }
        Shirt Factory.CreateShirt() { return new BlueShirt(); }
    }
}
