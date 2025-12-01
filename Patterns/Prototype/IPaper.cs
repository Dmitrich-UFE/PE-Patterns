using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal abstract class IPaper
    {
        internal string Text { get; }


        internal IPaper(string ex_text) { Text = ex_text; }
        internal IPaper(IPaper paper) 
        {
            Text = paper.Text;
        }

        internal abstract IPaper Clone();
    }
}
