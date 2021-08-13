using System;

namespace lib.sim_u_duck.DuckBehaviors
{
    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            System.Console.WriteLine("Flying with Wings");
        }

    }
}