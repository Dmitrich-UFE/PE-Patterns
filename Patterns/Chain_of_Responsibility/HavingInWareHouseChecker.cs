using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class HavingInWareHouseChecker: Handler
    {
        Warehouse _warehouse;
        Handler _nextHandler;

        internal HavingInWareHouseChecker(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        void Handler.SetNextHandler(Handler handler)
        {
            _nextHandler = handler;
        }

        void Handler.HandleRequest(User user) 
        {
            if (_nextHandler != null && _warehouse.FindInWareHouse(user.OrdingGood)) 
            {
                Console.WriteLine("Товар доступен для заказа");
                _nextHandler.HandleRequest(user);
            }
            else
                Console.WriteLine("Такого товара на складе нет");
        }
    }
}
