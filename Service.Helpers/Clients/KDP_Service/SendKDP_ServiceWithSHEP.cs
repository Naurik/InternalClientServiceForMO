using Service.Helpers.Clients.Shep;
using Service.Helpers.Helpers.KDP_Service;
using Service.Helpers.ResponseModel;
using Service.DATA.ResponseModel.KDP_Service;
using static Service.Helpers.Utils.Signing;
using _logger = Service.DATA.Logger;
using Service.DATA.Models.DTO;
using System.Xml;

namespace Service.Helpers.Clients.KDP_Service
{
    public class SendKDP_ServiceWithSHEP
    {
        public sendMessageResponseResponseResponseDataData SignXmlAndSend(SurveyDTO surveyDTO)
        {
            SendToShep send = new SendToShep();
            StringXml stringXml = new StringXml();
            var guid = Guid.NewGuid().ToString();
            var token = CreateJwtToken("KDP_Service");
            _logger.WriteToFile($"JWT token create =  {token}", "KDP_Service", _logger.LogLevel.Information);
            var reguestStr = stringXml.StringXmlRequest(surveyDTO, guid, token);
            var model = new RequestModel() { Attr = guid, Xml = reguestStr };
            var sign = SignWSSE(model, "KDP_Service");
            _logger.WriteToFile($"String request xml =  {sign}", "KDP_Service", _logger.LogLevel.Debug);

            //Запись запроса в файл
            string path = @"C:\xml\KDP_Service\example.xml";
            using (StreamWriter file = new StreamWriter(path))
            {
                file.Write(sign);
            }

            var responseResult = send.SendRequestToShep(sign);
            //XmlDocument docXML = new XmlDocument();
            //docXML.Load(@"C:\Наурызбай работа проект\Services\Контроль доступа к персональным данным\KDP_SERVICE\getUserDataResponse.xml");
            //var responseResult = docXML.InnerXml;
            _logger.WriteToFile($"String response xml =  {responseResult}", "KDP_Service", _logger.LogLevel.Debug);
            var deserialize = DeserilizeXmlToObject<Envelope>(responseResult, "KDP_Service");
            _logger.WriteToFile($"Deserialize =  {deserialize}", "KDP_Service", _logger.LogLevel.Debug);
            var resp = deserialize.Body.sendMessageResponse.response.responseData.data;
            return resp;
        }
    }
}
