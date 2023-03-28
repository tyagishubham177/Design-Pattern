using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Facade.RealLife
{
    internal class Customer
    {
        private string name;
        
        public Customer(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }
}
