using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal static class RunHandler
    {
        static Player player = new Player(1, 4);
        static IStrategy walking = new WalkStrategy();
        static IStrategy running = new RunStrategy();

        static IStrategy actStrategy = walking;

        public static void Do() 
        {
            actStrategy.UseBooster(player);
        }

        public static void SetStrategy(bool is_run) 
        {   
            if (is_run) 
            {
                Console.WriteLine("Игрок будет БЕЖАТЬ при прожатии WASD");
                actStrategy = running;
            }
            else 
            {
                Console.WriteLine("Игрок будет ХОДИТЬ при прожатии WASD");
                actStrategy = walking;
            }
                
        }



    }
}
