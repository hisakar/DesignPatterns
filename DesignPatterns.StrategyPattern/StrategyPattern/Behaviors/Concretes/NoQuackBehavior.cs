using DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Concretes
{
    public class NoQuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack.");
            //Other implementations in real problem

        }
    }
}
