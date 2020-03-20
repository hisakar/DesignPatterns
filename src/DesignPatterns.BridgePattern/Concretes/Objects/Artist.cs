using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.Concretes.Objects
{
    public class Artist
    {
        public string Biography { get; private set; } = "Artist's custom biography";
        public string Title { get; private set; } = "Artist's name";
        public string ImageUrl { get; private set; } = "Artist's image url";
        public string ButtonRedirectUrl { get; private set; } = "Artist's profile url";
    }
}
