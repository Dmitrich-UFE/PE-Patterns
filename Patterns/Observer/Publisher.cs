using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Publisher
    {

        List<ISubscriber> subscribers;
        private int _hour;

        public int Hour 
        {
            get { return _hour; } 
            set 
            {
                if (value < 0)
                    throw new ArgumentException("value must be equal or bigger than zero");

                if (value > _hour)
                    NotifySubscribers();
                _hour = value;
            } 
        }

        internal Publisher() 
        {
            subscribers = new List<ISubscriber>();
            Hour = 0;
        }

        void NotifySubscribers() 
        {
            foreach (var s in subscribers) 
            { s.Update(); }
        }

        internal void AddSubscriber(ISubscriber subscriber) {  subscribers.Add(subscriber); }
        internal void RemoveSubscriber(ISubscriber subscriber) { subscribers.Remove(subscriber); }


    }
}
