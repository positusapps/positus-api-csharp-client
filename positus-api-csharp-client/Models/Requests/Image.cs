using System;
using System.Collections.Generic;
using System.Text;

namespace positus_api_csharp_client.Models.Requests
{
    public class ImageDetail
    {
        public string link { get; set; }
        public string caption { get; set; }
    }

    public class Image
    {
        public string to { get; set; }
        public string type { get; set; }
        public ImageDetail image { get; set; }
    }
}
