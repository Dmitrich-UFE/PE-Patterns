using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class PC
    {
        internal string GPU { get; set; }
        internal string CPU { get; set; }
        internal string RAM {  get; set; }
        internal string ROM { get; set; }


        internal PC() 
        {
            GPU = string.Empty;
            CPU = string.Empty;
            RAM = string.Empty;
            ROM = string.Empty;
        }
        public override string ToString()
        {
            return $"Тип: {nameof(PC)} \nCPU: {CPU}\nGPU: {GPU}\nRAM count: {RAM}\nROM count: {ROM}\n";
        }
    }
}
