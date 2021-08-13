using System;
using lib.sim_u_duck;
using lib.sim_u_duck.DuckBehaviors;

namespace lib.sim_u_duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            base.flyBehavior = new FlyNoWay();
            base.quackBehavior = new QuackSound();
        }
        public override void Display()
        {
            System.Console.WriteLine("Display Model Duck");
        }
    }
}