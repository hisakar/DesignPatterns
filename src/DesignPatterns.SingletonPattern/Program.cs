using System;

namespace DesignPatterns.SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
          //  var singleton = new Singleton();  ==>  Not work. Cause singleton has only private ctor

            var singleton = Singleton.GetInstance("1"); // Now generated one instance of Singleton
            var singleton2 = Singleton.GetInstance("2");
            var singleton3 = Singleton.GetInstance("3");// Until here, all of references point the same object

            //Proof
            singleton.WriteText();
            singleton2.WriteText();
            singleton3.WriteText();
        }
    }
}
