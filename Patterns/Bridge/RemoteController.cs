using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class RemoteController
    {
        Washer washer;

        internal RemoteController(Washer washer)
        {
            this.washer = washer;
        }

        internal void SetPower(bool power) 
        {
            if (power)
                washer.Enable();
            else
                washer.Disable();
        }

        internal void Wash() 
        {
            if (washer.IsFullFilled())
                washer.Wash();
            else
                Console.WriteLine("Загрузите машину перед использованием");
        }

        internal void Fill() 
        {
            washer.Fill();
        }
    }
}
