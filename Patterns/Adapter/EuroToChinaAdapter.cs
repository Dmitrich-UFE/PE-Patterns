using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class EuroToChinaAdapter: ChinaFork
    {
        private EuroFork _euroFork;

        internal EuroToChinaAdapter(EuroFork euroFork)
        {
            _euroFork = euroFork;
        }

        
    }
}
