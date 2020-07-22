using System;
using System.Collections.Generic;
using System.Text;

namespace positus_api_csharp_client.Models.Webhook
{
    public class Profile
    {
        public string name { get; set; }
    }

    public class Contact
    {
        public Profile profile { get; set; }
        public string wa_id { get; set; }
    }

    public class Context
    {
        public string from { get; set; }
        public string group_id { get; set; }
        public string id { get; set; }
        public IList<string> mentions { get; set; }
        public bool forwarded { get; set; }
        public bool frequently_forwarded { get; set; }
    }

    public class Audio
    {
        public string file { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public string mime_type { get; set; }
        public string sha256 { get; set; }
    }

    public class Document
    {
        public string file { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public string mime_type { get; set; }
        public string sha256 { get; set; }
        public string caption { get; set; }
    }

    public class Image
    {
        public string file { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public string mime_type { get; set; }
        public string sha256 { get; set; }
        public string caption { get; set; }
    }

    public class Location
    {
        public string address { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string name { get; set; }
    }

    public class System
    {
        public string body { get; set; }
    }

    public class Text
    {
        public string body { get; set; }
    }

    public class Video
    {
        public string file { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public string mime_type { get; set; }
        public string sha256 { get; set; }
    }

    public class Voice
    {
        public string file { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public string mime_type { get; set; }
        public string sha256 { get; set; }
    }

    public class Message
    {
        public Context context { get; set; }
        public string from { get; set; }
        public string group_id { get; set; }
        public string id { get; set; }
        public string timestamp { get; set; }
        public string type { get; set; }
        public IList<object> errors { get; set; }
        public Audio audio { get; set; }
        public Document document { get; set; }
        public Image image { get; set; }
        public Location location { get; set; }
        public System system { get; set; }
        public Text text { get; set; }
        public Video video { get; set; }
        public Voice voice { get; set; }
    }

    public class Webhook
    {
        public IList<Contact> contacts { get; set; }
        public IList<Message> messages { get; set; }
    }



    public class Status
    {
        public string id { get; set; }
        public string recipient_id { get; set; }
        public string status { get; set; }
        public string timestamp { get; set; }
    }

    public class WebhookStatus
    {
        public IList<Status> statuses { get; set; }
    }

}
