using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class GrassFactory
    {
        static internal Dictionary<Sprite, GrassFlyWeight> GrassFlyWeightDict { get; } = new Dictionary<Sprite, GrassFlyWeight>();

        static internal GrassFlyWeight getGrassFlyWeight(Sprite sprite) 
        {
            GrassFlyWeight gFW;
            if (!GrassFlyWeightDict.TryGetValue(sprite, out gFW)) 
            {
                gFW = new GrassFlyWeight(sprite);
                GrassFlyWeightDict[sprite] = gFW;
            }
            return gFW;
        }


    }
}
