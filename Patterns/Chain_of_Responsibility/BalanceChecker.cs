using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class BalanceChecker: Handler
    {
        Handler _nextHandler; 


        void Handler.HandleRequest(User user) 
        {
            Console.WriteLine("Идет проверка...");
            if (_nextHandler != null && user.OrdingGood.Price < user.Balance) 
            {
                Console.WriteLine("Денег достаточно для покупки");
                _nextHandler.HandleRequest(user);
            }
            else
                Console.WriteLine("Недостаточный баланс для покупки");
        }

        void Handler.SetNextHandler(Handler handler) 
        {
            _nextHandler = handler;
        }
    }
}
