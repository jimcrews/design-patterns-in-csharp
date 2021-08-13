using System;
using lib.sim_u_duck;
using lib.sim_u_duck.DuckBehaviors;

namespace lib.sim_u_duck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeaking();
        }

        public override void Display()
        {
            System.Console.WriteLine("Display Rubber Duck");
        }

        public override void Quack()
        {
            System.Console.WriteLine("Rubber Duck Squeaks");
        }
    }
}