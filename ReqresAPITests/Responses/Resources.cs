using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresAPITests.Responses
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Pantone_value { get; set; }
    }

    public class Resources
    {
        public int Page { get; set; }
        public int Per_page { get; set; }
        public int Total { get; set; }
        public int Total_pages { get; set; }
        public List<Resource> Data { get; set; }
        public Support Support { get; set; }
    }

    public class Support
    {
        public string Url { get; set; }
        public string Text { get; set; }
    }
}
