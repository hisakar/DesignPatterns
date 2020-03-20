using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Commands.Abstract
{
    public interface ICommand
    {
        void Execute();
        void Unexecute();
    }
}
