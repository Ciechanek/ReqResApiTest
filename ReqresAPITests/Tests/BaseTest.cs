using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresAPITests.Tests
{
    public class BaseTest
    {
        public RestClient Client;
        public BaseTest()
        {
            Client = new RestClient("https://reqres.in/");
        }
    }
}
