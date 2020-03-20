using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.MainConcept
{
    public abstract class View
    {
        internal readonly IResource _recource;
        public View(IResource resource)
        {
            _recource = resource;
        }

        public abstract string generateHTML();
    }
}
