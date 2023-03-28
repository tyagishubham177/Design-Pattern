using System;
using DesignPatternsApp.AbstractFactory;
using DesignPatternsApp.Behavioral.Observer;
using DesignPatternsApp.Behavioral.Strategy;
using DesignPatternsApp.Creational.Builder;
using DesignPatternsApp.Creational.Prototype;
using DesignPatternsApp.Creational.Singleton;
using DesignPatternsApp.FactoryMethod;
using DesignPatternsApp.Models.Enums;
using DesignPatternsApp.Structural.Adapter;
using DesignPatternsApp.Structural.Decorator;
using DesignPatternsApp.Structural.Facade;

namespace DesignPatternsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Design Pattern Code!");
            Console.WriteLine("Press the number for the specific Design Pattern");
            Console.WriteLine("1. Factory Method Pattern");
            Console.WriteLine("2. Abstract Factory Pattern");
            Console.WriteLine("3. Builder Pattern");
            Console.WriteLine("4. Singleton Pattern");
            Console.WriteLine("5. Prototype Pattern");
            Console.WriteLine("6. Adapter Pattern");
            Console.WriteLine("7. Decorator Pattern");
            Console.WriteLine("8. Facade Pattern");
            Console.WriteLine("9. Strategy Pattern");
            Console.WriteLine("10. Observer Pattern");

            int input = Convert.ToInt32(Console.ReadLine());

            DirectDesignPattern(input);

            Console.ReadKey();
        }

        private static void DirectDesignPattern(int input)
        {
            switch (input)
            {
                case (int)DesignPatternEnum.FACTORY_METHOD:
                    StartFactoryMethodPattern();
                    break;
                case (int)DesignPatternEnum.ABSTRACT_FACTORY:
                    StartAbstractFactoryPattern();
                    break;
                case (int)DesignPatternEnum.BUILDER:
                    StartBuilderPattern();
                    break;
                case (int)DesignPatternEnum.SINGLETON:
                    StartSingletonPattern();
                    break;
                case (int)DesignPatternEnum.PROTOTYPE:
                    StartPrototypePattern();
                    break;
                case (int)DesignPatternEnum.ADAPTER:
                    StartAdapterPattern();
                    break;
                case (int)DesignPatternEnum.DECORATOR:
                    StartDecoratorPattern();
                    break;
                case (int)DesignPatternEnum.FACADE:
                    StartFacadePattern();
                    break;
                case (int)DesignPatternEnum.STRATEGY:
                    StartStrategyPattern();
                    break;
                case (int)DesignPatternEnum.OBSERVER:
                    StartObserverPattern();
                    break;
                default:
                    Console.WriteLine("Incorrect Input");
                    break;
            }
        }

        private static void StartObserverPattern()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to Observer Pattern!");
            Console.WriteLine("Press 1 for Standard Pattern 2 for Real Life example");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == (int)ExampleEnum.THEORY)
                ObserverClient.StartTheory();
            else
                ObserverClient.StartRealLife();
        }

        private static void StartStrategyPattern()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to Strategy Pattern!");
            Console.WriteLine("Press 1 for Standard Pattern 2 for Real Life example");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == (int)ExampleEnum.THEORY)
                StrategyClient.StartTheory();
            else
                StrategyClient.StartRealLife();
        }

        private static void StartFacadePattern()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to Facade Pattern!");
            Console.WriteLine("Press 1 for Standard Pattern 2 for Real Life example");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == (int)ExampleEnum.THEORY)
                FacadeClient.StartTheory();
            else
                FacadeClient.StartRealLife();
        }

        private static void StartDecoratorPattern()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to Decorator Pattern!");
            Console.WriteLine("Press 1 for Standard Pattern 2 for Real Life example");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == (int)ExampleEnum.THEORY)
                DecoratorClient.StartTheory();
            else
                DecoratorClient.StartRealLife();
        }

        private static void StartAdapterPattern()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to Adapter Pattern!");
            Console.WriteLine("Press 1 for Standard Pattern 2 for Real Life example");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == (int)ExampleEnum.THEORY)
                AdapterClient.StartTheory();
            else
                AdapterClient.StartRealLife();
        }

        private static void StartPrototypePattern()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to Prototype Pattern!");
            Console.WriteLine("Press 1 for Standard Pattern 2 for Real Life example");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == (int)ExampleEnum.THEORY)
                PrototypeClient.StartTheory();
            else
                PrototypeClient.StartRealLife();
        }

        private static void StartSingletonPattern()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to Singleton Pattern!");
            Console.WriteLine("Press 1 for Standard Pattern 2 for Real Life example");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == (int)ExampleEnum.THEORY)
                SingletonClient.StartTheory();
            else
                SingletonClient.StartRealLife();
        }

        private static void StartBuilderPattern()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to Builder Pattern!");
            Console.WriteLine("Press 1 for Standard Pattern 2 for Real Life example");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == (int)ExampleEnum.THEORY)
                BuilderClient.StartTheory();
            else
                BuilderClient.StartRealLife();
        }

        private static void StartAbstractFactoryPattern()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to Abstract Factory Pattern!");
            Console.WriteLine("Press 1 for Standard Pattern 2 for Real Life example");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == (int)ExampleEnum.THEORY)
                AbstractFactoryClient.StartTheory();
            else
            {
                //AbstractFactoryClient.StartRealLife();

                AbstractFactoryClient.StartRealLife2();
            }
        }

        public static void StartFactoryMethodPattern()
        {
            Console.WriteLine(Environment.NewLine + "Welcome to Factory Method Pattern!");
            Console.WriteLine("Press 1 for Standard Pattern 2 for Real Life example");

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == (int)ExampleEnum.THEORY)
                FactoryMethodClient.StartTheory();
            else
                FactoryMethodClient.StartRealLife();
        }
    }
}
