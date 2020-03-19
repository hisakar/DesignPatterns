using DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.StrategyPattern
{
    public class Duck
    {
        private readonly IQuackBehavior _quackBehavior;
        private readonly IFlyBehavior _flyBehavior ;
        private readonly IDisplayBehavior _displayBehavior;

        public Duck(IQuackBehavior quackBehavior,
        IFlyBehavior flyBehavior,
        IDisplayBehavior displayBehavior)
        {
            _quackBehavior = quackBehavior;
            _flyBehavior = flyBehavior;
            _displayBehavior = displayBehavior;
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void Display()
        {
            _displayBehavior.Display();
        }

    }
}
