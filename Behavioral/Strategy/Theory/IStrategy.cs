using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Strategy.Theory
{
    internal interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
