using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsApp.AbstractFactory.RealLife1;
using DesignPatternsApp.AbstractFactory.RealLife2;
using DesignPatternsApp.AbstractFactory.Theory;

namespace DesignPatternsApp.AbstractFactory
{
    internal static class AbstractFactoryClient
    {
        public static void StartRealLife()
        {
            AnimalWorld world;

            IContinentFactory africa = new AfricaFactory();
            world = new AnimalWorld(africa);
            Console.WriteLine(world.RunFoodChain());

            IContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            Console.WriteLine(world.RunFoodChain());
        }

        public static void StartTheory()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        public static void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productA.UsefulFunctionA());
            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }

        internal static void StartRealLife2()
        {
            Game game;

            IGamingPlatform openGLPlatform = new OpenGL();
            game = new Game(openGLPlatform);
            Console.WriteLine(game.RenderGame());

            IGamingPlatform directXPlatform = new DirectX();
            game = new Game(directXPlatform);
            Console.WriteLine(game.RenderGame());
        }
    }
}
