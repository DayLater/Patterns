using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
    public class Instagram: ISubscriber
    {
        public void Update(string post)
        {
            Console.WriteLine("Get the last new from insta: " + post);
        }
    }
}
