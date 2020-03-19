using DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Concretes
{
    class SimpleQuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Simpe quack quack");
            //Other implementations in real problem
        }
    }
}
