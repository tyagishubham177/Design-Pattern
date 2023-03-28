using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.FactoryMethod.RealLife1
{
    internal abstract class Document
    {
        public List<IPage> Pages { get; set; }

        public Document()
        {
            Pages = new List<IPage>();
            AddPages();
        }

        public abstract void AddPages();
    }
}
