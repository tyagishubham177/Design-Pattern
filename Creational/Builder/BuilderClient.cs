using DesignPatternsApp.Creational.Builder.RealLife1;
using DesignPatternsApp.Creational.Builder.Theory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Builder
{
    internal class BuilderClient
    {
        internal static void StartRealLife()
        {
            VehicleBuilder builder;
            
            // Create shop with vehicle builders
            Shop shop = new Shop();
            
            // Construct and display vehicles
            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }

        internal static void StartTheory()
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Remember, the Builder pattern can be used without a Director class.
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}
