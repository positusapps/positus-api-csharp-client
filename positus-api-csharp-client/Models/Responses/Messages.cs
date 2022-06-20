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
        public Trace trace { get; set; }
        public IList<Error> Errors { get; set; }
    }

    public class ServerType
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Trace
    {
        public Guid id { get; set; }
        public ServerType server_type { get; set; }
    }

    public class Error
    {
        public int code { get; set; }
        public string title { get; set; }
        public string details { get; set; }
    }
}
