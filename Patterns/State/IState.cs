using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal abstract class State
    {
        protected Context _context = null;

        internal void SetContext(Context context) { _context = context; }

        internal abstract void Do();

    }
}
