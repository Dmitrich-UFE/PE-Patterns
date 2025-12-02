using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Message: ISendable
    {
        void ISendable.Send(string text) { Console.WriteLine($"Отпралено сообщение: {text}"); }
    }
}
