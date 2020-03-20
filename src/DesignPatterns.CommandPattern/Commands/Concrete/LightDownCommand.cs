using DesignPatterns.CommandPattern.Commands.Abstract;
using DesignPatterns.CommandPattern.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concrete
{
    public class LightDownCommand : ICommand
    {
        Receiver _receiver;
        public LightDownCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("SAIMAN SAYS:Birgt down!");
            _receiver.Down();
        }

        public void Unexecute()
        {
            Console.WriteLine("SAIMAN SAYS:Bright up!");
            _receiver.Up();
        }
    }
}
