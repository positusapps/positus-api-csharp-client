using System;
using System.Collections.Generic;
using System.Text;

namespace positus_api_csharp_client.Models.Responses
{
    public class MessageDetail
    {
        public string id { get; set; }
    }

    public class @Message
    {
        public IList<MessageDetail> messages { get; set; }
        public string message { get; set; }
    }
}
