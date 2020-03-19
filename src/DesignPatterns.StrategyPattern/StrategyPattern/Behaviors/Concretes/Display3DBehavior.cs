using DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Concretes
{
    public class Display3DBehavior : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("Displayed on 3D screen.");
            //Other implementations in real problem
        }
    }
}
