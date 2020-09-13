using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Subscribers;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();
            var insta = new Instagram();
            var newspaper = new Newspaper();

            publisher.Subscribe(insta);
            publisher.Subscribe(newspaper);
            publisher.GetNewPost("The observer pattern is easy");
        }
    }
}
