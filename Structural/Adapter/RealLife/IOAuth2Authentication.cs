using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Adapter.RealLife
{
    internal interface IOAuth2Authentication
    {
        string GetAccessToken(string clientId, string clientSecret, string authorizationCode);
    }
}
