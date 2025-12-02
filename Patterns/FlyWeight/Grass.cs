using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace FlyWeight
{
    internal class Grass
    {
        private Transform _cords;
        private GrassFlyWeight _grassFlyWeight;

        internal Grass(GrassFlyWeight grassFlyWeight, Transform cords)
        {
            _cords = cords;
            _grassFlyWeight = grassFlyWeight;
        }

        internal void DrawOnMap() 
        {
            _grassFlyWeight.DrawOnMap(this, _cords);
        }
    }
}
