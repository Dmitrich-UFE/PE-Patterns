using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Player
    {
        bool can_jump;
        int actspeed;
        int base_speed;
        int modifier;

        internal Player(int base_speed, int modifier, bool can_jump_default = false) 
        {
            can_jump = can_jump_default;
            this.base_speed = base_speed;
            this.actspeed = base_speed;
            this.modifier = modifier;
        }


        internal void Walk() 
        {
            actspeed = base_speed;
            Console.WriteLine("Игрок ходит");
        }

        internal void Run() 
        {
            actspeed = modifier * base_speed;
            Console.WriteLine("Игрок бежит");
        }

    }
}
