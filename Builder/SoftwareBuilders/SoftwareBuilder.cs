namespace Builder.SoftwareBuilders
{
    public class SoftwareBuilder: ISoftwareBuilder
    {
        private Software software = new Software();
        public void SetName(string name)
        {
            software.Name = name;
        }

        public void Reset()
        {
            software = new Software();
        }

        public void CreateDevelopmentPlan()
        {
            software.BugsCount /= 4;
            software.Cost += 300;
        }

        public void CreateArchitectSystem()
        {
            software.BugsCount /= 4;
            software.Cost += 400;
        }

        public void Coding()
        {
            software.Description = "Was coded";
        }

        public void Testing()
        {
            software.BugsCount /= 3;
            software.Cost += 1000;
        }

        public void Optimization()
        {
            software.IsOptimized = true;
            software.Cost += 2000;
        }

        public void CreateUI()
        {
            software.Cost += 1000;
        }

        public Software GetSoftware() => software;
    }
}
