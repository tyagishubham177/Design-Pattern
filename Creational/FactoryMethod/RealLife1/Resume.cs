using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.FactoryMethod.RealLife1
{
    internal class Resume : Document
    {
        public override void AddPages()
        {
            Pages.Add(new IntroPage());
            Pages.Add(new SkillsPage());
            Pages.Add(new ReferencesPage());
        }
    }
}
