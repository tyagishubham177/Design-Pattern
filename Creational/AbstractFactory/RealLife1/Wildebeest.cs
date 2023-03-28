using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife1
{
    internal class Wildebeest : IHerbivore
    {
        //TODO: Remove setter
        public string Name { get; set; }

        public Wildebeest()
        {
            Name = typeof(Wildebeest).Name;
        }

        public string GetDescription()
        {
            return "Hi! I'm " + Name;
        }
    }
}
