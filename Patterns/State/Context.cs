using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Context
    {

        State _state;

        internal Context(State state)
        {
            SetState(state);
        }

        internal void SetState(State state) 
        {
            _state = state;
            _state.SetContext(this);
            Console.WriteLine($"switched state to {_state.GetType().ToString()}");
        }

        internal void Stop() 
        {
            this._state.Do();
        }

        internal void Move() 
        {
            this._state.Do();
        }
    }
}
