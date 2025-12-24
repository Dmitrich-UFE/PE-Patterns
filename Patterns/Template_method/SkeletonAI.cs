using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method
{
    internal class SkeletonAI: MonsterAI
    {
        protected override void giveDamage()
        {
            Console.WriteLine("Скелет стреляет в вас и наносит 7 урона");
        }
    }
}
