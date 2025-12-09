using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class MessageCountSubscriber: ISubscriber
    {
        void ISubscriber.Update() 
        {
            Console.WriteLine("A new messages have arrived");
        }
    }
}
