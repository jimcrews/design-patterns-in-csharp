using System;

namespace lib.sim_u_duck.DuckBehaviors
{
    public class Squeaking : IQuack
    {
        public void Quack()
        {
            System.Console.WriteLine("Duck is Squeaking");
        }
    }
}