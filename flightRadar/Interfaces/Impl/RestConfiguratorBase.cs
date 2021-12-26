using RestSharp;
using System;

namespace flightRadar.Interfaces.Impl
{
    public class RestConfiguratorBase : IRestConfigurator
    {
        private const int DefaultTimeOut = 60000;

        public RestConfiguratorBase()
        {
            
        }

        public void Configure(IRestClient client)
        {
            client.BaseUrl = new Uri("https://opensky-network.org/api");
            client.Timeout = DefaultTimeOut;
        }
    }
}
