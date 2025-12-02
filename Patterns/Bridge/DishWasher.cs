using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class DishWasher : Washer
    {
        private bool _isOn;
        private bool _isFullFilled;

        void Washer.Enable() { _isOn = true; }
        void Washer.Disable() { _isOn = false; }
        bool Washer.IsFullFilled() { return _isFullFilled; }
        void Washer.Fill() { _isFullFilled = true; Console.WriteLine("Посудомоечная машина загружена"); }
        void Washer.Wash() { Console.WriteLine("Посудомоечная машина моет"); _isFullFilled = false; }

    }
}
