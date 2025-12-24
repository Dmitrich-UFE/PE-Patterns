using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Некоторый обработчик смены дня и ночи. Бывает полезен при создании игр
    internal class DayLightHandler
    {
        private static DayLightHandler instance;
        private DayTime _dayTime;
        internal DayTime dayTime 
        {
            get => _dayTime; 
            set 
            {
                Console.WriteLine($"Время дня изменено на: {value}");
                _dayTime = value;
            }
        }
        public enum DayTime { Morning, Day, Noon, Evening, Night, Midnight}

        public static DayLightHandler getInstance() 
        {
            if (instance == null) { instance = new DayLightHandler(); }
            return instance;
        }

        private DayLightHandler() { dayTime = DayTime.Midnight; }

    }
}
