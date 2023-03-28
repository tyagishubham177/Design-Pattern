using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Adapter.RealLife
{
    internal class LegacyAuthenticationAdapter : IOAuth2Authentication
    {
        private readonly LegacyAuthentication _legacyAuthentication;

        public LegacyAuthenticationAdapter(LegacyAuthentication legacyAuthentication)
        {
            _legacyAuthentication = legacyAuthentication;
        }

        public string GetAccessToken(string clientId, string clientSecret, string authorizationCode)
        {
            string username = authorizationCode.Split('-')[0];
            string password = authorizationCode.Split('-')[1];

            // Authenticate using the legacy authentication system
            return _legacyAuthentication.Authenticate(username, password);
        }
    }
}
