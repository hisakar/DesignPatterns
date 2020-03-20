using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonPattern
{
    public class Singleton
    {
        private static Singleton singleton;
        private static string _text;

        private Singleton()
        { }

        public static Singleton GetInstance(string text)//Parameter are for proof
        {
            _text = text;
            singleton = singleton ?? new Singleton();
            return singleton;
        }

        public void WriteText()
        {
            Console.WriteLine(_text);
        }

    }
}
