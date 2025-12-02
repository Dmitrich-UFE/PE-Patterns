using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Box: IPhysicalObject
    {
        void IPhysicalObject.CalculatePhysics() 
        {
            Console.WriteLine("Физика коробки просчитана");
        }
    }
}
