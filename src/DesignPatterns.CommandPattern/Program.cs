using DesignPatterns.CommandPattern.Commands.Concrete;
using DesignPatterns.CommandPattern.Components;
using System;

namespace DesignPatterns.CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver();  //Light


            var invoker = new Invoker(new LightOnCommand(receiver),
                new LightOffCommand(receiver),
                new LightUpCommand(receiver),
                new LightDownCommand(receiver));  //Remote controller etc.

            invoker.On();

            invoker.Off();

            invoker.Up();

            invoker.Down();

            invoker.Down();

            invoker.Down();

            invoker.On();

            invoker.Off();

            invoker.Up();

            invoker.Up();

            invoker.On();

            invoker.Off();

            Console.WriteLine("------------------------------------");
           
            //Let's consider what we'll do if we want to go N step back
            invoker.GoBackNStep(2);

            Console.WriteLine("------------------------------------");

            //Let's see the command stack
            invoker.InvokeCommandStack();

        }
    }
}
