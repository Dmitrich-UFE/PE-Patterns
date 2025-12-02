using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Manager
    {
        private Person _person;
        private Banana? _banana;

        internal Banana banana { get { return _banana; } }
        internal void AskPersonToGiveBanana(string text) 
        {
            Console.WriteLine($"Менеджер: {text}");
            _person.ListenManager();
            _banana = _person.banana;
        }

        internal Manager(Person person) { _person = person; }
    }
}
