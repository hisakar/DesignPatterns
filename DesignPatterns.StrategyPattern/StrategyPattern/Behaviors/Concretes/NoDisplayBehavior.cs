using DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Concretes
{
    public class NoDisplayBehavior : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("Can't display");
            //Other implementations in real problem
        }
    }
}
