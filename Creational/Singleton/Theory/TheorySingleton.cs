using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Singleton.Theory
{
    internal class TheorySingleton
    {
        public string Value { get; set; }
        private static readonly object _lock = new object();
        private static TheorySingleton _instance;

        private TheorySingleton() { }

        public static TheorySingleton GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new TheorySingleton();
                        _instance.Value = value;
                    }
                }
            }

            return _instance;
        }

    }
}
