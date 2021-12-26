using flightRadar.Interfaces;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace flightRadar.Service
{
    public class RestService
    {
        private readonly ILogger logger;
        private readonly IRestConfigurator restConfigurator;
        internal IRestClient restClient;

        public RestService(IRestConfigurator restConfigurator, ILogger logger)
        {
            this.logger = logger;
            this.restConfigurator = restConfigurator;

            restClient = new RestClient();

            this.restConfigurator.Configure(restClient);
        }
    }
}
