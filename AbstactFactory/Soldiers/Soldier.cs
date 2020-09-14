namespace AbstractFactory.Soldiers
{
    public abstract class Soldier
    {
        public abstract string Name { get; }
        public abstract void Move();
        public abstract void Shoot();
    }
}