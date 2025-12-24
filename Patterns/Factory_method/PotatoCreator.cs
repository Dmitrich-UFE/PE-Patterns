using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class PotatoCreator: Creator
    {

        IPlant Creator.CreatePlant() 
        {
            return new Potato();
        }
    }
}
