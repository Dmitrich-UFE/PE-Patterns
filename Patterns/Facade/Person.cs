using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Person
    {
        
        private Banana? _banana;
        internal Banana banana { get { return _banana; } }
        internal Banana GetBanana() { return new Banana(); }
        internal void ListenManager() 
        {
            Console.WriteLine("Человек услышал просьбу отдать банан менеджеру");
            _banana = GetBanana();
        }

    }
}
