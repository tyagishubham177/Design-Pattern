﻿using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DesignPatternsApp.Structural.Facade.Theory
{
    internal class FacadeClass
    {
        protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;

        public FacadeClass(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.operation1();
            result += this._subsystem2.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.operationN();
            result += this._subsystem2.operationZ();
            return result;
        }
    }
}
