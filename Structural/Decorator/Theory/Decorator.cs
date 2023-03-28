using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DesignPatternsApp.Structural.Decorator.Theory
{
    internal abstract class Decorator : IComponent
    {
        protected IComponent component;

        public Decorator(IComponent component)
        {
            this.component = component;
        }

        public void SetComponent(IComponent component)
        {
            this.component = component;
        }

        // The Decorator delegates all work to the wrapped component.
        public virtual string Operation()
        {
            if (component != null)
            {
                return component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
