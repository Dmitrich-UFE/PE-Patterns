using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface IBuilder
    {
        void AddGPU(string gpu);
        void AddCPU(string cpu);
        void AddRAM(uint gigas);
        void AddROM(uint gigas);
        void Reset();
    }
}
