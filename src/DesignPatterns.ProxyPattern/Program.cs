using DesignPatterns.ProxyPattern.Concrete;
using System;

namespace DesignPatterns.ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var myReallyHugeText = "Really really huge text.";
            var lazyBookParser = new LazyBookParserProxy(myReallyHugeText);
            //Then expensive parsing process doesn't executed until i try to get number pages

            //Expensive process executed now.
            lazyBookParser.GetNumberPages();
        }
    }
}
