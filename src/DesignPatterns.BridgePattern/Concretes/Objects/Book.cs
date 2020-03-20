using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.Concretes.Objects
{
    public class Book
    {
        public string CoverText { get; private set; } = "Book's custom cover text";
        public string Title { get; private set; } = "Book's name";
        public string ImageUrl { get; private set; } = "Book's image url";
        public string ButtonRedirectUrl { get; private set; } = "Book's profile url";

        //We don't use this constructor, i implement this because want to make more meaningfull this sample
        public Book(string coverText,string title,string imageUrl,string buttonRedirectUrl)
        {
            CoverText = coverText;
            Title = title;
            ImageUrl = imageUrl;
            ButtonRedirectUrl = buttonRedirectUrl;
        }

        //We don't use this either but i think most meaningful sample is this
        public Book(int bookId)
        {
            //Assume that book has an id
            //Step 1 => Go to db and find my book. Like this(for ef) => var myBook =_db.Books.First(b=>b.Id == bookId);
            //this.props = myBook.props
        }

        public Book()
        {}

    }
}
