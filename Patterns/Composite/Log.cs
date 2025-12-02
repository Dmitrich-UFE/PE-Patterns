using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Log: IPhysicalObject
    {
        void IPhysicalObject.CalculatePhysics() 
        {
            Console.WriteLine("Физика бревна просчитана");
        }
    }
}
