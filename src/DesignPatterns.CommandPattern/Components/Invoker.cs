using DesignPatterns.CommandPattern.Commands.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Components
{
    public class Invoker
    {
        private Stack<ICommand> CommandStack;

        private ICommand _on;
        private ICommand _off;
        private ICommand _up;
        private ICommand _down;

        public Invoker(ICommand on, ICommand off, ICommand up, ICommand down)
        {
            CommandStack = CommandStack ?? new Stack<ICommand>();
            _on = on;
            _off = off;
            _up = up;
            _down = down;
        }

        public void On()
        {
            _on.Execute();
            CommandStack.Push(_on);
        }

        public void Off()
        {
            _off.Execute();
            CommandStack.Push(_off);
        }

        public void Up()
        {
            _up.Execute();
            CommandStack.Push(_up);
        }

        public void Down()
        {
            _down.Execute();
            CommandStack.Push(_down);
        }

        public void InvokeCommandStack()
        {
            while (CommandStack.Count > 0)
            {
                var command = CommandStack.Pop();
                command.Unexecute();
            }
        }

        public void GoBackNStep(int stepNumber)
        {
            while (stepNumber > 0)
            {
                if (CommandStack.Count <= 0)
                {
                    Console.WriteLine("No more command in the stack.");
                    return;
                }

                CommandStack.Pop().Unexecute();

                stepNumber--;
            }
        }
    }
}
