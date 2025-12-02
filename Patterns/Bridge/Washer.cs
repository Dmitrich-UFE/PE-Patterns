using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal interface Washer
    {
        internal void Enable();
        internal void Disable();
        internal bool IsFullFilled();
        internal void Fill();
        internal void Wash();
    }
}
