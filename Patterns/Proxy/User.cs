using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class User
    {
        internal bool HasPremium { get; }

        internal User(bool hasPremium)
        {
            HasPremium = hasPremium;
        }
    }
}
