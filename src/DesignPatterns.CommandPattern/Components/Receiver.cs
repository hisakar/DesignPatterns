using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern.Components
{
    public class Receiver
    {
        public void On()
        {
            Console.WriteLine("Ok Saiman I turning on.");
        }

        public void Off()
        {
            Console.WriteLine("Ok Saiman I turning off.");
        }

        public void Up()
        {
            Console.WriteLine("Ok Saiman I brightening up.");
        }

        public void Down()
        {
            Console.WriteLine("Ok Saiman I brightening down.");
        }
    }
}
