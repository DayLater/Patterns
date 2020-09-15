using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.SoftwareBuilders;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var webBuilder = new WebSitesBuilder();
            var softwareBuilder = new SoftwareBuilder();


            var director = new SoftwareDirector(webBuilder);
            director.CreateCheapSoftware("Cheap");
            Console.WriteLine("----------Cheap by Web------------");
            Console.WriteLine(webBuilder.GetWebSite());

            
            
            director.SetBuilder(softwareBuilder);
            director.CreateExpensiveSoftware("Expensive");
            Console.WriteLine("----------Expensive by Software------------");
            Console.WriteLine(softwareBuilder.GetSoftware());



            softwareBuilder.Reset();
            director.CreateMiddleSoftware("Middle");
            Console.WriteLine("----------Middle by Software------------");
            Console.WriteLine(softwareBuilder.GetSoftware());


            webBuilder.Reset();
            webBuilder.SetName("Without director");
            webBuilder.CreateDevelopmentPlan();
            webBuilder.CreateArchitectSystem();
            webBuilder.Coding();
            webBuilder.Testing();
            Console.WriteLine("----------Without Director------------");
            Console.WriteLine(webBuilder.GetWebSite());
        }
    }
}
