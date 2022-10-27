using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresAPITests.Requests
{
    public class ResourcesRequests
    {
        private string listOfResourcesPrefix = "api/unknown";
        private RestClient _client;

        public ResourcesRequests(RestClient client)
        {
            _client = client;
        }

        public RestResponse GetListOfResource()
        {
            RestRequest request = new RestRequest(listOfResourcesPrefix, Method.Get);
            RestResponse response = _client.Execute(request);
            return response;
        }
    }
}
