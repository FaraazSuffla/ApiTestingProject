using ApiTestingProject.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace ApiTestingProject.Utilities;

public class ApiClient
{
    private readonly HttpClient _client;
    private const string BaseUrl = "https://jsonplaceholder.typicode.com";

    public ApiClient()
    {
        _client = new HttpClient
        {
            BaseAddress = new Uri(BaseUrl)
        };
    }

    public async Task<List<UserModel>?> GetUsersAsync()
    {
        return await _client.GetFromJsonAsync<List<UserModel>>("/users");
    }

    public async Task<UserModel?> GetUserAsync(int id)
    {
        return await _client.GetFromJsonAsync<UserModel>($"/users/{id}");
    }
}