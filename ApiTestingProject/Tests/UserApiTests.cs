using NUnit.Framework;
using FluentAssertions;
using ApiTestingProject.Utilities;

namespace ApiTestingProject.Tests;

[TestFixture]
public class UserApiTests
{
    private ApiClient _apiClient = null!; // Initialize with null-forgiveness

    [SetUp]
    public void Setup()
    {
        _apiClient = new ApiClient();
    }

    [Test]
    public async Task GetAllUsers_ShouldReturnSuccessfulResponse()
    {
        // Act
        var users = await _apiClient.GetUsersAsync();

        // Assert
        users.Should().NotBeNull();
        users.Should().HaveCountGreaterThan(0);
    }

    [Test]
    public async Task GetSingleUser_ShouldReturnCorrectUserDetails()
    {
        // Act
        var user = await _apiClient.GetUserAsync(1);

        // Assert
        user.Should().NotBeNull();
        user.Id.Should().Be(1);
        user.Name.Should().NotBeNullOrEmpty();
    }
}
