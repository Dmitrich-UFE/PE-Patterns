using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Prototype
{
    internal class Message: IMessage
    {
        private string _text;

        internal Message(string ex_text): base(ex_text) { _text = ex_text; }
        internal Message(IMessage paper): base(paper) { _text = paper.Text; }

        internal override IMessage Clone() 
        {
            return new Message(this);
        }

    }
}
