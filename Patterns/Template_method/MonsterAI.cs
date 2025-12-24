using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method
{
    internal abstract class MonsterAI
    {
        internal void AttackPlayer()
        {
            Approach();
            giveDamage();
        }

        void Approach() 
        {
            Console.WriteLine("Монстр приближается к игроку");
        }

        protected abstract void giveDamage();

    }
}
