using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class MelonCreator: Creator
    {
        IPlant Creator.CreatePlant() 
        {
            return new Melon();
        }
    }
}
