namespace Builder.SoftwareBuilders
{
    public interface ISoftwareBuilder
    {
        void SetName(string name);
        void Reset();
        void CreateDevelopmentPlan();
        void CreateArchitectSystem();
        void Coding();
        void Testing();
        void Optimization();
        void CreateUI();
    }
}
