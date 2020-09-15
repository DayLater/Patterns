using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class WebSite
    {
        public string Name { get; set; }
        public string Context { get;set; }

        public bool IsGoodOptimization { get; set; }
        public bool IsGoodUI { get; set; }
        public bool IsGoodArchitecture { get; set; }
        public int BugsCount { get; set; }

        public WebSite()
        {
            BugsCount = 2000;
        }

        public override string ToString()
        {
            return $"{Name}  Good Optimization: {IsGoodOptimization}  Good Architecture: {IsGoodArchitecture} Good UI: {IsGoodUI}  Bugs: {BugsCount}";
        }
    }
}
