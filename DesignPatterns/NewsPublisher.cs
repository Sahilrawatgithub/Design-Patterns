using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class NewsPublisher
    {
        private List<ISubscriber> subscribers=new List<ISubscriber>();

        public void AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void NotifySubscribers(string message)
        {
            foreach(ISubscriber subscriber in subscribers)
            {
                subscriber.Update(message);
            }
        }

    }
}
