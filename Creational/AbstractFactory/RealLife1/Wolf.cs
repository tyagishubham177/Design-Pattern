using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife1
{
    internal class Wolf : ICarnivore
    {
        public string Name { get; set; }

        public Wolf()
        {
            Name = typeof(Wolf).Name;
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
