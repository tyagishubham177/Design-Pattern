using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife1
{
    internal class Lion : ICarnivore
    {
        public string Name { get; set; }

        public Lion()
        {
            Name = typeof(Lion).Name;
        }

        public string Eat(IHerbivore herbivore)
        {
            return "Hi! I'm " + Name + ", and I eat " + herbivore.Name;
        }

        public string GetDescription()
        {
            return "Hi! I'm " + Name;
        }
    }
}
