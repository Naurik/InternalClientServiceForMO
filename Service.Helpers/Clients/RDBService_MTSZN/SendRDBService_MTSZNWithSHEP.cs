using Service.Helpers.Clients.Shep;
using Service.Helpers.Helpers.RDBService_MTSZN;
using Service.Helpers.ResponseModel;
using Service.DATA.ResponseModel.RDBService_MTSZN;
using static Service.DATA.ResponseModel.RDBService_MTSZN.RdbResponses;
using static Service.Helpers.Utils.Signing;
using _logger = Service.DATA.Logger;
using Service.DATA.Models.DTO;
using System.Xml;
using System.Xml.Linq;

namespace Service.Helpers.Clients.RDBService_MTSZN
{
    public class SendRDBService_MTSZNWithSHEP
    {
        public GetRdbResponse SignXmlAndSend(SurveyDTO surveyDTO)
        {
            SendToShep send = new SendToShep();
            StringXml stringXml = new StringXml();
            var guid = Guid.NewGuid().ToString();
            var reguestStr = stringXml.StringXmlRequest(surveyDTO, guid);
            var model = new RequestModel() { Attr = guid, Xml = reguestStr };
            var sign = SignWSSE(model, "RDBService_MTSZN");
            _logger.WriteToFile($"String request xml =  {sign}", "RDBService_MTSZN", _logger.LogLevel.Information);

            //Запись запроса в файл
            string path = @"C:\xml\RDBService_MTSZN\example.xml";
            using (StreamWriter file = new StreamWriter(path))
            {
                file.Write(sign);
            }
            //var path2 = @"C:\app\data.xml";
            //var m = System.IO.File.ReadAllText(path2);
            ////XElement booksFromFile = XElement.Load(@"C:\app\data.xml");
            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(m); 
            
            var responseResult = send.SendRequestToShep(sign);
            
            _logger.WriteToFile($"String response xml =  {responseResult}", "RDBService_MTSZN", _logger.LogLevel.Debug);
            var deserialize = DeserilizeXmlToObject<Envelope>(responseResult, "RDBService_MTSZN");
            var resp = deserialize.Body.SendMessageResponse.response.responseData.data;
            _logger.WriteToFile($"Deserialize1 =  {resp}", "RDBService_MTSZN", _logger.LogLevel.Debug);

            var rdbResponse = DeserilizeXmlToObject<GetRdbResponse>(resp, "RDBService_MTSZN");
            _logger.WriteToFile($"Deserialize2 rdb =  {rdbResponse}", "RDBService_MTSZN", _logger.LogLevel.Debug);
            return rdbResponse;
        }
    }
}
