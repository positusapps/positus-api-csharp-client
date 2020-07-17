using System;
using System.Collections.Generic;
using System.Text;

namespace positus_api_csharp_client.Models.Requests
{
    public class Language
    {
        public string policy { get; set; }
        public string code { get; set; }
    }
    public class LocalizableParam
    {
        public string @default { get; set; }
    }
    public class HsmDetail
    {
        public string @namespace { get; set; }
        public string element_name { get; set; }
        public Language language { get; set; }
        public IList<LocalizableParam> localizable_params { get; set; }
    }
    public class Hsm
    {
        public string to { get; set; }
        public string type { get; set; }
        public HsmDetail hsm { get; set; }
    }
}
