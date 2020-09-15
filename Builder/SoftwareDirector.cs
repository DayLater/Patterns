using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.SoftwareBuilders;

namespace Builder
{
    public class SoftwareDirector
    {
        private ISoftwareBuilder builder;

        public SoftwareDirector(ISoftwareBuilder softwareBuilder)
        {
            builder = softwareBuilder;
        }

        public SoftwareDirector() {}

        public void SetBuilder(ISoftwareBuilder builder)
        {
            this.builder = builder;
        }

        public void CreateCheapSoftware(string name)
        {
            builder.SetName(name);
            builder.Coding();
            builder.CreateUI();
        }

        public void CreateMiddleSoftware(string name)
        {
            builder.CreateDevelopmentPlan();
            CreateCheapSoftware(name);
            builder.Testing();
        }

        public void CreateExpensiveSoftware(string name)
        {
            CreateMiddleSoftware(name);
            builder.CreateArchitectSystem();
            builder.Optimization();
        }
    }
}
