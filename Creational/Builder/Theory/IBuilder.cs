using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Builder.Theory
{
    internal interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
