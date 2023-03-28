using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Adapter.RealLife
{
    internal class WebApplication
    {
        private readonly IOAuth2Authentication _authentication;

        public WebApplication(IOAuth2Authentication authentication)
        {
            _authentication = authentication;
        }

        public void AuthenticateUser(string clientId, string clientSecret, string authorizationCode)
        {
            string accessToken = _authentication.GetAccessToken(clientId, clientSecret, authorizationCode);
            Console.WriteLine($"Access Token: {accessToken}");
        }
    }
}
