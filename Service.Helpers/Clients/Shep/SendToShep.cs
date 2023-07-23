using System.Text;
using Service.Helpers.Helpers;
using Service.Helpers.Models;
using static Service.Helpers.Utils.Signing;

namespace Service.Helpers.Clients.Shep
{
    
    public class SendToShep
    {
        public SendToShep() { }
        public string SignXmlAndSend(string iin)
        {
            StringXml stringXml = new StringXml();
            var guid = Guid.NewGuid().ToString();
            var reguestStr = stringXml.StringXmlRequest(iin, guid);
            var model = new RequestModel() { Attr = guid, Xml = reguestStr };
            var sign = SignWSSE(model);
            var responseResult = SendRequestToShep(sign);
            return responseResult;
        }
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
                    RequestUri = new Uri("http://10.61.40.133/shep/bip-sync-wss-gost/"),
                    Method = HttpMethod.Post
                };

                string path = @"C:\xml\example.xml";

                using (StreamWriter file = new StreamWriter(path))
                {
                    file.Write(signXml);
                }

                //var xmlDoc = new XmlDocument();
                //xmlDoc.LoadXml(signXml);
                //Console.WriteLine(xmlDoc.DocumentElement.OuterXml);
                //xmlDoc.Save(@"C:\xml\example.xml");

                request.Content = new StringContent(signXml ?? string.Empty, Encoding.UTF8, "text/xml");

                HttpResponseMessage response = client.SendAsync(request).Result;

                resp = response.Content.ReadAsStringAsync().Result.ToString();

                //var result = response.Content.ReadAsStringAsync().Result.ToString();

                //XmlSerializer xmlSerializer = new XmlSerializer(typeof(SendMessageResponse));

                //using (StringReader reader = new StringReader(result))
                //{
                //    //messageResponse = xmlSerializer.Deserialize(reader).ToString();
                //    resp = xmlSerializer.Deserialize(reader).ToString();
                //}

            };
            return resp;
        }
        

        
    }
}
