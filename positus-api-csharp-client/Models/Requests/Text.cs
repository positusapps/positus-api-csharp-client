using System;
using System.Collections.Generic;
using System.Text;

namespace positus_api_csharp_client.Models.Requests
{
    public class @TextDetail
    {
        public string body { get; set; }
    }

    public class Text
    {
        public string to { get; set; }
        public string type { get; set; }

        public @TextDetail text { get; set; }
    }

}
