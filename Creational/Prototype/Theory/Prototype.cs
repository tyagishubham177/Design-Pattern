﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Prototype.Theory
{
    internal abstract class Prototype
    {
        string id;

        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
        }

        public abstract Prototype Clone();
    }
}
