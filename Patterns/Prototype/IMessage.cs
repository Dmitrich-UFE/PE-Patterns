using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal abstract class IMessage
    {
        internal string Text { get; }


        internal IMessage(string ex_text) { Text = ex_text; }
        internal IMessage(IMessage paper) 
        {
            Text = paper.Text;
        }

        internal abstract IMessage Clone();
    }
}
