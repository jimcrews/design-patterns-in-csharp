using System;
using lib.sim_u_duck;
using lib.sim_u_duck.DuckBehaviors;

namespace lib.sim_u_duck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new QuackSound();
        }

        public override void Display()
        {
            System.Console.WriteLine("Display Redhead Duck");
        }
    }
}