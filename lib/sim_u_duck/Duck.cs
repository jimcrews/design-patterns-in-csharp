using System;
using lib.sim_u_duck.DuckBehaviors;

namespace lib.sim_u_duck
{
    public class Duck
    {
        internal IFly flyBehavior;
        internal IQuack quackBehavior;


        public virtual void Quack()
        {
            quackBehavior.Quack();
        }

        public virtual void PerformSwim()
        {
            System.Console.WriteLine("Duck Swims");
        }

        public virtual void Display()
        {
            System.Console.WriteLine("Display Duck");
        }

        public virtual void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void setFlyBehavior(IFly fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuack qb)
        {
            quackBehavior = qb;
        }
    }
}
