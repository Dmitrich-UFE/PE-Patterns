using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method
{
    internal class SlimeAI: MonsterAI
    {
        protected override void giveDamage() 
        {
            Console.WriteLine("Слизень напрыгивает на вас и наносит 3 урона");
        }
    }
}
