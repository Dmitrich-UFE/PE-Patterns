using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        internal void ConstructComputer(IBuilder builder) 
        {
            builder.Reset();
            builder.AddGPU("Nvidia GT710");
            builder.AddCPU("Intel core 2 duo");
            builder.AddROM(4);
            builder.AddRAM(16);
        }
    }
}
