# API Testing Project

![CI](https://github.com/FaraazSuffla/ApiTestingProject/actions/workflows/ci.yml/badge.svg)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)
![NUnit](https://img.shields.io/badge/NUnit-4.0-brightgreen)
![License](https://img.shields.io/github/license/FaraazSuffla/ApiTestingProject)

A C# API testing project demonstrating automated testing of REST APIs using NUnit and FluentAssertions. The project tests the [JSONPlaceholder](https://jsonplaceholder.typicode.com) API to retrieve user data.

## Prerequisites
- .NET SDK 8.0+
- Visual Studio 2022 (optional)

## Getting Started
1. Clone the repository
2. Restore packages: `dotnet restore`
3. Build the solution: `dotnet build`
4. Run tests:
   - Command line: `dotnet test`
   - Or open in Visual Studio and run via Test Explorer

## Technologies
- .NET 8
- NUnit
- FluentAssertions
- RestSharp
- HttpClient / System.Net.Http.Json
- System.Text.Json

## Project Structure
```
ApiTestingProject/
├── Models/
│   └── UserModel.cs      # User data model
├── Utilities/
│   └── ApiClient.cs      # HTTP client for API requests
└── Tests/
    └── UserApiTests.cs   # NUnit test cases
```

## Test Scenarios
- **GetAllUsers_ShouldReturnSuccessfulResponse** — Verifies GET /users returns a non-empty list of users
- **GetSingleUser_ShouldReturnCorrectUserDetails** — Verifies GET /users/{id} returns the correct user with valid id and name

## CI/CD
Tests run automatically on every push and pull request via GitHub Actions. See the badge above for current status.
