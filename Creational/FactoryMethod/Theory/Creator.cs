﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.FactoryMethod.Class
{
    internal abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Creator: The same creator's code has just worked with " + product.Operation();
            return result;
        }
    }
}
