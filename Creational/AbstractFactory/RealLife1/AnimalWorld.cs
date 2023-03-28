using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife1
{
    internal class AnimalWorld
    {
        private IHerbivore herbivore;
        private ICarnivore carnivore;

        public AnimalWorld(IContinentFactory continentFactory)
        {
            carnivore = continentFactory.CreateCarnivore();
            herbivore = continentFactory.CreateHerbivore();
        }

        public string RunFoodChain()
        {
            return carnivore.Eat(herbivore);
        }
    }
}
