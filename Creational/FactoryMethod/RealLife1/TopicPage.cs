using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.FactoryMethod.RealLife1
{
    internal class TopicPage : IPage
    {
        public string GetDescription()
        {
            return "This is " + typeof(TopicPage).Name;
        }
    }
}
