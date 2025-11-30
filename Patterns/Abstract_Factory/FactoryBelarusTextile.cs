using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class FactoryBelarusTextile: Factory
    {
        Bag Factory.CreateBag() { return new BackPack(10); }
        Shirt Factory.CreateShirt() { return new BigShirt(); }
    }
}
