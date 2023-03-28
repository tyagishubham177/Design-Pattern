using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Builder.RealLife1
{
    internal abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        // Gets vehicle instance
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }
        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
