using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Singleton.RealLife1
{
    internal class LoadBalancer
    {
        List<string> servers = new List<string>();
        Random random = new Random();

        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }

        private static LoadBalancer loadBalancer;
        private static object _lock = new object();

        private LoadBalancer()
        {
            servers.Add("Server I");
            servers.Add("Server II");
            servers.Add("Server III");
            servers.Add("Server IV");
            servers.Add("Server V");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (loadBalancer == null)
            {
                lock (_lock)
                {
                    if (loadBalancer == null)
                        loadBalancer = new LoadBalancer();
                }
            }

            return loadBalancer;
        }
    }
}
