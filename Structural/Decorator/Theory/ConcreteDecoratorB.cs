using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DesignPatternsApp.Structural.Decorator.Theory
{
    internal class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
