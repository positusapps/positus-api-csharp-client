using System;
using System.Collections.Generic;
using System.Text;

namespace positus_api_csharp_client.Models.Requests
{
    public class DocumentDetail
    {
        public Provider provider { get; set; }
        public string caption { get; set; }
        public string link { get; set; }
        public string filename { get; set; }
    }

    public class Document
    {
        public string to { get; set; }
        public string type { get; set; }
        public DocumentDetail document { get; set; }
    }
}
