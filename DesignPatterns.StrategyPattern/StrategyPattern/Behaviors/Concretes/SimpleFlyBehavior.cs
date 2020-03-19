using DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Concretes
{
    public class SimpleFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I fly simply");
            //Other implementations in real problem
        }
    }
}
