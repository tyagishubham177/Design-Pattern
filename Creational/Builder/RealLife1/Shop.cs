using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Builder.RealLife1
{
    internal class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
