using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class TelegramSender: BaseSender, ISendable
    {
        internal TelegramSender(ISendable message) : base(message) { }

        void ISendable.Send(string text) { _messageObj.Send(text + Extra()); }

        private string Extra() { return "\nОтправлено через Телеграм"; }
    }
}
