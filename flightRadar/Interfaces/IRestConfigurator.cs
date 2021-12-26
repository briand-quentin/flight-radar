using RestSharp;

namespace flightRadar.Interfaces
{
    public interface IRestConfigurator
    {
        public void Configure(IRestClient client);
    }
}
