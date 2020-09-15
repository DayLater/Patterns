using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Software
    {
        public string Name { get;set; }
        public string Description { get; set; }
        public int BugsCount { get; set; }
        public bool IsOptimized { get; set; }
        public int Cost { get; set; }


        public Software()
        {
            BugsCount = 10000;
            Cost = 1000;
        }
        public override string ToString()
        {
            return $"{Name} Good Optimization:  {IsOptimized} Total cost: {Cost}  Bugs: {BugsCount}";
        }
    }
}
