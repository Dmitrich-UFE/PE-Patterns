using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class MovingState : State
    {
        internal override void Do()
        {
            Console.WriteLine("MoveState is Active");
            this._context.SetState(new IdleState());
        }
    }

    internal class IdleState : State
    {
        internal override void Do()
        {
            Console.WriteLine("IdleState is Active");
            this._context.SetState(new MovingState());
        }
    }
}
