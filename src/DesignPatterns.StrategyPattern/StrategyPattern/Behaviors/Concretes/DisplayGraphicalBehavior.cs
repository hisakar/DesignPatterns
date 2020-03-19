using DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Concretes
{
    public class DisplayGraphicalBehavior : IDisplayBehavior
    {
        public void Display()
        {
             Console.WriteLine("Displayed on graphical interface.");
            //Other implementations in real problem
        }
    }
}
