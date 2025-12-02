
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class BaseSender: ISendable
    {
        protected ISendable _messageObj;
        void ISendable.Send(string text) {Console.WriteLine($" Отправлено через базовый декоратор {text} "); }

        internal BaseSender(ISendable messageObj) {  _messageObj = messageObj; }
    }
}
