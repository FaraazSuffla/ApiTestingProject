using NUnit.Framework;
using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using ApiTestingProject.Models;
using ApiTestingProject.Utilities;

namespace ApiTestingProject.Tests
{
    [TestFixture]
    public class UserApiTests
    {
        private ApiClient _apiClient;

        [SetUp]
        public void Setup()
        {
            _apiClient = new ApiClient();
        }

        [Test]
        public async Task GetAllUsers_ShouldReturnSuccessfulResponse()
        {
            // Act
            var response = await _apiClient.ExecuteGetAsync<List<UserModel>>("/users");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Data.Should().NotBeNull();
            response.Data.Should().HaveCountGreaterThan(0);
        }

        [Test]
        public async Task GetSingleUser_ShouldReturnCorrectUserDetails()
        {
            // Act
            var response = await _apiClient.ExecuteGetAsync<UserModel>("/users/1");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Data.Should().NotBeNull();
            response.Data.Id.Should().Be(1);
            response.Data.Name.Should().NotBeNullOrEmpty();
        }
    }
}