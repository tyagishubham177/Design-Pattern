using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Adapter.Theory
{
    internal class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Adaptee request.";
        }
    }
}
