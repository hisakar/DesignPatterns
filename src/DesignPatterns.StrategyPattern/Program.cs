using DesignPatterns.StrategyPattern.StrategyPattern;
using DesignPatterns.StrategyPattern.StrategyPattern.Behaviors.Concretes;
using System;

namespace DesignPatterns.StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var mountainDuck = new Duck(new SimpleQuackBehavior(),new NoFlyBehavior(),new Display3DBehavior());
            var poorDuck = new Duck(new NoQuackBehavior(), new NoFlyBehavior(),new NoDisplayBehavior());

            // We can create more custom duck like this way

            mountainDuck.Fly();
            mountainDuck.Quack();
            mountainDuck.Display();

            poorDuck.Fly();
            poorDuck.Quack();
            poorDuck.Display();

            //And use their behaviors
        }
    }
}
