using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife1
{
    internal class Bison : IHerbivore
    {
        //TODO: Remove setter
        public string Name { get; set; }

        public Bison()
        {
            Name = typeof(Bison).Name;
        }

        public string GetDescription()
        {
            return "Hi! I'm " + Name;
        }
    }
}
