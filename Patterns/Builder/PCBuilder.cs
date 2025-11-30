using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class PCBuilder: IBuilder
    {
        private PC strongPC;
        void IBuilder.AddGPU(string gpu) 
        {
            strongPC.GPU = gpu; 
        }
        void IBuilder.AddCPU(string cpu) 
        {
            strongPC.CPU = cpu; 
        }
        void IBuilder.AddRAM(uint gigas) 
        {
            strongPC.RAM = gigas.ToString();
        }
        void IBuilder.AddROM(uint gigas) 
        {
            strongPC.ROM = gigas.ToString();
        }
        void IBuilder.Reset() 
        {
            strongPC = new PC();
        }

        internal PC getResult() { return  strongPC; }

    }
}
