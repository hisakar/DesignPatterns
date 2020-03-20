using DesignPatterns.BridgePattern.Concretes.Objects;
using DesignPatterns.BridgePattern.MainConcept;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.Concretes.Resources
{
    public class ArtistResource : IResource
    {
        private readonly Artist _artist;
        public ArtistResource(Artist artist)
        {
            _artist = artist;
        }

        public string ButtonRedirectUrl()
        {
            return _artist.ButtonRedirectUrl;
        }

        public string ImageUrl()
        {
            return _artist.ImageUrl;
        }

        public string Snippet()
        {
            return _artist.Biography;
        }

        public string Title()
        {
            return _artist.Title;
        }
    }
}
