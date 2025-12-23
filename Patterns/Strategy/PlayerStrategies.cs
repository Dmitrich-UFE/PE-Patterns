using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Ходьба игрока
    internal class WalkStrategy: IStrategy
    {
        object IStrategy.UseBooster(object player)
        {
            Player player1 = (Player)player;
            player1.Walk();
            return true;
        }
    }

    //Бег игрока
    internal class RunStrategy: IStrategy 
    {
        object IStrategy.UseBooster(object player)
        {
            Player player1 = (Player)player;
            player1.Run();
            return true;
        }
    }
}
