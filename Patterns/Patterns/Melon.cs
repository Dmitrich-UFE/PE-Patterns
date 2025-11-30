using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class Melon: IPlant
    {
        public Melon() { }

        void IPlant.Grow() 
        {
            Console.WriteLine("Дыня выросла на 1 единицу");
        }
    }
}
