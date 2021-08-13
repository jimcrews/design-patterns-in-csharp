using System;
using System.Collections.Generic;
using lib.sim_u_duck;
using lib.sim_u_duck.DuckBehaviors;

namespace consoleApp
{
    public class SimUDuck
    {
        public static void Run()
        {
            var ducks = new List<Duck>()
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new ModelDuck()
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformSwim();
                duck.PerformFly();
                duck.Quack();
                System.Console.WriteLine("----------------");
            }

            Duck md = new ModelDuck();
            md.PerformFly();
            md.setFlyBehavior(new FlyWithRocket());
            md.PerformFly();
        }
    }
}
