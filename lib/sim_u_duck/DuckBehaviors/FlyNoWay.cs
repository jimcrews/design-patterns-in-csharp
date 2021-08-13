using System;

namespace lib.sim_u_duck.DuckBehaviors
{
    public class FlyNoWay : IFly
    {
        public void Fly()
        {
            System.Console.WriteLine("<Cant fly>");
        }

    }
}