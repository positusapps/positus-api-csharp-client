using System;
using System.Collections.Generic;
using System.Text;

namespace positus_api_csharp_client.Models.Requests
{
    public class Name
    {
        public string formatted_name { get; set; }
        public string first_name { get; set; }
    }

    public class Phone
    {
        public string phone { get; set; }
        public string type { get; set; }
        public string wa_id { get; set; }
    }

    public class ContactDetail
    {
        public Name name { get; set; }
        public IList<Phone> phones { get; set; }
    }

    public class Contact
    {
        public string to { get; set; }
        public string type { get; set; }
        public IList<ContactDetail> contacts { get; set; }
    }
}
