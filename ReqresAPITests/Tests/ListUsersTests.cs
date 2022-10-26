using Xunit;
using ReqresAPITests.Requests;
using ReqresAPITests.Tests;
using RestSharp;
using FluentAssertions;
using System.Net;

namespace ReqresAPITests.Tests
{
    public class ListUsersTests : BaseTest
    {
        [Fact]
        public void GetUsersTest()
        {
            GetUsersRequests request = new GetUsersRequests(Client);
            request.GetUsers().StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}