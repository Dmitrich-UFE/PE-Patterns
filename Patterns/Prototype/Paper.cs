using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Prototype
{
    internal class Paper: IPaper
    {
        private string _text;
        internal string Text { get { return _text; } }

        internal Paper(string ex_text): base(ex_text) { _text = ex_text; }
        internal Paper(IPaper paper): base(paper) { _text = paper.Text; }

        internal override IPaper Clone() 
        {
            return new Paper(this);
        }

    }
}
