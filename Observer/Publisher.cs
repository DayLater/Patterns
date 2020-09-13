using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Publisher
    {
        private List<ISubscriber> subscribers;

        public Publisher()
        {
            subscribers = new List<ISubscriber>();
        }

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            if (subscribers.Contains(subscriber))
                subscribers.Remove(subscriber);
            else Console.WriteLine("I dont know this guy");
        }

        public void GetNewPost(string post)
        {
            Console.WriteLine("I get something new");
            Notify(post);
        }

        public void Notify(string post)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update(post);
            }
        }
    }
}
