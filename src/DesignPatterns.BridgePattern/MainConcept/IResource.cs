using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.MainConcept
{
    public interface IResource
    {
        string Snippet();
        string Title();
        string ImageUrl();
        string ButtonRedirectUrl();
    }
}
