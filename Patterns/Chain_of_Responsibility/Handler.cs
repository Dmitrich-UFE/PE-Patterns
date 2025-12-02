using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal interface Handler
    {
        internal void SetNextHandler(Handler handler);

        internal void HandleRequest(User user);
    }
}
