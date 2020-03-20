using DesignPatterns.ProxyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern.Concrete
{
    public class BookParser : IBookParser
    {
        private int _numberPages;

        public BookParser(string reallyHugeText)
        {
            //Expensive parsing here ==> I want to escape this for unnecessary usage.
        }
        public int GetNumberPages()
        {
            return _numberPages;
        }
    }
}
