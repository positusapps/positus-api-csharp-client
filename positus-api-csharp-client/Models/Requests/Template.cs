using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace positus_api_csharp_client.Models.Requests
{
    public class Currency
    {
        public string fallback_value { get; set; }
        public string code { get; set; }
        public int amount_1000 { get; set; }
    }
    public class ImageLink
    {
        public string link { get; set; }
    }

    public class DocumentLink
    {
        public string link { get; set; }
        public string filename { get; set; }
    }

    public class DateTime
    {
        public string fallback_value { get; set; }
        public int timestamp { get; set; }
    }

    public class Parameter
    {
        public string type { get; set; }
        public ImageLink image { get; set; }
        public string text { get; set; }
        public Currency currency { get; set; }
        public DateTime date_time { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string sub_type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string index { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<Parameter> parameters { get; set; }
        public DocumentLink document { get; set; }

    }

    public class Component
    {
        public string type { get; set; }
        public IList<Parameter> parameters { get; set; }
        public string sub_type { get; set; }
        public string index { get; set; }
    }

    public class TemplateDetails
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string @namespace { get; set; }
        public Language language { get; set; }
        public string name { get; set; }
        public IList<Component> components { get; set; }
    }

    public class Template
    {
        public string to { get; set; }
        public string type { get; set; }
        public TemplateDetails template { get; set; }
    }
}
