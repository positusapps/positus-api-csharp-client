using Newtonsoft.Json;
using positus_api_csharp_client.Models.Requests;
using positus_api_csharp_client.Models.Responses;
using RestSharp;
using System.IO;

namespace positus_api_csharp_client
{
    public class Client
    {
        public string numberId;
        private string _token;
        bool sandbox ;

        public Client(string token, bool sandbox = false)
        {
            _token = token;
        }
        public @Message sendData(object obj)
        {
            return HttpClient(obj);
        }

        public @Message sendMessage(@Text text)
        {
            text.type = "text";
            return HttpClient(text);
        }
        public @Message sendTemplate(Template template)
        {
            template.type = "template";
            return HttpClient(template);
        }

        public @Message sendHsm(Hsm hsm)
        {
            return HttpClient(hsm);
        }

        public @Message sendContacts(Contact contact)
        {
            contact.type = "contacts";
            return HttpClient(contact);
        }
        public @Message sendLocation(Location location)
        {
            location.type = "location";
            return HttpClient(location); ;
        }

        public @Message sendImage(Image image)
        {
            image.type = "image";
            return HttpClient(image);
        }

        public @Message sendDocument(Document document)
        {
            document.type = "document";
            return HttpClient(document);
        }

        public @Message sendVideo(Video video)
        {
            video.type = "video";
            return HttpClient(video);
        }
        public @Message sendAudio(Audio audio)
        {
            audio.type = "audio";
            return HttpClient(audio);
        }

        public byte[] getMedia(string id)
        {
            return HttpClient(id);
        }

        private @Message HttpClient(object obj)
        {
            try
            {

                string uri = (sandbox ? "https://api.positus.global/v2/sandbox/whatsapp/numbers/{numberId}/messages" : $"https://api.positus.global/v2/whatsapp/numbers/{numberId}/messages");
                var client = new RestClient(uri);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", $"Bearer {_token}");
                request.AddParameter("application/json", JsonConvert.SerializeObject(obj), ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                return JsonConvert.DeserializeObject<@Message>(response.Content);
            }
            catch (System.Exception ex)
            {
                return new @Message() { message = ex.Message };
            }
        }

        private byte[] HttpClient(string id)
        {
            try
            {

                string uri = (sandbox ? "https://api.positus.global/v2/sandbox/whatsapp/numbers/{numberId}/media/{ID}" : $"https://api.positus.global/v2/whatsapp/numbers/{numberId}/media/{id}");
                var client = new RestClient(uri);
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", $"Bearer {_token}");
                return client.DownloadData(request);
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
