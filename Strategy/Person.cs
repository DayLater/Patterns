using Strategy.Behaviors;

namespace Strategy
{
    public class Person
    {
        private IBehavior behavior;

        public Person(IBehavior behavior)
        {
            this.behavior = behavior;
        }

        public void Do()
        {
            behavior.Do();
        }

        public void SetBehavior(IBehavior behavior)
        {
            this.behavior = behavior;
        }
    }
}
