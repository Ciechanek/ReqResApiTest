using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresAPITests.Responses
{
    public class User
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? First_name { get; set; }
        public string? Last_name { get; set; }
        public string? Avatar { get; set; }

        public class ListOfUsers
        {
            public List<User>? Data { get; set; }
        }
    }
}
