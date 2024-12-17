using RestSharp;
using System.Threading.Tasks;

namespace ApiTestingProject.Utilities
{
    public class ApiClient
    {
        private readonly RestClient _client;
        private const string BaseUrl = "https://jsonplaceholder.typicode.com";

        public ApiClient()
        {
            _client = new RestClient(BaseUrl);
        }

        public async Task<RestResponse<T>> ExecuteGetAsync<T>(string endpoint) where T : class
        {
            var request = new RestRequest(endpoint, Method.Get);
            return await _client.ExecuteAsync<T>(request);
        }
    }
}