using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class GrassFlyWeight
    {
        internal Sprite _sprite { get; }

        internal GrassFlyWeight(Sprite sprite) 
        {
            _sprite = sprite;
        }

        internal void DrawOnMap(Grass grass, Transform cords) 
        {
            Console.WriteLine($"Трава отрисована по координатам: {cords.x} {cords.y} {cords.z}");
        }
    }
}
