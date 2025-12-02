using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class OrderClaimer: Handler
    {

        internal OrderClaimer() { }

        void Handler.HandleRequest(User user) 
        {
            Console.WriteLine($"Заказ обрабатывается... Товар: {user.OrdingGood.Name}, цена: {user.OrdingGood.Price}");
        }

        void Handler.SetNextHandler(Handler handler) 
        {
        
        }
    }
}
