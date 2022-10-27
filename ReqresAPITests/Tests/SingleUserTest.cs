using FluentAssertions;
using ReqresAPITests.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReqresAPITests.Tests
{
    public class SingleUserTest : BaseTest
    {
        [Fact]
        public void GetSingleUserTest()
        {
            GetUsersRequests request = new GetUsersRequests(Client);
            request.GetSingleUser(2).StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public void GetNotExistingUserTest()
        {
            GetUsersRequests request = new GetUsersRequests(Client);
            request.GetSingleUser(253).StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}
