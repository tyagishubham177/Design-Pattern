using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Adapter.RealLife
{
    internal class LegacyAuthentication
    {
        public string Authenticate(string username, string password)
        {
            return $"LegacyAccessToken-{username}-{password}";
        }
    }
}
