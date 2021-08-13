using System;

namespace lib.sim_u_duck.DuckBehaviors
{
    public class FlyWithRocket : IFly
    {
        public void Fly()
        {
            System.Console.WriteLine("Flying with a Rocket");
        }

    }
}