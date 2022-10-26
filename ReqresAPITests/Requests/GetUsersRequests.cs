using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresAPITests.Requests
{
    public class GetUsersRequests
    {
        private string usersPrefix = "api/users?page=2";
        private string singleUserPrefix = "api/users/";
        private RestClient _client;

        public GetUsersRequests(RestClient client)
        {
            _client = client;
        }

        public RestResponse GetUsers()
        {
            var request = new RestRequest(usersPrefix, Method.Get);
            RestResponse response = _client.Execute(request);
            return response;
        }
        public RestResponse GetSingleUser(int userId)
        {
            var request = new RestRequest(singleUserPrefix+userId, Method.Get);
            RestResponse response = _client.Execute(request);
            return response;
        }
    }
}