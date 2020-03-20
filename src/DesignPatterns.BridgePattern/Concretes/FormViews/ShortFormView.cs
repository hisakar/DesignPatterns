using DesignPatterns.BridgePattern.MainConcept;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.Concretes.FormViews
{
    public class ShortFormView : View
    {
        public ShortFormView(IResource resource) : base(resource)
        {
        }

        public override string generateHTML()
        {
            return "Generated for short form " + _recource.Title() + _recource.ImageUrl() + _recource.Snippet() + _recource.ButtonRedirectUrl();
            //Some generate html logic here.
        }
    }
}
