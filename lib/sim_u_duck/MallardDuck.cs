using System;
using lib.sim_u_duck;
using lib.sim_u_duck.DuckBehaviors;

namespace lib.sim_u_duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            base.flyBehavior = new FlyWithWings();
            base.quackBehavior = new QuackSound();
        }
        public override void Display()
        {
            System.Console.WriteLine("Display Mallard Duck");
        }
    }
}