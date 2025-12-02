using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class Good
    {
        internal string Name { get; }
        internal int Price {  get; }

        internal Good(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
