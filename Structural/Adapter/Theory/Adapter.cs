using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Adapter.Theory
{
    internal class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is adapter getting adaptee's request :'{this._adaptee.GetSpecificRequest()}'";
        }
    }
}
