using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Shop
    {
        private Manager _manager;
        internal Banana GetBanana() 
        {
            Console.WriteLine("Где-то в магазине:");
            _manager.AskPersonToGiveBanana("бананы гони");
            Banana _banana = AskManagerToGiveBanana();
            Console.WriteLine("Готово! У вас банан");
            return _banana;
        }

        internal Banana AskManagerToGiveBanana()
        {
            if (_manager.banana != null)
                return _manager.banana;
            else throw new NoBananaFoundException();
        }
        internal Shop() 
        {
            Person person = new Person();   
            _manager = new Manager(person);
        }
    }
}
