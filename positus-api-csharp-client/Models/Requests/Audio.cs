using System;
using System.Collections.Generic;
using System.Text;

namespace positus_api_csharp_client.Models.Requests
{
    public class Provider
    {
        public string name { get; set; }
    }

    public class AudioDetail
    {
        public Provider provider { get; set; }
        public string link { get; set; }
    }

    public class Audio
    {
        public string to { get; set; }
        public string type { get; set; }
        public AudioDetail audio { get; set; }
    }
}
