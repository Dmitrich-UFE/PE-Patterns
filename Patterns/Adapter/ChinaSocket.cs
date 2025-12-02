using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class ChinaSocket
    {
        private ChinaFork? _chinaFork;

        internal void Connect(ChinaFork ex_chinaFork) 
        {
            _chinaFork = ex_chinaFork;
            Console.WriteLine("China connected"); 
        }

        internal void Disonnect() 
        {
            _chinaFork = null;
            Console.WriteLine("China connected"); 
        }
    }
}
