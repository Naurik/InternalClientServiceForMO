using System.Text;
using _logger = Service.DATA.Logger;

namespace Service.Helpers.Clients.Shep
{

    public class SendToShep
    {
        public SendToShep() { }

        public string SendRequestToShep(string signXml)
        {
            HttpClientHandler httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, SslPolicyErrors) => true
            };

            //SendMessageResponse messageResponse;
            var resp = "";

            using ( var client = new HttpClient(httpClientHandler)) 
            {
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri("http://192.168.145.133/shep/bip-sync-wss-gost/"),
                    Method = HttpMethod.Post
                };

                request.Content = new StringContent(signXml ?? string.Empty, Encoding.UTF8, "text/xml");

                HttpResponseMessage response = client.SendAsync(request).Result;

                resp = response.Content.ReadAsStringAsync().Result.ToString();

                //_logger.WriteToFileDefault($"Response =  {resp}", _logger.LogLevel.Debug);
            };
            return resp;
        }
        

        
    }
}
