using DesignPatterns.CommandPattern.Commands.Abstract;
using DesignPatterns.CommandPattern.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Concrete
{
    public class LightOnCommand : ICommand
    {
        Receiver _receiver;
        public LightOnCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("SAIMAN SAYS:Turn on!");
            _receiver.On();
        }

        public void Unexecute()
        {
            Console.WriteLine("SAIMAN SAYS:Turn off!");
            _receiver.Off();
        }
    }
}
