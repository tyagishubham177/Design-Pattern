using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.FactoryMethod.RealLife1
{
    internal class IntroPage : IPage
    {
        public string GetDescription()
        {
            return "This is " + typeof(IntroPage).Name;
        }
    }
}
