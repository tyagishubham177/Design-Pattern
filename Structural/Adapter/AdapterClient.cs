using DesignPatternsApp.Structural.Adapter.RealLife;
using DesignPatternsApp.Structural.Adapter.Theory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Adapter
{
    internal class AdapterClient
    {
        internal static void StartRealLife()
        {
            var legacyAuth = new LegacyAuthentication();
            var legacyAuthAdapter = new LegacyAuthenticationAdapter(legacyAuth);
            var webApp = new WebApplication(legacyAuthAdapter);

            string clientId = "some_client_id";
            string clientSecret = "some_client_secret";
            string authorizationCode = "testuser-testpassword";

            webApp.AuthenticateUser(clientId, clientSecret, authorizationCode);
        }

        internal static void StartTheory()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Theory.Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
