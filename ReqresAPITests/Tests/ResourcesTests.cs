using FluentAssertions;
using Newtonsoft.Json;
using ReqresAPITests.Requests;
using ReqresAPITests.Responses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReqresAPITests.Tests
{
    public class ResourcesTests : BaseTest
    {
        [Fact]
        public void GetListOfResources()
        {
            ResourcesRequests request = new ResourcesRequests(Client);
            RestResponse response = request.GetListOfResource();
            Resources jsonResponse = JsonConvert.DeserializeObject<Resources>(response.Content);
            Assert.Equal("cerulean", jsonResponse.Data[0].Name);
        }

        [Fact]
        public void GetSingleResource()
        {
            int resourceToGet = 2;
            ResourcesRequests request = new ResourcesRequests(Client);
            RestResponse response = request.GetSingleResource(resourceToGet);
            Resources jsonResponse = JsonConvert.DeserializeObject<Resources>(response.Content);
            Assert.Equal("fuchsia rose", jsonResponse.Data[resourceToGet-1].Name);
        }
    }
}
