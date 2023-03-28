using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.FactoryMethod.RealLife1
{
    internal class SkillsPage : IPage
    {
        public string GetDescription()
        {
            return "This is " + typeof(SkillsPage).Name;
        }
    }
}
