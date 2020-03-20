using DesignPatterns.BridgePattern.Concretes.Objects;
using DesignPatterns.BridgePattern.MainConcept;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.Concretes.Resources
{
    public class BookResource : IResource
    {
        private readonly Book _book;

        public BookResource(Book book)
        {
            _book = book;
        }

        public string ButtonRedirectUrl()
        {
            return _book.ButtonRedirectUrl;
        }

        public string ImageUrl()
        {
            return _book.ImageUrl;
        }

        public string Snippet()
        {
            return _book.CoverText;
        }

        public string Title()
        {
            return _book.Title;
        }
    }
}
