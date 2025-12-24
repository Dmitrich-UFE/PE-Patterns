using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class ClothesWasher: Washer
    {
        private bool _isOn;
        private bool _isFullFilled;

        void Washer.Enable() { Console.WriteLine("Стиральная машина включена"); _isOn = true; }
        void Washer.Disable() { Console.WriteLine("Стиральная машина отключена"); _isOn = false; }    
        bool Washer.IsFullFilled() { return _isFullFilled; }
        void Washer.Fill() { _isFullFilled = true; Console.WriteLine("Стиральная машина загружена"); }
        void Washer.Wash() { Console.WriteLine("Стиральная машина моет"); _isFullFilled = false; }

    }
}
