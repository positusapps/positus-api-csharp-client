using System;
using System.Collections.Generic;
using System.Text;

namespace positus_api_csharp_client.Models.Requests
{
    public class LocationDetail
    {
        public Double longitude { get; set; }
        public Double latitude { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }

    public class Location
    {
        public string to { get; set; }
        public string type { get; set; }
        public LocationDetail location { get; set; }
    }
}
