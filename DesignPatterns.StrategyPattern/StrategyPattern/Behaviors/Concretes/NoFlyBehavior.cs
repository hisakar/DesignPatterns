using DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Concretes
{
    public class NoFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
            //Other implementations in real problem
        }
    }
}
