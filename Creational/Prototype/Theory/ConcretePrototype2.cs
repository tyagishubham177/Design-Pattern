using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Prototype.Theory
{
    internal class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id)
        {
        }
        
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
