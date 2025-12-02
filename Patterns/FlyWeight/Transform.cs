using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    //Координаты (у каждого объекта уникальны)
    internal class Transform
    {
        internal double x { get; set; }
        internal double y { get; set; }
        internal double z { get; set; }

        internal Transform (double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
