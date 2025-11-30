using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class LaptopBuilder: IBuilder
    {
        private Laptop weakLaptop;
        void IBuilder.AddGPU(string gpu)
        {
            weakLaptop.GPU = gpu;
        }
        void IBuilder.AddCPU(string cpu)
        {
            weakLaptop.CPU = cpu;
        }
        void IBuilder.AddRAM(uint gigas)
        {
            weakLaptop.RAM = gigas.ToString();
        }
        void IBuilder.AddROM(uint gigas)
        {
            weakLaptop.ROM = gigas.ToString();
        }
        void IBuilder.Reset()
        {
            weakLaptop = new Laptop();
        }

        internal Laptop getResult() { return weakLaptop; }
    }
}
