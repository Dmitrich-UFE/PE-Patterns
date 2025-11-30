using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class Potato: IPlant
    {
        public Potato() { }

        void IPlant.Grow() 
        {
            Console.WriteLine("Картошка выросла на 1 единицу");
        }

    }
}
