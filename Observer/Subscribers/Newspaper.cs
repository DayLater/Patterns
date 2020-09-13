using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
    public class Newspaper: ISubscriber
    {
        public void Update(string post)
        {
            Console.WriteLine("The post in newspaper is " + post);
        }
    }
}
