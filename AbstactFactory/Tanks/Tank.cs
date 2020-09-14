namespace AbstractFactory.Tanks
{
    public abstract class Tank
    {
        public abstract string Name { get; }
        public abstract void Move();
    }
}