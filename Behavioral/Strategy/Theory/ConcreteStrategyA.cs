using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Strategy.Theory
{
    internal class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
