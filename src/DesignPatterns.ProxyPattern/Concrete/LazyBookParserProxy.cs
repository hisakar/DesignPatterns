using DesignPatterns.ProxyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern.Concrete
{
    public class LazyBookParserProxy : IBookParser
    {
        private BookParser _bookParser;
        private string book;

        public LazyBookParserProxy(string reallyHugeText)
        {
            book = reallyHugeText;
        }

        public int GetNumberPages()
        {
            _bookParser = _bookParser ?? new BookParser(book);
            return _bookParser.GetNumberPages();
        }
    }
}
