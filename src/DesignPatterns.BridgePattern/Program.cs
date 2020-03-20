
using DesignPatterns.BridgePattern.Concretes.FormViews;
using DesignPatterns.BridgePattern.Concretes.Objects;
using DesignPatterns.BridgePattern.Concretes.Resources;
using System;

namespace DesignPatterns.BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var artistResource = new ArtistResource(new Artist());
            var bookResource = new BookResource(new Book());

            //Two different view for artist resource
            var longFormViewForArtist = new LongFormView(artistResource);
            var shortFormViewForArtist = new ShortFormView(artistResource);

            //Two different view for book resource
            var longFormViewForBook = new LongFormView(bookResource);
            var shortFormViewForBook = new ShortFormView(bookResource);

            //We can completely change the behavior of sources via theirs objects

            Console.WriteLine(longFormViewForArtist.generateHTML());
            Console.WriteLine(shortFormViewForArtist.generateHTML());
            Console.WriteLine(longFormViewForBook.generateHTML());
            Console.WriteLine(shortFormViewForBook.generateHTML());
        }
    }
}
