namespace Builder.SoftwareBuilders
{
    public class WebSitesBuilder: ISoftwareBuilder
    {
        private WebSite webSite = new WebSite() {BugsCount = 1000};


        public void SetName(string name)
        {
            webSite.Name = name;
        }

        public void Reset()
        {
            webSite = new WebSite();
        }

        public void CreateDevelopmentPlan()
        {
            webSite.BugsCount /= 3;
        }

        public void CreateArchitectSystem()
        {
            webSite.BugsCount /= 2;
            webSite.IsGoodArchitecture = true;
        }

        public void Coding()
        {
            webSite.Context = "Site was coding";
        }


        public void Testing()
        {
            webSite.BugsCount /= 2;
        }

        public void Optimization()
        {
            webSite.IsGoodOptimization = true;
        }

        public void CreateUI()
        {
            webSite.IsGoodUI = true;
        }

        public WebSite GetWebSite() => webSite;
    }
}
